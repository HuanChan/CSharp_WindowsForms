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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void ComboBox_Load(object sender, EventArgs e)
        {
            //双击窗体进入编辑
            this.comboBox1.Items.Add("财务部");
            this.comboBox1.Items.Add("产品部");
            this.comboBox1.Items.Add("销售部");
            this.comboBox1.Items.Add("生产部");
            //在comboBox中输入内容,注意名称前的c是小写
            this.comboBox1.SelectedIndex = 1;
            //comboBox1，默认选择的是产品部

            this.comboBox2.Items.Add("财务部");
            this.comboBox2.Items.Add("产品部");
            this.comboBox2.Items.Add("销售部");
            this.comboBox2.Items.Add("生产部");
            this.comboBox2.SelectedIndex = 1;
            //comboBox2，默认选择的是产品部

            this.listBox1.Items.Add("财务部");
            this.listBox1.Items.Add("产品部");
            this.listBox1.Items.Add("销售部");
            this.listBox1.Items.Add("生产部");
            this.listBox1.SelectedIndex = 1;
            //listBox1,默认选择的是产品部

            this.textBox1.Text = "产品部";
            //textBox1，默认选择的是产品部

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //双击comboBox，在变化选择的时候，下面的comboBox2、textBox1、listBox1也跟着改变
            string mess = comboBox1.SelectedItem.ToString();
            //声明一个字符串mess，它的内容等于选中的comboBox1内容。
            comboBox2.SelectedItem = mess;
            //comboBox2 中选中的内容=mess
            listBox1.SelectedItem = mess;
            textBox1.Text = mess;
            //textBox1中的文字内容等于mess
        }


    }
}
