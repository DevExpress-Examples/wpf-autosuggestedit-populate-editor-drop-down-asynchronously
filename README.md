<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/189000401/19.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828691)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
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
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-autosuggestedit-populate-editor-drop-down-asynchronously&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-autosuggestedit-populate-editor-drop-down-asynchronously&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
