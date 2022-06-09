using Microsoft.AspNetCore.Mvc;
using SampiyonlarLigiApp.Bussines.Abstract;
using SampiyonlarLigiApp.Entity;
using SampiyonlarLigiApp.WebUı.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SampiyonlarLigiApp.WebUı.Controllers
{
    public class HomeController : Controller
    {
        private IGroup1Service _group1Service;
        private IGroup2Service _group2Service;
        private IGroup3Service _group3Service;
        private IGroup4Service _group4Service;
        private ILast32Group1Service _last32Group1Service;
        private ILast32Group2Service _last32Group2Service;
        private ILast32Group3Service _last32Group3Service;
        private ILast32Group4Service _last32Group4Service;
        private ILast32Group5Service _last32Group5Service;
        private ILast32Group6Service _last32Group6Service;
        private ILast32Group7Service _last32Group7Service;
        private ILast32Group8Service _last32Group8Service;
        private IFixtureService _fixtureService;
        private ITeamsService _teamsService;

        public HomeController(ITeamsService teamsService, IFixtureService fixtureService, IGroup1Service group1Service, IGroup2Service group2Service, IGroup3Service group3Service, IGroup4Service group4Service, ILast32Group1Service last32Group1Service, ILast32Group2Service last32Group2Service, ILast32Group3Service last32Group3Service, ILast32Group4Service last32Group4Service, ILast32Group5Service last32Group5Service, ILast32Group6Service last32Group6Service, ILast32Group7Service last32Group7Service, ILast32Group8Service last32Group8Service)
        {
            _fixtureService = fixtureService;
            _group1Service = group1Service;
            _group2Service = group2Service;
            _group3Service = group3Service;
            _group4Service = group4Service;
            _last32Group1Service = last32Group1Service;
            _last32Group2Service = last32Group2Service;
            _last32Group3Service = last32Group3Service;
            _last32Group4Service = last32Group4Service;
            _last32Group5Service = last32Group5Service;
            _last32Group6Service = last32Group6Service;
            _last32Group7Service = last32Group7Service;
            _last32Group8Service = last32Group8Service;
            _teamsService = teamsService;
        }

        public IActionResult Index()
        {
            GroupsModel groupsModel = new GroupsModel()
            {
                Group1s = _group1Service.GetAll(),
                Group2s = _group2Service.GetAll(),
                Group3s = _group3Service.GetAll(),
                Group4s = _group4Service.GetAll()
            };
            return View(groupsModel);
        }
        public IActionResult GroupsList()
        {
            var Group1s = _group1Service.GetAll();
            var Group2s = _group2Service.GetAll();
            var Group3s = _group3Service.GetAll();
            var Group4s = _group4Service.GetAll();
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g1t1 = _group1Service.GetById(random.Next(1, 9));
                var g1t2 = _group2Service.GetById(random.Next(1, 9));
                var g1t3 = _group3Service.GetById(random.Next(1, 9));
                var g1t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group1 team1 = new Last32Group1()
                {
                    TeamName = g1t1.TeamName,
                    TeamCountry = g1t1.TemaCountry,
                    GroupNumber = 1
                };
                Last32Group1 team2 = new Last32Group1()
                {
                    TeamName = g1t2.TeamName,
                    TeamCountry = g1t2.TemaCountry,
                    GroupNumber = 1
                };
                Last32Group1 team3 = new Last32Group1()
                {
                    TeamName = g1t3.TeamName,
                    TeamCountry = g1t3.TemaCountry,
                    GroupNumber = 1
                };
                Last32Group1 team4 = new Last32Group1()
                {
                    TeamName = g1t4.TeamName,
                    TeamCountry = g1t4.TemaCountry,
                    GroupNumber = 1
                };
                var last32Group1Teams = _last32Group1Service.GetAll();
                if (_last32Group1Service.IsTeam(g1t1.TemaCountry))
                {
                    if (last32Group1Teams.Count() == 0 && g1t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g1t1.Id);
                        _last32Group1Service.Create(team1);
                        continue;
                    }
                    if (last32Group1Teams.Count() == 1 && _last32Group1Service.IsTeam(g1t2.TemaCountry) && g1t2.IsActive == false)
                    {
                        _group2Service.IsActiveUpdate(g1t2.Id);
                        _last32Group1Service.Create(team2);
                        continue;
                    }
                    if (last32Group1Teams.Count() == 2 && _last32Group1Service.IsTeam(g1t3.TemaCountry) && g1t3.IsActive == false)
                    {
                        _group3Service.IsActiveUpdate(g1t3.Id);
                        _last32Group1Service.Create(team3);
                        continue;
                    }
                    if (last32Group1Teams.Count() == 3 && _last32Group1Service.IsTeam(g1t4.TemaCountry) && g1t4.IsActive == false)
                    {
                        _group4Service.IsActiveUpdate(g1t4.Id);
                        _last32Group1Service.Create(team4);
                        continue;
                    }
                    if (last32Group1Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g2t1 = _group1Service.GetById(random.Next(1, 9));
                var g2t2 = _group2Service.GetById(random.Next(1, 9));
                var g2t3 = _group3Service.GetById(random.Next(1, 9));
                var g2t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group2 team1 = new Last32Group2()
                {
                    TeamName = g2t1.TeamName,
                    TeamCountry = g2t1.TemaCountry,
                    GroupNumber = 2
                };
                Last32Group2 team2 = new Last32Group2()
                {
                    TeamName = g2t2.TeamName,
                    TeamCountry = g2t2.TemaCountry,
                    GroupNumber = 2
                };
                Last32Group2 team3 = new Last32Group2()
                {
                    TeamName = g2t3.TeamName,
                    TeamCountry = g2t3.TemaCountry,
                    GroupNumber = 2
                };
                Last32Group2 team4 = new Last32Group2()
                {
                    TeamName = g2t4.TeamName,
                    TeamCountry = g2t4.TemaCountry,
                    GroupNumber = 2
                };
                var last32Group2Teams = _last32Group2Service.GetAll();
                if (_last32Group2Service.IsTeam(g2t1.TemaCountry))
                {
                    if (last32Group2Teams.Count() == 0 && g2t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g2t1.Id);
                        _last32Group2Service.Create(team1);
                        continue;
                    }
                    if (last32Group2Teams.Count() == 1 && _last32Group2Service.IsTeam(g2t2.TemaCountry) && g2t2.IsActive == false)
                    {
                        _group2Service.IsActiveUpdate(g2t2.Id);
                        _last32Group2Service.Create(team2);
                        continue;
                    }
                    if (last32Group2Teams.Count() == 2 && _last32Group2Service.IsTeam(g2t3.TemaCountry) && g2t3.IsActive == false)
                    {
                        _group3Service.IsActiveUpdate(g2t3.Id);
                        _last32Group2Service.Create(team3);
                        continue;
                    }
                    if (last32Group2Teams.Count() == 3 && _last32Group2Service.IsTeam(g2t4.TemaCountry) && g2t4.IsActive == false)
                    {
                        _group4Service.IsActiveUpdate(g2t4.Id);
                        _last32Group2Service.Create(team4);
                        continue;
                    }
                    if (last32Group2Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g3t1 = _group1Service.GetById(random.Next(1, 9));
                var g3t2 = _group2Service.GetById(random.Next(1, 9));
                var g3t3 = _group3Service.GetById(random.Next(1, 9));
                var g3t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group3 team1 = new Last32Group3()
                {
                    TeamName = g3t1.TeamName,
                    TeamCountry = g3t1.TemaCountry,
                    GroupNumber = 3
                };
                Last32Group3 team2 = new Last32Group3()
                {
                    TeamName = g3t2.TeamName,
                    TeamCountry = g3t2.TemaCountry,
                    GroupNumber = 3
                };
                Last32Group3 team3 = new Last32Group3()
                {
                    TeamName = g3t3.TeamName,
                    TeamCountry = g3t3.TemaCountry,
                    GroupNumber = 3
                };
                Last32Group3 team4 = new Last32Group3()
                {
                    TeamName = g3t4.TeamName,
                    TeamCountry = g3t4.TemaCountry,
                    GroupNumber = 3
                };
                var last32Group3Teams = _last32Group3Service.GetAll();
                if (_last32Group3Service.IsTeam(g3t1.TemaCountry))
                {
                    if (last32Group3Teams.Count() == 0 && g3t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g3t1.Id);
                        _last32Group3Service.Create(team1);
                        continue;
                    }
                    if (last32Group3Teams.Count() == 1 && _last32Group3Service.IsTeam(g3t2.TemaCountry) && g3t2.IsActive == false)
                    {
                        _group2Service.IsActiveUpdate(g3t2.Id);
                        _last32Group3Service.Create(team2);
                        continue;
                    }
                    if (last32Group3Teams.Count() == 2 && _last32Group3Service.IsTeam(g3t3.TemaCountry) && g3t3.IsActive == false)
                    {
                        _group3Service.IsActiveUpdate(g3t3.Id);
                        _last32Group3Service.Create(team3);
                        continue;
                    }
                    if (last32Group3Teams.Count() == 3 && _last32Group3Service.IsTeam(g3t4.TemaCountry) && g3t4.IsActive == false)
                    {
                        _group4Service.IsActiveUpdate(g3t4.Id);
                        _last32Group3Service.Create(team4);
                        continue;
                    }
                    if (last32Group3Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g4t1 = _group1Service.GetById(random.Next(1, 9));
                var g4t2 = _group2Service.GetById(random.Next(1, 9));
                var g4t3 = _group3Service.GetById(random.Next(1, 9));
                var g4t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group4 team1 = new Last32Group4()
                {
                    TeamName = g4t1.TeamName,
                    TeamCountry = g4t1.TemaCountry,
                    GroupNumber = 4
                };
                Last32Group4 team2 = new Last32Group4()
                {
                    TeamName = g4t2.TeamName,
                    TeamCountry = g4t2.TemaCountry,
                    GroupNumber = 4
                };
                Last32Group4 team3 = new Last32Group4()
                {
                    TeamName = g4t3.TeamName,
                    TeamCountry = g4t3.TemaCountry,
                    GroupNumber = 4
                };
                Last32Group4 team4 = new Last32Group4()
                {
                    TeamName = g4t4.TeamName,
                    TeamCountry = g4t4.TemaCountry,
                    GroupNumber = 4
                };
                var last32Group4Teams = _last32Group4Service.GetAll();
                if (_last32Group4Service.IsTeam(g4t1.TemaCountry))
                {
                    if (last32Group4Teams.Count() == 0 && g4t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g4t1.Id);
                        _last32Group4Service.Create(team1);
                        continue;
                    }
                    if (last32Group4Teams.Count() == 1 && _last32Group4Service.IsTeam(g4t2.TemaCountry) && g4t2.IsActive == false && _last32Group4Service.IsTeam(g4t2.TemaCountry))
                    {
                        _group2Service.IsActiveUpdate(g4t2.Id);
                        _last32Group4Service.Create(team2);
                        continue;
                    }
                    if (last32Group4Teams.Count() == 2 && _last32Group4Service.IsTeam(g4t3.TemaCountry) && g4t3.IsActive == false && _last32Group4Service.IsTeam(g4t3.TemaCountry))
                    {
                        _group3Service.IsActiveUpdate(g4t3.Id);
                        _last32Group4Service.Create(team3);
                        continue;
                    }
                    if (last32Group4Teams.Count() == 3 && _last32Group4Service.IsTeam(g4t4.TemaCountry) && g4t4.IsActive == false && _last32Group3Service.IsTeam(g4t4.TemaCountry))
                    {
                        _group4Service.IsActiveUpdate(g4t4.Id);
                        _last32Group4Service.Create(team4);
                        continue;
                    }
                    if (last32Group4Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g5t1 = _group1Service.GetById(random.Next(1, 9));
                var g5t2 = _group2Service.GetById(random.Next(1, 9));
                var g5t3 = _group3Service.GetById(random.Next(1, 9));
                var g5t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group5 team1 = new Last32Group5()
                {
                    TeamName = g5t1.TeamName,
                    TeamCountry = g5t1.TemaCountry,
                    GroupNumber = 5
                };
                Last32Group5 team2 = new Last32Group5()
                {
                    TeamName = g5t2.TeamName,
                    TeamCountry = g5t2.TemaCountry,
                    GroupNumber = 5
                };
                Last32Group5 team3 = new Last32Group5()
                {
                    TeamName = g5t3.TeamName,
                    TeamCountry = g5t3.TemaCountry,
                    GroupNumber = 5
                };
                Last32Group5 team4 = new Last32Group5()
                {
                    TeamName = g5t4.TeamName,
                    TeamCountry = g5t4.TemaCountry,
                    GroupNumber = 5
                };
                var last32Group5Teams = _last32Group5Service.GetAll();
                if (_last32Group5Service.IsTeam(g5t1.TemaCountry))
                {
                    if (last32Group5Teams.Count() == 0 && g5t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g5t1.Id);
                        _last32Group5Service.Create(team1);
                        continue;
                    }
                    if (last32Group5Teams.Count() == 1 && g5t2.IsActive == false && _last32Group5Service.IsTeam(g5t2.TemaCountry))
                    {
                        _group2Service.IsActiveUpdate(g5t2.Id);
                        _last32Group5Service.Create(team2);
                        continue;
                    }
                    if (last32Group5Teams.Count() == 2 && g5t3.IsActive == false && _last32Group5Service.IsTeam(g5t3.TemaCountry))
                    {
                        _group3Service.IsActiveUpdate(g5t3.Id);
                        _last32Group5Service.Create(team3);
                        continue;
                    }
                    if (last32Group5Teams.Count() == 3 && g5t4.IsActive == false && _last32Group5Service.IsTeam(g5t4.TemaCountry))
                    {
                        _group4Service.IsActiveUpdate(g5t4.Id);
                        _last32Group5Service.Create(team4);
                        continue;
                    }
                    if (last32Group5Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g6t1 = _group1Service.GetById(random.Next(1, 9));
                var g6t2 = _group2Service.GetById(random.Next(1, 9));
                var g6t3 = _group3Service.GetById(random.Next(1, 9));
                var g6t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group6 team1 = new Last32Group6()
                {
                    TeamName = g6t1.TeamName,
                    TeamCountry = g6t1.TemaCountry,
                    GroupNumber = 6
                };
                Last32Group6 team2 = new Last32Group6()
                {
                    TeamName = g6t2.TeamName,
                    TeamCountry = g6t2.TemaCountry,
                    GroupNumber = 6
                };
                Last32Group6 team3 = new Last32Group6()
                {
                    TeamName = g6t3.TeamName,
                    TeamCountry = g6t3.TemaCountry,
                    GroupNumber = 6
                };
                Last32Group6 team4 = new Last32Group6()
                {
                    TeamName = g6t4.TeamName,
                    TeamCountry = g6t4.TemaCountry,
                    GroupNumber = 6
                };
                var last32Group6Teams = _last32Group6Service.GetAll();
                if (_last32Group6Service.IsTeam(g6t1.TemaCountry))
                {
                    if (last32Group6Teams.Count() == 0 && g6t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g6t1.Id);
                        _last32Group6Service.Create(team1);
                        continue;
                    }
                    if (last32Group6Teams.Count() == 1 && g6t2.IsActive == false && _last32Group6Service.IsTeam(g6t2.TemaCountry))
                    {
                        _group2Service.IsActiveUpdate(g6t2.Id);
                        _last32Group6Service.Create(team2);
                        continue;
                    }
                    if (last32Group6Teams.Count() == 2 && g6t3.IsActive == false && _last32Group6Service.IsTeam(g6t3.TemaCountry))
                    {
                        _group3Service.IsActiveUpdate(g6t3.Id);
                        _last32Group6Service.Create(team3);
                        continue;
                    }
                    if (last32Group6Teams.Count() == 3 && g6t4.IsActive == false && _last32Group6Service.IsTeam(g6t4.TemaCountry))
                    {
                        _group4Service.IsActiveUpdate(g6t4.Id);
                        _last32Group6Service.Create(team4);
                        continue;
                    }
                    if (last32Group6Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int i = 0; i > -1; i++)
            {
                Random random = new Random();
                var g7t1 = _group1Service.GetById(random.Next(1, 9));
                var g7t2 = _group2Service.GetById(random.Next(1, 9));
                var g7t3 = _group3Service.GetById(random.Next(1, 9));
                var g7t4 = _group4Service.GetById(random.Next(1, 9));
                Last32Group7 team1 = new Last32Group7()
                {
                    TeamName = g7t1.TeamName,
                    TeamCountry = g7t1.TemaCountry,
                    GroupNumber = 7
                };
                Last32Group7 team2 = new Last32Group7()
                {
                    TeamName = g7t2.TeamName,
                    TeamCountry = g7t2.TemaCountry,
                    GroupNumber = 7
                };
                Last32Group7 team3 = new Last32Group7()
                {
                    TeamName = g7t3.TeamName,
                    TeamCountry = g7t3.TemaCountry,
                    GroupNumber = 7
                };
                Last32Group7 team4 = new Last32Group7()
                {
                    TeamName = g7t4.TeamName,
                    TeamCountry = g7t4.TemaCountry,
                    GroupNumber = 7
                };
                var last32Group7Teams = _last32Group7Service.GetAll();
                if (_last32Group7Service.IsTeam(g7t1.TemaCountry))
                {
                    if (last32Group7Teams.Count() == 0 && g7t1.IsActive == false)
                    {
                        _group1Service.IsActiveUpdate(g7t1.Id);
                        _last32Group7Service.Create(team1);
                        continue;
                    }
                    if (last32Group7Teams.Count() == 1 && g7t2.IsActive == false && _last32Group7Service.IsTeam(g7t2.TemaCountry))
                    {
                        _group2Service.IsActiveUpdate(g7t2.Id);
                        _last32Group7Service.Create(team2);
                        continue;
                    }
                    if (last32Group7Teams.Count() == 2 && g7t3.IsActive == false && _last32Group7Service.IsTeam(g7t3.TemaCountry))
                    {
                        _group3Service.IsActiveUpdate(g7t3.Id);
                        _last32Group7Service.Create(team3);
                        continue;
                    }
                    if (last32Group7Teams.Count() == 3 && g7t4.IsActive == false && _last32Group7Service.IsTeam(g7t4.TemaCountry))
                    {
                        _group4Service.IsActiveUpdate(g7t4.Id);
                        _last32Group7Service.Create(team4);
                        continue;
                    }
                    if (last32Group7Teams.Count() == 4)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }
            }
            var last32Group8Teams = _last32Group8Service.GetAll();
            if (last32Group8Teams.Count() != 4)
            {
                var g8t1 = _group1Service.group1();
                var g8t2 = _group2Service.group1();
                var g8t3 = _group3Service.group1();
                var g8t4 = _group4Service.group1();
                Last32Group8 lastTeam1 = new Last32Group8()
                {
                    TeamName = g8t1.TeamName,
                    TeamCountry = g8t1.TemaCountry,
                    GroupNumber = 8
                };
                Last32Group8 lastTeam2 = new Last32Group8()
                {
                    TeamName = g8t2.TeamName,
                    TeamCountry = g8t2.TemaCountry,
                    GroupNumber = 8
                };
                Last32Group8 lastTeam3 = new Last32Group8()
                {
                    TeamName = g8t3.TeamName,
                    TeamCountry = g8t3.TemaCountry,
                    GroupNumber = 8
                };
                Last32Group8 lastTeam4 = new Last32Group8()
                {
                    TeamName = g8t4.TeamName,
                    TeamCountry = g8t4.TemaCountry,
                    GroupNumber = 8
                };
                _last32Group8Service.Create(lastTeam1);
                _last32Group8Service.Create(lastTeam2);
                _last32Group8Service.Create(lastTeam3);
                _last32Group8Service.Create(lastTeam4);
            }

            Last32TeamsGroups last32TeamsGroups = new Last32TeamsGroups()
            {
                last32Group1 = _last32Group1Service.GetAll(),
                last32Group2 = _last32Group2Service.GetAll(),
                last32Group3 = _last32Group3Service.GetAll(),
                last32Group4 = _last32Group4Service.GetAll(),
                last32Group5 = _last32Group5Service.GetAll(),
                last32Group6 = _last32Group6Service.GetAll(),
                last32Group7 = _last32Group7Service.GetAll(),
                last32Group8 = _last32Group8Service.GetAll()
            };
            return View(last32TeamsGroups);

        }
        public IActionResult Fixture()
        {

            List<Fixture> fixture = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group1Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group1Service.GetById(j + 1).TeamName;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 1);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 1);
                    fixture1.GroupNumber = 1;
                    fixture.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group1Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group1Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 1;
                    fixture.Add(fixture1);
                }
            }
            List<Fixture> fixture2 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group2Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group2Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 2;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 2);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 2);
                    fixture2.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group2Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group2Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 2;
                    fixture2.Add(fixture1);
                }
            }
            List<Fixture> fixture3 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group3Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group3Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 3;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 3);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 3);
                    fixture3.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group3Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group3Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 3;
                    fixture3.Add(fixture1);
                }
            }
            List<Fixture> fixture4 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group4Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group4Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 4;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 4);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 4);
                    fixture4.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group4Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group4Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 4;
                    fixture4.Add(fixture1);
                }
            }
            List<Fixture> fixture5 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group5Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group5Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 5;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 5);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 5);
                    fixture5.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group5Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group5Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 5;
                    fixture5.Add(fixture1);
                }
            }
            List<Fixture> fixture6 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group6Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group6Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 6;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 6);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 6);
                    fixture6.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group6Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group6Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 6;
                    fixture6.Add(fixture1);
                }
            }
            List<Fixture> fixture7 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group7Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group7Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 7;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 7);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 7);
                    fixture7.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group7Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group7Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 7;
                    fixture7.Add(fixture1);
                }
            }
            List<Fixture> fixture8 = new List<Fixture>();
            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j < 4; j++)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group8Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group8Service.GetById(j + 1).TeamName;
                    fixture1.GroupNumber = 8;
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team1Name, 8);
                    _teamsService.GetGroupNumberByTeamName(fixture1.Team2Name, 8);
                    fixture8.Add(fixture1);
                }
            }
            for (int i = 4; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Fixture fixture1 = new Fixture();
                    fixture1.Team1Name = _last32Group8Service.GetById(i).TeamName;
                    fixture1.Team2Name = _last32Group8Service.GetById(j - 1).TeamName;
                    fixture1.GroupNumber = 8;
                    fixture8.Add(fixture1);
                }
            }
            FixturesModel fixturesModel = new FixturesModel()
            {
                fixtures1 = fixture,
                fixtures2 = fixture2,
                fixtures3 = fixture3,
                fixtures4 = fixture4,
                fixtures5 = fixture5,
                fixtures6 = fixture6,
                fixtures7 = fixture7,
                fixtures8 = fixture8
            };
            _fixtureService.RangeCreate(fixturesModel.fixtures1);
            _fixtureService.RangeCreate(fixturesModel.fixtures2);
            _fixtureService.RangeCreate(fixturesModel.fixtures3);
            _fixtureService.RangeCreate(fixturesModel.fixtures4);
            _fixtureService.RangeCreate(fixturesModel.fixtures5);
            _fixtureService.RangeCreate(fixturesModel.fixtures6);
            _fixtureService.RangeCreate(fixturesModel.fixtures7);
            _fixtureService.RangeCreate(fixturesModel.fixtures8);
            return View(fixturesModel);
        }
        public IActionResult Play()
        {
            var teams = _teamsService.GetAll();
            var fixture = _fixtureService.GetAll();
            foreach (var item in fixture)
            {
                item.Team1GF = new Random().Next(1, 9);
                item.Team2Gf = new Random().Next(1, 9);
                if (item.Team1GF > item.Team2Gf)
                {
                    item.Result = item.Team1Name;
                    _teamsService.TeamsUpdate(item.Team1Name, item.Team1GF, item.Team2Gf);
                    _teamsService.TeamsUpdate(item.Team1Name, 3);
                    _teamsService.TeamsUpdate(item.Team2Name, item.Team2Gf, item.Team1GF);
                }
                else if (item.Team1GF < item.Team2Gf)
                {
                    item.Result = item.Team2Name;
                    _teamsService.TeamsUpdate(item.Team2Name, item.Team2Gf, item.Team1GF);
                    _teamsService.TeamsUpdate(item.Team1Name, item.Team1GF, item.Team2Gf);
                    _teamsService.TeamsUpdate(item.Team2Name, 3);
                }
                else
                {
                    item.Result = "scoreless";
                    _teamsService.TeamsUpdate(item.Team1Name, item.Team1GF, item.Team2Gf);
                    _teamsService.TeamsUpdate(item.Team2Name, item.Team2Gf, item.Team1GF);
                    _teamsService.TeamsUpdate(item.Team1Name, 1);
                    _teamsService.TeamsUpdate(item.Team2Name, 1);
                }
                _fixtureService.Update(item);
            }
            ViewBag.Teams = _teamsService.GetAll();
            return View(_fixtureService.GetAll());
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
