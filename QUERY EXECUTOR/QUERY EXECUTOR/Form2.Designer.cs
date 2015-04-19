namespace QUERY_EXECUTOR
{
    partial class Form2
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
            this.BtnYes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnYes.Location = new System.Drawing.Point(162, 292);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(123, 31);
            this.BtnYes.TabIndex = 0;
            this.BtnYes.Text = "YES";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 269);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnYes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Label label1;
    }
}