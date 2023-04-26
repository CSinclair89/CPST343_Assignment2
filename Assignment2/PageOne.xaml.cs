namespace Assignment2;

public partial class PageOne : ContentPage
{
	public PageOne()
	{
		InitializeComponent();
    }

	void OnEntryTextChanged(object sender, TextChangedEventArgs e)
	{
        string oldText = e.OldTextValue;
        string newText = e.NewTextValue;
        string myText = MatchID.Text;
    }

	void OnEntryCompleted(object sender, EventArgs e)
	{
		string text = ((Entry)sender).Text;
	}
}