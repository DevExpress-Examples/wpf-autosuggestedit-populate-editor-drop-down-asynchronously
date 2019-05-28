# How to populate AutoSuggestEdit asynchronously

In this example, we created an asynchronous [QuerySubmitted](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit.QuerySubmitted) event handler and used [CancellationTokenSource](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtokensource) since a user can change the editor's text without waiting for the previous query result.

We used [DataServiceContext](https://docs.microsoft.com/en-us/dotnet/api/system.data.services.client.dataservicecontext) to load data from our demo service, and can replace it with any other appropriate data source.

 See also:
 
 [How to use AutoSuggestEdit with InfiniteAsyncSource]()