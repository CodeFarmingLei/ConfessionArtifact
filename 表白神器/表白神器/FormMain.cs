using System;
using System.Drawing;
using System.Windows.Forms;

namespace 表白神器
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //加载背景窗口
            Form FormHei = new FromHei();
            FormHei.Show();
        }

        private void buttonNo_MouseMove(object sender, MouseEventArgs e)
        {
            Random xy = new Random();
            //随机X坐标
            int x = xy.Next(10,600);
            //随机y坐标
            int y = xy.Next(10,300);

            buttonNo.Location = new Point(x,y);
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            Form Yes = new Yes();
            Yes.Show();
        }
    }
}
