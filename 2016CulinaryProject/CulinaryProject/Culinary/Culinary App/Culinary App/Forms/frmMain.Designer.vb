<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.mnuCatalog = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuAddToCart = New System.Windows.Forms.ToolStripMenuItem()
        Me.tss1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuViewOnline = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInformation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuImages = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIngredients = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRecipes = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuViewItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRemoveRecipe = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControl = New Culinary_App.StrafeTabControl()
        Me.thDASHBOARD = New System.Windows.Forms.TabPage()
        Me.tpCatalog = New System.Windows.Forms.TabPage()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.grpCart = New Culinary_App.StrafeGroupBox()
        Me.btnAdvanced = New Culinary_App.StrafeButton()
        Me.lstIngredients = New System.Windows.Forms.ListView()
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpSearch = New Culinary_App.StrafeGroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New Culinary_App.StrafeTextBox()
        Me.grpCategory = New Culinary_App.StrafeGroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.cmboType = New System.Windows.Forms.ComboBox()
        Me.lblSelectACategory = New System.Windows.Forms.Label()
        Me.lstItems = New System.Windows.Forms.ListView()
        Me.chNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chItemName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chIncrement = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.thReview = New System.Windows.Forms.TabPage()
        Me.tpIngredients = New System.Windows.Forms.TabPage()
        Me.btnAddRecipe = New Culinary_App.StrafeButton()
        Me.lstReview = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mnuIngredientsReview = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuRemoveIngredients = New System.Windows.Forms.ToolStripMenuItem()
        Me.thDone = New System.Windows.Forms.TabPage()
        Me.tpRecipes = New System.Windows.Forms.TabPage()
        Me.btnExport = New Culinary_App.StrafeButton()
        Me.lstRecipes = New System.Windows.Forms.ListView()
        Me.chMenuNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chRecipeName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chIngredients = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.mnuCatalog.SuspendLayout()
        Me.mnuIngredients.SuspendLayout()
        Me.mnuRecipes.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.tpCatalog.SuspendLayout()
        Me.grpCart.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSearch.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCategory.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpIngredients.SuspendLayout()
        Me.mnuIngredientsReview.SuspendLayout()
        Me.tpRecipes.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuCatalog
        '
        Me.mnuCatalog.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAddToCart, Me.tss1, Me.mnuViewOnline})
        Me.mnuCatalog.Name = "ContextMenuStrip1"
        Me.mnuCatalog.Size = New System.Drawing.Size(139, 54)
        '
        'mnuAddToCart
        '
        Me.mnuAddToCart.Name = "mnuAddToCart"
        Me.mnuAddToCart.Size = New System.Drawing.Size(138, 22)
        Me.mnuAddToCart.Text = "Add To Cart"
        '
        'tss1
        '
        Me.tss1.Name = "tss1"
        Me.tss1.Size = New System.Drawing.Size(135, 6)
        '
        'mnuViewOnline
        '
        Me.mnuViewOnline.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInformation, Me.mnuImages})
        Me.mnuViewOnline.Name = "mnuViewOnline"
        Me.mnuViewOnline.Size = New System.Drawing.Size(138, 22)
        Me.mnuViewOnline.Text = "View Online"
        '
        'mnuInformation
        '
        Me.mnuInformation.Name = "mnuInformation"
        Me.mnuInformation.Size = New System.Drawing.Size(137, 22)
        Me.mnuInformation.Text = "Information"
        '
        'mnuImages
        '
        Me.mnuImages.Name = "mnuImages"
        Me.mnuImages.Size = New System.Drawing.Size(137, 22)
        Me.mnuImages.Text = "Images"
        '
        'mnuIngredients
        '
        Me.mnuIngredients.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRemove})
        Me.mnuIngredients.Name = "ContextMenuStrip1"
        Me.mnuIngredients.Size = New System.Drawing.Size(118, 26)
        '
        'mnuRemove
        '
        Me.mnuRemove.Name = "mnuRemove"
        Me.mnuRemove.Size = New System.Drawing.Size(117, 22)
        Me.mnuRemove.Text = "Remove"
        '
        'mnuRecipes
        '
        Me.mnuRecipes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewItems, Me.EditNameToolStripMenuItem, Me.mnuRemoveRecipe})
        Me.mnuRecipes.Name = "mnuRecipes"
        Me.mnuRecipes.Size = New System.Drawing.Size(156, 70)
        '
        'mnuViewItems
        '
        Me.mnuViewItems.Name = "mnuViewItems"
        Me.mnuViewItems.Size = New System.Drawing.Size(155, 22)
        Me.mnuViewItems.Text = "View Items"
        '
        'EditNameToolStripMenuItem
        '
        Me.EditNameToolStripMenuItem.Name = "EditNameToolStripMenuItem"
        Me.EditNameToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.EditNameToolStripMenuItem.Text = "Edit Name"
        '
        'mnuRemoveRecipe
        '
        Me.mnuRemoveRecipe.Name = "mnuRemoveRecipe"
        Me.mnuRemoveRecipe.Size = New System.Drawing.Size(155, 22)
        Me.mnuRemoveRecipe.Text = "Remove Recipe"
        '
        'tabControl
        '
        Me.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabControl.Controls.Add(Me.thDASHBOARD)
        Me.tabControl.Controls.Add(Me.tpCatalog)
        Me.tabControl.Controls.Add(Me.thReview)
        Me.tabControl.Controls.Add(Me.tpIngredients)
        Me.tabControl.Controls.Add(Me.thDone)
        Me.tabControl.Controls.Add(Me.tpRecipes)
        Me.tabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabControl.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tabControl.ItemSize = New System.Drawing.Size(40, 180)
        Me.tabControl.Location = New System.Drawing.Point(0, 0)
        Me.tabControl.Multiline = True
        Me.tabControl.Name = "tabControl"
        Me.tabControl.OverIndex = -1
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.Size = New System.Drawing.Size(1247, 635)
        Me.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabControl.TabIndex = 0
        '
        'thDASHBOARD
        '
        Me.thDASHBOARD.BackColor = System.Drawing.Color.White
        Me.thDASHBOARD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thDASHBOARD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.thDASHBOARD.Location = New System.Drawing.Point(184, 4)
        Me.thDASHBOARD.Name = "thDASHBOARD"
        Me.thDASHBOARD.Padding = New System.Windows.Forms.Padding(3)
        Me.thDASHBOARD.Size = New System.Drawing.Size(1059, 627)
        Me.thDASHBOARD.TabIndex = 0
        Me.thDASHBOARD.Text = "DASHBOARD"
        '
        'tpCatalog
        '
        Me.tpCatalog.BackColor = System.Drawing.Color.White
        Me.tpCatalog.Controls.Add(Me.lblResults)
        Me.tpCatalog.Controls.Add(Me.grpCart)
        Me.tpCatalog.Controls.Add(Me.grpSearch)
        Me.tpCatalog.Controls.Add(Me.grpCategory)
        Me.tpCatalog.Controls.Add(Me.lstItems)
        Me.tpCatalog.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpCatalog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tpCatalog.Location = New System.Drawing.Point(184, 4)
        Me.tpCatalog.Name = "tpCatalog"
        Me.tpCatalog.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCatalog.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tpCatalog.Size = New System.Drawing.Size(1059, 627)
        Me.tpCatalog.TabIndex = 1
        Me.tpCatalog.Tag = "#3399ff"
        Me.tpCatalog.Text = "Catalog"
        '
        'lblResults
        '
        Me.lblResults.Location = New System.Drawing.Point(872, 180)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(181, 19)
        Me.lblResults.TabIndex = 6
        Me.lblResults.Text = "..."
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpCart
        '
        Me.grpCart.Controls.Add(Me.btnAdvanced)
        Me.grpCart.Controls.Add(Me.lstIngredients)
        Me.grpCart.Controls.Add(Me.PictureBox1)
        Me.grpCart.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.grpCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.grpCart.Location = New System.Drawing.Point(872, 329)
        Me.grpCart.Name = "grpCart"
        Me.grpCart.Size = New System.Drawing.Size(181, 290)
        Me.grpCart.TabIndex = 7
        Me.grpCart.TabStop = False
        Me.grpCart.Text = "       Ingredients (0)"
        '
        'btnAdvanced
        '
        Me.btnAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdvanced.EnabledCalc = True
        Me.btnAdvanced.Location = New System.Drawing.Point(5, 252)
        Me.btnAdvanced.Name = "btnAdvanced"
        Me.btnAdvanced.Size = New System.Drawing.Size(170, 32)
        Me.btnAdvanced.TabIndex = 8
        Me.btnAdvanced.Text = "Advanced"
        '
        'lstIngredients
        '
        Me.lstIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstIngredients.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chID, Me.chName})
        Me.lstIngredients.ContextMenuStrip = Me.mnuIngredients
        Me.lstIngredients.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstIngredients.FullRowSelect = True
        Me.lstIngredients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstIngredients.Location = New System.Drawing.Point(6, 22)
        Me.lstIngredients.Name = "lstIngredients"
        Me.lstIngredients.Size = New System.Drawing.Size(169, 224)
        Me.lstIngredients.TabIndex = 8
        Me.lstIngredients.UseCompatibleStateImageBehavior = False
        Me.lstIngredients.View = System.Windows.Forms.View.Details
        '
        'chID
        '
        Me.chID.Text = "ID"
        Me.chID.Width = 0
        '
        'chName
        '
        Me.chName.Text = "Item name"
        Me.chName.Width = 120
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Culinary_App.My.Resources.Resources.cart
        Me.PictureBox1.Location = New System.Drawing.Point(6, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.PictureBox2)
        Me.grpSearch.Controls.Add(Me.Label1)
        Me.grpSearch.Controls.Add(Me.txtSearch)
        Me.grpSearch.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.grpSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.grpSearch.Location = New System.Drawing.Point(872, 88)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(181, 89)
        Me.grpSearch.TabIndex = 6
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "      Search"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Culinary_App.My.Resources.Resources.search
        Me.PictureBox2.Location = New System.Drawing.Point(5, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Keywords"
        '
        'txtSearch
        '
        Me.txtSearch.EnabledCalc = True
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.txtSearch.Location = New System.Drawing.Point(6, 51)
        Me.txtSearch.MaxLength = 32767
        Me.txtSearch.MultiLine = False
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.ReadOnly = False
        Me.txtSearch.Size = New System.Drawing.Size(169, 25)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSearch.UseSystemPasswordChar = False
        '
        'grpCategory
        '
        Me.grpCategory.Controls.Add(Me.PictureBox3)
        Me.grpCategory.Controls.Add(Me.pbRefresh)
        Me.grpCategory.Controls.Add(Me.cmboType)
        Me.grpCategory.Controls.Add(Me.lblSelectACategory)
        Me.grpCategory.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Bold)
        Me.grpCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.grpCategory.Location = New System.Drawing.Point(872, 0)
        Me.grpCategory.Name = "grpCategory"
        Me.grpCategory.Size = New System.Drawing.Size(181, 84)
        Me.grpCategory.TabIndex = 5
        Me.grpCategory.TabStop = False
        Me.grpCategory.Text = "      Category"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Culinary_App.My.Resources.Resources.category
        Me.PictureBox3.Location = New System.Drawing.Point(6, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'pbRefresh
        '
        Me.pbRefresh.Image = Global.Culinary_App.My.Resources.Resources.refresh
        Me.pbRefresh.Location = New System.Drawing.Point(159, 27)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(16, 16)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbRefresh.TabIndex = 5
        Me.pbRefresh.TabStop = False
        '
        'cmboType
        '
        Me.cmboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboType.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmboType.FormattingEnabled = True
        Me.cmboType.Location = New System.Drawing.Point(8, 46)
        Me.cmboType.Name = "cmboType"
        Me.cmboType.Size = New System.Drawing.Size(167, 21)
        Me.cmboType.TabIndex = 3
        '
        'lblSelectACategory
        '
        Me.lblSelectACategory.AutoSize = True
        Me.lblSelectACategory.Location = New System.Drawing.Point(6, 31)
        Me.lblSelectACategory.Name = "lblSelectACategory"
        Me.lblSelectACategory.Size = New System.Drawing.Size(33, 12)
        Me.lblSelectACategory.TabIndex = 4
        Me.lblSelectACategory.Text = "Select"
        '
        'lstItems
        '
        Me.lstItems.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNo, Me.chItemName, Me.chIncrement, Me.chPrice})
        Me.lstItems.ContextMenuStrip = Me.mnuCatalog
        Me.lstItems.FullRowSelect = True
        Me.lstItems.GridLines = True
        Me.lstItems.Location = New System.Drawing.Point(7, 8)
        Me.lstItems.Name = "lstItems"
        Me.lstItems.Size = New System.Drawing.Size(859, 611)
        Me.lstItems.TabIndex = 2
        Me.lstItems.UseCompatibleStateImageBehavior = False
        Me.lstItems.View = System.Windows.Forms.View.Details
        '
        'chNo
        '
        Me.chNo.Text = "No."
        Me.chNo.Width = 80
        '
        'chItemName
        '
        Me.chItemName.Text = "Item Name"
        Me.chItemName.Width = 340
        '
        'chIncrement
        '
        Me.chIncrement.Text = "Increment"
        Me.chIncrement.Width = 200
        '
        'chPrice
        '
        Me.chPrice.Text = "Price"
        Me.chPrice.Width = 200
        '
        'thReview
        '
        Me.thReview.BackColor = System.Drawing.Color.White
        Me.thReview.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thReview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.thReview.Location = New System.Drawing.Point(184, 4)
        Me.thReview.Name = "thReview"
        Me.thReview.Size = New System.Drawing.Size(1059, 627)
        Me.thReview.TabIndex = 3
        Me.thReview.Text = "Review (0)"
        '
        'tpIngredients
        '
        Me.tpIngredients.BackColor = System.Drawing.Color.White
        Me.tpIngredients.Controls.Add(Me.btnAddRecipe)
        Me.tpIngredients.Controls.Add(Me.lstReview)
        Me.tpIngredients.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpIngredients.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tpIngredients.Location = New System.Drawing.Point(184, 4)
        Me.tpIngredients.Name = "tpIngredients"
        Me.tpIngredients.Size = New System.Drawing.Size(1059, 627)
        Me.tpIngredients.TabIndex = 5
        Me.tpIngredients.Tag = "#7fffd4"
        Me.tpIngredients.Text = "Ingredients"
        '
        'btnAddRecipe
        '
        Me.btnAddRecipe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddRecipe.EnabledCalc = True
        Me.btnAddRecipe.Location = New System.Drawing.Point(889, 580)
        Me.btnAddRecipe.Name = "btnAddRecipe"
        Me.btnAddRecipe.Size = New System.Drawing.Size(162, 39)
        Me.btnAddRecipe.TabIndex = 4
        Me.btnAddRecipe.Text = "Add Recipe"
        '
        'lstReview
        '
        Me.lstReview.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstReview.ContextMenuStrip = Me.mnuIngredientsReview
        Me.lstReview.FullRowSelect = True
        Me.lstReview.GridLines = True
        Me.lstReview.Location = New System.Drawing.Point(7, 8)
        Me.lstReview.Name = "lstReview"
        Me.lstReview.Size = New System.Drawing.Size(1044, 566)
        Me.lstReview.TabIndex = 3
        Me.lstReview.UseCompatibleStateImageBehavior = False
        Me.lstReview.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Item Name"
        Me.ColumnHeader2.Width = 340
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Increment"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.Width = 200
        '
        'mnuIngredientsReview
        '
        Me.mnuIngredientsReview.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRemoveIngredients})
        Me.mnuIngredientsReview.Name = "ContextMenuStrip1"
        Me.mnuIngredientsReview.Size = New System.Drawing.Size(153, 48)
        '
        'mnuRemoveIngredients
        '
        Me.mnuRemoveIngredients.Name = "mnuRemoveIngredients"
        Me.mnuRemoveIngredients.Size = New System.Drawing.Size(152, 22)
        Me.mnuRemoveIngredients.Text = "Remove"
        '
        'thDone
        '
        Me.thDone.BackColor = System.Drawing.Color.White
        Me.thDone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.thDone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.thDone.Location = New System.Drawing.Point(184, 4)
        Me.thDone.Name = "thDone"
        Me.thDone.Size = New System.Drawing.Size(1059, 627)
        Me.thDone.TabIndex = 2
        Me.thDone.Text = "Completed (0)"
        '
        'tpRecipes
        '
        Me.tpRecipes.BackColor = System.Drawing.Color.White
        Me.tpRecipes.Controls.Add(Me.btnExport)
        Me.tpRecipes.Controls.Add(Me.lstRecipes)
        Me.tpRecipes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tpRecipes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.tpRecipes.Location = New System.Drawing.Point(184, 4)
        Me.tpRecipes.Name = "tpRecipes"
        Me.tpRecipes.Size = New System.Drawing.Size(1059, 627)
        Me.tpRecipes.TabIndex = 4
        Me.tpRecipes.Tag = "#ff4040"
        Me.tpRecipes.Text = "Recipes"
        '
        'btnExport
        '
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.EnabledCalc = True
        Me.btnExport.Location = New System.Drawing.Point(889, 580)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(162, 39)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export"
        '
        'lstRecipes
        '
        Me.lstRecipes.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chMenuNo, Me.chRecipeName, Me.chIngredients})
        Me.lstRecipes.ContextMenuStrip = Me.mnuRecipes
        Me.lstRecipes.FullRowSelect = True
        Me.lstRecipes.GridLines = True
        Me.lstRecipes.Location = New System.Drawing.Point(7, 8)
        Me.lstRecipes.Name = "lstRecipes"
        Me.lstRecipes.Size = New System.Drawing.Size(1044, 566)
        Me.lstRecipes.TabIndex = 4
        Me.lstRecipes.UseCompatibleStateImageBehavior = False
        Me.lstRecipes.View = System.Windows.Forms.View.Details
        '
        'chMenuNo
        '
        Me.chMenuNo.Text = "No."
        Me.chMenuNo.Width = 80
        '
        'chRecipeName
        '
        Me.chRecipeName.Text = "Recipe Name"
        Me.chRecipeName.Width = 400
        '
        'chIngredients
        '
        Me.chIngredients.Text = "Total Ingredients"
        Me.chIngredients.Width = 220
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 635)
        Me.Controls.Add(Me.tabControl)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.mnuCatalog.ResumeLayout(False)
        Me.mnuIngredients.ResumeLayout(False)
        Me.mnuRecipes.ResumeLayout(False)
        Me.tabControl.ResumeLayout(False)
        Me.tpCatalog.ResumeLayout(False)
        Me.grpCart.ResumeLayout(False)
        Me.grpCart.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSearch.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCategory.ResumeLayout(False)
        Me.grpCategory.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpIngredients.ResumeLayout(False)
        Me.mnuIngredientsReview.ResumeLayout(False)
        Me.tpRecipes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabControl As Culinary_App.StrafeTabControl
    Friend WithEvents thDASHBOARD As System.Windows.Forms.TabPage
    Friend WithEvents tpCatalog As System.Windows.Forms.TabPage
    Friend WithEvents cmboType As System.Windows.Forms.ComboBox
    Friend WithEvents lstItems As System.Windows.Forms.ListView
    Friend WithEvents chItemName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chIncrement As System.Windows.Forms.ColumnHeader
    Friend WithEvents chPrice As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblSelectACategory As System.Windows.Forms.Label
    Friend WithEvents grpCategory As Culinary_App.StrafeGroupBox
    Friend WithEvents grpSearch As Culinary_App.StrafeGroupBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As Culinary_App.StrafeTextBox
    Friend WithEvents chNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents mnuCatalog As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuAddToCart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpCart As Culinary_App.StrafeGroupBox
    Friend WithEvents pbRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents thReview As System.Windows.Forms.TabPage
    Friend WithEvents tpIngredients As System.Windows.Forms.TabPage
    Friend WithEvents thDone As System.Windows.Forms.TabPage
    Friend WithEvents tpRecipes As System.Windows.Forms.TabPage
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents tss1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuViewOnline As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuImages As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInformation As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIngredients As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuRemove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstIngredients As System.Windows.Forms.ListView
    Friend WithEvents chID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents lstReview As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdvanced As StrafeButton
    Friend WithEvents btnAddRecipe As StrafeButton
    Friend WithEvents lstRecipes As ListView
    Friend WithEvents chMenuNo As ColumnHeader
    Friend WithEvents chRecipeName As ColumnHeader
    Friend WithEvents chIngredients As ColumnHeader
    Friend WithEvents btnExport As StrafeButton
    Friend WithEvents mnuRecipes As ContextMenuStrip
    Friend WithEvents mnuViewItems As ToolStripMenuItem
    Friend WithEvents EditNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuRemoveRecipe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIngredientsReview As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuRemoveIngredients As System.Windows.Forms.ToolStripMenuItem
End Class
