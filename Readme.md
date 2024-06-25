<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650203/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2030)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Data Grid - Use a RichTextBox to Display and Edit Grid Data

This example illustrates how to embed a standard [RichTextBox](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.richtextbox) control into [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) cells. The [CellDisplayTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellDisplayTemplate) and [CellEditTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellEditTemplate) properties allow you to define different settings for display and edit modes.

![image](https://user-images.githubusercontent.com/65009440/208886885-74a1770d-082f-43a0-a1a6-fa40e0aab9d8.png)

## Files to Review

* [RichTextBoxEx.cs](./CS/RichTextBoxEx.cs) (VB: [RichTextBoxEx.vb](./VB/RichTextBoxEx.vb))
* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))

## Documentation

* [ColumnBase.CellDisplayTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellDisplayTemplate)
* [ColumnBase.CellEditTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellEditTemplate)
* [DataViewBase.GetActiveEditorNeedsKey](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.GetActiveEditorNeedsKey)
* [DataViewBase.ProcessEditorActivationAction](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.ProcessEditorActivationAction)
* [RichTextBox](https://learn.microsoft.com/en-us/dotnet/api/system.windows.controls.richtextbox)

## More Examples

* [WPF Data Grid - Specify Navigation in Custom Cell Editors](https://github.com/DevExpress-Examples/how-to-specify-navigation-in-custom-cell-editors)
* [WPF Data Grid - Use Custom Editors to Edit Cell Values](https://github.com/DevExpress-Examples/how-to-use-custom-editors-to-edit-cell-values-e1596)
* [WPF Data Grid - Assign a ComboBox Editor to a Column](https://github.com/DevExpress-Examples/wpf-data-grid-assign-combobox-editor-to-column)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-embed-a-richtextbox-into-grid-cells&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-embed-a-richtextbox-into-grid-cells&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
