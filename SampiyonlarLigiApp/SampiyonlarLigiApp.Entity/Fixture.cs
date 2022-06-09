using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Entity
{
    public class Fixture
    {
        public int Id { get; set; }
        public string Team1Name { get; set; }
        public string Team2Name { get; set; }
        public int Team1GF { get; set; }
        public int Team2Gf { get; set; }
        public string Result { get; set; }
        public int GroupNumber { get; set; }
    }
}
