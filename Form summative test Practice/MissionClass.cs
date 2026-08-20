using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_summative_test_Practice
{
    internal class MissionClass
    {
        private string _status;
        public static event EventHandler<string> StatusChanged;
        //stores the history of events
        public static List<string> EventHistory { get; } = new List<string>();
        public string missionName { get; set; }
        public string destination { get; set; }
        
        public string status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnStatusChanged($"{missionName} status changed to {status}");
                    EventHistory.Add($"{DateTime.Now:HH:mm:ss} - {missionName} status changed to {status}");
                }
            }
        }
         public MissionClass(string missionName, string destination, string status)
        {
            this.missionName = missionName;
            this.destination = destination;
            this.status = status;
        }

        protected virtual void OnStatusChanged(string status)
        { 
            StatusChanged?.Invoke(this, status);
        }
    }
}
