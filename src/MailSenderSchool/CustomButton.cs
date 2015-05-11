using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSenderSchool
{
    class CustomButton : System.Windows.Forms.Button
    {
        private bool _DisplayFocusCues = false;
        protected override bool ShowFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
        }

        public bool DisplayFocusCues
        {
            get
            {
                return _DisplayFocusCues;
            }
            set
            {
                _DisplayFocusCues = value;
            }
        }
    }
}
