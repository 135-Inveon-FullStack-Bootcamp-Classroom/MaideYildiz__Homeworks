using FootballManagerApi.ServiceAbstracts;

namespace FootballManagerApi.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ICoachService coachService,IFootballerService footballerService,
                          IManagerService managerService,INationalTeamService nationalTeamService,
                          IPositionService positionService,ITacticService tacticService,
                          ITeamService teamService)
        {
            this.CoachService = coachService;
            this.FootballerService = footballerService;
            this.ManagerService = managerService;
            this.NationalTeamService = nationalTeamService;
            this.PositionService = positionService;
            this.TacticService = tacticService;
            this.TeamService = teamService; 
        }
        public ICoachService CoachService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public IManagerService ManagerService { get; set; }
        public INationalTeamService NationalTeamService { get; set; }
        public IPositionService PositionService { get; set; }
        public ITacticService TacticService { get; set; }
        public ITeamService TeamService { get; set; }
    }
}
