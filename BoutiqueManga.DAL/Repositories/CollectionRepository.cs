using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;
using BoutiqueManga.DAL.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BoutiqueManga.DAL.Repositories
{
    public class CollectionRepository(SqlConnection connection) : ICollectionRepository
    {
        public IEnumerable<Collection> GetAll()
        {
            return connection.Query<Collection>("SELECT * FROM Collection");
        }

        public Collection GetById(int id)
        {
            return connection.QueryFirst<Collection>("SELECT * FROM Collection WHERE Id = @Id", new {id}) ;
        }
        public Collection Create(Collection c)
        {
            string sql = "INSERT INTO Collection (Image, Title, Author, Price, PublishedDate) OUTPUT [INSERTED].Id VALUES (@Image, @Title, @Author, @Price, @PublishedDate)";
            int insertedId = connection.ExecuteScalar<int>(sql, new { c.Image, c.Title, c.Author, c.Price, c.PublishedDate });

            return GetById(insertedId) ;
        }
    }
}
