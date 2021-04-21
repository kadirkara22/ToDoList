using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities;

namespace ToDoList.Database
{
   public static class Sanaldatabase
    {
        public static List<kullanici> kullaniciTablo;
        public static List<todo> todoTablo;

        static Sanaldatabase()
        {
            kullaniciTablo = new List<kullanici>();
            kullaniciTablo.Add(new kullanici() { 
            id=Guid.NewGuid(),
            kullaniciAdi="test1",
            sifre="1"
            });

            todoTablo = new List<todo>();

        }
    }
}
