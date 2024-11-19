using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Interfaces
{
    public interface IUserService
    {
        public IEnumerable<User> GetAll();
        public User GetById(int id);
        public User Create(User user, string password);
        public User UpdateNbPurchase(int userId, int nbPurchase);
        public string Login(int id, string email, string password);
        //TODO Add ActivateSeller(); 
    }
}
