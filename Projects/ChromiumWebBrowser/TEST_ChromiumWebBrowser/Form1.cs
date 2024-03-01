using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_ChromiumWebBrowser
{
    public partial class Form1 : Form
    {
       ChromiumWebBrowser chrome;

        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        public void CallForm(object message)
        {
            MessageBox.Show(message.ToString());
        }

        public void CloseForm()
        {
            Invoke(new MethodInvoker(delegate
            {
                Close();
            }));
        }

        private void InitializeChromium()
        {
            if (!Cef.IsInitialized) // Check before init
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }

            chrome = new ChromiumWebBrowser(Application.StartupPath + "\\Resources\\test.html");
            chrome.Dock = DockStyle.Fill;
            panel1.Controls.Add(chrome);

            chrome.JavascriptObjectRepository.Settings.LegacyBindingEnabled = true;
            chrome.JavascriptObjectRepository.Register("bound", new BoundObject(this), false, BindingOptions.DefaultBinder);
        }

        private void buttonJavacript_Click(object sender, EventArgs e)
        {
            var message = textBoxMessage.Text;
            if (string.IsNullOrWhiteSpace(textBoxMessage.Text))
            {
                message = "Hello World";
            }

            string callJS = $"helloWorld('{message}');";
            chrome.GetBrowser().MainFrame.ExecuteJavaScriptAsync(callJS);
        }

        private void buttonDevTools_Click(object sender, EventArgs e)
        {
            chrome.ShowDevTools();
        }
    }
}
