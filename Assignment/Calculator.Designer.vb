<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAmountDue = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblChangeDue = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnProceed = New System.Windows.Forms.Button()
        'Me.PaymentTableAdapter = New Assignment.Database1DataSetTableAdapters.PaymentTableAdapter()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.Color.Black
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.ForeColor = System.Drawing.Color.White
        Me.btn1.Location = New System.Drawing.Point(516, 178)
        Me.btn1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(116, 91)
        Me.btn1.TabIndex = 4
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.Color.Black
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.ForeColor = System.Drawing.Color.White
        Me.btn2.Location = New System.Drawing.Point(627, 178)
        Me.btn2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(116, 91)
        Me.btn2.TabIndex = 5
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.Color.Black
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.ForeColor = System.Drawing.Color.White
        Me.btn3.Location = New System.Drawing.Point(736, 178)
        Me.btn3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(116, 91)
        Me.btn3.TabIndex = 6
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.Color.Black
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.ForeColor = System.Drawing.Color.White
        Me.btn6.Location = New System.Drawing.Point(736, 264)
        Me.btn6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(116, 91)
        Me.btn6.TabIndex = 9
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.Color.Black
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.ForeColor = System.Drawing.Color.White
        Me.btn5.Location = New System.Drawing.Point(627, 264)
        Me.btn5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(116, 91)
        Me.btn5.TabIndex = 8
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.Color.Black
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.ForeColor = System.Drawing.Color.White
        Me.btn4.Location = New System.Drawing.Point(516, 264)
        Me.btn4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(116, 91)
        Me.btn4.TabIndex = 7
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.Color.Black
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.ForeColor = System.Drawing.Color.White
        Me.btn9.Location = New System.Drawing.Point(736, 350)
        Me.btn9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(116, 91)
        Me.btn9.TabIndex = 12
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.Color.Black
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.ForeColor = System.Drawing.Color.White
        Me.btn8.Location = New System.Drawing.Point(627, 350)
        Me.btn8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(116, 91)
        Me.btn8.TabIndex = 11
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.Color.Black
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.ForeColor = System.Drawing.Color.White
        Me.btn7.Location = New System.Drawing.Point(516, 350)
        Me.btn7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(116, 91)
        Me.btn7.TabIndex = 10
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.Color.Black
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.ForeColor = System.Drawing.Color.White
        Me.btn0.Location = New System.Drawing.Point(516, 437)
        Me.btn0.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(116, 91)
        Me.btn0.TabIndex = 13
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnDot
        '
        Me.btnDot.BackColor = System.Drawing.Color.Black
        Me.btnDot.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDot.ForeColor = System.Drawing.Color.White
        Me.btnDot.Location = New System.Drawing.Point(627, 437)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(116, 91)
        Me.btnDot.TabIndex = 14
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(736, 437)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(116, 91)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.White
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.Black
        Me.lblAmount.Location = New System.Drawing.Point(516, 69)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(335, 89)
        Me.lblAmount.TabIndex = 16
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 29)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Amount Due: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(870, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 54)
        Me.Label2.TabIndex = 18
        '
        'lblAmountDue
        '
        Me.lblAmountDue.BackColor = System.Drawing.Color.Black
        Me.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.ForeColor = System.Drawing.Color.White
        Me.lblAmountDue.Location = New System.Drawing.Point(300, 176)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(178, 44)
        Me.lblAmountDue.TabIndex = 19
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(78, 470)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 59)
        Me.btnBack.TabIndex = 69
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(117, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 29)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Change Due:"
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.Color.Black
        Me.lblPaid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaid.ForeColor = System.Drawing.Color.White
        Me.lblPaid.Location = New System.Drawing.Point(300, 262)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(178, 44)
        Me.lblPaid.TabIndex = 74
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(142, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 29)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Cash Paid:"
        '
        'lblChangeDue
        '
        Me.lblChangeDue.BackColor = System.Drawing.Color.Black
        Me.lblChangeDue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChangeDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeDue.ForeColor = System.Drawing.Color.White
        Me.lblChangeDue.Location = New System.Drawing.Point(300, 339)
        Me.lblChangeDue.Name = "lblChangeDue"
        Me.lblChangeDue.Size = New System.Drawing.Size(178, 44)
        Me.lblChangeDue.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(225, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 54)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Cash"
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Black
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(880, 470)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(124, 59)
        Me.btnProceed.TabIndex = 77
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'PaymentTableAdapter1
        '
        'Me.PaymentTableAdapter1.ClearBeforeFill = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1026, 556)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblChangeDue)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAmountDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblAmount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblChangeDue As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnProceed As Button
    'Friend WithEvents PaymentTableAdapter1 As Database1DataSetTableAdapters.PaymentTableAdapter
End Class
