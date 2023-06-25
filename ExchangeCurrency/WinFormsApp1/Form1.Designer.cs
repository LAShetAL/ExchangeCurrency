namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            currencyInput = new TextBox();
            currencyOutput = new TextBox();
            firstOption = new ComboBox();
            secondOption = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // currencyInput
            // 
            currencyInput.BackColor = SystemColors.Window;
            currencyInput.Location = new Point(52, 99);
            currencyInput.Name = "currencyInput";
            currencyInput.Size = new Size(113, 23);
            currencyInput.TabIndex = 0;
            currencyInput.TextChanged += currencyInput_TextChanged;
            // 
            // currencyOutput
            // 
            currencyOutput.Location = new Point(696, 99);
            currencyOutput.Name = "currencyOutput";
            currencyOutput.ReadOnly = true;
            currencyOutput.Size = new Size(100, 23);
            currencyOutput.TabIndex = 1;
            // 
            // firstOption
            // 
            firstOption.FormattingEnabled = true;
            firstOption.Items.AddRange(new object[] { "AUD", "BGN", "BRL", "CAD", "CHF", "CNY", "CZK", "DKK", "EUR", "GBP", "HKD", "HRK", "HUF", "IDR", "ILS", "INR", "ISK", "JPY", "KRW", "MXN", "MYR", "NOK", "NZD", "PHP", "PLN", "RON", "RUB", "SEK", "SGD", "THB", "TRY", "USD", "ZAR" });
            firstOption.Location = new Point(305, 99);
            firstOption.Name = "firstOption";
            firstOption.Size = new Size(121, 23);
            firstOption.TabIndex = 2;
            firstOption.SelectedIndexChanged += firstOption_SelectedIndexChanged;
            // 
            // secondOption
            // 
            secondOption.FormattingEnabled = true;
            secondOption.Items.AddRange(new object[] { "AUD", "BGN", "BRL", "CAD", "CHF", "CNY", "CZK", "DKK", "EUR", "GBP", "HKD", "HRK", "HUF", "IDR", "ILS", "INR", "ISK", "JPY", "KRW", "MXN", "MYR", "NOK", "NZD", "PHP", "PLN", "RON", "RUB", "SEK", "SGD", "THB", "TRY", "USD", "ZAR" });
            secondOption.Location = new Point(528, 99);
            secondOption.Name = "secondOption";
            secondOption.Size = new Size(121, 23);
            secondOption.TabIndex = 3;
            secondOption.SelectedIndexChanged += secondOption_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 69);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 4;
            label1.Text = "Çevireceğiniz Miktarı Giriniz";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 102);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Bu birime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, 102);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 6;
            label3.Text = "Bu birimden";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 69);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Sonuç";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(881, 577);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(secondOption);
            Controls.Add(firstOption);
            Controls.Add(currencyOutput);
            Controls.Add(currencyInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox currencyInput;
        private TextBox currencyOutput;
        private ComboBox firstOption;
        private ComboBox secondOption;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}