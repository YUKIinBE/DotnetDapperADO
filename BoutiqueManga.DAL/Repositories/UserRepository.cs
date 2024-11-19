using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;
using BoutiqueManga.DAL.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BoutiqueManga.DAL.Repositories
{
    public class UserRepository(SqlConnection connection) : IUserRepository
    {
        public IEnumerable<User> GetAll()
        {
            return connection.Query<User>("SELECT * FROM [User]");
        }

        public User GetById(int id)
        {
            return connection.QueryFirst<User>("SELECT * FROM [User] WHERE Id = @Id", new { id });
        }

        public User Create(User u)
        {
            string sql = "INSERT INTO [User] (Password, Firstname, Lastname, Email, Address, Telephone) OUTPUT [INSERTED].Id VALUES (@Password, @Firstname, @Lastname, @Email, @Address, @Telephone)";
            int insertedId = connection.ExecuteScalar<int>(sql, new { u.Password, u.Firstname, u.Lastname, u.Email, u.Address, u.Telephone });

            return GetById(insertedId);
        }

        public User UpdateNbPurchase(int userId, int nbPurchase)
        {
            string sql = "UPDATE User SET NbPurchase = @NbPurchase OUTPUT [INSERTED].Id WHERE Id = @userId";

            string updatedId = connection.ExecuteScalar<string>(sql, new {  userId, nbPurchase });

            return GetById(userId);            
        }
    }
}
