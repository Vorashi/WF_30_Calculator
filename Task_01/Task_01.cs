using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_01
{
    public partial class Task_01 : Form
    {
        public double FirstAmpersand = 0;
        public string Operation = "";
        public Task_01()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> btnList = new List<string> { "7", "8", "9", "+", "4", "5", "6", "-", "1", "2", "3", "=", "0", ".", "C" };

            for (int i = 0; i < btnList.Count; i++)
            {
                Button btn = new Button();
                btn.Text = btnList[i].ToString();
                switch (i)
                {
                    case 0:
                        btn.Click += new EventHandler(btnClick7);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(10, 20);
                        break;
                    case 1:
                        btn.Click += new EventHandler(btnClick8);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(90, 20);
                        break;
                    case 2:
                        btn.Click += new EventHandler(btnClick9);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(170, 20);
                        break;
                    case 3:
                        btn.Click += new EventHandler(btnClickPlus);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(250, 20);
                        break;
                    case 4:
                        btn.Click += new EventHandler(btnClick4);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(10, 50);
                        break;
                    case 5:
                        btn.Click += new EventHandler(btnClick5);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(90, 50);
                        break;
                    case 6:
                        btn.Click += new EventHandler(btnClick6);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(170, 50);
                        break;
                    case 7:
                        btn.Click += new EventHandler(btnClickMinus);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(250, 50);
                        break;
                    case 8:
                        btn.Click += new EventHandler(btnClick1);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(10, 80);
                        break;
                    case 9:
                        btn.Click += new EventHandler(btnClick2);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(90, 80);
                        break;
                    case 10:
                        btn.Click += new EventHandler(btnClick3);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(170, 80);
                        break;
                    case 11:
                        btn.Click += new EventHandler(btnClickRavno);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(250, 80);
                        break;
                    case 12:
                        btn.Click += new EventHandler(btnClick0);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Size = new Size(75 + 80, 23);
                        btn.Location = new Point(10, 110);
                        break;
                    case 13:
                        btn.Click += new EventHandler(btnClickPoint);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(170, 110);
                        break;
                    case 14:
                        btn.Click += new EventHandler(btnClickClear);
                        btn.Name = $"btn{btnList[i]}";
                        btn.Location = new Point(250, 110);
                        break;
                }
                Panel.Controls.Add(btn);
            }
        }


        private void btnClick7 (object sender, EventArgs e)
        {
            TbxInput.Text += "7";
        }

        private void btnClick8(object sender, EventArgs e)
        {
            TbxInput.Text += "8";
        }

        private void btnClick9(object sender, EventArgs e)
        {
            TbxInput.Text += "9";
        }

        private void btnClickPlus(object sender, EventArgs e)
        {
            double number;
            if (FirstAmpersand == 0) 
            {
                double.TryParse(TbxInput.Text, out number);
                FirstAmpersand = number;
            }
            if (Operation == "") Operation = "+";
            TbxInput.Text = "";
        }

        private void btnClick4(object sender, EventArgs e)
        {
            TbxInput.Text += "4";
        }

        private void btnClick5(object sender, EventArgs e)
        {
            TbxInput.Text += "5";
        }

        private void btnClick6(object sender, EventArgs e)
        {
            TbxInput.Text += "6";
        }

        private void btnClickMinus(object sender, EventArgs e)
        {
            if (FirstAmpersand == 0)
            {
                FirstAmpersand =  Convert.ToDouble(TbxInput.Text);  
            }
            if (Operation == "") Operation = "-";
            TbxInput.Text = "";
        }

        private void btnClick1(object sender, EventArgs e)
        {
            TbxInput.Text += "1";
        }

        private void btnClick2(object sender, EventArgs e)
        {
            TbxInput.Text += "2";
        }

        private void btnClick3(object sender, EventArgs e)
        {
            TbxInput.Text += "3";
        }

        private void btnClickRavno(object sender, EventArgs e)
        {
           double number; 
           double.TryParse(TbxInput.Text,out number);
           if (FirstAmpersand != 0) TbxInput.Text = Calc(FirstAmpersand, number, Operation).ToString();
           FirstAmpersand = 0;
           Operation = "";
        }

        private void btnClick0(object sender, EventArgs e)
        {
            TbxInput.Text += "0";
        }

        private void btnClickPoint(object sender, EventArgs e)
        {
            TbxInput.Text += ".";
        }

        private void btnClickClear(object sender, EventArgs e)
        {
            TbxInput.Text = "";
            FirstAmpersand = 0;
            Operation = "";
        }

        public double Calc(double First, double Second, string Operation)
        {
            if (Operation == "+") return First + Second;
            else return First - Second;
        }
    }
}
