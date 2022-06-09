using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Abstract
{
    public interface ILast32Group1Repository : IRepository<Last32Group1>
    {
        bool IsTeam(string teamCountry);
    }
}
