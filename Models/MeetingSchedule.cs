using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Models
{
    internal class MeetingSchedule:Meeting
    { 
        Meeting [] Mettings = new Meeting[0];
        public bool SetMeeting(DateTime Fromdate, DateTime Todate, string fulname)
        {
            if(Fromdate>Todate)
            {
                return true;
            }
            return false;
        }
    }
}
