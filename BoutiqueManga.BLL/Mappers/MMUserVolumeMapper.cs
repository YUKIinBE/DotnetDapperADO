using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities = BoutiqueManga.DAL.Entities;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Mappers
{
    public static class MMUserVolumeMapper
    {
        public static Models.MMUserVolume ToModel(this Entities.MMUserVolume uv)
        {
            return new Models.MMUserVolume
            {
                Id = uv.Id,
                PurchaseDate = uv.PurchaseDate,
                Quantity = uv.Quantity,
                UserId = uv.UserId,
                VolumeISBN = uv.VolumeISBN,
                TotalPrice = uv.TotalPrice,
            };
        }
        public static Entities.MMUserVolume ToEntity(this Models.MMUserVolume uv)
        {
            return new Entities.MMUserVolume
            {
                Id = uv.Id,
                PurchaseDate = uv.PurchaseDate,
                Quantity = uv.Quantity,
                UserId = uv.UserId,
                VolumeISBN = uv.VolumeISBN,
                TotalPrice = uv.TotalPrice,
            };
        }
    }
}
