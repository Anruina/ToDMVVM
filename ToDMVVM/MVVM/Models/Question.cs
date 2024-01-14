using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDMVVM.Data.Abstractions;
using SQLite;
using SQLiteNetExtensions.Attributes;
using ForeignKeyAttribute = System.ComponentModel.DataAnnotations.Schema.ForeignKeyAttribute;

namespace ToDMVVM.MVVM.Models
{
    public class Question : TableData
    {
        [Unique, SQLite.MaxLength(120)]
        public string? Description { get; set; }


        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }


        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Category? Category { get; set; }


        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }

        
        [ManyToOne(CascadeOperations = CascadeOperation.CascadeRead)]
        public Game? Game {  get; set; }   
    }
}
