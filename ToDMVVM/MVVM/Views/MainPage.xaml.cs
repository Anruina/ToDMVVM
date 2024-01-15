using ToDMVVM.MVVM.Views;

namespace ToDMVVM
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void StartGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Memes());
        }
        private void ModifyGame_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListQuestionPage());
        }
        private void LoginSignIn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UserLoginPage());
        }
    }

}
