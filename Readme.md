<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128637310/15.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T328436)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomTreeList.cs](./CS/WindowsApplication3/CustomTreeList.cs) (VB: [CustomTreeList.vb](./VB/WindowsApplication3/CustomTreeList.vb))**
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
<!-- default file list end -->
# How to change an indent between root nodes in TreeList


<p>This example illustrates how to change an indent between root nodes. </p>


<h3>Description</h3>

Here, we create a custom&nbsp;<strong>TreeList</strong>&nbsp;and add a new&nbsp;<strong>RootNodeIndent</strong>&nbsp;property. To take this property into account when&nbsp;<strong>TreeList</strong>&nbsp;calculates its view information, we create a custom&nbsp;<strong>TreeListViewInfo</strong>&nbsp;class and override the&nbsp;<strong>TreeListViewInfo.CalcRowGroupInfo</strong>&nbsp;method.&nbsp;

<br/>


