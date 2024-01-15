using ToDMVVM.Data.APIService;

namespace ToDMVVM.MVVM.Views;

public partial class Memes : ContentPage
{
	public Memes()
	{
		InitializeComponent();

		OnCreate();

	}

	private async void OnCreate()
	{
		
		MemeImage.Source = ImageSource.FromUri(new Uri(await ServiceLocator.memeService.GetMeme()));
    }

	private void CaptureSmileOnClick(object sender, EventArgs e)
	{
        Navigation.PushAsync(new MobileFunctions());
    }

}