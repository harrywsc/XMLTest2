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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            XMLCashInfo[] xmlData = new XMLCashInfo[1000];
            ReadXML(Util.xmlPath, xmlData);
            for (int i=0;i<1000;i++)
            {
                if (null==xmlData[i]) { break; }
                cb_Cash.Items.Add(xmlData[i]);
            }
            cb_Cash.DisplayMember = "Type";
        }


        /// <summary>
        /// 读取XML配置文件，返回券别名称
        /// </summary>
        /// <param name="path"></param>
        /// <param name="xmlData"></param>
        private void ReadXML(string path, XMLCashInfo[] xmlData)
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
                xmlData[i] = new XMLCashInfo();
                xmlData[i].Type = xnl0.Item(0).InnerText;
                xmlData[i].Label= xnl0.Item(1).InnerText;
                xmlData[i].Version = xnl0.Item(2).InnerText;
                xmlData[i].Box = xnl0.Item(3).InnerText;
                xmlData[i].Bundle = xnl0.Item(4).InnerText;
                xmlData[i].Bag = xnl0.Item(5).InnerText;
                i++;
            }
            reader.Close();
        }
    }
}
