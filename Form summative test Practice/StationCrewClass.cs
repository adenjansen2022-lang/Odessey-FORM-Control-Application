using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_summative_test_Practice
{
    internal class StationCrewClass:CrewClass
    {
        public string stationLocation {  get; set; }
        public StationCrewClass(int id, string name, string role, string sl) : base(id, name, role)
        {
            this.stationLocation = sl;
        }

        public override string PerformDuty()
        {
            return $"Operating systems at station: {stationLocation}.";
        }
    }
}
