using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SISARASA.Class
{
    public class Pengguna
    {
        [Key]
        public int id { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
        public string? role { get; set; }
        public string? image { get; set; }
        public string? alamat { get; set; }
        public string? telephone { get; set; }

        public string Register(string username, string email, string password, string role)
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.username == username || u.email == email))
                {
                    return "Pengguna sudah ada!";
                }

                var user = new Pengguna
                {
                    username = username,
                    email = email,
                    password = password,
                    role = role
                };

                context.Users.Add(user);
                context.SaveChanges();
                return "Register sukses!";
            }
        }
    }
}
