using ToDMVVM.Data.Repositories;
using ToDMVVM.MVVM.Models;

namespace ToDMVVM
{
    public partial class App : Application
    {
        public static BaseRepository<Category>? CategoryRepo { get; private set; }
        public static BaseRepository<Game>? GameRepo { get; private set; }
        public static BaseRepository<Player>? PlayerRepo { get; private set; }
        public static BaseRepository<Question>? QuestionRepo { get; private set; }


        public App(
            BaseRepository<Category>? categoryRepo,
            BaseRepository<Game>? gameRepo,
            BaseRepository<Player>? playerRepo,
            BaseRepository<Question>? questionRepo
            )
        {
            InitializeComponent();

            CategoryRepo = categoryRepo;
            GameRepo = gameRepo;
            PlayerRepo = playerRepo;
            QuestionRepo = questionRepo;


            MainPage = new AppShell();
        }
    }
}
