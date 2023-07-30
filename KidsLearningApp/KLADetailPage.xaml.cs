namespace KidsLearningApp;

public partial class KLADetailPage : ContentPage
{
    public KLADetailPage(string categoryName)
    {
        InitializeComponent();
        DisplayLearningResult(categoryName);
        Title = categoryName;

    }

    private void DisplayLearningResult(string categoryName)
    {
        LearningData data = new LearningData();
        switch (categoryName)
        {
            case "numbers":
                CvKids.ItemsSource = data.Numbers; break;
            case "letters":
                CvKids.ItemsSource = data.Letters; break;
            case "shapes":
                CvKids.ItemsSource = data.Shapes; break;
            case "color":
                CvKids.ItemsSource = data.Colors; break;
            case "fruits":
                CvKids.ItemsSource = data.Fruits; break;
            case "animals":
                CvKids.ItemsSource = data.Animals; break;
            default:
                break;
        }
    }

    private async void CvKids_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as LearningItem;
        await TextToSpeech.SpeakAsync(selectedItem.Name);

    }
}