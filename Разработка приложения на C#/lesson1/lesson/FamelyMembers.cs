using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Спроектируйте программу для построения генеалогического дерева. Учтите что у нас есть члены семьи у кого нет детей(дет). 
  Есть члены семьи у кого дети есть (взрослые). Есть мужчины и женщины.*/

namespace lesson
{
    public class FamelyMambers
    {
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public string FullName { get; set; }
        public FamelyMambers Mother { get; set; }
        public FamelyMambers Father { get; set; }
        public FamelyMambers Son {  get; set; }

        public FamelyMambers[] GetGrandMotherName()
        {
            return new FamelyMambers[] { Mother?.Mother, Father?.Mother };
        }
        public FamelyMambers[] GetGrandFatherName()
        {
            return new FamelyMambers[] { Father?.Father, Mother?.Father };
        }
        public FamelyMambers[] GetFatherParentsName()
        {
            return new FamelyMambers[] { Father?.Father, Father?.Mother };
        }
        public FamelyMambers[] GetMotherParentsName()
        {
            return new FamelyMambers[] { Mother?.Father, Mother?.Mother };
        }
        public FamelyMambers[] GetSonParentsName()
        {
            return new FamelyMambers[] { Father, Mother };
        }
        
    }

    public enum Gender { men, woman };
}
