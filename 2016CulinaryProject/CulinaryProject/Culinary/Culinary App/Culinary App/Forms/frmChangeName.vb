Public Class frmChangeName
    Public R As Recipe

    Private Sub frmChangeName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblName.Text = "Enter a new name for '" & R.Name & "'"
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If String.IsNullOrWhiteSpace(txtName.Text) Or Not Len(txtName.Text) > 3 Then
            MessageBox.Show("That name doesn't meet the requirements!" & vbCrLf & vbCrLf & "- Four or more characters" & vbCrLf & "- Contains more then just spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        With frmMain
            For Each Item As ListViewItem In .lstRecipes.Items
                If Item.Text = R.Index Then
                    dsRecipes.Tables(Item.SubItems(1).Text).TableName = txtName.Text
                    Item.SubItems(1).Text = txtName.Text
                    Exit For
                End If
            Next
        End With
        R.Name = txtName.Text
        Me.Dispose()
    End Sub
End Class