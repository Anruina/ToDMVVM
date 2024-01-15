namespace ToDMVVM.MVVM.Views;

public partial class UserLoginPage : ContentPage
{
	public UserLoginPage()
	{
		InitializeComponent();
	}

    public void LoginBtn_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(L_UsernameEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(L_PasswordEntry.Text);

        if (isUsernameEmpty)
        {
            L_UsernameEntry.Placeholder = "Cannot be Empty";
        }
        else if (isPasswordEmpty)
        {
            L_PasswordEntry.Placeholder = "Cannot be Empty";
        }
        else if (L_UsernameEntry.Text == "admin" && L_PasswordEntry.Text == "notadmin")
        {
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            L_UsernameEntry.Placeholder = "Is incorrect or does not match";
            L_PasswordEntry.Placeholder = "Is incorrect or does not match";
        }
    }

    public void RegisterBtn_Clicked(Object sender, EventArgs e)
    {
        LoginForm.IsVisible=!LoginForm.IsVisible;

        RegisterForm.IsVisible = !RegisterForm.IsVisible;

        RegisterButtons.IsVisible = !RegisterButtons.IsVisible;

        LoginButtons.IsVisible = !LoginButtons.IsVisible;
    }

    public void CreateBtn_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(R_UsernameEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(R_PasswordEntry.Text);
        bool isEmailEmpty = string.IsNullOrEmpty(R_EmailEntry.Text);
        bool isDateOfBirthEmpty = string.IsNullOrEmpty(R_DateOfBirthEntry.Date.ToString());

        if (isUsernameEmpty)
        {
            R_UsernameEntry.Placeholder = "Cannot be Empty";
        }
        else if (isPasswordEmpty)
        {
            R_PasswordEntry.Placeholder = "Cannot be Empty";
        }
        else if (isEmailEmpty)
        {
            R_EmailEntry.Placeholder = "Cannot be Empty";
        }

        else if (R_UsernameEntry.Text == "admin" && R_PasswordEntry.Text == "notadmin" && R_EmailEntry.Text =="admin@gmail.com")
        {
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            R_UsernameEntry.Placeholder = "Is incorrect or does not match";
            R_PasswordEntry.Placeholder = "Is incorrect or does not match";
        }
    }

    public void CancelBtn_Clicked(object sender, EventArgs e)
    {
        LoginForm.IsVisible=!LoginForm.IsVisible;

        RegisterForm.IsVisible = !RegisterForm.IsVisible;

        RegisterButtons.IsVisible = !RegisterButtons.IsVisible;

        LoginButtons.IsVisible = !LoginButtons.IsVisible;
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {

    }

}