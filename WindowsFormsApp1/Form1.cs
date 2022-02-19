using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// 
        ///     Salam mellim kodu yoxlayanda hecbir yerde deysiyliy etmeyin en axirda neyise yoxlamaq isdeseniz edin cunki neyise deyisdirende formlar arasi kecis edende gosderdiyiniz bagg olur Hide() gore 
        ///     Kodun duz isleyir sade Hide() problemin hell ede bilmirem deyesen menle elaqeli bir sey deyil
        /// 

        List<Catagori> catagoris1 = new List<Catagori>();

        static bool moneyPath = false;
        static bool SelectionPath = false;


        public string DaxilEdilen { get; set; }
        public string Selection { get; set; }

        public Form1()
        {
            InitializeComponent();
        }


        public void moneyPathVerif(bool other) { moneyPath = other; }
        public void SelectionPathVerif(bool other) { SelectionPath = other; }

        public bool RetrunSelectionPath() { return SelectionPath; }


        public void CatagoriList()
        {
            var jsonStr = File.ReadAllText("Otomat.json");
            catagoris1 = JsonConvert.DeserializeObject<List<Catagori>>(jsonStr);
        }


        public void JasonDec(int index)
        {
            if(index == 1) { catagoris1[0].Coca_Cola = label2.Text; }
            else if (index == 2) { catagoris1[0].Pepsi = label3.Text; }
            else if (index == 3) { catagoris1[0].MilkShake = label4.Text; }
            else if (index == 4) { catagoris1[0].ChokolateRed = label5.Text; }
            else if (index == 5) { catagoris1[0].IceCream = label6.Text; }
            else if (index == 6) { catagoris1[0].ChokolatePurple = label7.Text; }
            else if (index == 7) { catagoris1[0].ChokolateLovePurple = label8.Text; }
            else if (index == 8) { catagoris1[0].Soda = label9.Text; }
            else if (index == 9) { catagoris1[0].ChokolateBlue = label10.Text; }
            else if (index == 10) { catagoris1[0].ChokolateMilkShake = label12.Text; }
            else if (index == 11) { catagoris1[0].ChokolateIceCream = label11.Text; }
            else if (index == 12) { catagoris1[0].ChokolateEnergiy = label13.Text; }

            var str = JsonConvert.SerializeObject(catagoris1, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText("Otomat.json", str);

        }



        public void Reset()
        {
            label16.Text = "0";
            label17.Text = "0";
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;

            label1.Text = "0";

            moneyPath = false;
            SelectionPath = false;

            pictureBox48.Visible = false;
            button4.Visible = false;

        }


        public void Form1_Load(object sender, EventArgs e)
        {

            if(SelectionPath == true)
            {
                label1.Text = Selection;
            }
            else
            {
                label1.Text = "0";
            }

            if(moneyPath == true)
            {
                label14.Visible = true;
                label16.Visible = true;
                
                if(label16.Text == "0") label16.Text = DaxilEdilen;
                else label16.Text += DaxilEdilen;

            }
            else
            {
                label14.Visible = false;
                label16.Visible = false;
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            List<Catagori> catagoris = new List<Catagori>();

            label15.Visible = false;
            label17.Visible = false;

            var jsonStr = File.ReadAllText("Otomat.json");
            catagoris = JsonConvert.DeserializeObject<List<Catagori>>(jsonStr);

            label2.Text = catagoris[0].Coca_Cola;
            label3.Text = catagoris[0].Pepsi;
            label4.Text = catagoris[0].MilkShake;
            label5.Text = catagoris[0].ChokolateRed;
            label6.Text = catagoris[0].IceCream;
            label7.Text = catagoris[0].ChokolatePurple;
            label8.Text = catagoris[0].ChokolateLovePurple;
            label9.Text = catagoris[0].Soda;
            label10.Text = catagoris[0].ChokolateBlue;
            label11.Text = catagoris[0].ChokolateMilkShake;
            label12.Text = catagoris[0].ChokolateIceCream;
            label13.Text = catagoris[0].ChokolateEnergiy;

            pictureBox48.Visible = false;
            button4.Visible = false;

        }



        private void GetButton(object sender, EventArgs e)
        {

            if(label16.Text != "0" && label1.Text != "0" && button4.Visible == false)
            {

                int num = int.Parse(label16.Text);
                int selection = int.Parse(label1.Text);

                pictureBox48.Visible = true;
                button4.Visible = true;

                label15.Visible = true;
                label17.Visible = true;
                label17.Text = (num - 1).ToString();


                switch (selection)
                {
                    case 1:
                        int num1 = int.Parse(label2.Text);
                        label2.Text = (num1 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate64;
                        break;
                    case 2:
                        int num2 = int.Parse(label3.Text);
                        label3.Text = (num2 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.pepsi64;
                        break;
                    case 3:
                        int num3 = int.Parse(label4.Text);
                        label4.Text = (num3 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.milk_bottle64;
                        break;
                    case 4:
                        int num4 = int.Parse(label5.Text);
                        label5.Text = (num4 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate64;
                        break;
                    case 5:
                        int num5 = int.Parse(label6.Text);
                        label6.Text = (num5 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate__1_64;

                        break;
                    case 6:
                        int num6 = int.Parse(label7.Text);
                        label7.Text = (num6 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate_bar64;

                        break;
                    case 7:
                        int num7 = int.Parse(label8.Text);
                        label8.Text = (num7 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate__2_64;

                        break;
                    case 8:
                        int num8 = int.Parse(label9.Text);
                        label9.Text = (num8 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.soft_drink64;
                        break;
                    case 9:
                        int num9 = int.Parse(label10.Text);
                        label10.Text = (num9 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate_bar64__2_;
                        break;
                    case 10:
                        int num10 = int.Parse(label12.Text);
                        label12.Text = (num10 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.chocolate_milk64;
                        break;
                    case 11:
                        int num11 = int.Parse(label11.Text);
                        label11.Text = (num11 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.ice_cream64;
                        break;
                    case 12:
                        int num12 = int.Parse(label13.Text);
                        label13.Text = (num12 - 1).ToString();
                        button4.BackgroundImage = Properties.Resources.energy_bar64;
                        break;

                }

                CatagoriList();
                JasonDec(selection);

            }
            else
            {

                if (label16.Text == "0" && label1.Text == "0")
                {
                    label14.Visible = true;
                    label16.Visible = true;
                    label16.ForeColor = Color.Red;
                    label1.ForeColor = Color.Red;

                }

                else if (label16.Text == "0")
                {
                    label14.Visible = true;
                    label16.Visible = true;
                    label16.ForeColor = Color.Red;
                }
                else if(label1.Text == "0")
                {
                    label1.ForeColor = Color.Red;
                }
               
            }

           
        }

        private void MoneyAdd(object sender, EventArgs e)
        {

            if(label16.Visible == true && label16.ForeColor == Color.Red && button4.Visible == false)
            {
                label16.ForeColor = Color.Black;
                label14.Visible = false;
                label16.Visible = false;


            }

            if(button4.Visible == false)
            {
                MoneyAddForm moneyAddForm = new MoneyAddForm(label16.Text);
                moneyAddForm.OtomatNumber = label1.Text;
                moneyAddForm.Show();
                Hide();
            }
        }



        private void SelectionNumber(object sender, EventArgs e)
        {

            if(button4.Visible == false)
            {
                SelectionNumberOtomat selectionNumber = new SelectionNumberOtomat();
                selectionNumber.Path = label16.Text;
                selectionNumber.Show();
                Hide();
            }
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
