using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopForHair.Core.Specification
{
    internal class UserWithRolesSpecification : ISpecification<User>
    {
        private int id;
        public IList<string> Includes =>
            new List<string> { $"{nameof(User.Members)}.{nameof(Member.Role)}" };

        public UserWithRolesSpecification(int id)
        {
            this.id = id;
        }


        public IQueryable<User> Apply(IQueryable<User> query)
        {
            return query.Where(i => i.Id == id);
        }

    }
}
