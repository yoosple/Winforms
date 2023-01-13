using System;
using System.Windows.Forms;
using UserControlPopup;

namespace TEST_WINFORM
{
    class CustomButtonCalendar : Button
    {
        Popup complexCalendar;
        UserControlCalendar userControlCalendar;

        public CustomButtonCalendar()
        {
            Click += CustomButtonCalendar_Click;
        }

        public void Show(DateTime lastTime, int maxCount = 0)
        {
            complexCalendar = new Popup(userControlCalendar = new UserControlCalendar(lastTime, maxCount));
            complexCalendar.Closed += ComplexCalendar_Closed;

            Text = $"{GetStartDate().ToString("yyyy-MM-dd")} ~ {GetEndDate().ToString("yyyy-MM-dd")}";
        }

        private void ComplexCalendar_Closed(object sender, System.Windows.Forms.ToolStripDropDownClosedEventArgs e)
        {
            Text = $"{GetStartDate().ToString("yyyy-MM-dd")} ~ {GetEndDate().ToString("yyyy-MM-dd")}";
        }

        private void CustomButtonCalendar_Click(object sender, EventArgs e)
        {
            complexCalendar.Show(sender as Button);
        }

        public DateTime GetStartDate()
        {
            return userControlCalendar.GetStartDate();
        }

        public DateTime GetEndDate()
        {
            return userControlCalendar.GetEndDate();
        }
    }
}
