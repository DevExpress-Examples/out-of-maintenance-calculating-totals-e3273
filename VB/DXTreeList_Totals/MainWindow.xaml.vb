Imports Microsoft.VisualBasic
Imports System.Windows
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace DXTreeList_Totals
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			treeListControl1.ItemsSource = Stuff.GetStuff()
			treeListControl1.View.ExpandAllNodes()
			CreateTotal("Age", SummaryItemType.Min)
			CreateTotal("Age", SummaryItemType.Max)
			CreateTotal("Age", SummaryItemType.Average)
		End Sub

		Private Sub CreateTotal(ByVal fieldName As String, ByVal summaryType As SummaryItemType)
			Dim total As New TreeListSummaryItem() With {.FieldName = fieldName, .SummaryType = summaryType, .ShowInColumn = fieldName}
			treeListControl1.TotalSummary.Add(total)
		End Sub
	End Class
End Namespace
