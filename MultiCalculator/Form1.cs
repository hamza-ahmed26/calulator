using System;
using System.Windows.Forms;

namespace MultiCalculator
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        string op = "";

        public Form1()
        {
            InitializeComponent();
        }

        string ToArabic(string s)
        {
            return s.Replace('0', '٠').Replace('1', '١').Replace('2', '٢')
                    .Replace('3', '٣').Replace('4', '٤').Replace('5', '٥')
                    .Replace('6', '٦').Replace('7', '٧').Replace('8', '٨')
                    .Replace('9', '٩');
        }

        string ToEnglish(string s)
        {
            return s.Replace('٠', '0').Replace('١', '1').Replace('٢', '2')
                    .Replace('٣', '3').Replace('٤', '4').Replace('٥', '5')
                    .Replace('٦', '6').Replace('٧', '7').Replace('٨', '8')
                    .Replace('٩', '9');
        }

        private void checkBox_ar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ar.Checked)
            {
                checkBox_en.Checked = false;

                btn_0.Text = "٠";
                btn_1.Text = "١";
                btn_2.Text = "٢";
                btn_3.Text = "٣";
                btn_4.Text = "٤";
                btn_5.Text = "٥";
                btn_6.Text = "٦";
                btn_7.Text = "٧";
                btn_8.Text = "٨";
                btn_9.Text = "٩";

                textBox1.Text = ToArabic(textBox1.Text);
            }
        }

        private void checkBox_en_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_en.Checked)
            {
                checkBox_ar.Checked = false;

                btn_0.Text = "0";
                btn_1.Text = "1";
                btn_2.Text = "2";
                btn_3.Text = "3";
                btn_4.Text = "4";
                btn_5.Text = "5";
                btn_6.Text = "6";
                btn_7.Text = "7";
                btn_8.Text = "8";
                btn_9.Text = "9";

                textBox1.Text = ToEnglish(textBox1.Text);
            }
        }

        private void btn0_Click(object sender, EventArgs e) { textBox1.Text += btn_0.Text; }
        private void btn1_Click(object sender, EventArgs e) { textBox1.Text += btn_1.Text; }
        private void btn2_Click(object sender, EventArgs e) { textBox1.Text += btn_2.Text; }
        private void btn3_Click(object sender, EventArgs e) { textBox1.Text += btn_3.Text; }
        private void btn4_Click(object sender, EventArgs e) { textBox1.Text += btn_4.Text; }
        private void btn5_Click(object sender, EventArgs e) { textBox1.Text += btn_5.Text; }
        private void btn6_Click(object sender, EventArgs e) { textBox1.Text += btn_6.Text; }
        private void btn7_Click(object sender, EventArgs e) { textBox1.Text += btn_7.Text; }
        private void btn8_Click(object sender, EventArgs e) { textBox1.Text += btn_8.Text; }
        private void btn9_Click(object sender, EventArgs e) { textBox1.Text += btn_9.Text; }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(ToEnglish(textBox1.Text));
            op = "+";
            textBox1.Clear();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(ToEnglish(textBox1.Text));
            op = "-";
            textBox1.Clear();
        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(ToEnglish(textBox1.Text));
            op = "*";
            textBox1.Clear();
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(ToEnglish(textBox1.Text));
            op = "/";
            textBox1.Clear();
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            double num2 = double.Parse(ToEnglish(textBox1.Text));
            double result = 0;

            if (op == "+") result = num1 + num2;
            if (op == "-") result = num1 - num2;
            if (op == "*") result = num1 * num2;
            if (op == "/") result = num1 / num2;

            string text = result.ToString();

            if (checkBox_ar.Checked)
            {
                text = ToArabic(text);
            }

            textBox1.Text = text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}