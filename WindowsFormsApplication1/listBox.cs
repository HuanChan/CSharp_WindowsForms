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
    public partial class listBox : Form
    {
        public listBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
            //双击窗口
        {
            this.listBox1.Items.Add("软件部");
            this.listBox1.Items.Add("硬件部");
            this.listBox1.Items.Add("财务部");
            this.listBox1.Items.Add("人事部");
            //this：指Form1
            //items：内容
            //add：添加
            //窗口初始化加载ListBox，并载入以上内容
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("您选择的部门是："+listBox1.SelectedItem.ToString()+"位列第" + listBox1.SelectedIndex.ToString(), "信息提示");
            //+listBox1.SelectedItem.ToString()：选择内容，然后显示
            //listBox1.SelectedIndex.ToString()：选择的列，然后显示
            //第一列为0
        }
    }
}
