using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TEST_WINFORM
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();

            CustomButtonCalendar customCalendar = new CustomButtonCalendar();
            customCalendar.Size = new Size(240, 25);
            Controls.Add(customCalendar);
            customCalendar.Show(DateTime.Now, 100);
        }
    }
}
