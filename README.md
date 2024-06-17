<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/189000401/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF AutoSuggestEdit - Populate Editor Drop-down Asynchronously

This example populates a drop-down list of suggestions in [AutoSuggestEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit) asynchronously:

![AutoSuggestEdit Async](./i/AutoSuggestEdit_Async.gif)

## Implementation Details

Сreate an asynchronous [QuerySubmitted](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit.QuerySubmitted) event handler and use [CancellationTokenSource](https://docs.microsoft.com/en-us/dotnet/api/system.threading.cancellationtokensource) for cases when users change editor text and do not wait for the previous query result.

The example uses [DataServiceContext](https://docs.microsoft.com/en-us/dotnet/api/system.data.services.client.dataservicecontext) to load data from our demo service, you can replace it with any other appropriate data source.

## Files to Review

* [MainWindow.xaml](./CS/MainWindow.xaml)
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))

## Documentation

* [AutoSuggestEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit)
* [AutoSuggestEdit.QuerySubmitted](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.AutoSuggestEdit.QuerySubmitted)

## More Examples

* [WPF AutoSuggestEdit - Use Data Grid with InfiniteAsyncSource as Editor Drop-down](https://github.com/DevExpress-Examples/wpf-autosuggestedit-use-grid-with-infiniteasyncsource-as-drop-down)
* [WPF Data Grid - Use AutoSuggestEditSettings](https://github.com/DevExpress-Examples/wpf-data-grid-use-autosuggesteditsettings)
