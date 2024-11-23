using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SISARASA.Class
{
    public class Pembeli : Pengguna
    {
        private string _alamat;
        private string _noHp;

        //Properties
        public string Alamat
        {
            get => _alamat;
            set => _alamat = value ?? throw new ArgumentNullException("Masukkan alamat!");
        }
        public string NoHp
        {
            get => _noHp;
            set => _noHp = value ?? throw new ArgumentNullException("Masukkan nomor HP!");
        }

        //Methods
        public bool UpdateAlamat(string alamat)
        {
            if (alamat != "")
            {
                this.Alamat = alamat;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool UpdateNoHp(string noHp)
        {
            if (noHp != "")
            {
                this.NoHp = noHp;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
