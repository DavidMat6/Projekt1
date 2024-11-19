namespace Projekt1
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
            label1 = new Label();
            Mag_sila_na_vod = new Button();
            El_en_u_kuc = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 27);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Odaberi što želiš računati";
            // 
            // Mag_sila_na_vod
            // 
            Mag_sila_na_vod.Location = new Point(43, 66);
            Mag_sila_na_vod.Name = "Mag_sila_na_vod";
            Mag_sila_na_vod.Size = new Size(215, 26);
            Mag_sila_na_vod.TabIndex = 1;
            Mag_sila_na_vod.Text = "Magnetska sila na vodič";
            Mag_sila_na_vod.UseVisualStyleBackColor = true;
            Mag_sila_na_vod.Click += Mag_sila_na_vod_Click;
            // 
            // El_en_u_kuc
            // 
            El_en_u_kuc.Location = new Point(349, 66);
            El_en_u_kuc.Name = "El_en_u_kuc";
            El_en_u_kuc.Size = new Size(277, 26);
            El_en_u_kuc.TabIndex = 2;
            El_en_u_kuc.Text = "Izračun električne energije u kućanstvu";
            El_en_u_kuc.UseVisualStyleBackColor = true;
            El_en_u_kuc.Click += El_en_u_kuc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(El_en_u_kuc);
            Controls.Add(Mag_sila_na_vod);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Početna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Mag_sila_na_vod;
        private Button El_en_u_kuc;
    }
}
