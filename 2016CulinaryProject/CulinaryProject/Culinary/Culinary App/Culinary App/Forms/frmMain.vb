Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\" & DatabaseName & ".accdb"
        con.ConnectionString = dbProvider
        con.Open()
        tabControl.SelectedIndex = 1
        FillCategories()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim CleanedSQL As String = Regex.Replace(txtSearch.Text, "[^A-Za-z0-9\-/. ]", "")
        SearchQuery("SELECT ID, Category, ItemName, Increment, Price FROM Culinary WHERE ItemName LIKE '%" & CleanedSQL & "%' OR Category LIKE '%" & CleanedSQL & "%' OR Increment LIKE '%" & CleanedSQL & "%' OR Price LIKE '%" & CleanedSQL & "%'")
    End Sub
    Private Sub cmboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboType.SelectedIndexChanged
        SearchQuery("SELECT * FROM Culinary WHERE Category = '" & cmboType.Text & "'")
    End Sub
    Private Sub mnuAddToCart_Click(sender As Object, e As EventArgs) Handles mnuAddToCart.Click
        For Each Item As ListViewItem In lstItems.SelectedItems
            If Cart.Contains(Item.Text) Then
                MessageBox.Show("That item already exist in the cart")
            Else
                AddToCart(Item.Text, Item.SubItems(1).Text, Item.SubItems(2).Text, Item.SubItems(3).Text)
                Item.BackColor = InCartColor
            End If
        Next
    End Sub
    Private Sub pbRefresh_Click(sender As Object, e As EventArgs) Handles pbRefresh.Click
        FillCategories()
    End Sub
    Private Sub mnuImages_Click(sender As Object, e As EventArgs) Handles mnuImages.Click
        Try
            Process.Start("https://www.google.com/search?q=" & Replace(lstItems.SelectedItems(0).SubItems(1).Text, " ", "+") & "&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiol7zah6_MAhXIGj4KHY_3BhcQ_AUICCgC&biw=1920&bih=1099")
        Catch ex As Exception
            MessageBox.Show("There was a problem viewing online!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mnuInformation_Click(sender As Object, e As EventArgs) Handles mnuInformation.Click
        Try
            Process.Start("https://www.google.com/#q=" & Replace(lstItems.SelectedItems(0).SubItems(1).Text, " ", "+"))
        Catch ex As Exception
            MessageBox.Show("There was a problem viewing online!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
        Try
            For Each item As ListViewItem In lstIngredients.SelectedItems
                RemoveItem(item.Text, lstReview, False)
                RemoveItem(item.Text, lstIngredients, True)
                For i As Integer = 0 To lstItems.Items.Count - 1
                    If lstItems.Items(i).Text = item.Text Then
                        lstItems.Items(i).BackColor = Color.White
                        Exit For
                    End If
                Next
                grpCart.Text = "       Ingredients (" & Cart.Count & ")"
                thReview.Text = "REVIEW (" & Cart.Count & ")"
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnAdvanced_Click(sender As Object, e As EventArgs) Handles btnAdvanced.Click
        tabControl.SelectedIndex = 3
    End Sub
    Private Sub btnAddRecipe_Click(sender As Object, e As EventArgs) Handles btnAddRecipe.Click
        Dim R As New Recipe

        With R
            For Each item As ListViewItem In lstReview.Items
                R.Items.Add(item.Text & ":" & item.SubItems(1).Text & ":" & item.SubItems(3).Text & "/" & item.SubItems(2).Text)
            Next
            .Name = "Recipe Costing " & .Index
            Dim lvi As New ListViewItem(.Index)
            lvi.SubItems.Add("Recipe Costing " & .Index)
            lvi.SubItems.Add(.Items.Count)
            lstRecipes.Items.Add(lvi)
        End With


        Cart.Clear()
        lstIngredients.Items.Clear()
        lstReview.Items.Clear()
        FillCategories()
        tabControl.SelectedIndex = 1
        grpCart.Text = "       Ingredients (" & Cart.Count & ")"
        thReview.Text = "REVIEW (0)"
        thDone.Text = "COMPLETED (" & Recipes.Count & ")"
        MessageBox.Show("Succesfully added " & R.Items.Count & " items to receipe #" & R.Index, "Culinary", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub mnuViewItems_Click(sender As Object, e As EventArgs) Handles mnuViewItems.Click
        For Each Item As ListViewItem In lstRecipes.SelectedItems
            Dim VR As New frmRecipe
            Dim R As Recipe = Recipes(Convert.ToInt32(Item.Text))
            VR.R = R
            VR.Show()
        Next
    End Sub
    Private Sub EditNameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNameToolStripMenuItem.Click
        Dim CN As New frmChangeName
        For Each Item As ListViewItem In lstRecipes.SelectedItems
            Dim R As Recipe = Recipes(Convert.ToInt32(Item.Text))
            With CN
                .R = R
                .Show()
            End With
        Next
    End Sub

    Private Sub mnuRemoveRecipe_Click(sender As Object, e As EventArgs) Handles mnuRemoveRecipe.Click
        For Each Item As ListViewItem In lstRecipes.SelectedItems
            lstRecipes.Items.Remove(Item)
            Dim R As Recipe = Recipes(Convert.ToInt32(Item.Text))
            R.RemoveRecipe()
            thDone.Text = "COMPLETED (" & Recipes.Count & ")"
        Next
    End Sub

    Private Sub mnuRemoveIngredients_Click(sender As Object, e As EventArgs) Handles mnuRemoveIngredients.Click
        For Each item As ListViewItem In lstReview.SelectedItems
            RemoveItem(Convert.ToInt32(item.Text), lstReview, True)
            RemoveItem(Convert.ToInt32(item.Text), lstIngredients, False)
        Next
        grpCart.Text = "       Ingredients (" & Cart.Count & ")"
        thReview.Text = "REVIEW (" & Cart.Count & ")"
    End Sub
End Class
