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
    public class CollectionService(ICollectionRepository repo) : ICollectionService
    {
        public IEnumerable<Collection> GetAll()
        {
            return repo.GetAll().Select(entity => entity.ToModel());
        }

        public Collection GetById(int id)
        {
            return repo.GetById(id).ToModel();
        }

        public Collection Create(Collection collection)
        {
            return repo.Create(collection.ToEntity()).ToModel();
            //TODO Add AlreadyExistException
        }
    }
}
