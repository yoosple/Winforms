namespace Calculator.NetFramework.Views
{
    partial class StandardUI
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGetHistory = new System.Windows.Forms.Button();
            this.labelHistory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "표준";
            // 
            // buttonGetHistory
            // 
            this.buttonGetHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetHistory.Location = new System.Drawing.Point(90, 11);
            this.buttonGetHistory.Name = "buttonGetHistory";
            this.buttonGetHistory.Size = new System.Drawing.Size(48, 21);
            this.buttonGetHistory.TabIndex = 1;
            this.buttonGetHistory.Text = "기록";
            this.buttonGetHistory.UseVisualStyleBackColor = true;
            this.buttonGetHistory.Click += new System.EventHandler(this.buttonGetHistory_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Location = new System.Drawing.Point(18, 58);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(0, 12);
            this.labelHistory.TabIndex = 2;
            // 
            // StandardUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.labelHistory);
            this.Controls.Add(this.buttonGetHistory);
            this.Controls.Add(this.label1);
            this.Name = "StandardUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetHistory;
        private System.Windows.Forms.Label labelHistory;
    }
}
