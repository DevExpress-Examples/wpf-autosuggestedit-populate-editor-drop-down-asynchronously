<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/189000401/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to populate AutoSuggestEdit asynchronously

In this example, we created an asynchronous [QuerySubmitted](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit.QuerySubmitted) event handler and used [CancellationTokenSource](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtokensource) since a user can change the editor's text without waiting for the previous query result.

We used [DataServiceContext](https://docs.microsoft.com/en-us/dotnet/api/system.data.services.client.dataservicecontext) to load data from our demo service, and can replace it with any other appropriate data source.

See also:
 
[How to use AutoSuggestEdit with InfiniteAsyncSource](https://github.com/DevExpress-Examples/How-to-use-AutoSuggestEdit-with-InfiniteAsyncSource)
