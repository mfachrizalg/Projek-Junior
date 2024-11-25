using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISARASA.Class
{
    public class Menu
    {
        [Key]
        public int id { get; set; }
        public int? kuantitas { get; set; }
        public string nama { get; set; }
        public string deskripsi { get; set; }
        public int harga { get; set; }
        public string gambar { get; set; }
        public int user_id { get; set; }
    }
}
