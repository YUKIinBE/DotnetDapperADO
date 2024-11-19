using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoutiqueManga.DAL.Entities
{
    /*
    [Id] INT NOT NULL PRIMARY KEY, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Firstname] NVARCHAR(50) NOT NULL,
    [Lastname] NVARCHAR(50) NOT NULL,
    [Email] NVARCHAR(250) NOT NULL, 
    [Address] NVARCHAR(250) NOT NULL,
    [Telephone] NVARCHAR(50) NOT NULL,
    [isSeller] BIT NOT NULL DEFAULT 0
    */
    public class User
    {
        public int Id { get; set; }
        public byte[] Password { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Telephone { get; set; } = string.Empty;
        public bool IsSeller { get; set; } = false;
    }
}
