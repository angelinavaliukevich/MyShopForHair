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
    public class GroupViewModelService : IGroupViewModelService
    {
        private readonly IGroupService groupService;
        private readonly IRepository<Group> groupRepository;
        private readonly IRepository<Criteria> criteriaRepository;

        public GroupViewModelService(IGroupService groupService, IRepository<Group> groupRepository, IRepository<Criteria> criteriaRepository)
        {
            this.groupService = groupService;
            this.groupRepository = groupRepository;
            this.criteriaRepository = criteriaRepository;
        }
        public int Add(GroupViewModel groupViewModel)
        {
            return groupService.Add(ConvertToModel(groupViewModel));
        }

        public void DeleteGroup(int id)
        {
            Group brand = groupRepository.List().Where(i => i.Id == id).FirstOrDefault();
            if (brand != null)
                groupRepository.Delete(brand);
        }

        public void Edit(GroupViewModel groupViewModel)
        {
            groupService.Edit(ConvertToModel(groupViewModel));
        }

        public IEnumerable<GroupViewModel> GetAll()
        {
            IList<Group> l = groupRepository.List();
            return l.Select(ConvertToViewModel);
        }

        public GroupViewModel GetEmpty()
        {
            return new GroupViewModel
            {
                Id = 0,
                Name = "",
                CriteriaID = 0,
                Criteria = null,
                CriteriasAll = criteriaRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToList(),
                //GroupId = criteria.GroupId,
                //Groups = groupRepository.List().Select(g => new SelectListItem(g.Name, g.Id.ToString(), criteria.GroupId ==  g.Id)).ToList()
            };
        }


        public GroupViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }
        private GroupViewModel ConvertToViewModel(Group group)
        {
            return new GroupViewModel
            {
                Id = group.Id,
                Name = group.Name,
                CriteriaID = group.CriteriaID,
                Criteria = criteriaRepository.List().Where(i => i.Id == group.CriteriaID).FirstOrDefault(),
                CriteriasAll = criteriaRepository.List().Select(a =>
                                  new SelectListItem
                                  {
                                      Value = a.Id.ToString(),
                                      Text = a.Name
                                  }).ToList(),
                //GroupId = criteria.GroupId,
                //Groups = groupRepository.List().Select(g => new SelectListItem(g.Name, g.Id.ToString(), criteria.GroupId ==  g.Id)).ToList()
            };
        }

        public void DeleteCriteria(int id)
        {
            Criteria brand = criteriaRepository.List().Where(i => i.Id == id).FirstOrDefault();
            if (brand != null)
                criteriaRepository.Delete(brand);
        }

        private Group ConvertToModel(GroupViewModel groupViewModel)
        {
            return new Group
            {
                Id = groupViewModel.Id.HasValue ? groupViewModel.Id.Value : 0,
                Name = groupViewModel.Name,
                CriteriaID = groupViewModel.CriteriaID,

            };

        }
    }
}