using CartolinApp.Services;
using CartolinApp.ViewModels;
using Xamarin.Forms;

namespace CartolinApp
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel => BindingContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
            var cartolaApiService = DependencyService.Get<ICartolaApiService>();
            BindingContext = new MainViewModel(cartolaApiService);
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            if (ViewModel != null)
                await ViewModel.LoadAsync();
        }
    }
}
