using Xamarin.Forms;

namespace WebView
{
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        async void Handle_Navigated(object sender, Xamarin.Forms.WebNavigatedEventArgs e)
        {
            var canGoBack = webview.CanGoBack;
            var canGoFormware = webview.CanGoForward;
            await DisplayAlert("Estado",
                               "se ha terminado de cargar la pagina",
                               "Aceptar");
            if (canGoBack)
            {
                webview.GoBack();
            }
        }

         void  Handle_Navigating(object sender, Xamarin.Forms.WebNavigatingEventArgs e)
        {
            
           
        }
    }
}
