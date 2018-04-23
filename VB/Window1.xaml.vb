Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Editors

Namespace GridApplication

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
			Dim dataSet As New DataSet()
			dataSet.ReadXml("Cars2.xml")
			grid.DataSource = dataSet.Tables(0)
		End Sub
	End Class

	Public Class RichTextEdit
		Inherits TextEdit
		Protected Overrides Function NeedsKey(ByVal key As Key, ByVal modifiers As ModifierKeys) As Boolean
			If EditMode = EditMode.InplaceActive AndAlso key = Key.Enter AndAlso (modifiers And ModifierKeys.Control) = 0 Then
				Return True
			End If

			Return MyBase.NeedsKey(key, modifiers)
		End Function
	End Class
End Namespace
