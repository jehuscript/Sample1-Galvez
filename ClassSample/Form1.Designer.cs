namespace ClassSample
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnToyota = new System.Windows.Forms.Button();
            this.btnMitsubishi = new System.Windows.Forms.Button();
            this.btnYamaha = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnDucati = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnToyota
            // 
            this.btnToyota.Location = new System.Drawing.Point(68, 24);
            this.btnToyota.Name = "btnToyota";
            this.btnToyota.Size = new System.Drawing.Size(75, 23);
            this.btnToyota.TabIndex = 1;
            this.btnToyota.Text = "Toyota";
            this.btnToyota.UseVisualStyleBackColor = true;
            this.btnToyota.Click += new System.EventHandler(this.btnToyota_Click);
            // 
            // btnMitsubishi
            // 
            this.btnMitsubishi.Location = new System.Drawing.Point(179, 24);
            this.btnMitsubishi.Name = "btnMitsubishi";
            this.btnMitsubishi.Size = new System.Drawing.Size(75, 23);
            this.btnMitsubishi.TabIndex = 2;
            this.btnMitsubishi.Text = "Mitsubishi";
            this.btnMitsubishi.UseVisualStyleBackColor = true;
            this.btnMitsubishi.Click += new System.EventHandler(this.btnMitsubishi_Click);
            // 
            // btnYamaha
            // 
            this.btnYamaha.Location = new System.Drawing.Point(287, 25);
            this.btnYamaha.Name = "btnYamaha";
            this.btnYamaha.Size = new System.Drawing.Size(75, 23);
            this.btnYamaha.TabIndex = 3;
            this.btnYamaha.Text = "Yamaha";
            this.btnYamaha.UseVisualStyleBackColor = true;
            this.btnYamaha.Click += new System.EventHandler(this.btnYamaha_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(78, 69);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "label1";
            // 
            // btnDucati
            // 
            this.btnDucati.Location = new System.Drawing.Point(388, 25);
            this.btnDucati.Name = "btnDucati";
            this.btnDucati.Size = new System.Drawing.Size(75, 23);
            this.btnDucati.TabIndex = 5;
            this.btnDucati.Text = "Ducati";
            this.btnDucati.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 261);
            this.Controls.Add(this.btnDucati);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnYamaha);
            this.Controls.Add(this.btnMitsubishi);
            this.Controls.Add(this.btnToyota);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnToyota;
        private System.Windows.Forms.Button btnMitsubishi;
        private System.Windows.Forms.Button btnYamaha;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnDucati;
    }
}

