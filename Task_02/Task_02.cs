using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_02
{
    public partial class Task_02 : Form
    {
        public Task_02()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label lblWidth = new Label();
            lblWidth.Text = "Введите значение ширины:";
            lblWidth.Size = new Size(145, 16);
            lblWidth.Location = new Point(15, 60);
            Controls.Add(lblWidth);

            TextBox tbxWidth = new TextBox();
            tbxWidth.BorderStyle = BorderStyle.FixedSingle;
            tbxWidth.Location = new Point(20, 85);
            Controls.Add(tbxWidth);

            Label lblHeight = new Label();
            lblHeight.Text = "Длина высоты:";
            lblHeight.Size = new Size(145, 16);
            lblHeight.Location = new Point(175, 60);
            Controls.Add(lblHeight);

            TextBox tbxHeight = new TextBox();
            tbxHeight.BorderStyle = BorderStyle.FixedSingle;
            tbxHeight.Location = new Point(180, 85);
            Controls.Add(tbxHeight);

            ComboBox cbx = new ComboBox();
            cbx.Name = "Cbx";
            cbx.Location = new Point(20, 120);
            cbx.Items.Add("330*330мм");
            cbx.Items.Add("400*400мм");
            cbx.Items.Add("500*500мм");
            cbx.TabStop = false;
            Controls.Add(cbx);

            Button btn = new Button();
            btn.Location = new Point(40, 160);
            btn.Text = "Посчитать";
            btn.FlatStyle = FlatStyle.Popup;
            btn.Click += new EventHandler(btnClickCalc);
            Controls.Add(btn);

            Label lblResult = new Label();
            lblResult.Size = new Size(400, 16);
            lblResult.Location = new Point(10, 210);
            Controls.Add(lblResult);

            Button btnClose = new Button();
            btnClose.Location = new Point(40, 240);
            btnClose.Text = "Закрыть";
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Click += new EventHandler(btnClickClose);
            Controls.Add(btnClose);
        }

        private void btnClickClose(object sender, EventArgs e) 
        {
            Close();
        }

        private void btnClickCalc(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Controls[3].Text) && double.TryParse(Controls[3].Text, out double length) &&
            !string.IsNullOrEmpty(Controls[1].Text) && double.TryParse(Controls[1].Text, out double width))
            {
                ComboBox cbx = (ComboBox)Controls[4];
                double tileLength = 0;
                double tileWidth = 0;

                switch (cbx.SelectedIndex)
                {
                    case 0:
                        tileLength = 0.33;
                        tileWidth = 0.33;
                        break;
                    case 1:
                        tileLength = 0.4;
                        tileWidth = 0.4;
                        break;
                    case 2:
                        tileLength = 0.5;
                        tileWidth = 0.5;
                        break;
                    default:
                        MessageBox.Show("Неверный выбор размера плитки.");
                        return;
                }
                double seamWidth = double.Parse(Controls[1].Text) / 1000; // переводим ширину шва в метры

                double areaToCover = length * width;
                double areaPerTile = (tileLength + seamWidth) * (tileWidth + seamWidth);
                int tilesNeeded = (int)Math.Ceiling(areaToCover / areaPerTile);

                Controls[6].Text = $"Для покрытия помещения площадью {areaToCover} м^2 требуется {tilesNeeded} плиток.";
            }
            else
            {
                Controls[6].Text = "Введите числовое значение";
            }
        }
    }
}
