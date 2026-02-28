namespace URI_Parameter_Passing
{
    [QueryProperty(nameof(Username), "Username")]
    [QueryProperty(nameof(Email), "Email")]
    public partial class ProfilePage : ContentPage
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public ProfilePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            UsernameLabel.Text = $"Username: {Username ?? ""}";
            EmailLabel.Text = $"Email: {Email ?? ""}";
        }

        private void OnGoToSignupClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SignupPage));
        }
    }
}
