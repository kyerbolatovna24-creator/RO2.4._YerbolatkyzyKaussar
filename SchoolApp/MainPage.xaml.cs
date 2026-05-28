using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Person();
    }

    // existing OnOpenStudentsClicked from L14 stays here unchanged
}