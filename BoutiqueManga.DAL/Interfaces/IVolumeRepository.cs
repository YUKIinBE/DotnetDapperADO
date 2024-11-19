using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;

namespace BoutiqueManga.DAL.Interfaces
{
    public interface IVolumeRepository
    {
        public IEnumerable<Volume> GetAll();
        public Volume GetByISBN(string isbn);
        public Volume Create(Volume volume);
        public Volume Update(Volume volume);
        public Volume UpdateStockByISBN(string isbn, int stockToAdd);
        //TODO Add Delete()
        //TODO Add AlreadyExistException
    }
}
