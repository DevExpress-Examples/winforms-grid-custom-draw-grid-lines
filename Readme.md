<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128626886/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2826)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Custom draw grid lines

This example creates a custom grid control with the `CustomDrawGridLine` event that allows you to paint grid lines:

```csharp
private void myGridView1_CustomDrawGridLine(object sender, CustomDrawLineEventArgs e) {
    if(e.CellInfo != null)
        e.Appearance.BackColor = e.CellInfo.RowHandle % 2 == 0 ? Color.BlueViolet : Color.DarkOrange;
    else {
        e.Cache.FillRectangle(Brushes.CadetBlue, e.Bounds);
        e.Handled = true;
    }
}
```


## Files to Review

* [CustomDrawLineEventArgs.cs](./CS/WindowsApplication3/CustomDrawLineEventArgs.cs) (VB: [CustomDrawLineEventArgs.vb](./VB/WindowsApplication3/CustomDrawLineEventArgs.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [MyGridControl.cs](./CS/WindowsApplication3/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/WindowsApplication3/MyGridControl.vb))
* [MyGridPainter.cs](./CS/WindowsApplication3/MyGridPainter.cs) (VB: [MyGridPainter.vb](./VB/WindowsApplication3/MyGridPainter.vb))
* [MyGridRegistration.cs](./CS/WindowsApplication3/MyGridRegistration.cs) (VB: [MyGridRegistration.vb](./VB/WindowsApplication3/MyGridRegistration.vb))
* [MyGridView.cs](./CS/WindowsApplication3/MyGridView.cs) (VB: [MyGridView.vb](./VB/WindowsApplication3/MyGridView.vb))


## Documentation

* [Custom Painting](https://docs.devexpress.com/WindowsForms/3496/controls-and-libraries/data-grid/appearance-and-conditional-formatting/custom-painting)
