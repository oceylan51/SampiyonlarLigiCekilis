using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Entity
{
    public class Last32Groups
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public string TeamCountry { get; set; }
        public int TeamPoints { get; set; }
        public int TeamGoalsFor { get; set; }
        public int TeamGoalsAgainst { get; set; }
        public int GoalDifference { get; set; }
        public int GroupNumber { get; set; }
    }
}
