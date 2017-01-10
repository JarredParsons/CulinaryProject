<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangeName
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
        Me.txtName = New Culinary_App.StrafeTextBox()
        Me.btnOK = New Culinary_App.StrafeButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.EnabledCalc = True
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(12, 36)
        Me.txtName.MaxLength = 32767
        Me.txtName.MultiLine = False
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = False
        Me.txtName.Size = New System.Drawing.Size(291, 34)
        Me.txtName.TabIndex = 0
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtName.UseSystemPasswordChar = False
        '
        'btnOK
        '
        Me.btnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOK.EnabledCalc = True
        Me.btnOK.Location = New System.Drawing.Point(217, 76)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 33)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(10, 14)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(293, 19)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Nothing"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmChangeName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(315, 116)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmChangeName"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Recipe Name"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtName As StrafeTextBox
    Friend WithEvents btnOK As StrafeButton
    Friend WithEvents lblName As Label
End Class
