using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDMVVM.MVVM.Models;

namespace ToDMVVM.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class QuestionDataViewModel
    {
        public List<Question>? Questions { get; set; }
        public List<Category>? Categories { get; set; }
        public Question? CurrentQuestion { get; set; }
        public Category? CurrentCategory { get; set; }

        public ICommand CreateQuestionCommand { get; set; }

        public ICommand DeleteQuestionCommand { get; set; }

        public QuestionDataViewModel()
        {
            Refresh();

            CreateQuestionCommand = new Command(async () =>
            {
                App.QuestionRepo.SaveEntityWithChildren(CurrentQuestion);
                Console.WriteLine(App.QuestionRepo.StatusMessage);
                Refresh();
            });

            DeleteQuestionCommand = new Command(() =>
            {
                App.QuestionRepo.DeleteEntity(CurrentQuestion);
                Refresh();
            });

            
        }

        private void Refresh()
        {
            Categories = App.CategoryRepo.GetEntities();
            Questions = App.QuestionRepo.GetEntities();
        }
        
        

    }
}
