using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Data.Abstract;
using SampiyonlarLigiApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampiyonlarLigiApp.Bussines.Concrete
{
    public class TeamsManager : ITeamsService
    {
        private ITeamsRepository _teamsRepository;

        public TeamsManager(ITeamsRepository teamsRepository)
        {
            _teamsRepository = teamsRepository;
        }

        public void Create(Teams entity)
        {
            throw new NotImplementedException();
        }

        public List<Teams> GetAll()
        {
            return _teamsRepository.GetAll();
        }

        public Teams GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void GetGroupNumberByTeamName(string teamName, int groupNumber)
        {
            _teamsRepository.GetGroupNumberByTeamName(teamName, groupNumber);
        }

        public void TeamsUpdate(string teamName, int gf, int ga)
        {
            _teamsRepository.TeamsUpdate(teamName, gf, ga);
        }

        public void TeamsUpdate(string teamName, int point)
        {
            _teamsRepository.TeamsUpdate(teamName, point);
        }
    }
}
