using System.Reflection;
using BoutiqueManga.API.DTOInsertForm;
using DTO = BoutiqueManga.API.DTOs;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.API.Mappers
{
    public static class MMUserVolumeMapper
    {
        public static DTO.MMUserVolume ToDTO(this Models.MMUserVolume uv)
        {
            return new DTO.MMUserVolume
            {
                Id = uv.Id,
                PurchaseDate = uv.PurchaseDate,
                Quantity = uv.Quantity,
                UserId = uv.UserId,
                VolumeISBN = uv.VolumeISBN
            };
        }
        public static Models.MMUserVolume ToModel(this MMUserVolumeInsertForm uv)
        {
            return new Models.MMUserVolume
            {
                Quantity = uv.Quantity,
                UserId = uv.UserId,
                VolumeISBN = uv.VolumeISBN
            };
        }
    }
}
