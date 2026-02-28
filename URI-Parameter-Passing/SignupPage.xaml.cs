namespace URI_Parameter_Passing
{
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }
    

        private async void OnGoToProfileClicked(object sender, EventArgs e)
        {
            if (!VerifyInputs())
                return;

            var userData = new Dictionary<string, object>
            {
                { "Username", UsernameEntry.Text ?? "" },
                { "Email", EmailEntry.Text ?? "" },
            };
            await Shell.Current.GoToAsync(nameof(ProfilePage), userData);
        }

        private bool VerifyInputs()
        {
            if (string.IsNullOrWhiteSpace(UsernameEntry.Text) ||
                string.IsNullOrWhiteSpace(EmailEntry.Text) ||
                string.IsNullOrWhiteSpace(PasswordEntry.Text) ||
                string.IsNullOrWhiteSpace(ConfirmPasswordEntry.Text))
            {
                DisplayAlert("Error", "Please fill in all fields.", "OK");
                return false;
            }
            if (PasswordEntry.Text != ConfirmPasswordEntry.Text)
            {
                DisplayAlert("Error", "Passwords do not match.", "OK");
                return false;
            }
            return true;
        }
    }
}