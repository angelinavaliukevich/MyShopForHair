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
    public class RoleModelService : IRoleModelService
    {
        private readonly IRepository<Role> roleRepository;

        public RoleModelService(IRepository<Role> roleRepository)
        {
            this.roleRepository = roleRepository;
        }

        public int Add(RoleModel role)
        {
            var entity = ConvertToEntity(role);
            roleRepository.Add(entity);

            return entity.Id;
        }

        public void Delete(int id)
        {
            roleRepository.Delete(new Role { Id = id });
        }

        public IEnumerable<RoleModel> Get()
        {
            return roleRepository.List().Select(ConvertToModel);
        }

        public RoleModel Get(int id)
        {
            return ConvertToModel(roleRepository.Get(id));
        }

        public void Update(RoleModel role)
        {
            roleRepository.Update(ConvertToEntity(role));
        }

        private Role ConvertToEntity(RoleModel roleModel)
        {
            return roleModel != null
                ? new Role
                {
                    Id = roleModel.Id ?? 0,
                    Name = roleModel.Name,
                }
                : null;
        }

        private RoleModel ConvertToModel(Role role)
        {
            return role != null
                ? new RoleModel
                {
                    Id = role.Id,
                    Name = role.Name,
                }
                : null;
        }
    }
}
