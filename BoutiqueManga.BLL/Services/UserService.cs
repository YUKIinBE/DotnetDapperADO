using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.BLL.Interfaces;
using BoutiqueManga.BLL.Mappers;
using BoutiqueManga.BLL.Models;
using BoutiqueManga.DAL.Interfaces;
using Entities = BoutiqueManga.DAL.Entities;
using BoutiqueManga.DAL.Repositories;
using BoutiqueManga.BLL.Utilities;

namespace BoutiqueManga.BLL.Services
{
    public class UserService(IUserRepository repo, TokenManager tokenManager) : IUserService
    {
        public IEnumerable<User> GetAll()
        {
            return repo.GetAll().Select(entity => entity.ToModel());
        }

        public User GetById(int id)
        {
            return repo.GetById(id).ToModel();
        }

        public User Create(User user, string password)
        {
            byte[] hashPassword = SHA512.HashData(Encoding.UTF8.GetBytes(password + user.Email));

            return repo.Create(user.ToEntity(hashPassword)).ToModel();

            //TODO Add AlreadyExistException
        }

        //TODO UpdateNbPurchase => Update()
        public User UpdateNbPurchase(int userId, int nbPurchase)
        {
            return repo.UpdateNbPurchase(userId, nbPurchase).ToModel();
        }

        //TODO Delete id from parameter
        //TODO Add GetByEmail() and use it
        public string Login(int id, string email, string password)
        {
            Entities.User? user = repo.GetById(id);

            if(user is null)
            {
                throw new AuthenticationException();
            }
            byte[] hashPassword = SHA512.HashData(Encoding.UTF8.GetBytes(password + user.Email));

            if (!hashPassword.SequenceEqual(user.Password))
            {
                throw new AuthenticationException();
            }
            return tokenManager.CreateToken(user.Id, user.Email, user.IsSeller);
        }
    }
}
