<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnCards = New System.Windows.Forms.Button()
        Me.btnMobilePay = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.picCash = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(622, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Payment Method"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(58, 590)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(140, 74)
        Me.btnBack.TabIndex = 64
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.Black
        Me.btnCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.White
        Me.btnCash.Location = New System.Drawing.Point(145, 470)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(159, 74)
        Me.btnCash.TabIndex = 66
        Me.btnCash.Text = "Cash"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnCards
        '
        Me.btnCards.BackColor = System.Drawing.Color.Black
        Me.btnCards.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCards.ForeColor = System.Drawing.Color.White
        Me.btnCards.Location = New System.Drawing.Point(528, 470)
        Me.btnCards.Name = "btnCards"
        Me.btnCards.Size = New System.Drawing.Size(159, 74)
        Me.btnCards.TabIndex = 67
        Me.btnCards.Text = "Cards"
        Me.btnCards.UseVisualStyleBackColor = False
        '
        'btnMobilePay
        '
        Me.btnMobilePay.BackColor = System.Drawing.Color.Black
        Me.btnMobilePay.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMobilePay.ForeColor = System.Drawing.Color.White
        Me.btnMobilePay.Location = New System.Drawing.Point(846, 470)
        Me.btnMobilePay.Name = "btnMobilePay"
        Me.btnMobilePay.Size = New System.Drawing.Size(253, 74)
        Me.btnMobilePay.TabIndex = 68
        Me.btnMobilePay.Text = "Mobile Pay"
        Me.btnMobilePay.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment.My.Resources.Resources.mobile_pay
        Me.PictureBox2.Location = New System.Drawing.Point(805, 160)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(319, 275)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Assignment.My.Resources.Resources.cards
        Me.PictureBox1.Location = New System.Drawing.Point(437, 160)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(319, 275)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'picCash
        '
        Me.picCash.Image = Global.Assignment.My.Resources.Resources.cash
        Me.picCash.Location = New System.Drawing.Point(58, 160)
        Me.picCash.Name = "picCash"
        Me.picCash.Size = New System.Drawing.Size(319, 275)
        Me.picCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCash.TabIndex = 1
        Me.picCash.TabStop = False
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1154, 695)
        Me.Controls.Add(Me.btnMobilePay)
        Me.Controls.Add(Me.btnCards)
        Me.Controls.Add(Me.btnCash)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.picCash)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents picCash As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnCards As Button
    Friend WithEvents btnMobilePay As Button
End Class
