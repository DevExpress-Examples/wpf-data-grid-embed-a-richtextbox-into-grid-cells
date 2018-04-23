Imports Microsoft.VisualBasic
Imports System.IO
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents

Namespace GridApplication
	Public Class RichTextBoxEx
		Inherits RichTextBox
		Private IsSettingText As Boolean

        Public Shared ReadOnly RtfTextProperty As DependencyProperty = DependencyProperty.Register("RtfText", GetType(String), GetType(RichTextBoxEx), New FrameworkPropertyMetadata(String.Empty, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, AddressOf OnRtfTextChanged))

		Private Shared Sub OnRtfTextChanged(ByVal d As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
			CType(d, RichTextBoxEx).LoadText()
		End Sub

		Public Property RtfText() As String
			Get
				Return TryCast(GetValue(RtfTextProperty), String)
			End Get
			Set(ByVal value As String)
				SetValue(RtfTextProperty, value)
			End Set
		End Property

		Protected Overrides Sub OnTextChanged(ByVal e As TextChangedEventArgs)
			Dim binding As Binding = BindingOperations.GetBinding(Me, RtfTextProperty)
			If binding IsNot Nothing AndAlso binding.Mode <> BindingMode.OneWay Then
				SaveText()
			End If
			MyBase.OnTextChanged(e)
		End Sub

		Private Sub LoadText()
			If IsSettingText Then
				Return
			End If

			Dim rtfText As String = Me.RtfText
			Document.Blocks.Clear()

			If (Not String.IsNullOrEmpty(rtfText)) Then
				Dim tr As New TextRange(Document.ContentStart, Document.ContentEnd)

				Using rtfMemoryStream As New MemoryStream(Encoding.ASCII.GetBytes(rtfText))

					tr.Load(rtfMemoryStream, DataFormats.Rtf)
				End Using
			End If
		End Sub

		Private Sub SaveText()
			Dim tr As New TextRange(Document.ContentStart, Document.ContentEnd)

			Dim CurrentText As String = tr.Text

			Using ms As New MemoryStream(CurrentText.Length * 2)
				tr.Save(ms, DataFormats.Rtf)
				Dim rtfText As String = ASCIIEncoding.Default.GetString(ms.ToArray())
				SetRtfText(rtfText)
			End Using
		End Sub

		Private Sub SetRtfText(ByVal value As String)
			IsSettingText = True
			Try
				RtfText = value
			Finally
				IsSettingText = False
			End Try
		End Sub
	End Class
End Namespace
