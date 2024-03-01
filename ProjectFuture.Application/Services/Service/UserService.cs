using ProjectFuture.Application.IBaseRepositories;
using ProjectFuture.Application.Services.IService;
using ProjectFuture.Domain.Entites.DTOs;
using ProjectFuture.Domain.Entites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFuture.Application.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }
        public Task<User> Create(User user)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException(); 
        }

        public Task<IEnumerable<User>> GetAll()
        {
            try
            {
                _userRepository.GetAll();
            }
        }

        public Task<User> GetByAny(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<User> Update(int Id, UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
