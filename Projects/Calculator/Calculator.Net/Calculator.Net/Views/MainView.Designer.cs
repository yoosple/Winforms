namespace Calculator.Net.Views
{
    partial class MainView
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
            menuStrip1 = new MenuStrip();
            표준ToolStripMenuItem = new ToolStripMenuItem();
            날짜계산ToolStripMenuItem = new ToolStripMenuItem();
            MenuContent = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 표준ToolStripMenuItem, 날짜계산ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(370, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 표준ToolStripMenuItem
            // 
            표준ToolStripMenuItem.Name = "표준ToolStripMenuItem";
            표준ToolStripMenuItem.Size = new Size(43, 20);
            표준ToolStripMenuItem.Text = "표준";
            표준ToolStripMenuItem.Click += 표준ToolStripMenuItem_Click;
            // 
            // 날짜계산ToolStripMenuItem
            // 
            날짜계산ToolStripMenuItem.Name = "날짜계산ToolStripMenuItem";
            날짜계산ToolStripMenuItem.Size = new Size(71, 20);
            날짜계산ToolStripMenuItem.Text = "날짜 계산";
            날짜계산ToolStripMenuItem.Click += 날짜계산ToolStripMenuItem_Click;
            // 
            // MenuContent
            // 
            MenuContent.Location = new Point(12, 27);
            MenuContent.Name = "MenuContent";
            MenuContent.Size = new Size(346, 411);
            MenuContent.TabIndex = 1;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
            Controls.Add(MenuContent);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainView";
            Text = "계산기";
            Load += MainView_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 표준ToolStripMenuItem;
        private ToolStripMenuItem 날짜계산ToolStripMenuItem;
        private Panel MenuContent;
    }
}