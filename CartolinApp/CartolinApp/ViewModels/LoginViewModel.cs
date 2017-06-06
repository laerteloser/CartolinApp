using CartolinApp.Services;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using CartolinApp.Helpers;

namespace CartolinApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        AzureService azureService;
        INavigation navigation;

        ICommand loginCommand;

        public ICommand LoginCommand => loginCommand ?? (loginCommand = new Command(async () => await ExecuteLoginCommandAsync()));

        public LoginViewModel(INavigation nav)
        {
            azureService = DependencyService.Get<AzureService>();
            navigation = nav;            
        }

        private async Task ExecuteLoginCommandAsync()
        {
            if (!(await LoginAsync()))
            {
                return;
            }
            else
            {
                var mainPage = new MainPage();
                await navigation.PushAsync(mainPage);

                RemovePageFromStack();
            }
        }

        private void RemovePageFromStack()
        {
            var existingPages = navigation.NavigationStack.ToList();
            foreach (var page in existingPages)
            {
                if (page.GetType() == typeof(LoginPage))
                {
                    navigation.RemovePage(page);
                }
            }
        }

        public Task<bool> LoginAsync()
        {
            if (Settings.IsLoggedIn)
            {
                return Task.FromResult(true);
            }

            return azureService.LoginAsync();
        }
    }
}