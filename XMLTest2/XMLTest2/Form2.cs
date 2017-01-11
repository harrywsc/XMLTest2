using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLTest2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_addXML_Click(object sender, EventArgs e)
        {
            if (tb_bag.Text == "" || tb_box.Text == "" || tb_bundle.Text == "" || tb_type.Text == "" || tb_version.Text == "")
            {
                MessageBox.Show("请正确填写数据，否则填“0”或关闭窗口！");
                return;
            }
            AddXML(Util.xmlPath);
            this.Dispose();
            this.Close();
        }
        private void AddXML(string path)
        {
            //加载文件，选出节点
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNode xn = xmlDoc.SelectSingleNode("cashlist");

            //创建节点
            XmlElement xelKey = xmlDoc.CreateElement("cash");

            //创建子节点
            XmlElement xelType = xmlDoc.CreateElement("type");
            xelType.InnerText = tb_type.Text;
            XmlElement xelLabel = xmlDoc.CreateElement("label");
            xelLabel.InnerText = tb_type.Text;
            XmlElement xelVersion = xmlDoc.CreateElement("version");
            xelVersion.InnerText = tb_version.Text;
            XmlElement xelBox = xmlDoc.CreateElement("box");
            xelBox.InnerText = tb_box.Text;
            XmlElement xelBundle = xmlDoc.CreateElement("bundle");
            xelBundle.InnerText = tb_bundle.Text;
            XmlElement xelBag = xmlDoc.CreateElement("bag");
            xelBag.InnerText = tb_bag.Text;
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
    }
}
