using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_16
{
    public partial class Test3_1 : Form
    {
        public Test3_1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int age;
            if (!(int.TryParse(textBox1.Text, out age)))
                label2.Text="输入错误，请重新输入！";
            else
            {
                if (age >= 18)
                {
                    label2.Text="您已成年";
                }
                else if (age < 0)
                {
                    label2.Text="输入错误，请重新输入！";
                }
                else if (age >= 0 && age < 18)
                {
                    label2.Text="您未成年";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
