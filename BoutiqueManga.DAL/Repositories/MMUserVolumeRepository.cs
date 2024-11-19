using System;
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
    public class MMUserVolumeRepository(SqlConnection connection) : IMMUserVolumeRepository
    {
        public IEnumerable<MMUserVolume> Get(int? userId, string? isbn)
        {
            return connection.Query<MMUserVolume>("SELECT * FROM MMUserVolume WHERE (@userId IS NULL OR UserId = @userId) AND (@isbn IS NULL OR VolumeISBN = @isbn)", new { userId, isbn });
        }

        public MMUserVolume GetById(int id)
        {
            return connection.QueryFirst<MMUserVolume>("SELECT * FROM MMUserVolume WHERE Id = @Id", new { id });
        }

        public IEnumerable<MMUserVolume> GetByUserId(int userId)
        {
            return connection.Query<MMUserVolume>("SELECT * FROM MMUserVolume WHERE UserId = @UserId", new { userId });
        }
        
        public MMUserVolume Create(MMUserVolume uv)
        {
            string sql = "INSERT INTO MMUserVolume (Quantity, UserId, VolumeISBN) OUTPUT [INSERTED].Id VALUES (@Quantity, @UserId, @VolumeISBN)";
            int insertedId = connection.ExecuteScalar<int>(sql, new { uv.Quantity, uv.UserId, uv.VolumeISBN });

            return GetById(insertedId);
        }
    }
}
