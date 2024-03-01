namespace Calculator.NetFramework.Views
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.표준ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.날짜계산ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.표준ToolStripMenuItem,
            this.날짜계산ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(314, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 표준ToolStripMenuItem
            // 
            this.표준ToolStripMenuItem.Name = "표준ToolStripMenuItem";
            this.표준ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.표준ToolStripMenuItem.Text = "표준";
            this.표준ToolStripMenuItem.Click += new System.EventHandler(this.표준ToolStripMenuItem_Click);
            // 
            // 날짜계산ToolStripMenuItem
            // 
            this.날짜계산ToolStripMenuItem.Name = "날짜계산ToolStripMenuItem";
            this.날짜계산ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.날짜계산ToolStripMenuItem.Text = "날짜 계산";
            this.날짜계산ToolStripMenuItem.Click += new System.EventHandler(this.날짜계산ToolStripMenuItem_Click);
            // 
            // MenuContent
            // 
            this.MenuContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MenuContent.Location = new System.Drawing.Point(12, 40);
            this.MenuContent.Name = "MenuContent";
            this.MenuContent.Size = new System.Drawing.Size(290, 281);
            this.MenuContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 333);
            this.Controls.Add(this.MenuContent);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "계산기";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 표준ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 날짜계산ToolStripMenuItem;
        private System.Windows.Forms.Panel MenuContent;
    }
}

