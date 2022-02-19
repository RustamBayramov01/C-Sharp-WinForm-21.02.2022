using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MoneyAddForm : Form
    {
        public string OtomatNumber { get; set; }
        public string lastMoney { get; set; }

        public MoneyAddForm()
        {
            InitializeComponent();

        }


        public MoneyAddForm(string other)
        {
            InitializeComponent();
            lastMoney = other;
            
        }


        private void MoneyAddForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            label1.Visible = false;
        }

        private void Num1(object sender, EventArgs e)
        {
            if(label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if(result < 4)
            {
                if(label1.Text == "0")
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

        private void Num2(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num3(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num4(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num5(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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


        private void Num6(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num7(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num8(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

        private void Num9(object sender, EventArgs e)
        {
            if (label1.Visible == false) { label1.Visible = true; }

            int result = 0;
            result = label1.Text.Length;

            if (result < 4)
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

            if(result >= 1 && size < 4)
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

            if(size == 1)
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            form1.Selection = OtomatNumber;

            if (label1.Visible == true)
            {
                label1.Text = "0";
                label1.Visible = false;

                int result = int.Parse(lastMoney) + int.Parse(label1.Text);
                
                form1.DaxilEdilen = result.ToString();

                form1.Show();

                Close();
                Dispose();


            }
            else
            {

                int result = int.Parse(lastMoney) + int.Parse(label1.Text);
                
                form1.DaxilEdilen = result.ToString();

                form1.Show();

                Close();
                Dispose();

            }
        }


        private void Verif_Click(object sender, EventArgs e)
        {


            if (label1.Text != "0" && label1.Visible == true)
            {

                Form1 form1 = new Form1();
                
                form1.Selection = OtomatNumber;

                int result = int.Parse(lastMoney) + int.Parse(label1.Text);

                form1.DaxilEdilen = result.ToString();

                form1.moneyPathVerif(true);

                form1.Show();
                
                Close();
                Dispose();
            }
        }
    }
}
