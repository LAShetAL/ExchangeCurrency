using System.Collections.Generic;
using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {


        }
       
        public async Task runEvent()
        {
            try
            {

                //Dönüþtüreceðimiz tüm deðerleri dinamik alýyoruz Program.cs teki GetData fonksiyonuna gönderiyoruz
                int amount = Convert.ToInt32(currencyInput.Text);  

                string firstOptionValue = firstOption.Text;
                int secondOptionValue = secondOption.SelectedIndex;

                double output = Convert.ToDouble( await Program.GetData(amount, firstOptionValue, secondOptionValue));
                currencyOutput.Text = output.ToString("F2");
            }
            catch
            {
                string.IsNullOrEmpty(currencyInput.Text);
            }
        }

        private void firstOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             runEvent();//tekst deðiþtiðinde dinamik çalýþmasý için
        }

        private void secondOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            runEvent(); // keza döviz birimleri deðiþtinde de
        }

        private void currencyInput_TextChanged(object sender, EventArgs e)
        {
            runEvent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

