using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Abstract
{
    public interface ITeamsService : IRepositoryService<Teams>
    {
        void TeamsUpdate(string teamName, int gf, int ga);
        void TeamsUpdate(string teamName, int point);
        void GetGroupNumberByTeamName(string teamName,int groupNumber);
    }
}
