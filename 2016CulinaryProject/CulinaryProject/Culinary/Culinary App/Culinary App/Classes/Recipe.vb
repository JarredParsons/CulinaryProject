Public Class Recipe
    'Properties
    Public Property Name As String
    Public Property Items As New ArrayList()
    Public Property Use As Boolean
    'Variables
    Public Index As ULong

    Public Sub New()
        Recipes.Add(Me)
        Me.Index = Recipes.Count
        Use = True
    End Sub
    Public Sub RemoveItem(Item As String)
        For i As Integer = 0 To Items.Count - 1
            Dim strSplit() As String = Split(Items(i), ":")
            If strSplit(0) = Item Then
                Items.Remove(Items(i))
                Exit For
            End If
        Next
    End Sub
    Public Sub RemoveRecipe()
        Items.Clear()
        Me.Use = False
    End Sub
End Class
