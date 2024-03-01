using Microsoft.EntityFrameworkCore;
using ProjectFuture.Domain.Entites.Models;
using ProjectFuture.Infrostructure.Persistance;
using ProjectFuture.Application.IBaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFuture.Infrostructure.BaseRepositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ProjectFutureDbContext context) : base(context)
        {
        }
    }
}
