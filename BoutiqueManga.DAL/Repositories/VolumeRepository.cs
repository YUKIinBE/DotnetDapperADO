using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;
using BoutiqueManga.DAL.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;

namespace BoutiqueManga.DAL.Repositories
{
    public class VolumeRepository(SqlConnection connection) : IVolumeRepository
    {
        public IEnumerable<Volume> GetAll()
        {
            return connection.Query<Volume>("SELECT * FROM Volume");
        }

        public Volume GetByISBN(string isbn)
        {
            return connection.QueryFirst<Volume>("SELECT * FROM Volume WHERE ISBN = @ISBN", new { isbn });
        }

        public Volume Create(Volume v)
        {
            string sql = "INSERT INTO Volume (ISBN, VolNumber, CoverImage, Stock, EditorId, CollectionId) OUTPUT [INSERTED].ISBN VALUES (@ISBN, @VolNumber, @CoverImage, @Stock, @EditorId, @CollectionId)";
            string insertedISBN = connection.ExecuteScalar<string>(sql, new { v.ISBN, v.VolNumber, v.CoverImage, v.Stock, v.EditorId, v.CollectionId });

            return GetByISBN(insertedISBN);
        }

        public Volume Update(Volume v)
        {
            string sql = "UPDATE Volume SET VolNumber = @VolNumber, CoverImage = @CoverImage, Stock = @Stock, EditorId = @EditorId, CollectionId = @CollectionId OUTPUT[INSERTED].ISBN WHERE ISBN = @ISBN";
            string updatedISBN = connection.ExecuteScalar<string>(sql, new { v.ISBN, v.VolNumber, v.CoverImage, v.Stock, v.EditorId, v.CollectionId });

            return GetByISBN(updatedISBN);
        }

        public Volume UpdateStockByISBN(string isbn, int stockToAdd)
        {
            string sql = "UPDATE Volume SET Stock = Stock + @stockToAdd OUTPUT [INSERTED].ISBN WHERE ISBN = @ISBN";
            string updatedISBN = connection.ExecuteScalar<string>(sql, new { isbn, stockToAdd });

            return GetByISBN(updatedISBN);

        }
    }
}
