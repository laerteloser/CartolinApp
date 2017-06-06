using System;
using System.Collections.Generic;
using CartolinApp.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Microsoft.WindowsAzure.MobileServices;
using CartolinApp.Droid;
using Xamarin.Forms;
using CartolinApp.Helpers;
using CartolinApp.Droid.Authentication;

[assembly: Xamarin.Forms.Dependency(typeof(SocialAuthentication))]
namespace CartolinApp.Droid.Authentication
{
    public class SocialAuthentication : IAuthentication
    {
        public async Task<MobileServiceUser> LoginAsync(MobileServiceClient client, MobileServiceAuthenticationProvider provider, 
            IDictionary<string,string> parameters = null)
        {
            try
            {
                var user = await client.LoginAsync(Forms.Context, provider);

                Settings.AuthToken = user?.MobileServiceAuthenticationToken ?? string.Empty;
                Settings.UserId = user?.UserId;

                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}