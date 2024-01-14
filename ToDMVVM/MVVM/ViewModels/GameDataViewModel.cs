using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDMVVM.MVVM.Models;

namespace ToDMVVM.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GameDataViewModel
    {

        public List<Models.Question>? Questions { get; set; }
        public Question? CurrentQuestion { get; set; }

        public List<Models.Category>? Categories { get; set; }
        public Category? CurrentCategory { get; set; }


        //commands
        public ICommand? DeleteCommand { get; set; }

        public ICommand? AddOrUpdateCommand { get; set; }

        public GameDataViewModel()
        {
            
        
        }
        
        private void Refresh()
        {

        }
    } 
}
