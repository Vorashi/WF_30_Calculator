using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task_03
{
    public partial class Task_03 : Form
    {
        public Task_03()
        {
            InitializeComponent();
            CbxX.Items.AddRange(new object[] { 38.3, -2.62, -3.75 });
        }


        private void BtnCalc_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TbxA.Text, out double a) && double.TryParse(TbxB.Text, out double b) && CbxX.Text != "")
            {
                double x = Convert.ToDouble(CbxX.SelectedItem);
                double c = Math.Exp(Math.Abs(a)) * (a + 1 / Math.Sin(x)) * Math.Sqrt(a + b);
                LblResult.Text = $"a = {a}, b = {b}, c = {c}";

                // Запись результата в файл
                using (StreamWriter writer = new StreamWriter("C:\\My work programm\\C#\\WF_30\\result.txt"))
                {
                    writer.WriteLine($"a = {a}, b = {b}, c = {c}");
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите числовые значения для a и b или выбирете значение в комбо боксе.");
            }
        }

        private void BthClear_Click(object sender, EventArgs e)
        {
            TbxA.Text = "";
            TbxB.Text = "";
            LblResult.Text = "Результат = ";
            CbxX.Text = "";
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            FormClosingEventArgs args = new FormClosingEventArgs(CloseReason.UserClosing, false);
            Task_03_FormClosing(this, args);
            if (!args.Cancel)
            {
                Close();
            }
        }
        private void Task_03_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Предупреждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
