<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asian
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.picCart = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.pnlAsian = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.picAsian = New System.Windows.Forms.PictureBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picCart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAsian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCart
        '
        Me.picCart.Image = Global.Assignment.My.Resources.Resources.shopping_cart
        Me.picCart.Location = New System.Drawing.Point(546, 580)
        Me.picCart.Name = "picCart"
        Me.picCart.Size = New System.Drawing.Size(68, 69)
        Me.picCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCart.TabIndex = 70
        Me.picCart.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCart, "View Cart")
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(202, -202)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(240, 149)
        Me.DataGridView1.TabIndex = 38
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.White
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Black
        Me.lblQty.Location = New System.Drawing.Point(867, 402)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(66, 52)
        Me.lblQty.TabIndex = 68
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlAsian
        '
        Me.pnlAsian.AutoScroll = True
        Me.pnlAsian.BackColor = System.Drawing.Color.Transparent
        Me.pnlAsian.Location = New System.Drawing.Point(96, 40)
        Me.pnlAsian.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pnlAsian.Name = "pnlAsian"
        Me.pnlAsian.Size = New System.Drawing.Size(580, 485)
        Me.pnlAsian.TabIndex = 67
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(807, 460)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(174, 74)
        Me.btnAdd.TabIndex = 74
        Me.btnAdd.Text = "&Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.White
        Me.btnPlus.BackgroundImage = Global.Assignment.My.Resources.Resources.plus
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.ForeColor = System.Drawing.Color.White
        Me.btnPlus.Location = New System.Drawing.Point(956, 402)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(50, 52)
        Me.btnPlus.TabIndex = 73
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.White
        Me.btnMinus.BackgroundImage = Global.Assignment.My.Resources.Resources.minus
        Me.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinus.ForeColor = System.Drawing.Color.White
        Me.btnMinus.Location = New System.Drawing.Point(789, 402)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(50, 52)
        Me.btnMinus.TabIndex = 72
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'picAsian
        '
        Me.picAsian.BackColor = System.Drawing.Color.Transparent
        Me.picAsian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAsian.Location = New System.Drawing.Point(705, 40)
        Me.picAsian.Name = "picAsian"
        Me.picAsian.Size = New System.Drawing.Size(352, 344)
        Me.picAsian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAsian.TabIndex = 71
        Me.picAsian.TabStop = False
        Me.picAsian.Visible = False
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Black
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(918, 580)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(140, 74)
        Me.btnProceed.TabIndex = 69
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(96, 580)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(140, 74)
        Me.btnBack.TabIndex = 66
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Asian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.asian_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1154, 695)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.pnlAsian)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.picAsian)
        Me.Controls.Add(Me.picCart)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Asian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asian"
        CType(Me.picCart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAsian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblQty As Label
    Friend WithEvents pnlAsian As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents picAsian As PictureBox
    Friend WithEvents picCart As PictureBox
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnBack As Button
End Class
