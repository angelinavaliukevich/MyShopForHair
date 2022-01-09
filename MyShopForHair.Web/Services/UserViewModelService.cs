using Microsoft.AspNetCore.Identity;
using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using MyShopForHair.Web.Interfaces;
using MyShopForHair.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShopForHair.Web.Services
{
    public class UserViewModelService : IUserViewModelService
    {
        private readonly IUserService userService;
        private readonly IPasswordHasher passwordHasher;
        private readonly IRepository<Role> roleRepository;

        public UserViewModelService(IUserService userService, IPasswordHasher passwordHasher, IRepository<Role> roleRepository)
        {
            this.userService = userService;
            this.passwordHasher = passwordHasher;
            this.roleRepository = roleRepository;
        }
        public int Add(UserViewModel userViewModel)
        {
            return userService.Add(ConvertToModel(userViewModel));
        }

        public void Edit(UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int value)
        {
            var user = userService.Get(id);
            return user != null ? ConvertToViewModel(user) : null;
        }

        public UserViewModel GetEmpty()
        {
            return ConvertToViewModel(new User());
        }
        private User ConvertToModel(UserViewModel userViewModel)
        {
            var salt = passwordHasher.GenerateSalt();

            return new User
            {
                Id = userViewModel.Id.HasValue ? userViewModel.Id.Value : 0,
                Name = userViewModel.Name,
                Login = userViewModel.Login,
                Password = passwordHasher.Hash(userViewModel.Password, salt),
            };
        }

        private UserViewModel ConvertToViewModel(User user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Login = user.Login,
                Password = user.Password,
            };
        }
    } 
}
