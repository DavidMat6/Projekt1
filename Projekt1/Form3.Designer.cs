namespace Projekt1
{
    partial class Form3
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
            textBoxSnaga = new TextBox();
            textBoxVrijeme = new TextBox();
            Izracunaj = new Button();
            label1 = new Label();
            label2 = new Label();
            labelRezultat = new Label();
            SuspendLayout();
            // 
            // textBoxSnaga
            // 
            textBoxSnaga.Location = new Point(165, 21);
            textBoxSnaga.Name = "textBoxSnaga";
            textBoxSnaga.Size = new Size(74, 23);
            textBoxSnaga.TabIndex = 0;
            // 
            // textBoxVrijeme
            // 
            textBoxVrijeme.Location = new Point(165, 50);
            textBoxVrijeme.Name = "textBoxVrijeme";
            textBoxVrijeme.Size = new Size(74, 23);
            textBoxVrijeme.TabIndex = 1;
            // 
            // Izracunaj
            // 
            Izracunaj.Location = new Point(165, 79);
            Izracunaj.Name = "Izracunaj";
            Izracunaj.Size = new Size(74, 28);
            Izracunaj.TabIndex = 2;
            Izracunaj.Text = "Izračunaj";
            Izracunaj.UseVisualStyleBackColor = true;
            Izracunaj.Click += Izracunaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 29);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Snaga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 58);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 4;
            label2.Text = "Vrijeme";
            // 
            // labelRezultat
            // 
            labelRezultat.AutoSize = true;
            labelRezultat.Location = new Point(165, 142);
            labelRezultat.Name = "labelRezultat";
            labelRezultat.Size = new Size(38, 15);
            labelRezultat.TabIndex = 5;
            labelRezultat.Text = "label3";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRezultat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Izracunaj);
            Controls.Add(textBoxVrijeme);
            Controls.Add(textBoxSnaga);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSnaga;
        private TextBox textBoxVrijeme;
        private Button Izracunaj;
        private Label label1;
        private Label label2;
        private Label labelRezultat;
    }
}