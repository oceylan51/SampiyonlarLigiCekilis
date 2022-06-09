using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Data.Concrete
{
    public class EfCoreTeamsRepository : EfCoreGenericRepository<SampiyonlarLigiAppDbContext, Teams>, ITeamsRepository
    {
        public void GetGroupNumberByTeamName(string teamName, int groupNumber)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                var team = context.Teams.Where(x => x.TeamName == teamName).FirstOrDefault();
                team.GroupNumber = groupNumber;
                context.Teams.Update(team);
                context.SaveChanges();
            }
        }

        public void TeamsUpdate(string teamName,  int gf, int ga)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                var team = context.Teams.Where(x => x.TeamName == teamName).FirstOrDefault();
                if (team.TeamGoalsFor == 0)
                {
                    team.TeamGoalsFor = gf;
                }
                else
                {
                    team.TeamGoalsFor += gf;
                }
                if (team.TeamGoalsAgainst == 0)
                {
                    team.TeamGoalsAgainst = ga;
                }
                else
                {
                    team.TeamGoalsAgainst += ga;
                }
                team.GoalDifference += gf - ga;
                var team2 = context.Teams.Where(x => x.TeamName == teamName).FirstOrDefault();
                context.Teams.Update(team2);
                context.SaveChanges();
            }
        }

        public void TeamsUpdate(string teamName, int point)
        {
            using (var context = new SampiyonlarLigiAppDbContext())
            {
                var team = context.Teams.Where(x => x.TeamName == teamName).FirstOrDefault();           
                if (team.TeamPoints == 0)
                {
                    team.TeamPoints = point;

                }
                else
                {
                    team.TeamPoints = team.TeamPoints + point;
                }
                var team2 = context.Teams.Where(x => x.TeamName == teamName).FirstOrDefault();
                context.Teams.Update(team2);
                context.SaveChanges();
            }
        }
    }
}
