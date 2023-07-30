namespace KidsLearningApp;

public partial class KidsLearningApp : ContentPage
{

	public KidsLearningApp()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		var button = (ImageButton)sender;
        Navigation.PushAsync(new KLADetailPage(button.CommandParameter.ToString()));

    }
}