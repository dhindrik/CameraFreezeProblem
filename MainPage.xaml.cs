namespace CameraFreezeProblem;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnTakePhotoClicked(object sender, EventArgs e)
	{
		var result = await MediaPicker.CapturePhotoAsync();
	}
}

