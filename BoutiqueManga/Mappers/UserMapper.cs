using BoutiqueManga.API.DTOInsertForm;
using DTO = BoutiqueManga.API.DTOs;
using Models = BoutiqueManga.BLL.Models;

namespace BoutiqueManga.API.Mappers
{
    public static class UserMapper
    {
        public static DTO.User ToDTO(this Models.User u)
        {
            return new DTO.User
            {
                Id = u.Id,
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                Email = u.Email,
                Address = u.Address,
                Telephone = u.Telephone,
                IsSeller = u.IsSeller
            };
        }
        public static Models.User ToModel(this UserInsertForm u)
        {
            return new Models.User
            {
                Firstname = u.Firstname,
                Lastname = u.Lastname,
                Email = u.Email,
                Address = u.Address,
                Telephone = u.Telephone
            };
        }
    }
}
