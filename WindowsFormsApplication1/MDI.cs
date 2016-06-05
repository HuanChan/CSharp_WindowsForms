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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            //添加菜单步骤：右键，工具箱空白处，选择项，.NET Framework组件，MainMenu，然后出现在工具箱，拖动添加即可
            Form1 Mdichild = new Form1();
            //首先实例化 Form1 对象，命名为Mdichild
            Mdichild.MdiParent = this;
            //其次指定Form1的MdiParent，即Form1的父窗体为当前主MDI窗体
            Mdichild.Show();
            //单击父窗体“菜单”\“子窗体1”时，会显示Form1窗体。
            //Form1只能再父窗体下活动，不能超出父窗体的范围。
        }

        private void MDI_Load(object sender, EventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Form2 Mdichild = new Form2();
            Mdichild.MdiParent = this;
            Mdichild.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Form3 Mdichild = new Form3();
            Mdichild.MdiParent = this;
            Mdichild.Show();
        }
    }
}
