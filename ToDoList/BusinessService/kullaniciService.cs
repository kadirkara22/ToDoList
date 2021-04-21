using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Database;
using ToDoList.Entities;

namespace ToDoList.BusinesServis
{
   public class kullaniciService
    {
        public kullanici kullaniciKontrol(string kullaniciAdi,string sifre)
        {
            return Sanaldatabase.kullaniciTablo.Where(x => x.kullaniciAdi == kullaniciAdi && x.sifre == sifre).FirstOrDefault();
        }
    }
}
