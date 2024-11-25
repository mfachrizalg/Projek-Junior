using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISARASA.Class
{
    public class Notifikasi
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public string deskripsi { get; set; }
    }
}
