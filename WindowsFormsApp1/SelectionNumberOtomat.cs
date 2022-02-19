using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelectionNumberOtomat : Form
    {

        public string Path { get; set; }

        public SelectionNumberOtomat()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        private void num1(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 1;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "1";
                }
            }
        }

        private void num2(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 2;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "2";
                }
            }
        }

        private void num3(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 3;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "3";
                }
            }
        }

        private void num4(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 4;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "4";
                }
            }
        }

        private void num5(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 5;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "5";
                }
            }
        }

        private void num6(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 6;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "6";
                }
            }
        }

        private void num7(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 7;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "7";
                }
            }
        }

        private void num8(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 8;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int result = 0;
            result = label1.Text.Length;

            if (result < 2)
            {
                if (label1.Text == "0")
                {
                    int other = int.Parse(label1.Text);
                    other += 9;
                    label1.Text = other.ToString();
                }
                else
                {
                    int other = int.Parse(label1.Text);
                    label1.Text = other.ToString() + "9";
                }
            }
        }

        private void Zero(object sender, EventArgs e)
        {
            int result, size;
            result = int.Parse(label1.Text);
            size = label1.Text.Length;

            if (result >= 1 && size < 2)
            {
                if (label1.Visible == false) { label1.Visible = true; }
                int other = int.Parse(label1.Text);
                label1.Text = other.ToString() + "0";
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            int size = 0;
            string result = "";
            size = label1.Text.Length;

            if (size == 1)
            {
                label1.Text = "0";
            }
            else
            {
                for (int i = 0; i < size - 1; i++)
                {
                    result += label1.Text[i];
                }

                label1.Text = result;
            }
        }

        private void Verif(object sender, EventArgs e)
        {

            int other = int.Parse(label1.Text);

            if (label1.Text != "0" && other <= 12)
            {

                Form1 form1 = new Form1();

                form1.label16.Text = Path;

                form1.SelectionPathVerif(true);

                form1.Selection = label1.Text;

                label2.Visible = false;

                form1.Show();

                Close();
                Dispose();

            }
            else
            {
                label2.Visible = true;
            }

        }


    }
}
