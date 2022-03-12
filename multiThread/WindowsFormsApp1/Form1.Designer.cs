
namespace WindowsFormsApp1
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
            this.btny = new System.Windows.Forms.Button();
            this.btnb = new System.Windows.Forms.Button();
            this.btnr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btny
            // 
            this.btny.Location = new System.Drawing.Point(103, 185);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(75, 23);
            this.btny.TabIndex = 0;
            this.btny.Text = "Yellow";
            this.btny.UseVisualStyleBackColor = true;
            // 
            // btnb
            // 
            this.btnb.Location = new System.Drawing.Point(238, 185);
            this.btnb.Name = "btnb";
            this.btnb.Size = new System.Drawing.Size(75, 23);
            this.btnb.TabIndex = 1;
            this.btnb.Text = "Blue";
            this.btnb.UseVisualStyleBackColor = true;
            // 
            // btnr
            // 
            this.btnr.Location = new System.Drawing.Point(370, 185);
            this.btnr.Name = "btnr";
            this.btnr.Size = new System.Drawing.Size(75, 23);
            this.btnr.TabIndex = 2;
            this.btnr.Text = "Red";
            this.btnr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 372);
            this.Controls.Add(this.btnr);
            this.Controls.Add(this.btnb);
            this.Controls.Add(this.btny);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Button btnb;
        private System.Windows.Forms.Button btnr;
    }
}

