<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fruits
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
        Me.pnlFruits = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnMinus = New System.Windows.Forms.Button()
        Me.picFruits = New System.Windows.Forms.PictureBox()
        Me.picCart = New System.Windows.Forms.PictureBox()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picFruits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlFruits
        '
        Me.pnlFruits.AutoScroll = True
        Me.pnlFruits.BackColor = System.Drawing.Color.Transparent
        Me.pnlFruits.Location = New System.Drawing.Point(85, 32)
        Me.pnlFruits.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlFruits.Name = "pnlFruits"
        Me.pnlFruits.Size = New System.Drawing.Size(516, 388)
        Me.pnlFruits.TabIndex = 5
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Black
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(728, 378)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(155, 59)
        Me.btnAdd.TabIndex = 65
        Me.btnAdd.Text = "&Add to Cart"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.White
        Me.btnPlus.BackgroundImage = Global.Assignment.My.Resources.Resources.plus
        Me.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPlus.ForeColor = System.Drawing.Color.White
        Me.btnPlus.Location = New System.Drawing.Point(850, 322)
        Me.btnPlus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(44, 42)
        Me.btnPlus.TabIndex = 63
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnMinus
        '
        Me.btnMinus.BackColor = System.Drawing.Color.White
        Me.btnMinus.BackgroundImage = Global.Assignment.My.Resources.Resources.minus
        Me.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinus.ForeColor = System.Drawing.Color.White
        Me.btnMinus.Location = New System.Drawing.Point(701, 322)
        Me.btnMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnMinus.Name = "btnMinus"
        Me.btnMinus.Size = New System.Drawing.Size(44, 42)
        Me.btnMinus.TabIndex = 62
        Me.btnMinus.UseVisualStyleBackColor = False
        '
        'picFruits
        '
        Me.picFruits.BackColor = System.Drawing.Color.Transparent
        Me.picFruits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFruits.Location = New System.Drawing.Point(627, 32)
        Me.picFruits.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picFruits.Name = "picFruits"
        Me.picFruits.Size = New System.Drawing.Size(313, 276)
        Me.picFruits.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFruits.TabIndex = 61
        Me.picFruits.TabStop = False
        Me.picFruits.Visible = False
        '
        'picCart
        '
        Me.picCart.Image = Global.Assignment.My.Resources.Resources.shopping_cart
        Me.picCart.Location = New System.Drawing.Point(485, 464)
        Me.picCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picCart.Name = "picCart"
        Me.picCart.Size = New System.Drawing.Size(60, 55)
        Me.picCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCart.TabIndex = 60
        Me.picCart.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picCart, "View Cart")
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Black
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(816, 464)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(124, 59)
        Me.btnProceed.TabIndex = 59
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(85, 464)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 59)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'lblQty
        '
        Me.lblQty.BackColor = System.Drawing.Color.White
        Me.lblQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.Black
        Me.lblQty.Location = New System.Drawing.Point(771, 322)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(59, 42)
        Me.lblQty.TabIndex = 43
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fruits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.fruits
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1026, 556)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.pnlFruits)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnMinus)
        Me.Controls.Add(Me.picFruits)
        Me.Controls.Add(Me.picCart)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Fruits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fruits"
        CType(Me.picFruits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlFruits As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMinus As Button
    Friend WithEvents picFruits As PictureBox
    Friend WithEvents picCart As PictureBox
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblQty As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
