using FootballManagerApi.ServiceAbstracts;

namespace FootballManagerApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        public ICoachService CoachService { get; set; }
        public IFootballerService FootballerService { get; set; }
        public IManagerService ManagerService { get; set; } 
        public INationalTeamService NationalTeamService { get; set; }   
        public IPositionService PositionService { get; set; }   
        public ITacticService TacticService { get; set; }   
        public ITeamService TeamService { get; set; }   
    }
}
