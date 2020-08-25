namespace HiddenPairGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlay.Location = new System.Drawing.Point(50, 80);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(300, 40);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonRanking
            // 
            this.buttonRanking.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRanking.Location = new System.Drawing.Point(50, 160);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Size = new System.Drawing.Size(300, 40);
            this.buttonRanking.TabIndex = 1;
            this.buttonRanking.Text = "Ranking";
            this.buttonRanking.UseVisualStyleBackColor = true;
            this.buttonRanking.Click += new System.EventHandler(this.buttonRanking_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(50, 380);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(300, 40);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Instruction";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.Location = new System.Drawing.Point(50, 401);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(300, 40);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 389);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 40);
            this.label2.TabIndex = 6;
            this.label2.Text = "Points          Name          Level";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 349);
            this.label3.TabIndex = 7;
            this.label3.Text = "1.\r\n\r\n2.\r\n\r\n3.\r\n\r\n4.\r\n\r\n5.\r\n\r\n6.";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(49, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 349);
            this.label4.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(382, 453);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRanking);
            this.Controls.Add(this.buttonPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MathPuzzles";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRanking;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

