using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDMVVM.Data.Abstractions;
using ForeignKeyAttribute = System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute;

namespace ToDMVVM.MVVM.Models
{
    public class Player : TableData
    {
        [Unique, SQLite.MaxLength(55)]
        public string? Name { get; set; }
      
        public int? Age { get; set; }

        public bool? OldEnoughToDrink =>
            Age > 17 ? true : false;    

        [ForeignKey(nameof(Game))]
        public int GameId {  get; set; }
        

    }
}
