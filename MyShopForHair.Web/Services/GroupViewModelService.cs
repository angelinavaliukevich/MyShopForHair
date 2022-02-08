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
    public class GroupViewModelService : IGroupViewModelService
    {
        private readonly IGroupService groupService;

        public GroupViewModelService(IGroupService groupService)
        {
            this.groupService = groupService;
        }
        public int Add(GroupViewModel groupViewModel)
        {
            return groupService.Add(ConvertToModel(groupViewModel));
        }


        public void Edit(GroupViewModel groupViewModel)
        {
            groupService.Edit(ConvertToModel(groupViewModel));
        }

        public IEnumerable<GroupViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public GroupViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        private Group ConvertToModel(GroupViewModel groupViewModel)
        {
            return new Group
            {
                Id = groupViewModel.Id.HasValue ? groupViewModel.Id.Value : 0,
                Name = groupViewModel.Name,
             
            };

        }
    }
}