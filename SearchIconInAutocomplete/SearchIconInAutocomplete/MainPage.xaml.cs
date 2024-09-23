namespace SearchIconInAutocomplete
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            DisplayAlert("Search Text", $"You searched for: {autocomplete.Text}", "OK");
        }
    }

}
