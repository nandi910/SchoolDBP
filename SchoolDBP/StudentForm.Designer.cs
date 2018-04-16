namespace SchoolDBP
{
    partial class StudentForm
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
            this.dis1Label = new System.Windows.Forms.Label();
            this.dis2Label = new System.Windows.Forms.Label();
            this.dis1Box = new System.Windows.Forms.TextBox();
            this.dis2Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dis1Label
            // 
            this.dis1Label.AutoSize = true;
            this.dis1Label.Location = new System.Drawing.Point(12, 9);
            this.dis1Label.Name = "dis1Label";
            this.dis1Label.Size = new System.Drawing.Size(35, 13);
            this.dis1Label.TabIndex = 1;
            this.dis1Label.Text = "label1";
            // 
            // dis2Label
            // 
            this.dis2Label.AutoSize = true;
            this.dis2Label.Location = new System.Drawing.Point(12, 41);
            this.dis2Label.Name = "dis2Label";
            this.dis2Label.Size = new System.Drawing.Size(35, 13);
            this.dis2Label.TabIndex = 2;
            this.dis2Label.Text = "label2";
            // 
            // dis1Box
            // 
            this.dis1Box.Location = new System.Drawing.Point(117, 6);
            this.dis1Box.Name = "dis1Box";
            this.dis1Box.ReadOnly = true;
            this.dis1Box.Size = new System.Drawing.Size(38, 20);
            this.dis1Box.TabIndex = 3;
            // 
            // dis2Box
            // 
            this.dis2Box.Location = new System.Drawing.Point(117, 41);
            this.dis2Box.Name = "dis2Box";
            this.dis2Box.ReadOnly = true;
            this.dis2Box.Size = new System.Drawing.Size(38, 20);
            this.dis2Box.TabIndex = 4;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dis2Box);
            this.Controls.Add(this.dis1Box);
            this.Controls.Add(this.dis2Label);
            this.Controls.Add(this.dis1Label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dis1Label;
        private System.Windows.Forms.Label dis2Label;
        private System.Windows.Forms.TextBox dis1Box;
        private System.Windows.Forms.TextBox dis2Box;
    }
}