namespace While_loop_practice_2
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
            this.titlelable = new System.Windows.Forms.Label();
            this.beginnumberlable = new System.Windows.Forms.Label();
            this.endnumberlable = new System.Windows.Forms.Label();
            this.begininput = new System.Windows.Forms.TextBox();
            this.endinput = new System.Windows.Forms.TextBox();
            this.valueoutput = new System.Windows.Forms.Label();
            this.valuebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titlelable
            // 
            this.titlelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelable.Location = new System.Drawing.Point(94, 35);
            this.titlelable.Name = "titlelable";
            this.titlelable.Size = new System.Drawing.Size(275, 49);
            this.titlelable.TabIndex = 0;
            this.titlelable.Text = "Fun with loops";
            this.titlelable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beginnumberlable
            // 
            this.beginnumberlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginnumberlable.Location = new System.Drawing.Point(12, 131);
            this.beginnumberlable.Name = "beginnumberlable";
            this.beginnumberlable.Size = new System.Drawing.Size(235, 35);
            this.beginnumberlable.TabIndex = 1;
            this.beginnumberlable.Text = "Enter a begining number";
            // 
            // endnumberlable
            // 
            this.endnumberlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endnumberlable.Location = new System.Drawing.Point(12, 195);
            this.endnumberlable.Name = "endnumberlable";
            this.endnumberlable.Size = new System.Drawing.Size(235, 37);
            this.endnumberlable.TabIndex = 2;
            this.endnumberlable.Text = "Enter an ending number ";
            // 
            // begininput
            // 
            this.begininput.Location = new System.Drawing.Point(288, 135);
            this.begininput.Name = "begininput";
            this.begininput.Size = new System.Drawing.Size(100, 22);
            this.begininput.TabIndex = 3;
            // 
            // endinput
            // 
            this.endinput.Location = new System.Drawing.Point(288, 199);
            this.endinput.Name = "endinput";
            this.endinput.Size = new System.Drawing.Size(100, 22);
            this.endinput.TabIndex = 4;
            this.endinput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // valueoutput
            // 
            this.valueoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueoutput.Location = new System.Drawing.Point(51, 286);
            this.valueoutput.Name = "valueoutput";
            this.valueoutput.Size = new System.Drawing.Size(337, 155);
            this.valueoutput.TabIndex = 5;
            // 
            // valuebutton
            // 
            this.valuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valuebutton.Location = new System.Drawing.Point(129, 248);
            this.valuebutton.Name = "valuebutton";
            this.valuebutton.Size = new System.Drawing.Size(175, 35);
            this.valuebutton.TabIndex = 6;
            this.valuebutton.Text = "show values ";
            this.valuebutton.UseVisualStyleBackColor = true;
            this.valuebutton.Click += new System.EventHandler(this.valuebutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.valuebutton);
            this.Controls.Add(this.valueoutput);
            this.Controls.Add(this.endinput);
            this.Controls.Add(this.begininput);
            this.Controls.Add(this.endnumberlable);
            this.Controls.Add(this.beginnumberlable);
            this.Controls.Add(this.titlelable);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlelable;
        private System.Windows.Forms.Label beginnumberlable;
        private System.Windows.Forms.Label endnumberlable;
        private System.Windows.Forms.TextBox begininput;
        private System.Windows.Forms.TextBox endinput;
        private System.Windows.Forms.Label valueoutput;
        private System.Windows.Forms.Button valuebutton;
    }
}

