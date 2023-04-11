/// <summary>
/// Form2.Designer.cs
/// </summary>
namespace TEST_Observer
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserName :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(43, 55);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(65, 12);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "UserName";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(252, 124);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(100, 21);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "정보 수정";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(122, 124);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 21);
            this.textBoxUserName.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 218);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxUserName);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUserName;
    }
}