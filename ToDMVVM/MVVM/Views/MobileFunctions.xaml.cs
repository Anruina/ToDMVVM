
using Plugin.LocalNotification;
using System.Runtime.CompilerServices;

namespace ToDMVVM.MVVM.Views;

public partial class MobileFunctions : ContentPage
{
	public MobileFunctions()
	{
		InitializeComponent();
	}

	private void cameraView_camerasLoaded(object sender, EventArgs e)
	{
		cameraView.Camera = cameraView.Cameras.First();

		MainThread.BeginInvokeOnMainThread(new Action(async () =>
		{
            await cameraView.StopCameraAsync();
            await cameraView.StartCameraAsync();
		
		}));

	}

	private void Captured_Clicked(object sender, EventArgs e)
	{
		myImage.Source = cameraView.GetSnapShot(Camera.MAUI.ImageFormat.PNG);
	}

	private void PushNotification_Clicked(object sender, EventArgs e)
	{
		var request = new NotificationRequest
		{
			NotificationId = 1337,
			Title = "Wanna play a game?",
			Subtitle = "Truth Or Drink",
			Description = "Start having some fun, ask your friends some way too personal questions!",
			BadgeNumber = 42,
			Schedule = new NotificationRequestSchedule
			{
				NotifyTime = DateTime.Now.AddSeconds(5),
				NotifyRepeatInterval = TimeSpan.FromSeconds(30),

			}
		};
		
		LocalNotificationCenter.Current.Show(request);
	}
}