using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_WINFORM
{
    public partial class UserControlCalendar : UserControl
    {
        int clickCount;
        int maxCount;
        DateTime lastDateTime;
        DateTime currentDateTime;
        DateTime selectedDateTime;
        Button clickButton;
        List<DaysList> selecetedDates;
        List<Button> numberLists;
        readonly DateTime minDateTime = new DateTime(2021, 1, 1);
        readonly Color selectBackColor = Color.FromArgb(206, 221, 245);

        public UserControlCalendar(DateTime lastDate, int maxCount = 0)
        {
            InitializeComponent();
            DoubleBuffered = true;
            ResizeRedraw = true;
            clickCount = 0;
            this.maxCount = maxCount;
            lastDateTime = lastDate;
            currentDateTime = lastDate;
            ButtonStartDate.Text = lastDate.ToString("yyyy년 M월 d일");
            var list = new List<Button>();
            foreach (Control control in panelDays.Controls)
            {
                if (control is Button button && button.Name.Contains("Number"))
                {
                    list.Add(button);
                }
            }

            numberLists = list.OrderBy(x => int.Parse(x.Name.Replace("Number", ""))).ToList();
            DrawMonth(lastDate);
        }

        public DateTime GetStartDate()
        {
            if (selecetedDates != null)
            {
                switch (selecetedDates.Count)
                {
                    case 1:
                        return selecetedDates[0].DateTime;
                    case 2:
                        if (selecetedDates[0].DateTime < selecetedDates[1].DateTime)
                        {
                            return selecetedDates[0].DateTime;
                        }

                        if (selecetedDates[0].DateTime > selecetedDates[1].DateTime)
                        {
                            return selecetedDates[1].DateTime;
                        }
                        break;
                }
            }

            return lastDateTime;
        }

        public DateTime GetEndDate()
        {
            if (selecetedDates != null)
            {
                switch (selecetedDates.Count)
                {
                    case 1:
                        return selecetedDates[0].DateTime;
                    case 2:
                        if (selecetedDates[0].DateTime < selecetedDates[1].DateTime)
                        {
                            return selecetedDates[1].DateTime;
                        }

                        if (selecetedDates[0].DateTime > selecetedDates[1].DateTime)
                        {
                            return selecetedDates[0].DateTime;
                        }
                        break;
                }
            }

            return lastDateTime;
        }

        protected override void WndProc(ref Message m)
        {
            if ((Parent as UserControlPopup.Popup).ProcessResizing(ref m))
            {
                return;
            }
            base.WndProc(ref m);
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            currentDateTime = currentDateTime.AddMonths(-1);
            if (currentDateTime < minDateTime)
            {
                currentDateTime = minDateTime;
            }
            else
            {
                DrawMonth(currentDateTime);
            }
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            currentDateTime = currentDateTime.AddMonths(1);
            if (currentDateTime > lastDateTime)
            {
                currentDateTime = lastDateTime;
            }
            else
            {
                DrawMonth(currentDateTime);
            }
        }

        private void ButtonStartDate_Click(object sender, EventArgs e)
        {
            currentDateTime = lastDateTime;
            DrawMonth(currentDateTime);
        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button.Tag != null)
            {
                var clickDateTime = (DateTime)button.Tag;
                selectedDateTime = clickDateTime;
                clickButton = button;

                clickCount += 1;
                switch (clickCount)
                {
                    case 2:
                        selecetedDates.Add(new DaysList { Button = button, DateTime = clickDateTime });
                        DrawSelectedDays();
                        break;
                    default:
                        clickCount = 1;
                        selecetedDates.Clear();
                        selecetedDates.Add(new DaysList { Button = button, DateTime = clickDateTime });
                        DrawSelectedDay(clickDateTime, button);
                        break;
                }
            }
        }

        /// <summary>
        /// 해당 달에 맞는 일자들 표시
        /// </summary>
        /// <param name="dateTime"></param>
        private void DrawMonth(DateTime dateTime)
        {
            Caption.Text = dateTime.ToString("yyyy년 M월");
            var dataStart = new DateTime(dateTime.Year, dateTime.Month, 1);
            int nowTotalDays = DateTime.DaysInMonth(dataStart.Year, dataStart.Month);
            var dateLast = new DateTime(dateTime.Year, dateTime.Month, nowTotalDays);

            // 일:0, 월:1, 화:2, 수:3, 목:4, 금:5, 토:6
            int nowStart = (int)dataStart.DayOfWeek;

            var startMonthDate = dataStart.AddDays(-nowStart);

            Button button = clickButton;

            for (int i = 0; i < numberLists.Count; i++)
            {
                var date = startMonthDate.AddDays(i);
                if (date < lastDateTime)
                {
                    numberLists[i].Text = date.Day.ToString();
                    numberLists[i].Tag = date;
                    if (date < dataStart || date > dateLast)
                    {
                        numberLists[i].ForeColor = Color.LightGray;
                    }
                    else
                    {
                        if ((i % 7) == (int)DayOfWeek.Sunday)
                        {
                            numberLists[i].ForeColor = Color.Red;
                        }
                        else if ((i % 7) == (int)DayOfWeek.Saturday)
                        {
                            numberLists[i].ForeColor = Color.Blue;
                        }
                        else
                        {
                            numberLists[i].ForeColor = Color.Black;
                        }

                        if (selecetedDates == null && date.Date == dateTime.Date)
                        {
                            selecetedDates = new List<DaysList>();
                            selecetedDates.Add(new DaysList { Button = numberLists[i], DateTime = dateTime });
                            clickButton = numberLists[i];
                            selectedDateTime = dateTime;
                            clickCount = 1;
                        }
                    }
                }
                else
                {
                    numberLists[i].Text = "";
                    numberLists[i].Tag = null;
                    //numberLists[i].Enabled = false;
                }

                if (clickButton != null && numberLists[i].Name == clickButton.Name)
                {
                    button = numberLists[i];
                    //DrawSelectedDay(numberLists[i], date);
                }
            }

            switch (clickCount)
            {
                case 1:
                    DrawSelectedDay(selectedDateTime, button);
                    break;
                case 2:
                    DrawSelectedDays();
                    break;
            }
        }

        /// <summary>
        /// 한 번 클릭하면 해당일만 배경색 변경
        /// 해당일을 기준으로 선택 가능한 일자만 활성화 되고, 그 외의 일자는 비활성화
        /// </summary>
        /// <param name="start"></param>
        private void DrawSelectedDay(DateTime clickedDate, Button button)
        {
            DateTime dateStart = clickedDate.AddDays(-maxCount);
            DateTime dateEnd = clickedDate.AddDays(maxCount);
            if (dateStart < minDateTime)
            {
                dateStart = minDateTime;
            }

            if (dateEnd > lastDateTime)
            {
                dateEnd = lastDateTime;
            }

            foreach (Control control in numberLists)
            {
                control.BackColor = Color.White;
                control.Enabled = true;
            }

            foreach (Control control in numberLists)
            {
                if (control.Tag != null)
                {
                    if (clickCount != 2 && maxCount > 0)
                    {
                        var buttonDate = (DateTime)control.Tag;
                        if (buttonDate.Date >= dateStart.Date && buttonDate.Date <= dateEnd.Date)
                        {
                            control.BackColor = Color.White;
                            control.Enabled = true;
                        }
                        else
                        {
                            control.BackColor = Color.Gray;
                            control.Enabled = false;
                        }
                    }
                }
            }

            if (button.Tag != null)
            {
                if (((DateTime)button.Tag).Date == clickedDate.Date)
                {
                    button.BackColor = selectBackColor;
                }
                else
                {
                    if (button.Enabled == true)
                    {
                        button.BackColor = Color.White;
                    }
                    else
                    {
                        button.BackColor = Color.Gray;
                    }
                }
            }
        }

        /// <summary>
        /// 또 한 번 클릭하면 범위 내의 일자들 배경색 변경
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void DrawSelectedDays()
        {
            if (selecetedDates[0].DateTime != selecetedDates[1].DateTime)
            {
                DateTime dateStart;
                DateTime dateEnd;

                if (selecetedDates[0].DateTime < selecetedDates[1].DateTime)
                {
                    dateStart = selecetedDates[0].DateTime;
                    dateEnd = selecetedDates[1].DateTime;
                }
                else
                {
                    dateStart = selecetedDates[1].DateTime;
                    dateEnd = selecetedDates[0].DateTime;
                }

                foreach (Control control in numberLists)
                {
                    control.Enabled = true;
                    if (control.Tag != null)
                    {
                        var buttonDate = (DateTime)control.Tag;
                        if (buttonDate.Date >= dateStart.Date && buttonDate.Date <= dateEnd.Date)
                        {
                            control.BackColor = selectBackColor;
                        }
                        else
                        {
                            control.BackColor = Color.White;
                        }
                    }
                    else
                    {
                        control.BackColor = Color.White;
                        control.Enabled = false;
                    }
                }
            }
        }
    }

    public class DaysList
    {
        public Button Button { get; set; }
        public DateTime DateTime { get; set; }
    }
}
