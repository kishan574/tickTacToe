namespace tickTacToe
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
            this.A00 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.NGButton = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.xwin = new System.Windows.Forms.Label();
            this.draw = new System.Windows.Forms.Label();
            this.owin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.Location = new System.Drawing.Point(13, 13);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(78, 62);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = true;
            this.A00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(223, 178);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(78, 62);
            this.A22.TabIndex = 1;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(116, 178);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(78, 62);
            this.A21.TabIndex = 2;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A20
            // 
            this.A20.Location = new System.Drawing.Point(13, 178);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(78, 62);
            this.A20.TabIndex = 3;
            this.A20.UseVisualStyleBackColor = true;
            this.A20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(223, 94);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(78, 62);
            this.A12.TabIndex = 4;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(116, 94);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(78, 62);
            this.A11.TabIndex = 5;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A10
            // 
            this.A10.Location = new System.Drawing.Point(13, 94);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(78, 62);
            this.A10.TabIndex = 6;
            this.A10.UseVisualStyleBackColor = true;
            this.A10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(223, 13);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(78, 62);
            this.A02.TabIndex = 7;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(116, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(78, 62);
            this.A01.TabIndex = 8;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // NGButton
            // 
            this.NGButton.Location = new System.Drawing.Point(13, 286);
            this.NGButton.Name = "NGButton";
            this.NGButton.Size = new System.Drawing.Size(75, 23);
            this.NGButton.TabIndex = 9;
            this.NGButton.Text = "New Game";
            this.NGButton.UseVisualStyleBackColor = true;
            this.NGButton.Click += new System.EventHandler(this.NGButton_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(223, 286);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(116, 286);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // xwin
            // 
            this.xwin.AutoSize = true;
            this.xwin.Location = new System.Drawing.Point(346, 38);
            this.xwin.Name = "xwin";
            this.xwin.Size = new System.Drawing.Size(35, 13);
            this.xwin.TabIndex = 13;
            this.xwin.Text = "label1";
            // 
            // draw
            // 
            this.draw.AutoSize = true;
            this.draw.Location = new System.Drawing.Point(346, 203);
            this.draw.Name = "draw";
            this.draw.Size = new System.Drawing.Size(35, 13);
            this.draw.TabIndex = 14;
            this.draw.Text = "label2";
            // 
            // owin
            // 
            this.owin.AutoSize = true;
            this.owin.Location = new System.Drawing.Point(346, 119);
            this.owin.Name = "owin";
            this.owin.Size = new System.Drawing.Size(35, 13);
            this.owin.TabIndex = 15;
            this.owin.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.owin);
            this.Controls.Add(this.draw);
            this.Controls.Add(this.xwin);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.NGButton);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A00);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button NGButton;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label xwin;
        private System.Windows.Forms.Label draw;
        private System.Windows.Forms.Label owin;
    }
}

