using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            long startNum = 0, endNum = 0, total = 0, i = 0;
            startNum = Convert.ToInt64(txtStart.Text);
            endNum = Convert.ToInt64(txtEnd.Text);
            if (startNum <= endNum)
            {
                if (rdbFor.Checked)
                {
                    for (i = startNum; i <= endNum; i++)
                    {
                        total = +1;
                    }
                }
                if (rdbWhile.Checked)
                {
                    while (startNum <= endNum)
                    {
                        total += startNum;
                        startNum++;
                    }
                }
                if (rdbDo.Checked)
                {
                    do
                    {
                        total += startNum;
                        startNum++;
                    }
                    while (startNum <= endNum);

                }
                lblShow.Text = total.ToString();
            }
            else 
            {
                lblShow.Text = "起始值須小於等於終止值";
            }
        }
    }
}
