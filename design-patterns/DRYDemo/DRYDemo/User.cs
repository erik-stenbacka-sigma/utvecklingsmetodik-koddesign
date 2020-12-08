using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DRYDemo
{
    class User
    {
        public bool IsInMeeting;
        public bool SickLeave;
        public bool IsVacation;

        public bool IsAvailable
        {
            get
            {
                return !IsInMeeting && !SickLeave && !IsVacation;
            }
        }
    }
}
