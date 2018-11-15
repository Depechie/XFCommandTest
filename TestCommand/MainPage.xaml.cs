using TestCommand.ViewModels;
using Xamarin.Forms;

namespace TestCommand
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MainViewModel mainVM = new MainViewModel();

            this.BindingContext = mainVM;
        }
    }
}