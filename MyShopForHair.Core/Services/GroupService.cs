using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly IRepository<Group> groupRepository;
        public GroupService(IRepository<Group> groupRepository)
        {
            this.groupRepository = groupRepository;
        }
        public int Add(Group group)
        {
            groupRepository.Add(group);

            return group.Id;
        }

        public void Edit(Group group)
        {
            
        }
    }
}
