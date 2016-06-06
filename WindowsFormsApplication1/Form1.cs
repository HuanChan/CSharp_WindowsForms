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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("颜色反馈");
            comboBox1.Items.Add("颜馈");
            comboBox1.SelectedIndex = 0;
            textBox2.Text = "";
            textBox1.Focus();
            //设置Form1 窗体的初始化源代码
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" | textBox2.Text == "")
            {
                MessageBox.Show("姓名或邮件地址不能为空！", "信息提示");
            }
            else
            {
                this.Hide();
                //button所在的Form1隐藏
                Form2 childForm2 = new Form2(this.textBox1.Text, this.textBox2.Text, this.comboBox1.SelectedItem.ToString());
                childForm2.Show();
                //Form2为将要接收Form1参数的窗体
                //效果：点击“发送”，先判断Form1中文本框是否有参数，然后生成新的Form2，用以接受Form1中的参数
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
