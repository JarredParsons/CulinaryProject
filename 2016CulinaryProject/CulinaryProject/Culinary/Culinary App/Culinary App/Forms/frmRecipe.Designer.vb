<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipe
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblItemsCount = New System.Windows.Forms.Label()
        Me.btnOK = New Culinary_App.StrafeButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.mnuItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRemoveItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StrafeSeparator1 = New Culinary_App.StrafeSeparator()
        Me.mnuItems.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItemsCount
        '
        Me.lblItemsCount.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemsCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblItemsCount.Location = New System.Drawing.Point(212, 12)
        Me.lblItemsCount.Name = "lblItemsCount"
        Me.lblItemsCount.Size = New System.Drawing.Size(38, 19)
        Me.lblItemsCount.TabIndex = 1
        Me.lblItemsCount.Text = "0"
        Me.lblItemsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.EnabledCalc = True
        Me.btnOK.Location = New System.Drawing.Point(145, 250)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(105, 28)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(12, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(194, 19)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Nothing"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'mnuItems
        '
        Me.mnuItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRemoveItems})
        Me.mnuItems.Name = "mnuItems"
        Me.mnuItems.Size = New System.Drawing.Size(158, 48)
        '
        'mnuRemoveItems
        '
        Me.mnuRemoveItems.Name = "mnuRemoveItems"
        Me.mnuRemoveItems.Size = New System.Drawing.Size(157, 22)
        Me.mnuRemoveItems.Text = "Remove Item(s)"
        '
        'lstItems
        '
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chID, Me.chName})
        Me.lstItems.ContextMenuStrip = Me.mnuItems
        Me.lstItems.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstItems.FullRowSelect = True
        Me.lstItems.Location = New System.Drawing.Point(9, 46)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(241, 198)
        Me.lstItems.TabIndex = 9
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'chID
        '
        Me.chID.Text = "ID"
        Me.chID.Width = 40
        '
        'chName
        '
        Me.chName.Text = "Item Name"
        Me.chName.Width = 180
        '
        'StrafeSeparator1
        '
        Me.StrafeSeparator1.Location = New System.Drawing.Point(9, 34)
        Me.StrafeSeparator1.Name = "StrafeSeparator1"
        Me.StrafeSeparator1.Size = New System.Drawing.Size(241, 6)
        Me.StrafeSeparator1.TabIndex = 3
        Me.StrafeSeparator1.Text = "StrafeSeparator1"
        '
        'frmRecipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(258, 282)
        Me.Controls.Add(Me.lstItems)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.StrafeSeparator1)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblItemsCount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRecipe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mnuItems.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblItemsCount As Label
    Friend WithEvents btnOK As StrafeButton
    Friend WithEvents StrafeSeparator1 As StrafeSeparator
    Friend WithEvents lblName As Label
    Friend WithEvents mnuItems As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuRemoveItems As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstItems As System.Windows.Forms.ListView
    Friend WithEvents chID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
End Class
