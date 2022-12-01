using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18.Models
{
    internal class Meeting
    {
        public DateTime Fromdate { get; set; }
        public DateTime Todate { get; set; }
        public string fulname;
        public string Fulname
        {
            get { return fulname; }
            set
            {
                if(value.Trim().Length>0 && value.Trim().Length<40)
                {
                    fulname= value.Trim();
                }
            }
        }
    }
}
