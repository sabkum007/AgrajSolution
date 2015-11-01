using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntities
{
    public class UserLogs
    {
        public int PId { get; set; }

        public string Hostname { get; set; }

        public string Pagename { get; set; }

        public int PageUsageTime { get; set; }

        public DateTime UserEnter { get; set; }

        public DateTime UserExit { get; set; }

        public string UserIp { get; set; }

        public string UserAgent { get; set; }

        public string ControlType { get; set; }

        public int ControlUsageCount { get; set; }

        public string Content { get; set; }
    }
}
