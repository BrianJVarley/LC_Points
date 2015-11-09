using Facebook;
using LC_Points.View;
using LC_Points.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Security.Authentication.Web;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using WinRTXamlToolkit.Controls.DataVisualization.Charting;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace LC_Points
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        private MainViewModel ViewModel;



        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
            ViewModel = new MainViewModel();
            this.DataContext = ViewModel;

        }


      

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            
        }


        private async void shareBtn_Click(object sender, RoutedEventArgs e)
        {
            await ShareScore();
        }



        private async Task ShareScore()
        {
            //Facebook app id
            var clientId = "573586446116744";
            //Facebook permissions
            var scope = "public_profile, email, publish_actions";

            
            var redirectUri = WebAuthenticationBroker.GetCurrentApplicationCallbackUri().ToString();
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = clientId,
                redirect_uri = redirectUri,
                response_type = "token",
                scope = scope
            });

            Uri startUri = loginUrl;
            Uri endUri = new Uri(redirectUri, UriKind.Absolute);

            WebAuthenticationBroker.AuthenticateAndContinue(startUri, endUri, null, WebAuthenticationOptions.None);

            var postArgs = new Dictionary<string, string>();
            postArgs["link"] = "http://allaboutwindowsphone.com/software/developer/Brian-Varley.php";
            postArgs["name"] = "More from BV Apps..";
            postArgs["message"] = "I'm using LC Points to calculate my Leaving Cert Points!";
            await fb.PostTaskAsync("[pageid]/feed/", postArgs);

           
           
            


        }

            
        
    }
}
