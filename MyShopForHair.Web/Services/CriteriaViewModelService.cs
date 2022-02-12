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
        //private readonly IRepository<Group> groupRepository;
        public CriteriaViewModelService(ICriteriaService criteriaService, IRepository<Criteria> criteriaRepository)
        {
            this.criteriaService = criteriaService;
            this.criteriaRepository = criteriaRepository;
            
        }
        public int Add(CriteriaViewModel criteriaViewModel)
        {
            return criteriaService.Add(ConvertToModel(criteriaViewModel));
        }

        public void DeleteCriteria(int id) {
            Criteria brand = criteriaRepository.List().Where(i => i.Id == id).FirstOrDefault();
            if (brand != null)
                criteriaRepository.Delete(brand);
        }

        public void Edit(CriteriaViewModel criteriaViewModel)
        {
            criteriaService.Edit(ConvertToModel(criteriaViewModel));
        }

        public IEnumerable<CriteriaViewModel> GetAll()
        {
            IList<Criteria> l = criteriaRepository.List();
            return l.Select(ConvertToViewModel);
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
               
                
            };
        }

        private Criteria ConvertToModel(CriteriaViewModel criteriaViewModel)
        {
            return new Criteria
            {
                Id = criteriaViewModel.Id.HasValue ? criteriaViewModel.Id.Value : 0,
                Name = criteriaViewModel.Name,
              
            };
        }

    }
}
