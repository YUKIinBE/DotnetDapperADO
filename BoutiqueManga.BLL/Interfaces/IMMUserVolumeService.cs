using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Interfaces
{
    public interface IMMUserVolumeService
    {
        public IEnumerable<MMUserVolume> Get(int? userId, string? isbn);
        public MMUserVolume GetById(int id);
        public IEnumerable<MMUserVolume> GetByUserId(int userId);
        public MMUserVolume Create(MMUserVolume mmUserVolume);
        //TODO Add Delete()
    }
}
