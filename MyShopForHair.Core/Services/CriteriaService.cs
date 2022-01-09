using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Services
{
   public class CriteriaService
    {
        private readonly IRepository<Criteria> criteriaRepository;
        public CriteriaService(IRepository<Criteria> criteriaRepository)
        {
            this.criteriaRepository = criteriaRepository;
        }

        public int Add(Criteria criteria)
        {
            criteriaRepository.Add(criteria);

            return criteria.Id;
        }

        public void Edit(Criteria criteria)
        {

        }
    }
}
