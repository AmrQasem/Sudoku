using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        [DllImport("Project.dll")]
        private static extern void getEasy([In, Out]char[] unsolved, int unsize, [In, Out]char[] solved, int ssize);

        [DllImport("Project.dll")]
        private static extern void getMed([In, Out]char[] unsolved, int unsize, [In, Out]char[] solved, int ssize);

        [DllImport("Project.dll")]
        private static extern void getHard([In, Out]char[] unsolved, int unsize, [In, Out]char[] solved, int ssize);

        public static char[] unsolved = new char[81];
        public char[] Ref_unsolved = new char[81];
        public static char[] solved = new char[81];
        public static char[] clear = new char[81];
        public static int counter=0;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getEasy(unsolved, unsolved.Length, solved, solved.Length);
            Form1 form1 = new Form1();
            this.Visible=false;
            form1.Visible = true;
            for (int x = 0; x < 81; x++)
            {
                if (unsolved[x] == ' ')
                    counter++;
            }
            counter = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    clear[counter] = unsolved[counter];
                    counter++;
                }
            }
            Ref_unsolved = unsolved;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getMed(unsolved, unsolved.Length, solved, solved.Length);
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Visible = true;
            for (int x = 0; x < 81; x++)
            {
                if (unsolved[x] == ' ')
                    counter++;
            }
            counter = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    clear[counter] = unsolved[counter];
                    counter++;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getHard(unsolved, unsolved.Length, solved, solved.Length);
            Form1 form1 = new Form1();
            this.Visible = false;
            form1.Visible = true;
            for (int x = 0; x < 81; x++)
            {
                if (unsolved[x] == ' ')
                    counter++;
            }
            counter = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    clear[counter] = unsolved[counter];
                    counter++;
                }
            }
        }
         private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
