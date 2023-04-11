
namespace TEST_Observer
{
    partial class FormMain
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
            this.buttonFormShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFormShow
            // 
            this.buttonFormShow.Location = new System.Drawing.Point(121, 64);
            this.buttonFormShow.Name = "buttonFormShow";
            this.buttonFormShow.Size = new System.Drawing.Size(111, 61);
            this.buttonFormShow.TabIndex = 0;
            this.buttonFormShow.Text = "하위 폼 생성";
            this.buttonFormShow.UseVisualStyleBackColor = true;
            this.buttonFormShow.Click += new System.EventHandler(this.buttonFormShow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 197);
            this.Controls.Add(this.buttonFormShow);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFormShow;
    }
}