<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Data_maintenance
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
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim ProductIDLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim ProductPriceLabel As System.Windows.Forms.Label
        Dim ProductStatusLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Data_maintenance))
        Me.btnBack = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtProdID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ProductImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Assignment.Database1DataSet()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.ProductStatusComboBox = New System.Windows.Forms.ComboBox()
        Me.ProductPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.ProductTableAdapter = New Assignment.Database1DataSetTableAdapters.ProductTableAdapter()
        Me.TableAdapterManager = New Assignment.Database1DataSetTableAdapters.TableAdapterManager()
        Me.ProductBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        ProductIDLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        ProductPriceLabel = New System.Windows.Forms.Label()
        ProductStatusLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductBindingNavigator.SuspendLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        UserIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UserIDLabel.Location = New System.Drawing.Point(6, 47)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(163, 25)
        UserIDLabel.TabIndex = 0
        UserIDLabel.Text = "User ID:"
        '
        'ProductIDLabel
        '
        ProductIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductIDLabel.Location = New System.Drawing.Point(6, 98)
        ProductIDLabel.Name = "ProductIDLabel"
        ProductIDLabel.Size = New System.Drawing.Size(163, 25)
        ProductIDLabel.TabIndex = 2
        ProductIDLabel.Text = "Product ID:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(6, 151)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(163, 25)
        ProductNameLabel.TabIndex = 4
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductPriceLabel
        '
        ProductPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductPriceLabel.Location = New System.Drawing.Point(359, 98)
        ProductPriceLabel.Name = "ProductPriceLabel"
        ProductPriceLabel.Size = New System.Drawing.Size(174, 25)
        ProductPriceLabel.TabIndex = 6
        ProductPriceLabel.Text = "Product Price:"
        '
        'ProductStatusLabel
        '
        ProductStatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductStatusLabel.Location = New System.Drawing.Point(359, 151)
        ProductStatusLabel.Name = "ProductStatusLabel"
        ProductStatusLabel.Size = New System.Drawing.Size(174, 25)
        ProductStatusLabel.TabIndex = 8
        ProductStatusLabel.Text = "Product Status:"
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(13, 31)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(143, 48)
        Me.btnBack.TabIndex = 133
        Me.btnBack.Text = "< BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.search
        Me.PictureBox1.Location = New System.Drawing.Point(960, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'txtProdID
        '
        Me.txtProdID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdID.Location = New System.Drawing.Point(799, 44)
        Me.txtProdID.Multiline = True
        Me.txtProdID.Name = "txtProdID"
        Me.txtProdID.Size = New System.Drawing.Size(157, 35)
        Me.txtProdID.TabIndex = 135
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(665, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 35)
        Me.Label1.TabIndex = 134
        Me.Label1.Text = "Product ID:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.ProductImagePictureBox)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(ProductStatusLabel)
        Me.GroupBox1.Controls.Add(Me.ProductStatusComboBox)
        Me.GroupBox1.Controls.Add(ProductPriceLabel)
        Me.GroupBox1.Controls.Add(Me.ProductPriceTextBox)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(Me.ProductNameTextBox)
        Me.GroupBox1.Controls.Add(ProductIDLabel)
        Me.GroupBox1.Controls.Add(Me.ProductIDTextBox)
        Me.GroupBox1.Controls.Add(UserIDLabel)
        Me.GroupBox1.Controls.Add(Me.UserIDTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(58, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(945, 204)
        Me.GroupBox1.TabIndex = 137
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Entry Form"
        '
        'ProductImagePictureBox
        '
        Me.ProductImagePictureBox.BackColor = System.Drawing.Color.Silver
        Me.ProductImagePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.ProductBindingSource, "ProductImage", True))
        Me.ProductImagePictureBox.Location = New System.Drawing.Point(741, 31)
        Me.ProductImagePictureBox.Name = "ProductImagePictureBox"
        Me.ProductImagePictureBox.Size = New System.Drawing.Size(180, 129)
        Me.ProductImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductImagePictureBox.TabIndex = 26
        Me.ProductImagePictureBox.TabStop = False
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Silver
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Black
        Me.btnBrowse.Location = New System.Drawing.Point(778, 160)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(105, 36)
        Me.btnBrowse.TabIndex = 25
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'ProductStatusComboBox
        '
        Me.ProductStatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductStatus", True))
        Me.ProductStatusComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductStatusComboBox.FormattingEnabled = True
        Me.ProductStatusComboBox.Items.AddRange(New Object() {"Available", "Out of Stock"})
        Me.ProductStatusComboBox.Location = New System.Drawing.Point(539, 148)
        Me.ProductStatusComboBox.Name = "ProductStatusComboBox"
        Me.ProductStatusComboBox.Size = New System.Drawing.Size(169, 33)
        Me.ProductStatusComboBox.TabIndex = 9
        '
        'ProductPriceTextBox
        '
        Me.ProductPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductPrice", True))
        Me.ProductPriceTextBox.Location = New System.Drawing.Point(539, 90)
        Me.ProductPriceTextBox.Multiline = True
        Me.ProductPriceTextBox.Name = "ProductPriceTextBox"
        Me.ProductPriceTextBox.Size = New System.Drawing.Size(169, 41)
        Me.ProductPriceTextBox.TabIndex = 7
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(175, 139)
        Me.ProductNameTextBox.Multiline = True
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(160, 41)
        Me.ProductNameTextBox.TabIndex = 5
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "ProductID", True))
        Me.ProductIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIDTextBox.Location = New System.Drawing.Point(175, 85)
        Me.ProductIDTextBox.Multiline = True
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(160, 41)
        Me.ProductIDTextBox.TabIndex = 3
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductBindingSource, "UserID", True))
        Me.UserIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDTextBox.Location = New System.Drawing.Point(175, 31)
        Me.UserIDTextBox.Multiline = True
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(160, 41)
        Me.UserIDTextBox.TabIndex = 1
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Order_DetailTableAdapter = Nothing
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Me.ProductTableAdapter
        Me.TableAdapterManager.UpdateOrder = Assignment.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'ProductBindingNavigator
        '
        Me.ProductBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductBindingNavigator.BindingSource = Me.ProductBindingSource
        Me.ProductBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ProductBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductBindingNavigatorSaveItem})
        Me.ProductBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductBindingNavigator.Name = "ProductBindingNavigator"
        Me.ProductBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductBindingNavigator.Size = New System.Drawing.Size(1118, 27)
        Me.ProductBindingNavigator.TabIndex = 138
        Me.ProductBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'ProductBindingNavigatorSaveItem
        '
        Me.ProductBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductBindingNavigatorSaveItem.Name = "ProductBindingNavigatorSaveItem"
        Me.ProductBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.ProductBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewImageColumn1, Me.DataGridViewTextBoxColumn5})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Location = New System.Drawing.Point(58, 343)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.RowTemplate.Height = 24
        Me.ProductDataGridView.Size = New System.Drawing.Size(945, 220)
        Me.ProductDataGridView.TabIndex = 138
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductPrice"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductPrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductStatus"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ProductStatus"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.DataPropertyName = "ProductImage"
        Me.DataGridViewImageColumn1.HeaderText = "ProductImage"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Silver
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Location = New System.Drawing.Point(580, 295)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(114, 42)
        Me.btnSave.TabIndex = 142
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(800, 295)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 42)
        Me.btnExit.TabIndex = 141
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Silver
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Black
        Me.btnDelete.Location = New System.Drawing.Point(360, 295)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(104, 42)
        Me.btnDelete.TabIndex = 140
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAddNew
        '
        Me.btnAddNew.BackColor = System.Drawing.Color.Silver
        Me.btnAddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddNew.ForeColor = System.Drawing.Color.Black
        Me.btnAddNew.Location = New System.Drawing.Point(140, 295)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(107, 42)
        Me.btnAddNew.TabIndex = 139
        Me.btnAddNew.Text = "Add New"
        Me.btnAddNew.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(1043, 546)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Data_maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.form1_background_image_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1118, 614)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAddNew)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.Controls.Add(Me.ProductBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtProdID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Data_maintenance"
        Me.Text = "Data_maintenance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ProductImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductBindingNavigator.ResumeLayout(False)
        Me.ProductBindingNavigator.PerformLayout()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProdID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As Database1DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ProductBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ProductStatusComboBox As ComboBox
    Friend WithEvents ProductPriceTextBox As TextBox
    Friend WithEvents ProductNameTextBox As TextBox
    Friend WithEvents ProductIDTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents ProductImagePictureBox As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
End Class
