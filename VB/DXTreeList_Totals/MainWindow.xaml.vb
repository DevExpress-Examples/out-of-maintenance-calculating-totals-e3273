Imports System.Windows
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace DXTreeList_Totals

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits System.Windows.Window

        Public Sub New()
            Me.InitializeComponent()
            Me.treeListControl1.ItemsSource = DXTreeList_Totals.Stuff.GetStuff()
            Me.treeListControl1.View.ExpandAllNodes()
            Me.CreateTotal("Age", DevExpress.Data.SummaryItemType.Min)
            Me.CreateTotal("Age", DevExpress.Data.SummaryItemType.Max)
            Me.CreateTotal("Age", DevExpress.Data.SummaryItemType.Average)
        End Sub

        Private Sub CreateTotal(ByVal fieldName As String, ByVal summaryType As DevExpress.Data.SummaryItemType)
            Dim total As DevExpress.Xpf.Grid.TreeListSummaryItem = New DevExpress.Xpf.Grid.TreeListSummaryItem() With {.FieldName = fieldName, .SummaryType = summaryType, .ShowInColumn = fieldName}
            Me.treeListControl1.TotalSummary.Add(total)
        End Sub
    End Class
End Namespace
