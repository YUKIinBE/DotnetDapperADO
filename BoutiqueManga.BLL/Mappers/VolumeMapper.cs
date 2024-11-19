using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoutiqueManga.DAL.Entities;
using Entities = BoutiqueManga.DAL.Entities;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.BLL.Mappers
{
    public static class VolumeMapper
    {
        public static Models.Volume ToModel(this Entities.Volume v)
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

        public static Entities.Volume ToEntity(this Models.Volume v)
        {
            return new Entities.Volume
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
