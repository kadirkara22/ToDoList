using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Database;
using ToDoList.Entities;

namespace ToDoList.BusinessService
{
   public class todoService
    {
       

        public int kayitKontrol()
        {
            return Sanaldatabase.todoTablo.Count;
        }
        public List<todo> kayitListe()
        {
            return Sanaldatabase.todoTablo;
        }
        public int kayitYeni(todo data)
        {
            try
            {
                Sanaldatabase.todoTablo.Add(data);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
