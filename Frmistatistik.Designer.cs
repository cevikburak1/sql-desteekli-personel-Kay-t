namespace Personel_Kayıt
{
    partial class Frmistatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblToplamPersonel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblŞehir = new System.Windows.Forms.Label();
            this.LblBekarPersonel = new System.Windows.Forms.Label();
            this.LblEvliPersonel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LblOrtalamaMaaş = new System.Windows.Forms.Label();
            this.LblMaaş = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(84, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toplam Personel Sayısı :";
            // 
            // LblToplamPersonel
            // 
            this.LblToplamPersonel.AutoSize = true;
            this.LblToplamPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblToplamPersonel.Location = new System.Drawing.Point(319, 53);
            this.LblToplamPersonel.Name = "LblToplamPersonel";
            this.LblToplamPersonel.Size = new System.Drawing.Size(24, 25);
            this.LblToplamPersonel.TabIndex = 1;
            this.LblToplamPersonel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(119, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Evli Personel Sayısı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şehir Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(99, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bekar Personel Sayısı :";
            // 
            // LblŞehir
            // 
            this.LblŞehir.AutoSize = true;
            this.LblŞehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblŞehir.Location = new System.Drawing.Point(319, 161);
            this.LblŞehir.Name = "LblŞehir";
            this.LblŞehir.Size = new System.Drawing.Size(24, 25);
            this.LblŞehir.TabIndex = 7;
            this.LblŞehir.Text = "0";
            // 
            // LblBekarPersonel
            // 
            this.LblBekarPersonel.AutoSize = true;
            this.LblBekarPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBekarPersonel.Location = new System.Drawing.Point(319, 124);
            this.LblBekarPersonel.Name = "LblBekarPersonel";
            this.LblBekarPersonel.Size = new System.Drawing.Size(24, 25);
            this.LblBekarPersonel.TabIndex = 8;
            this.LblBekarPersonel.Text = "0";
            // 
            // LblEvliPersonel
            // 
            this.LblEvliPersonel.AutoSize = true;
            this.LblEvliPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEvliPersonel.Location = new System.Drawing.Point(319, 87);
            this.LblEvliPersonel.Name = "LblEvliPersonel";
            this.LblEvliPersonel.Size = new System.Drawing.Size(24, 25);
            this.LblEvliPersonel.TabIndex = 9;
            this.LblEvliPersonel.Text = "0";
            this.LblEvliPersonel.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ortalama Maaş :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(170, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Toplam Maaş :";
            // 
            // LblOrtalamaMaaş
            // 
            this.LblOrtalamaMaaş.AutoSize = true;
            this.LblOrtalamaMaaş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrtalamaMaaş.Location = new System.Drawing.Point(319, 235);
            this.LblOrtalamaMaaş.Name = "LblOrtalamaMaaş";
            this.LblOrtalamaMaaş.Size = new System.Drawing.Size(24, 25);
            this.LblOrtalamaMaaş.TabIndex = 12;
            this.LblOrtalamaMaaş.Text = "0";
            // 
            // LblMaaş
            // 
            this.LblMaaş.AutoSize = true;
            this.LblMaaş.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblMaaş.Location = new System.Drawing.Point(319, 197);
            this.LblMaaş.Name = "LblMaaş";
            this.LblMaaş.Size = new System.Drawing.Size(24, 25);
            this.LblMaaş.TabIndex = 13;
            this.LblMaaş.Text = "0";
            // 
            // Frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 326);
            this.Controls.Add(this.LblMaaş);
            this.Controls.Add(this.LblOrtalamaMaaş);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblEvliPersonel);
            this.Controls.Add(this.LblBekarPersonel);
            this.Controls.Add(this.LblŞehir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblToplamPersonel);
            this.Controls.Add(this.label1);
            this.Name = "Frmistatistik";
            this.Text = "Frmistatistik";
            this.Load += new System.EventHandler(this.Frmistatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblToplamPersonel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblŞehir;
        private System.Windows.Forms.Label LblBekarPersonel;
        private System.Windows.Forms.Label LblEvliPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label LblOrtalamaMaaş;
        private System.Windows.Forms.Label LblMaaş;
    }
}