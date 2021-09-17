<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(652, 518)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 52)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Total Price:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.Black
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(894, 518)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(166, 52)
        Me.lblTotal.TabIndex = 44
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Black
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(548, 128)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(166, 68)
        Me.btnRemove.TabIndex = 45
        Me.btnRemove.Text = "&Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Black
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(920, 588)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(140, 74)
        Me.btnProceed.TabIndex = 47
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(88, 588)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(140, 74)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(548, 218)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(166, 68)
        Me.btnClear.TabIndex = 48
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(628, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 52)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Total Item(s):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(416, 52)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Food List/Quantity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Black
        Me.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.ForeColor = System.Drawing.Color.White
        Me.lblCount.Location = New System.Drawing.Point(894, 440)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(166, 52)
        Me.lblCount.TabIndex = 43
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lstCart
        '
        Me.lstCart.BackColor = System.Drawing.Color.Black
        Me.lstCart.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.ForeColor = System.Drawing.Color.White
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 32
        Me.lstCart.Location = New System.Drawing.Point(88, 145)
        Me.lstCart.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(416, 388)
        Me.lstCart.TabIndex = 51
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.cart_background
        Me.ClientSize = New System.Drawing.Size(1154, 695)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cart"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents lstCart As ListBox
End Class
