using MyShopForHair.Core.Entities;
using MyShopForHair.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Core.Specifications
{
    internal class UserByLoginSpecification : ISpecification<User>
    {
        private string login;
        public IList<string> Includes;
        public UserByLoginSpecification(string login)
        {
            this.login = login;
        }
        public IQueryable<User> Applay(IQueryable<User> query)
        {
            return query.Where(i => i.Login == login);
        }
    }
}