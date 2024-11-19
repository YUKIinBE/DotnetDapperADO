using System.ComponentModel.DataAnnotations;

namespace BoutiqueManga.API.DTOInsertForm
{
    public class UserInsertForm
    {
        /*
        [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
        [Password] NVARCHAR(50) NOT NULL, 
        [Firstname] NVARCHAR(50) NOT NULL,
        [Lastname] NVARCHAR(50) NOT NULL,
        [Email] NVARCHAR(250) NOT NULL, 
        [Address] NVARCHAR(250) NOT NULL,
        [Telephone] NVARCHAR(50) NOT NULL,
        [isSeller] BIT NOT NULL DEFAULT 0
         */
        [Required]
        [MaxLength(50)]
        public string Password { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Firstname { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Lastname { get; set; } = string.Empty;
        [Required]
        [MaxLength(250)]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(250)]
        public string Address { get; set; } = string.Empty;
        [Required]
        [MaxLength(50)]
        public string Telephone { get; set; } = string.Empty;
    }
}
