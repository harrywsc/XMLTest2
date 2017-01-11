using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool CheckPath()
        {
            if (lb_DataDir.Text != "数据文件：" && lb_XMLDir.Text != "配置文件：" && lb_CashInfoDir.Text != "券别基本信息文件：")
            {
                return true;
            }
            return false;
        }

        private void BackupXML(string path)
        {
            if (!Directory.Exists((Util.xmlPath2 + @"\备份数据")))
            {
                Directory.CreateDirectory((Util.xmlPath2 + @"\备份数据"));
            }
            string targetPath = Util.xmlPath2 + @"\备份数据\" + Util.xmlName + DateTime.Now.ToLongDateString() + @".xml";
            bool isrewrite = false;
            if (!File.Exists(targetPath))
            {
                File.Copy(path, targetPath, isrewrite);
            }
        }

        //读取数据文件，返回券别名称
        public void ReadData(string path,string[] cashData)
        {
            StreamReader sr = new StreamReader(path, Encoding.Default);
            String line; 
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                cashData[i] = line.ToString().Split('|')[0];
                cashData[i+1] = line.ToString().Split('|')[1];
                i = i + 2;
            }
        }
        

        /// <summary>
        /// 查找泛用券别信息，导入箱捆包数据
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cashType"></param>
        /// <param name="cashInfo"></param>
        private bool GetCashInfo(string path,string cashType, CashInfo cashInfo)
        {
            if (-1 !=cashType.IndexOf("币"))
            {
                if (-1 != cashType.IndexOf("10元")) { cashType = "硬10元"; }
                if (-1 != cashType.IndexOf("5元")) { cashType = "硬5元"; }
                if (-1 != cashType.IndexOf("1元")) { cashType = "硬1元"; }
            }
            if (-1 != cashType.IndexOf("钞"))
            {
                if (-1 != cashType.IndexOf("100元")) { cashType = "纸100元"; }
                if (-1 != cashType.IndexOf("50元")) { cashType = "纸50元"; }
                if (-1 != cashType.IndexOf("20元")) { cashType = "纸20元"; }
                if (-1 != cashType.IndexOf("10元")) { cashType = "纸10元"; }
                if (-1 != cashType.IndexOf("5元")) { cashType = "纸5元"; }
                if (-1 != cashType.IndexOf("2元")) { cashType = "纸2元"; }
                if (-1 != cashType.IndexOf("1元")) { cashType = "纸1元"; }
            }

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create(path, settings);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);
            XmlNode xn = xmlDoc.SelectSingleNode("cashlist");
            XmlNodeList xnl = xn.ChildNodes;
            foreach (XmlNode xn1 in xnl)
            {
                XmlElement xe = (XmlElement)xn1;// 将节点转换为元素，便于得到节点的属性值
                XmlNodeList xnl0 = xe.ChildNodes;
                if (-1 != cashType.IndexOf(xnl0.Item(0).InnerText))
                {
                    cashInfo.Type = xnl0.Item(0).InnerText;
                    cashInfo.Box = xnl0.Item(1).InnerText;
                    cashInfo.Bundle = xnl0.Item(2).InnerText;
                    cashInfo.Bag = xnl0.Item(3).InnerText;
                    reader.Close();
                    return true;
                }
            }
            reader.Close();
            Util.start = false;
            return false;
        }

        /// <summary>
        /// 读取XML配置文件，返回券别名称
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public void ReadXML(string path,string[] xmlData)
        {
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create(path, settings);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(reader);
            XmlNode xn = xmlDoc.SelectSingleNode("cashlist");
            XmlNodeList xnl = xn.ChildNodes;
            int i = 0;
            foreach (XmlNode xn1 in xnl)
            {
                XmlElement xe = (XmlElement)xn1;// 将节点转换为元素，便于得到节点的属性值
                XmlNodeList xnl0 = xe.ChildNodes;
                xmlData[i] = xnl0.Item(0).InnerText;
                i++;
            }
            reader.Close();
        }

        /// <summary>
        /// 添加券别信息到配置文件中。
        /// </summary>
        /// <param name="path"></param>
        /// <param name="cashType"></param>
        private void AddXML(string path,string cashType,string cashVersion)
        {
            //获取券别包装信息
            CashInfo cashInfo = new CashInfo();
            if (!GetCashInfo(Util.cashInfoPath, cashType, cashInfo))
            {
                MessageBox.Show("没找到" + cashType + "券别包装信息，请核对券别包装。");
                return;
            }

            //加载文件，选出节点
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode xn = xmlDoc.SelectSingleNode("cashlist");

            //创建节点
            XmlElement xelKey = xmlDoc.CreateElement("cash");

            //创建子节点
            XmlElement xelType = xmlDoc.CreateElement("type");
            xelType.InnerText = cashType;
            XmlElement xelLabel = xmlDoc.CreateElement("label");
            xelLabel.InnerText = cashType;
            XmlElement xelVersion = xmlDoc.CreateElement("version");
            xelVersion.InnerText = cashVersion;
            XmlElement xelBox = xmlDoc.CreateElement("box");
            xelBox.InnerText = cashInfo.Box;
            XmlElement xelBundle = xmlDoc.CreateElement("bundle");
            xelBundle.InnerText = cashInfo.Bundle;
            XmlElement xelBag = xmlDoc.CreateElement("bag");
            xelBag.InnerText = cashInfo.Bag;

            xelKey.AppendChild(xelType);
            xelKey.AppendChild(xelLabel);
            xelKey.AppendChild(xelVersion);
            xelKey.AppendChild(xelBox);
            xelKey.AppendChild(xelBundle);
            xelKey.AppendChild(xelBag);

            //添加入文件
            xn.AppendChild(xelKey);
            xmlDoc.Save(path);
        }

        private void Btn_SelectData_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SafeFileName != "fxkkwxx.txt")
                {
                    MessageBox.Show(@"请选择正确的文件，文件名应为""fxkkwxx.txt""");
                    return;
                }
                Util.dataPath = dialog.FileName;
                lb_DataDir.Text = lb_DataDir.Text + dialog.FileName;
            }
        }

        private void Btn_SelectXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SafeFileName != "cashes.cfg.xml")
                {
                    MessageBox.Show(@"请选择正确的文件，文件名应为""cashes.cfg.xml""");
                    return;
                }
                Util.xmlName = System.IO.Path.GetFileNameWithoutExtension(dialog.FileName);
                Util.xmlPath = dialog.FileName;
                Util.xmlPath2 = System.IO.Path.GetDirectoryName(dialog.FileName);
                //MessageBox.Show(Class1.xmlName);
                lb_XMLDir.Text = lb_XMLDir.Text + dialog.FileName;
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (!CheckPath())
            {
                MessageBox.Show("请选择正确的文件!");
                return;
            }
            BackupXML(Util.xmlPath);
            Util.start = true;
            if (Util.start)
            {
                //定义券别数据
                string[] cashData = new string[1000];
                //定义xml数据
                string[] xmlData = new string[1000];
                //导入券别数据
                if ("" != Util.dataPath)
                {
                    ReadData(Util.dataPath, cashData);
                }

                //导入xml数据
                if ("" != Util.xmlPath)
                {
                    ReadXML(Util.xmlPath, xmlData);
                }

                //校验数据
                for (int i = 0; i < 1000; i+=2)
                {
                    if (cashData[i] == null)
                    {
                        break;
                    }
                    for (int j = 0; j < 1000; j++)
                    {
                        if (xmlData[j] == null)
                        {
                            //录入新数据                        
                            AddXML(Util.xmlPath, cashData[i],cashData[i+1]);
                            break;
                        }
                        if (cashData[i] == xmlData[j])
                        {
                            break;
                        }
                    }
                }
            }

        }

        private void Btn_SelectCashInfo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (dialog.SafeFileName != "cashesInfo.xml")
                {
                    MessageBox.Show(@"请选择正确的文件，文件名应为""cashesInfo.xml""");
                    return;
                }
                Util.cashInfoPath = dialog.FileName;
                lb_CashInfoDir.Text = lb_CashInfoDir.Text + dialog.FileName;
            }
        }

        private void Btn_Stop_Click(object sender, EventArgs e)
        {
            Util.start = false;
        }

        private void Btn_AddCashInfo_Click(object sender, EventArgs e)
        {
            if (!CheckPath())
            {
                MessageBox.Show("请选择正确的文件!");
                return;
            }
            BackupXML(Util.xmlPath);
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
        }

        private void Btn_UpdateCashInfo_Click(object sender, EventArgs e)
        {
            if (!CheckPath())
            {
                MessageBox.Show("请选择正确的文件!");
                return;
            }
            BackupXML(Util.xmlPath);
            Form3 fm3 = new Form3();
            fm3.ShowDialog();
        }

    }
}
