namespace SpringfieldReactor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.resetButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuclear Reactor Control";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reactor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reactor 2";
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Chartreuse;
            this.reactor1StateLabel.Location = new System.Drawing.Point(172, 205);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(132, 119);
            this.reactor1StateLabel.TabIndex = 3;
           // this.reactor1StateLabel.Click += new System.EventHandler(this.reactor1StateLabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(519, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 119);
            this.label4.TabIndex = 4;
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.Color.Orange;
            this.enableButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enableButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.enableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enableButton.Location = new System.Drawing.Point(344, 171);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(138, 48);
            this.enableButton.TabIndex = 5;
            this.enableButton.Text = "ENABLE";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.outputLabel.Location = new System.Drawing.Point(292, 324);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(242, 39);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactor Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // resetButton1
            // 
            this.resetButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton1.Location = new System.Drawing.Point(377, 225);
            this.resetButton1.Name = "resetButton1";
            this.resetButton1.Size = new System.Drawing.Size(75, 23);
            this.resetButton1.TabIndex = 7;
            this.resetButton1.Text = "RESET";
            this.resetButton1.UseVisualStyleBackColor = true;
            this.resetButton1.Click += new System.EventHandler(this.resetButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetButton1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button resetButton1;
    }
}

