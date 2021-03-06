using Hotel.Core.Specifications;
using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> userRepository;
        private readonly IRepository<Role> roleRepository;

        public UserService(IRepository<User> userRepository, IRepository<Role> roleRepository)
        {
            this.userRepository = userRepository;
            this.roleRepository = roleRepository;
        }

        public int Add(User user)
        {
            userRepository.Add(user);

            return user.Id;
        }

        public User Get(int id)
        {
            return userRepository.Get(id);
        }

        public User Get(string login)
        {
            UserByLoginSpecification u = new UserByLoginSpecification(login);
            User user = userRepository.Get(u);
            return user;
        }
    }
}
