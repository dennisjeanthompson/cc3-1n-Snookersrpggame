using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models
{
    public  class GameItem
    {
        public int  ItemTypeID { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }

        public string ImageName { get; set; }


        public  GameItem( int itemTypeId,string name,int price,string imageName)
            {
           this.ItemTypeID = itemTypeId;   
            this.Name = name;   
                this.Price = price;
            this.ImageName = imageName;
           

            }
        public GameItem Clone()
        {
            return new GameItem(this.ItemTypeID, this.Name, this.Price, this.ImageName);
        }


        /*  public virtual void Getinfo(string itemTypeId, string name, decimal price, string imageName)
          {
              this.ItemTypeID = itemTypeId;
              this.Name = name;
              this.Price = price;
              this.ImageName = imageName;
          }
      */
        ///imade dumb







    }

}
