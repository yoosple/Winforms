
namespace TEST_ChromiumWebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonJavacript = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDevTools = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonJavacript
            // 
            this.buttonJavacript.Location = new System.Drawing.Point(165, 12);
            this.buttonJavacript.Name = "buttonJavacript";
            this.buttonJavacript.Size = new System.Drawing.Size(324, 23);
            this.buttonJavacript.TabIndex = 0;
            this.buttonJavacript.Text = "javascript 함수 helloWorld 호출";
            this.buttonJavacript.UseVisualStyleBackColor = true;
            this.buttonJavacript.Click += new System.EventHandler(this.buttonJavacript_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 408);
            this.panel1.TabIndex = 1;
            // 
            // buttonDevTools
            // 
            this.buttonDevTools.Location = new System.Drawing.Point(604, 12);
            this.buttonDevTools.Name = "buttonDevTools";
            this.buttonDevTools.Size = new System.Drawing.Size(168, 23);
            this.buttonDevTools.TabIndex = 2;
            this.buttonDevTools.Text = "DevTools";
            this.buttonDevTools.UseVisualStyleBackColor = true;
            this.buttonDevTools.Click += new System.EventHandler(this.buttonDevTools_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(147, 21);
            this.textBoxMessage.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonDevTools);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonJavacript);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "크로미움 브라우저 테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonJavacript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDevTools;
        private System.Windows.Forms.TextBox textBoxMessage;
    }
}

