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
    public class CriteriaViewModelService : ICriteriaViewModelService
    {
        private readonly ICriteriaService criteriaService;
        private readonly IRepository<Criteria> criteriaRepository;
        private readonly IRepository<Group> groupRepository;
        public CriteriaViewModelService(ICriteriaService criteriaService, IRepository<Criteria> criteriaRepository, IRepository<Group> groupRepository)
        {
            this.criteriaService = criteriaService;
            this.criteriaRepository = criteriaRepository;
            this.groupRepository = groupRepository;
        }
        public int Add(CriteriaViewModel criteriaViewModel)
        {
            return criteriaService.Add(ConvertToModel(criteriaViewModel));
        }
        
        public void Edit(CriteriaViewModel criteriaViewModel)
        {
            criteriaService.Edit(ConvertToModel(criteriaViewModel));
        }

        public IEnumerable<CriteriaViewModel> GetAll()
        {
            return criteriaRepository.List().Select(ConvertToViewModel);
        }

        public CriteriaViewModel GetById(int id)
        {
            var criteria = criteriaRepository.Get(id);
            return criteria != null ? ConvertToViewModel(criteria) : null;
        }    
        
        public CriteriaViewModel GetEmpty()
        {
            return ConvertToViewModel(new Criteria());
        }

        private CriteriaViewModel ConvertToViewModel(Criteria criteria)
        {
            return new CriteriaViewModel
            {
                Id = criteria.Id,
                Name = criteria.Name,
                GroupId = criteria.GroupId,
                Groups = groupRepository.List().Select(g => new SelectListItem(g.Name, g.Id.ToString(), criteria.GroupId ==  g.Id)).ToList()
            };
        }

        private Criteria ConvertToModel(CriteriaViewModel criteriaViewModel)
        {
            return new Criteria
            {
                Id = criteriaViewModel.Id.HasValue ? criteriaViewModel.Id.Value : 0,
                Name = criteriaViewModel.Name,
                GroupId = criteriaViewModel.GroupId,


            };
        }

    }
}
