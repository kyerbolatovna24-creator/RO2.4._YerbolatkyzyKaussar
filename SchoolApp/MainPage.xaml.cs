using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new Person();
    }

    private async void OnOpenStudentsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StudentsPage());
    }
}