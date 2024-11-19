using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entities = BoutiqueManga.DAL.Entities;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Mappers
{
    public static class UserMapper
    {
        public static Models.User ToModel(this Entities.User u)
        {
            return new Models.User
            {
                Id = u.Id, 
                Firstname = u.Firstname, 
                Lastname = u.Lastname, 
                Email = u.Email, 
                Address = u.Address, 
                Telephone = u.Telephone,
                IsSeller = u.IsSeller
            };
        }
        public static Entities.User ToEntity(this Models.User u, byte[] password)
        {
            return new Entities.User
            {
                Id = u.Id,
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                Email = u.Email,
                Address = u.Address,
                Telephone = u.Telephone,
                IsSeller = u.IsSeller,
                Password = password
            };
        }
    }
}
