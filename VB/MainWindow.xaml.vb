Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Editors
Imports System.Threading
Imports System.Threading.Tasks

Namespace InfiniteAsyncSourceODataSample
    Partial Public Class MainWindow
        Inherits ThemedWindow

        Private Shared Function GetIssueDataQueryable() As IQueryable(Of SCIssuesDemo)
            Dim context = New SCEntities(New Uri("https://demos.devexpress.com/Services/WcfLinqSC/WcfSCService.svc/"))
            Return context.SCIssuesDemo
        End Function

        Private Shared Async Function GetItems(ByVal text As String, ByVal token As CancellationToken) As Task(Of SCIssuesDemo())
            Await Task.Delay(1000, token)
            Return Await Task.Run(Function() If(String.IsNullOrEmpty(text) OrElse text.Length < 3, Nothing, GetIssueDataQueryable().Where(Function(x) x.Subject.Contains(text)).Take(20).ToArray()), token)
        End Function

        Private source As CancellationTokenSource

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Async Sub QuerySubmitted(ByVal sender As Object, ByVal e As AutoSuggestEditQuerySubmittedEventArgs)
            If source IsNot Nothing Then
                source.Cancel()
            End If
            source = New CancellationTokenSource()
            Dim token = source.Token
            Try
                autoSuggestEdit.ItemsSource = Await GetItems(e.Text, token)
            Catch e1 As OperationCanceledException
            End Try
        End Sub

        Private Sub SuggestionChosen(ByVal sender As Object, ByVal e As AutoSuggestEditSuggestionChosenEventArgs)
            layoutControl.CurrentItem = e.SelectedItem
        End Sub
    End Class
End Namespace