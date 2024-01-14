using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDMVVM.Data.Abstractions;

namespace ToDMVVM.MVVM.Models
{
    public class Game : TableData
    {
        //sets amount of questions
        public int QuestionAmount {  get; set; }

        //start of the game
        public DateTime? CreationDate { get; set; }

        //read the playernames
        [OneToMany(CascadeOperations = CascadeOperation.CascadeRead)]
        public List<Player>? Players { get; set; }

        //Read the questions
        [OneToMany(CascadeOperations =CascadeOperation.CascadeRead)]
        public List<Question>? Questions { get; set; }
    }
}
