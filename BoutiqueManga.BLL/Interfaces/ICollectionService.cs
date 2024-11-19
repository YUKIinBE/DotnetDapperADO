using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Interfaces
{
    public interface ICollectionService
    {
        public IEnumerable<Collection> GetAll();
        public Collection GetById(int id);
        public Collection Create(Collection collection);
        //TODO Add Update()
        //TODO Add Delete()
        //TODO Add AlreadyExistException
    }
}
