<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cards
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.picWestern = New System.Windows.Forms.PictureBox()
        CType(Me.picWestern, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-778, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "jj"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(68, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(890, 123)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Please follow the payment instruction displayed on the pin pad below "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.Color.Black
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(848, 474)
        Me.btnProceed.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(124, 59)
        Me.btnProceed.TabIndex = 82
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Black
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Location = New System.Drawing.Point(46, 474)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 59)
        Me.btnBack.TabIndex = 81
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'picWestern
        '
        Me.picWestern.Image = Global.Assignment.My.Resources.Resources.card_reader
        Me.picWestern.Location = New System.Drawing.Point(359, 245)
        Me.picWestern.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picWestern.Name = "picWestern"
        Me.picWestern.Size = New System.Drawing.Size(322, 253)
        Me.picWestern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWestern.TabIndex = 49
        Me.picWestern.TabStop = False
        '
        'Cards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1026, 556)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.picWestern)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Cards"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cards"
        CType(Me.picWestern, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents picWestern As PictureBox
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnBack As Button
End Class
