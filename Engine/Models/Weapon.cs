using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
       

        public int MaxmimumDamage{get;set;}
        public  int MinmimumDamage { get; set; }
        public Weapon(int itemTypeId, string name, int price, string imageName, int minmimumDamage,int maxmimumDamage) :base(itemTypeId,  name,price, imageName)
        {
            
            this.MaxmimumDamage = maxmimumDamage;
            this.MinmimumDamage = minmimumDamage;
        }

        public new Weapon  Clone()
        {
            return new Weapon(this.ItemTypeID, this.Name, this.Price, this.ImageName ,this.MinmimumDamage, this.MaxmimumDamage);
        }


       
    }
}
