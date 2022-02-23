using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefOutParamsExcercise
{
    public partial class Form1 : Form
    {
        int number1 = 1;
        int number2 = 2;
        int number3 = 3;
        int number4 = 4;
        int sum;
        int multiplication;

        public Form1()
        {
            InitializeComponent();
        }

        void InitializeValues()
        {
            sum = 0;
            multiplication = 1;
        }

        void ShowValues()
        {
            MessageBox.Show("Sayıların toplamı " + sum + "\n" + "Sayıların çarpımı " + multiplication);
        }

        private void standart_button_Click(object sender, EventArgs e)
        {
            InitializeValues();
            StandartMethod(sum, multiplication, number1, number2, number3, number4);
            ShowValues();
        }
        void StandartMethod(int sum, int multiplication, params int[] numbers)
        {
            sum = 0;
            multiplication = 1;

            foreach (int sayi in numbers)
            {
                sum += sayi;
                multiplication *= sayi;
            }
        }

        private void out_button_Click(object sender, EventArgs e)
        {
            InitializeValues();
            OutMethod(out sum, out multiplication, number1, number2, number3, number4);
            ShowValues();
        }

        void OutMethod(out int sum, out int multiplication, params int[] numbers)
        {
            sum = 0;
            multiplication = 1;

            foreach (int sayi in numbers)
            {
                sum += sayi;
                multiplication *= sayi;
            }
        }

        private void ref_button_Click(object sender, EventArgs e)
        {
            InitializeValues();
            RefMethod(ref sum, ref multiplication, number1, number2, number3, number4);
            ShowValues();
        }

        void RefMethod(ref int sum, ref int multiplication, params int[] numbers)
        {
            sum = 0;
            multiplication = 1;

            foreach (int sayi in numbers)
            {
                sum += sayi;
                multiplication *= sayi;
            }
        }
    }
}
