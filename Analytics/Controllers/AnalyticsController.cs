using BLayer;
using DataEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Analytics.Controllers
{
    public class AnalyticsController : ApiController
    {

        BUserInteractions _bUserInteractions = new BUserInteractions(WebApiApplication.ConnectionString);

        // GET api/values/5
        [HttpGet]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post(string value)
        {

        }
        [HttpPost]
        //public void PostUserActivities()
        public void PostUserActivities(UserLogs objUserLogs)
        {
            objUserLogs.Content = "TestContent";
            objUserLogs.ControlType = "TestControl";
            objUserLogs.ControlUsageCount = 2;
            objUserLogs.Hostname = "TestHostName";
            objUserLogs.Pagename = "TestPage";
            objUserLogs.PageUsageTime = 20;
            objUserLogs.UserAgent = "TestAgent";
            objUserLogs.UserEnter = DateTime.Now;
            objUserLogs.UserExit = DateTime.Now;
            objUserLogs.UserIp = "Test";

            _bUserInteractions.Insert(objUserLogs);
        }
    }
}
