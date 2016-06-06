using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        private string p1;
        private string p2;
        private string p3;
        //对Form2定义，明确定义了相关的参数
        //创建Form2的类
        public Form2()
        {
            InitializeComponent();
            //在private 变量中存储值。
        }

        public Form2(string varp1, string varp2, string varp3)
        {
            // TODO: Complete member initialization
            this.p1 = varp1;
            this.p2 = varp2;
            this.p3 = varp3;
            listBox1.Items.Add("姓名" + this.p1);
            listBox1.Items.Add("邮件" + this.p2);
            listBox1.Items.Add("主题" + this.p3);
            //Form2类的实例化：使用InitializeComponent() 存储值。
            //类的实例化，必须先声明变量，然后赋值。

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("感谢您输入的反馈！");
            this.Close();
        }
    }
}
