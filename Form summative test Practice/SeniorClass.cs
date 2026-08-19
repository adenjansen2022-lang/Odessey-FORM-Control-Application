using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_summative_test_Practice
{
    internal class SeniorClass:CrewClass
    {
        public int RankLevel {  get; set; }
        public SeniorClass(int id, string name, string role, int rankLevel) : base(id, name, role)
        {
            this.RankLevel = rankLevel;
        }

        public override string PerformDuty()
        {
            return $"Commanding vessel at Rank Level {RankLevel}.";
        }
    }
}
