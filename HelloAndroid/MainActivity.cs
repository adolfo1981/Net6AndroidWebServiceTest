using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using ServiceReference1;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            try
            {
                var soapClient = new WebServiceSoapClient(WebServiceSoapClient.EndpointConfiguration.WebServiceSoap);
                //Sync test
                //var helloResponse = soapClient.HelloWorld();
                //Async test
                var helloResponse = await soapClient.HelloWorldAsync();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}