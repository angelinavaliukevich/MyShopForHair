using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private readonly IRepository<Role> roleRepository;
        private readonly IPasswordHasher passwordHasher;

        public UserViewModelService(IUserService userService, IPasswordHasher passwordHasher, IRepository<Role> roleRepository)
        {
            this.userService = userService;
            this.passwordHasher = passwordHasher;
            this.roleRepository = roleRepository;
        }
        public int Add(UserViewModel userViewModel)
        {
            return userService.Add(ConvertToEntity(userViewModel));
        }

        public void Edit(UserViewModel user)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetById(int value)
        {
            throw new NotImplementedException();
        }

        public UserViewModel GetEmpty()
        {
            return ConvertToViewModel(new User());
        }

        private User ConvertToEntity(UserViewModel userViewModel)
        {
            var salt = passwordHasher.GenerateSalt();

            return new User
            {
                Id = userViewModel.Id.HasValue ? userViewModel.Id.Value : 0,
                Name = userViewModel.Name,
                Login = userViewModel.Login,
                Password = passwordHasher.Hash(userViewModel.Password, salt),
                Salt = salt,
                Members = userViewModel.RoleIds.Select(id => new Member { RoleId = id }).ToList()
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
                Roles = roleRepository.List().Select(r => new SelectListItem(r.Name, r.Id.ToString(), user.Members?.Any(m => m.RoleId == r.Id) ?? false)).ToList()
            };
        }
    } 
}
