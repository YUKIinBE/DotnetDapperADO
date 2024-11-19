using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = BoutiqueManga.DAL.Entities;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Mappers
{
    public static class CollectionMapper
    {
        public static Models.Collection ToModel(this Entities.Collection c)
        {
            return new Models.Collection
            {
                Id = c.Id,
                Image = c.Image,
                Title = c.Title,
                Author = c.Author,
                Price = c.Price,
                PublishedDate = c.PublishedDate,
            };
        }
        public static Entities.Collection ToEntity(this Models.Collection c)
        {
            return new Entities.Collection
            {
                Id = c.Id,
                Image = c.Image,
                Title = c.Title,
                Author = c.Author,
                Price = c.Price,
                PublishedDate = c.PublishedDate,
            };
        }
    }
}
