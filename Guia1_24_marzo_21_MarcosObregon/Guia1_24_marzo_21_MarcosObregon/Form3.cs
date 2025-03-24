using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia1_24_marzo_21_MarcosObregon
{
    public partial class Form3 : Form
    {
        int i;
        int num1;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(button1.Text);
            do {
                int multi;
                multi = num1 * i;
                dataGridView1.Rows.Add(num1,i,multi);
                i++;
            }while (i > 11);
            
        }
    }
}
