<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order_management
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Order_DetailBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.Order_DetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet = New Assignment.Database1DataSet()
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
        Me.Order_DetailBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnPrepared = New System.Windows.Forms.Button()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.PictureBoxProduct = New System.Windows.Forms.PictureBox()
        Me.Order_DetailTableAdapter = New Assignment.Database1DataSetTableAdapters.Order_DetailTableAdapter()
        Me.TableAdapterManager = New Assignment.Database1DataSetTableAdapters.TableAdapterManager()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Order_DetailBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_DetailBindingNavigator.SuspendLayout()
        CType(Me.Order_DetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(65, 149)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.Size = New System.Drawing.Size(644, 388)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No of Order"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "OrderID"
        Me.ColumnHeader2.Width = 122
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ProductID"
        Me.ColumnHeader3.Width = 134
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Quantity"
        Me.ColumnHeader4.Width = 268
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ORDER MANAGEMENT"
        '
        'Order_DetailBindingNavigator
        '
        Me.Order_DetailBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Order_DetailBindingNavigator.BindingSource = Me.Order_DetailBindingSource
        Me.Order_DetailBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order_DetailBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Order_DetailBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Order_DetailBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Order_DetailBindingNavigatorSaveItem})
        Me.Order_DetailBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order_DetailBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order_DetailBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order_DetailBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order_DetailBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order_DetailBindingNavigator.Name = "Order_DetailBindingNavigator"
        Me.Order_DetailBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order_DetailBindingNavigator.Size = New System.Drawing.Size(1090, 27)
        Me.Order_DetailBindingNavigator.TabIndex = 2
        Me.Order_DetailBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'Order_DetailBindingSource
        '
        Me.Order_DetailBindingSource.DataMember = "Order_Detail"
        Me.Order_DetailBindingSource.DataSource = Me.Database1DataSet
        '
        'Database1DataSet
        '
        Me.Database1DataSet.DataSetName = "Database1DataSet1"
        Me.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
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
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Order_DetailBindingNavigatorSaveItem
        '
        Me.Order_DetailBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order_DetailBindingNavigatorSaveItem.Name = "Order_DetailBindingNavigatorSaveItem"
        Me.Order_DetailBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.Order_DetailBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnPrepared
        '
        Me.btnPrepared.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrepared.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnPrepared.Location = New System.Drawing.Point(834, 461)
        Me.btnPrepared.Name = "btnPrepared"
        Me.btnPrepared.Size = New System.Drawing.Size(143, 76)
        Me.btnPrepared.TabIndex = 3
        Me.btnPrepared.Text = "Prepared"
        Me.btnPrepared.UseVisualStyleBackColor = True
        '
        'lblProductName
        '
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(849, 368)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(188, 58)
        Me.lblProductName.TabIndex = 5
        Me.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(756, 368)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(87, 58)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Product Name:"
        '
        'PictureBoxProduct
        '
        Me.PictureBoxProduct.BackColor = System.Drawing.Color.Black
        Me.PictureBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxProduct.Location = New System.Drawing.Point(756, 149)
        Me.PictureBoxProduct.Name = "PictureBoxProduct"
        Me.PictureBoxProduct.Size = New System.Drawing.Size(281, 202)
        Me.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxProduct.TabIndex = 4
        Me.PictureBoxProduct.TabStop = False
        '
        'Order_DetailTableAdapter
        '
        Me.Order_DetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Order_DetailTableAdapter = Me.Order_DetailTableAdapter
        Me.TableAdapterManager.OrderTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Assignment.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(562, 102)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(147, 44)
        Me.lblTime.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblDate
        '
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(408, 102)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(147, 44)
        Me.lblDate.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(65, 57)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 33)
        Me.Button1.TabIndex = 145
        Me.Button1.Text = "< BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(846, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 146
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Order_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.Order_management_background_image_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1090, 549)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.PictureBoxProduct)
        Me.Controls.Add(Me.btnPrepared)
        Me.Controls.Add(Me.Order_DetailBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Order_management"
        Me.Text = "Order_management"
        CType(Me.Order_DetailBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_DetailBindingNavigator.ResumeLayout(False)
        Me.Order_DetailBindingNavigator.PerformLayout()
        CType(Me.Order_DetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Database1DataSet As Database1DataSet
    Friend WithEvents Order_DetailBindingSource As BindingSource
    Friend WithEvents Order_DetailTableAdapter As Database1DataSetTableAdapters.Order_DetailTableAdapter
    Friend WithEvents TableAdapterManager As Database1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_DetailBindingNavigator As BindingNavigator
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
    Friend WithEvents Order_DetailBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents btnPrepared As Button
    Friend WithEvents PictureBoxProduct As PictureBox
    Friend WithEvents lblProductName As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
