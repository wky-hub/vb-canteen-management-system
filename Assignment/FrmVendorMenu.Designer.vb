<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendorMenu
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEditDelete = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnAddEditProduct = New System.Windows.Forms.Button()
        Me.btnOrderManagement = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(223, 425)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 25)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Edit Vendor"
        '
        'btnEditDelete
        '
        Me.btnEditDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnEditDelete.BackgroundImage = Global.Assignment.My.Resources.Resources.images__2_
        Me.btnEditDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditDelete.ForeColor = System.Drawing.Color.Black
        Me.btnEditDelete.Location = New System.Drawing.Point(187, 233)
        Me.btnEditDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditDelete.Name = "btnEditDelete"
        Me.btnEditDelete.Size = New System.Drawing.Size(197, 169)
        Me.btnEditDelete.TabIndex = 147
        Me.btnEditDelete.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(16, 15)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(160, 58)
        Me.btnBack.TabIndex = 155
        Me.btnBack.Text = "< BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnAddEditProduct
        '
        Me.btnAddEditProduct.BackgroundImage = Global.Assignment.My.Resources.Resources.download1
        Me.btnAddEditProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEditProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEditProduct.Location = New System.Drawing.Point(536, 233)
        Me.btnAddEditProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddEditProduct.Name = "btnAddEditProduct"
        Me.btnAddEditProduct.Size = New System.Drawing.Size(180, 169)
        Me.btnAddEditProduct.TabIndex = 156
        Me.btnAddEditProduct.UseVisualStyleBackColor = True
        '
        'btnOrderManagement
        '
        Me.btnOrderManagement.BackgroundImage = Global.Assignment.My.Resources.Resources.download__1_
        Me.btnOrderManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrderManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrderManagement.Location = New System.Drawing.Point(839, 233)
        Me.btnOrderManagement.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOrderManagement.Name = "btnOrderManagement"
        Me.btnOrderManagement.Size = New System.Drawing.Size(183, 169)
        Me.btnOrderManagement.TabIndex = 157
        Me.btnOrderManagement.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(531, 425)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 25)
        Me.Label1.TabIndex = 158
        Me.Label1.Text = "Add / Edit Product"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(833, 425)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 25)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Order Management"
        '
        'FrmVendorMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1308, 672)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOrderManagement)
        Me.Controls.Add(Me.btnAddEditProduct)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnEditDelete)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmVendorMenu"
        Me.Text = "Vendor Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEditDelete As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnAddEditProduct As Button
    Friend WithEvents btnOrderManagement As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
