Imports System.IO
Imports Microsoft.Office.Interop
Module Functions
    Public con As New OleDb.OleDbConnection
    Public Sub SearchQuery(Query As String)
        Try
            Dim ds As New DataSet
            Dim da As OleDb.OleDbDataAdapter
            Dim inc As Integer
            Dim Success As Boolean = False

            da = New OleDb.OleDbDataAdapter(Query, con)
            da.Fill(ds, DatabaseName)

            With frmMain
                .lstItems.Items.Clear()
                For inc = 0 To ds.Tables(DatabaseName).Rows.Count - 1
                    Dim listitem As ListViewItem
                    Dim Data(3) As String
                    Data(0) = Convert.ToString(ds.Tables(DatabaseName).Rows(inc).Item(0))
                    Data(1) = Convert.ToString(ds.Tables(DatabaseName).Rows(inc).Item(2))
                    Data(2) = Convert.ToString(ds.Tables(DatabaseName).Rows(inc).Item(3))
                    Data(3) = Convert.ToString(ds.Tables(DatabaseName).Rows(inc).Item(4))
                    listitem = New ListViewItem(Data)

                    For i As Integer = 0 To Cart.Count - 1
                        If Data(0) = Cart(i) Then listitem.BackColor = InCartColor
                    Next
                    .lstItems.Items.Add(listitem)
                Next inc
                .lblResults.Text = .lstItems.Items.Count & " results"
            End With
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try
    End Sub
    Public Sub FillCategories()
        Dim ds As New DataSet
        Dim da As OleDb.OleDbDataAdapter
        Dim inc As Integer

        Try
            da = New OleDb.OleDbDataAdapter("SELECT DISTINCT Category FROM Culinary", con)
            da.Fill(ds, DatabaseName)

            With frmMain
                .lstItems.Items.Clear()
                .cmboType.Items.Clear()
                For inc = 0 To ds.Tables(DatabaseName).Rows.Count - 1
                    Dim Data As String = Convert.ToString(ds.Tables(DatabaseName).Rows(inc).Item(0))
                    .cmboType.Items.Add(Data)
                Next inc

                .cmboType.SelectedIndex = 0
                .lblResults.Text = "Database Loaded @ " & TimeOfDay
            End With

        Catch ex As Exception
            MessageBox.Show("There was a problem loading categories!" & vbCrLf & "Message: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub RemoveItem(No As Integer, ListView As ListView, Selected As Boolean)
        If Selected Then
            For Each Item In ListView.SelectedItems
                If Item.Text = No Then
                    Cart.Remove(Item.Text)
                    ListView.Items.Remove(Item)
                End If
            Next
        Else
            For Each Item In ListView.Items
                If Item.Text = No Then
                    Cart.Remove(Item.Text)
                    ListView.Items.Remove(Item)
                End If
            Next
        End If
    End Sub
    Public Sub AddToCart(No As String, ItemName As String, Increment As String, Price As String)
        Cart.Add(No)
        With frmMain
            Dim lviCart As New ListViewItem(No)
            lviCart.SubItems.Add(ItemName)
            .lstIngredients.Items.Add(lviCart)

            Dim lviReview As New ListViewItem(No)
            lviReview.SubItems.Add(ItemName)
            lviReview.SubItems.Add(Increment)
            lviReview.SubItems.Add(Price)
            .lstReview.Items.Add(lviReview)
            .grpCart.Text = "       Ingredients (" & Cart.Count & ")"
            .thReview.Text = "REVIEW (" & Cart.Count & ")"
        End With
    End Sub
    Public Sub ExportToExcel()
        With frmMain
            Try
                .Cursor = Cursors.WaitCursor
                Dim ExcelApp As Object, ExcelBook As Object
                Dim ExcelSheet As Object
                Dim i As Integer
                Dim j As Integer
                ExcelApp = CreateObject("Excel.Application")
                ExcelBook = ExcelApp.WorkBooks.Add
                ExcelSheet = ExcelBook.WorkSheets(1)

                With ExcelSheet
                    .Columns(1).ColumnWidth = 40
                    .Columns(2).ColumnWidth = 30
                    .Columns(3).ColumnWidth = 20
                    .cells(1, 1) = "Item Name"
                    .cells(1, 2) = "Increment"
                    .cells(1, 3) = "Price"
                    .cells(1, 1).EntireRow.Font.Bold = True
                End With

                For i = 2 To .lstReview.Items.Count
                    ExcelSheet.cells(i, 2) = .lstReview.Items(i - 2).Text
                    For j = 1 To .lstReview.Columns.Count - 1
                        ExcelSheet.cells(i, j) = .lstReview.Items(i - 1).SubItems(j).Text
                    Next
                Next
                ExcelApp.Visible = True
                ExcelSheet = Nothing
                ExcelBook = Nothing
                ExcelApp = Nothing
                .Cursor = Cursors.Default
            Catch ex As Exception
                .Cursor = Cursors.Default
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End With
    End Sub
End Module
