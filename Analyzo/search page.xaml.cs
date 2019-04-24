using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Union_Cup;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Analyzo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class search_page : ContentPage
    {
        public search_page()
        {
            InitializeComponent();
        }
        private string VideoID;
        private async void searchBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChartsPage());

            /* VideoID = search_txt.Text;
             IAnalysisApi analysis_api = ApiService.getApiService();
             var data = new Dictionary<string, object> {
                 {"num_of_comments", 200}
             };
             data.Add("video_id", VideoID);
             await analysis_api.getAnalysis(data).ContinueWith(post =>
             {
                 if (post.IsCompleted && post.Status == TaskStatus.RanToCompletion)
                 {
                     // Get result and update any UI here.
                     var post_res = post.Result;

                     string result = post_res.answer + ""; // For property serialized/deserialized using Newtonsoft.Json
                     if (result == "1")
                         result = "the most ratio is Psitive";
                     else
                         result = "the most ratio is Negative";

                     this.DisplayAlert(result, post.Status.ToString(), "OK");
                 }
                 else if (post.IsFaulted)
                 {
                     // If any error occurred exception throws.
                     this.DisplayAlert("post fault", "post fault", "ok");
                 }
                 else if (post.IsCanceled)
                 {
                     // Task cancelled
                     this.DisplayAlert("post canceled", "post canceled", "ok");
                 }
             }, TaskScheduler.FromCurrentSynchronizationContext())// execute in main/UI thread.
              .ConfigureAwait(false);*/
        }

    }
}