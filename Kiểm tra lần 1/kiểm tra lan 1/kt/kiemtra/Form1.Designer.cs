namespace kiemtra
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
            this.btnbai1 = new System.Windows.Forms.Button();
            this.btnbai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbai1
            // 
            this.btnbai1.Location = new System.Drawing.Point(97, 226);
            this.btnbai1.Name = "btnbai1";
            this.btnbai1.Size = new System.Drawing.Size(352, 100);
            this.btnbai1.TabIndex = 0;
            this.btnbai1.Text = "Bài 1";
            this.btnbai1.UseVisualStyleBackColor = true;
            this.btnbai1.Click += new System.EventHandler(this.btnbai1_Click);
            // 
            // btnbai2
            // 
            this.btnbai2.Location = new System.Drawing.Point(688, 226);
            this.btnbai2.Name = "btnbai2";
            this.btnbai2.Size = new System.Drawing.Size(352, 100);
            this.btnbai2.TabIndex = 1;
            this.btnbai2.Text = "Bài 2";
            this.btnbai2.UseVisualStyleBackColor = true;
            this.btnbai2.Click += new System.EventHandler(this.btnbai2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 657);
            this.Controls.Add(this.btnbai2);
            this.Controls.Add(this.btnbai1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnbai1;
        private Button btnbai2;
    }
}