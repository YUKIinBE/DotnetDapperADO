using System.Reflection;
using Models = BoutiqueManga.BLL.Models;
using DTO = BoutiqueManga.API.DTOs;
using BoutiqueManga.API.DTOInsertForm;

namespace BoutiqueManga.API.Mappers
{
    public static class VolumeMapper
    {
        public static DTO.Volume ToDTO(this Models.Volume v)
        {
            return new DTO.Volume
            {
                ISBN = v.ISBN,
                VolNumber = v.VolNumber,
                CoverImage = v.CoverImage,
                Stock = v.Stock,
                EditorId = v.EditorId,
                CollectionId = v.CollectionId
            };
        }
        public static Models.Volume ToModel(this VolumeInsertForm v)
        {
            return new Models.Volume
            {
                ISBN = v.ISBN,
                VolNumber = v.VolNumber,
                CoverImage = v.CoverImage,
                Stock = v.Stock,
                EditorId = v.EditorId,
                CollectionId = v.CollectionId
            };
        }
    }
}
