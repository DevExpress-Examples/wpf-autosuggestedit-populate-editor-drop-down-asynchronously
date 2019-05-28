using DevExpress.Xpf.Core;
using DevExpress.Xpf.Editors;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InfiniteAsyncSourceODataSample {
    public partial class MainWindow : ThemedWindow {
        static IQueryable<SCIssuesDemo> GetIssueDataQueryable() {
            var context = new SCEntities(new Uri("https://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"));
            return context.SCIssuesDemo;
        }

        static async Task<SCIssuesDemo[]> GetItems(string text, CancellationToken token) {
            await Task.Delay(1000, token);
            return await Task.Run(() => {
                return string.IsNullOrEmpty(text) || text.Length < 3 ? null : GetIssueDataQueryable().Where(x => x.Subject.Contains(text)).Take(20).ToArray();
            }, token);
        }

        CancellationTokenSource source;

        public MainWindow() {
            InitializeComponent();
        }

        async void QuerySubmitted(object sender, AutoSuggestEditQuerySubmittedEventArgs e) {
            if (source != null)
                source.Cancel();
            source = new CancellationTokenSource();
            var token = source.Token;
            try {
                autoSuggestEdit.ItemsSource = await GetItems(e.Text, token);
            }
            catch (OperationCanceledException) { }
        }

        void SuggestionChosen(object sender, AutoSuggestEditSuggestionChosenEventArgs e) {
            layoutControl.CurrentItem = e.SelectedItem;
        }
    }
}