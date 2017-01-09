using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLTest2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
