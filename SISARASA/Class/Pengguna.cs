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
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        //Methods
        public bool Login(string username, string password)
        {
            using (var context = new AppDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.username == username && u.password == password);
                return user != null;
            }
        }
        public bool Register(string username, string email, string password, string role)
        {
            using (var context = new AppDbContext())
            {
                if (context.Users.Any(u => u.username == username || u.email == email))
                {
                    return false; // User already exists
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
                return true;
            }
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == this.password)
            {
                this.password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ChangeProfile(string username, string email)
        {
            if (username != "" && email != "")
            {
                this.username = username;
                this.email = email;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
