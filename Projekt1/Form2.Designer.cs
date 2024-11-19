namespace Projekt1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxDuljina = new TextBox();
            textBoxStruja = new TextBox();
            textBoxMagPolje = new TextBox();
            textBoxKut = new TextBox();
            Izracunaj = new Button();
            textBoxRezultat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxDuljina
            // 
            textBoxDuljina.Location = new Point(113, 12);
            textBoxDuljina.Name = "textBoxDuljina";
            textBoxDuljina.Size = new Size(84, 23);
            textBoxDuljina.TabIndex = 0;
            // 
            // textBoxStruja
            // 
            textBoxStruja.Location = new Point(113, 41);
            textBoxStruja.Name = "textBoxStruja";
            textBoxStruja.Size = new Size(84, 23);
            textBoxStruja.TabIndex = 1;
            // 
            // textBoxMagPolje
            // 
            textBoxMagPolje.Location = new Point(113, 70);
            textBoxMagPolje.Name = "textBoxMagPolje";
            textBoxMagPolje.Size = new Size(84, 23);
            textBoxMagPolje.TabIndex = 2;
            // 
            // textBoxKut
            // 
            textBoxKut.Location = new Point(113, 99);
            textBoxKut.Name = "textBoxKut";
            textBoxKut.Size = new Size(84, 23);
            textBoxKut.TabIndex = 3;
            // 
            // Izracunaj
            // 
            Izracunaj.Location = new Point(96, 128);
            Izracunaj.Name = "Izracunaj";
            Izracunaj.Size = new Size(84, 28);
            Izracunaj.TabIndex = 4;
            Izracunaj.Text = "Izračunaj";
            Izracunaj.UseVisualStyleBackColor = true;
            Izracunaj.Click += Izracunaj_Click;
            // 
            // textBoxRezultat
            // 
            textBoxRezultat.Location = new Point(96, 189);
            textBoxRezultat.Name = "textBoxRezultat";
            textBoxRezultat.Size = new Size(262, 23);
            textBoxRezultat.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 20);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 6;
            label1.Text = "Duljina";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 49);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 7;
            label2.Text = "Struja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Magnetsko polje";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 197);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Rezultat";
          
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 107);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 10;
            label5.Text = "Kut";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRezultat);
            Controls.Add(Izracunaj);
            Controls.Add(textBoxKut);
            Controls.Add(textBoxMagPolje);
            Controls.Add(textBoxStruja);
            Controls.Add(textBoxDuljina);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDuljina;
        private TextBox textBoxStruja;
        private TextBox textBoxMagPolje;
        private TextBox textBoxKut;
        private Button Izracunaj;
        private TextBox textBoxRezultat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}