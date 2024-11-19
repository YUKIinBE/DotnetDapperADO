using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.BLL.Interfaces;
using BoutiqueManga.BLL.Mappers;
using BoutiqueManga.BLL.Models;
using BoutiqueManga.DAL.Interfaces;

namespace BoutiqueManga.BLL.Services
{
    public class VolumeService(IVolumeRepository repo) : IVolumeService
    {
        public IEnumerable<Volume> GetAll()
        {
            return repo.GetAll().Select(entity => entity.ToModel());
        }

        public Volume GetByISBN(string isbn)
        {
            return repo.GetByISBN(isbn).ToModel();
        }

        public Volume Create(Volume volume)
        {
            return repo.Create(volume.ToEntity()).ToModel();
            //TODO Add AlreadyExistException
        }

        public Volume Update(Volume volume)
        {
            return repo.Update(volume.ToEntity()).ToModel();
        }

        public Volume UpdateStockByISBN(string isbn, int stockToAdd)
        {
            return repo.UpdateStockByISBN(isbn, stockToAdd).ToModel();
        }
    }
}
