namespace TaskManager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string username = "sajjad";
        string password = "1234567*";

        private void PasswordShow(object sender, EventArgs e)
        {
            passwordEntry.IsPassword = !passwordEntry.IsPassword;
        }

        private void LoginButton(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameEntry.Text) && !string.IsNullOrEmpty(passwordEntry.Text))
            {
                if (userNameEntry.Text == username && passwordEntry.Text == password)
                {
                    App.Current.MainPage = new HomePage();
                    
                }
                else
                {
                    DisplayAlert("Hoooy", "Huh", "Bede sish");
                }
            }
            else
            {
                DisplayAlert("Hoooy", "Huh", "Bede sish");
            }
        }
    }

}
