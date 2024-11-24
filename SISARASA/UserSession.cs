using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISARASA
{
    public static class UserSession
    {
        public static int Id { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string Role { get; set; }
        public static string? Alamat { get; set; }
        public static string? Image { get; set; }
        public static string? NoTelephone { get; set; }
    }
}
