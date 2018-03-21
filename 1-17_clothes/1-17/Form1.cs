using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int 第一个,第二个;
            if (!(int.TryParse(textBox1.Text, out 第一个) && (int.TryParse(textBox2.Text, out 第二个))))
                label3.Text = "输入错误，请重新输入";
            else
            {
                switch(第一个)
                {
                    case 1: label3.Text = "应付款"+计算价钱(100, 第二个).ToString()+"元"+"\n谢谢惠顾！"; break;
                    case 2: label3.Text = "应付款"+计算价钱(1000, 第二个).ToString()+"元\n谢谢惠顾！";break;
                    case 3: label3.Text = "应付款"+计算价钱(5000, 第二个).ToString()+"元\n谢谢惠顾！";break;
                }
            }

        }

        public int 计算价钱(int 单价, int 数量)
        {
            return 单价 * 数量;
        }
    }
}
