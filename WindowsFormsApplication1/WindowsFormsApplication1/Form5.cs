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
    public partial class Form5 : Form
    {
        public static int i;
        public static int j;
        public static char value;
        public char Space= ' ';
        public int index;
        public int score=0;
        public int incorrect = 0;
        public Form5()
        {
            InitializeComponent();
        }
           void DrawChar1(int row, int col, char c)
        {
             
            Form1.g.DrawString("" + c, new Font(new FontFamily("Times New Roman"), 31, FontStyle.Bold), Brushes.Green, new PointF(col * 50 + 10, row * 50));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            i--;
            j--;
            if (i == -1 || j == -1 || value == '\0')
            {
                MessageBox.Show("Enter a valid value :D");
            }
            else
            {
                index = (9 * i) + j;
                if (Form3.unsolved[index] != ' ')
                {
                    MessageBox.Show("Invalid Position");
                }
                else
                {
                    if(value==Form3.solved[index])
                    {
                        DrawChar1(i, j, value);
                        Form3.counter--;
                        score++;
                        if(Form3.counter==0)
                         MessageBox.Show("Congratulations..!!!!"+"Your Score is: "+score+"Your incorrect Answers are: "+incorrect);
                    }
                    else
                    {
                        MessageBox.Show("Wrong answer");
                        incorrect++;
                    }
                }
            }

           }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object index_row = comboBox1.SelectedItem;
            i = Convert.ToInt32(index_row);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            object index_col = comboBox2.SelectedItem;
            j = Convert.ToInt32(index_col);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            object index_value = comboBox3.SelectedItem;
            value = Convert.ToChar(index_value);
        }
    }
}
