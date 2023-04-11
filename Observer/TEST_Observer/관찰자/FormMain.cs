using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TEST_Observer.Models;

namespace TEST_Observer
{
    public partial class FormMain : Form, ISubject
    {
        List<IObserver> observers = new List<IObserver>();

        public FormMain()
        {
            InitializeComponent();
        }

        public void Notify(UserInfo userInfo)
        {
            foreach (IObserver o in observers)
            {
                o.UpdateInfo(userInfo);
            }
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            observers.Remove(o);
        }

        private void buttonFormShow_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            Form2 form2 = new Form2(this);
            form2.Show();
            Form3 form3 = new Form3(this);
            form3.Show();
        }
    }
}