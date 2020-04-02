namespace lambdaa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tB1 = new System.Windows.Forms.TextBox();
            this.tB2 = new System.Windows.Forms.TextBox();
            this.rtB2 = new System.Windows.Forms.RichTextBox();
            this.zad1 = new System.Windows.Forms.Button();
            this.zad2 = new System.Windows.Forms.Button();
            this.zad3 = new System.Windows.Forms.Button();
            this.zad4 = new System.Windows.Forms.Button();
            this.zad5 = new System.Windows.Forms.Button();
            this.zad6 = new System.Windows.Forms.Button();
            this.zad7 = new System.Windows.Forms.Button();
            this.zad8 = new System.Windows.Forms.Button();
            this.zad9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tB1
            // 
            this.tB1.Location = new System.Drawing.Point(71, 122);
            this.tB1.Name = "tB1";
            this.tB1.Size = new System.Drawing.Size(100, 20);
            this.tB1.TabIndex = 0;
            // 
            // tB2
            // 
            this.tB2.Location = new System.Drawing.Point(71, 164);
            this.tB2.Name = "tB2";
            this.tB2.Size = new System.Drawing.Size(100, 20);
            this.tB2.TabIndex = 2;
            // 
            // rtB2
            // 
            this.rtB2.Location = new System.Drawing.Point(239, 67);
            this.rtB2.Name = "rtB2";
            this.rtB2.Size = new System.Drawing.Size(224, 224);
            this.rtB2.TabIndex = 3;
            this.rtB2.Text = "";
            // 
            // zad1
            // 
            this.zad1.Location = new System.Drawing.Point(536, 30);
            this.zad1.Name = "zad1";
            this.zad1.Size = new System.Drawing.Size(140, 31);
            this.zad1.TabIndex = 23;
            this.zad1.Text = "x do n";
            this.zad1.UseVisualStyleBackColor = true;
            this.zad1.Click += new System.EventHandler(this.zad1_Click);
            // 
            // zad2
            // 
            this.zad2.Location = new System.Drawing.Point(536, 67);
            this.zad2.Name = "zad2";
            this.zad2.Size = new System.Drawing.Size(140, 33);
            this.zad2.TabIndex = 25;
            this.zad2.Text = "sklejenie dwóch napisów";
            this.zad2.UseVisualStyleBackColor = true;
            this.zad2.Click += new System.EventHandler(this.zad2_Click);
            // 
            // zad3
            // 
            this.zad3.Location = new System.Drawing.Point(536, 106);
            this.zad3.Name = "zad3";
            this.zad3.Size = new System.Drawing.Size(140, 36);
            this.zad3.TabIndex = 27;
            this.zad3.Text = "napis składający się z n podanych znaków";
            this.zad3.UseVisualStyleBackColor = true;
            this.zad3.Click += new System.EventHandler(this.zad3_Click);
            // 
            // zad4
            // 
            this.zad4.Location = new System.Drawing.Point(536, 148);
            this.zad4.Name = "zad4";
            this.zad4.Size = new System.Drawing.Size(140, 36);
            this.zad4.TabIndex = 29;
            this.zad4.Text = "10 wyrażeń lambda podnoszących x do n";
            this.zad4.UseVisualStyleBackColor = true;
            this.zad4.Click += new System.EventHandler(this.zad4_Click);
            // 
            // zad5
            // 
            this.zad5.Location = new System.Drawing.Point(536, 190);
            this.zad5.Name = "zad5";
            this.zad5.Size = new System.Drawing.Size(140, 34);
            this.zad5.TabIndex = 31;
            this.zad5.Text = "własna metoda";
            this.zad5.UseVisualStyleBackColor = true;
            this.zad5.Click += new System.EventHandler(this.zad5_Click);
            // 
            // zad6
            // 
            this.zad6.Location = new System.Drawing.Point(536, 230);
            this.zad6.Name = "zad6";
            this.zad6.Size = new System.Drawing.Size(140, 37);
            this.zad6.TabIndex = 33;
            this.zad6.Text = "Sortowanie liczb malejąco i rosnąco";
            this.zad6.UseVisualStyleBackColor = true;
            this.zad6.Click += new System.EventHandler(this.zad6_Click);
            // 
            // zad7
            // 
            this.zad7.Location = new System.Drawing.Point(536, 273);
            this.zad7.Name = "zad7";
            this.zad7.Size = new System.Drawing.Size(140, 50);
            this.zad7.TabIndex = 35;
            this.zad7.Text = "sortowanie liczb, najpierw parzyste rosnąco potem nieparzyste rosnąco";
            this.zad7.UseVisualStyleBackColor = true;
            this.zad7.Click += new System.EventHandler(this.zad7_Click);
            // 
            // zad8
            // 
            this.zad8.Location = new System.Drawing.Point(536, 329);
            this.zad8.Name = "zad8";
            this.zad8.Size = new System.Drawing.Size(140, 39);
            this.zad8.TabIndex = 37;
            this.zad8.Text = "sortowanie w kolejności alfabetycznej";
            this.zad8.UseVisualStyleBackColor = true;
            this.zad8.Click += new System.EventHandler(this.zad8_Click);
            // 
            // zad9
            // 
            this.zad9.Location = new System.Drawing.Point(536, 374);
            this.zad9.Name = "zad9";
            this.zad9.Size = new System.Drawing.Size(140, 64);
            this.zad9.TabIndex = 41;
            this.zad9.Text = "metoda zwracaąca wyrażenie podnoszące liczbę do potęgi określonej parametrem";
            this.zad9.UseVisualStyleBackColor = true;
            this.zad9.Click += new System.EventHandler(this.zad9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zad9);
            this.Controls.Add(this.zad8);
            this.Controls.Add(this.zad7);
            this.Controls.Add(this.zad6);
            this.Controls.Add(this.zad5);
            this.Controls.Add(this.zad4);
            this.Controls.Add(this.zad3);
            this.Controls.Add(this.zad2);
            this.Controls.Add(this.zad1);
            this.Controls.Add(this.rtB2);
            this.Controls.Add(this.tB2);
            this.Controls.Add(this.tB1);
            this.Name = "Form1";
            this.Text = "Wyrażenia lambda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB1;
        private System.Windows.Forms.TextBox tB2;
        private System.Windows.Forms.RichTextBox rtB2;
        private System.Windows.Forms.Button zad1;
        private System.Windows.Forms.Button zad2;
        private System.Windows.Forms.Button zad3;
        private System.Windows.Forms.Button zad4;
        private System.Windows.Forms.Button zad5;
        private System.Windows.Forms.Button zad6;
        private System.Windows.Forms.Button zad7;
        private System.Windows.Forms.Button zad8;
        private System.Windows.Forms.Button zad9;
    }
}

