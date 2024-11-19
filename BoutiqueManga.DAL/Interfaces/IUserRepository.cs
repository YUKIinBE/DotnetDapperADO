using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;

namespace BoutiqueManga.DAL.Interfaces
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public User Create(User user);
        public User UpdateNbPurchase(int userId, int nbPurchase);
        //TODO Add Delete()
        //TODO Add AlreadyExistException
    }
}
