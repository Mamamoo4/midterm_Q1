using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace midterm_exam_Q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void bubbleSort(int[] data)
        {
            int i, j,len,temp ;
            len = data.GetUpperBound(0);
            for(i=len ; i>=0 ; i--)
                for(j=0 ; j<=(len-1) ; j++)
                    if (data[j + 1] < data[j])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[4];
            data[0] = Convert.ToInt32(textBox1.Text);
            data[1] = Convert.ToInt32(textBox2.Text);
            data[2] = Convert.ToInt32(textBox3.Text);
            data[3] = Convert.ToInt32(textBox4.Text);
            bubbleSort(data);
            label2.Text = $"最大值為 : {data[3]} ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
