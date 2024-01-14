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


        
            if (QuestionRepo?.GetEntities().Count == 0) 
            {
                List<Category> categories = new List<Category>();
                List<Question> questions = new List<Question>();

                //Preset Categories
                Category AwkwardCategory = CategoryRepo.SaveEntity(new Category() { Title="Awkward Questions" });

                Category SpicyCategory = CategoryRepo.SaveEntity(new Category() { Title="Spicy Questions" });

                Category FunnyCategory = CategoryRepo.SaveEntity(new Category() { Title="Funny Questions" });

                //Preset Questions
                QuestionRepo.SaveEntity(new Question() { Description="Have you ever cheated on someone?", Category=SpicyCategory, CategoryId=SpicyCategory.Id });
                QuestionRepo.SaveEntity(new Question() { Description="What’s the one thing you’d do if you knew there were no consequences?", Category=SpicyCategory, CategoryId=SpicyCategory.Id });
                
                QuestionRepo.SaveEntity(new Question() { Description="What’s your biggest insecurity?", Category=AwkwardCategory, CategoryId=AwkwardCategory.Id });
                QuestionRepo.SaveEntity(new Question() { Description="What is your guilty pleasure?", Category=AwkwardCategory, CategoryId=AwkwardCategory.Id });

                QuestionRepo.SaveEntity(new Question() { Description="Where’s your favourite place to fart in public?", Category=FunnyCategory, CategoryId=FunnyCategory.Id });
                QuestionRepo.SaveEntity(new Question() { Description="What is the weirdest thing you have ever done in front of the mirror?", Category=FunnyCategory, CategoryId=FunnyCategory.Id });


            }

        }


    }
}
