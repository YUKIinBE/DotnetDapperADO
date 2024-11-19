using System.Reflection;
using Models = BoutiqueManga.BLL.Models;
using DTO = BoutiqueManga.API.DTOs;
using BoutiqueManga.API.DTOInsertForm;

namespace BoutiqueManga.API.Mappers
{
    public static class CollectionMapper
    {
        public static DTO.Collection ToDTO(this Models.Collection c)
        {
            return new DTO.Collection
            {
                Id = c.Id,
                Image = c.Image,
                Title = c.Title,
                Author = c.Author,
                Price = c.Price,
                PublishedDate = c.PublishedDate,
            };
        }
        public static Models.Collection ToModel(this CollectionInsertForm c)
        {
            return new Models.Collection
            {
                Image = c.Image,
                Title = c.Title,
                Author = c.Author,
                Price = c.Price,
                PublishedDate = c.PublishedDate,
            };
        }
    }
}
