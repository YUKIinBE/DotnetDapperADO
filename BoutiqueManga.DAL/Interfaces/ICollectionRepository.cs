using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;

namespace BoutiqueManga.DAL.Interfaces
{
    public interface ICollectionRepository
    {
        public IEnumerable<Collection> GetAll();
        public Collection GetById(int id);
        public Collection Create(Collection collection);
        //TODO Add Delete()
        //TODO Add AlreadyExistException
    }
}
