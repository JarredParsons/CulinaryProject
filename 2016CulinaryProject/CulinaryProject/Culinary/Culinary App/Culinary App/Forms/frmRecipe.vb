Public Class frmRecipe
    Public R As Recipe
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Dispose()
    End Sub
    Private Sub frmRecipe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With R
            For i As Integer = 0 To R.Items.Count - 1
                Dim strSplit() As String = Split(R.Items(i), ":")
                Dim lvi As New ListViewItem(strSplit(0))
                lvi.SubItems.Add(strSplit(1))
                lstItems.Items.Add(lvi)
            Next
            lblName.Text = R.Name
            lblItemsCount.Text = lstItems.Items.Count
        End With
    End Sub
    Private Sub mnuRemoveItems_Click(sender As Object, e As EventArgs) Handles mnuRemoveItems.Click
        For Each Item As ListViewItem In lstItems.SelectedItems
            lstItems.Items.Remove(Item)
            R.RemoveItem(Item.Text)
        Next
        For Each Item As ListViewItem In frmMain.lstRecipes.Items
            If R.Index = Item.Text Then
                Item.SubItems(2).Text = R.Items.Count
                lblItemsCount.Text = R.Items.Count
                Exit For
            End If
        Next

        With R
            If .Items.Count = 0 Then
                .RemoveRecipe()
                RemoveItem(.Index, frmMain.lstRecipes, False)
                MessageBox.Show("There are zero items remaining in '" & .Name & "' the recipe is now being removed", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        End With
    End Sub
End Class