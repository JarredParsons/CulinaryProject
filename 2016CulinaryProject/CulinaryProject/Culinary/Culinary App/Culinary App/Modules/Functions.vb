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
    Public Sub ExportToExcel(recipes)
        With frmMain
            Dim ExcelApp As Object, ExcelBook As Object
            ExcelApp = CreateObject("Excel.Application")
            ExcelBook = ExcelApp.Workbooks.Add
            Dim count = 1
            For Each recipe As DataTable In recipes.Tables
                Dim ExcelSheet As Object
                ExcelSheet = ExcelBook.Worksheets(count)
                count += 1
                ExcelSheet.name = recipe.TableName
                With ExcelSheet
                    .Columns(1).ColumnWidth = 40
                    .Columns(2).ColumnWidth = 30
                    .Columns(3).ColumnWidth = 20
                    .cells(1, 1) = recipe.TableName
                    .cells(2, 1) = recipe.Columns(0).ColumnName
                    .cells(2, 2) = recipe.Columns(1).ColumnName
                    .cells(2, 3) = recipe.Columns(2).ColumnName
                    .cells(2, 4) = recipe.Columns(3).ColumnName
                    .cells(2, 1).EntireRow.Font.Bold = True
                End With


                Dim row = 3
                For Each item In recipe.Rows
                    Dim col = 1
                    With ExcelSheet
                        .cells(row, col) = item("No")
                        col += 1
                        .cells(row, col) = item("ItemName")
                        col += 1
                        .cells(row, col) = item("Increment")
                        col += 1
                        .cells(row, col) = item("Price")
                    End With
                    row += 1

                Next



            Next
            Dim save = New SaveFileDialog()
            Dim filename
            If save.ShowDialog() = DialogResult.OK Then
                filename = save.FileName
            Else
                MessageBox.Show("Process Successfully Cancelled")
                ExcelBook.Close()
                Return
            End If
            Dim sc As StringComparison = StringComparison.CurrentCulture

            If filename.EndsWith(".xlsx", sc) Then
                ExcelBook.SaveAs(filename)
            Else
                ExcelBook.SaveAs(filename + ".xlsx")
            End If

            ExcelBook.Close()
            MessageBox.Show("Export Successful")

        End With

    End Sub
End Module
