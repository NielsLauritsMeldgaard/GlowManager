using Xamarin.Forms;

namespace BuetoothToArduinoTest
{
    public class App : Application
    {
        public App()
        {
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            MainPage = new BuetoothToArduinoTest.MainPage();
        }
        
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
