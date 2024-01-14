using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDMVVM.Data.Abstractions;
using ForeignKeyAttribute = System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute;

namespace ToDMVVM.MVVM.Models
{
    public class Category : TableData
    {
        [Unique]
        public string? Title { get; set; }

        //lijst van vragen
        //ÓneToMany
        [OneToMany(CascadeOperations=CascadeOperation.All)]
        public List<Question>? Questions { get; set; }
    }

}
