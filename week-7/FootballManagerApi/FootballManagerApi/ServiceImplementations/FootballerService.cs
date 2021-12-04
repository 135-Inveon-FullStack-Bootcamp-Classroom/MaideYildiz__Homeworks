using FootballManagerApi.Data;
using FootballManagerApi.Entities;
using FootballManagerApi.ServiceAbstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballManagerApi.ServiceImplementations
{
    public class FootballerService : BaseService<Footballer> ,IFootballerService
    {
        private readonly ApplicationDbContext _context;

        public FootballerService(ApplicationDbContext context): base(context)
        {
            _context = context;
        }

        
      
    }
}
