using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_ChromiumWebBrowser
{
    public class BoundObject
    {
        Form1 form;

        public BoundObject(Form1 _form)
        {
            form = _form;
        }

        public void callForm(object message)
        {
            form.CallForm(message);
        }

        public void closeForm()
        {
            form.CloseForm();
        }
    }
}
