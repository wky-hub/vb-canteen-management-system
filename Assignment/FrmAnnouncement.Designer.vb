<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnnouncement
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
        Me.chkbxAll = New System.Windows.Forms.CheckBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.chkbxV1 = New System.Windows.Forms.CheckBox()
        Me.chkbxV2 = New System.Windows.Forms.CheckBox()
        Me.chkbxV3 = New System.Windows.Forms.CheckBox()
        Me.chkbxV4 = New System.Windows.Forms.CheckBox()
        Me.chkbxV5 = New System.Windows.Forms.CheckBox()
        Me.rtxtMessage = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAnnounce = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkbxAll
        '
        Me.chkbxAll.AutoSize = True
        Me.chkbxAll.BackColor = System.Drawing.Color.Transparent
        Me.chkbxAll.Location = New System.Drawing.Point(206, 110)
        Me.chkbxAll.Name = "chkbxAll"
        Me.chkbxAll.Size = New System.Drawing.Size(48, 24)
        Me.chkbxAll.TabIndex = 0
        Me.chkbxAll.Text = "All"
        Me.chkbxAll.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 38)
        Me.btnBack.TabIndex = 122
        Me.btnBack.Text = "< BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'chkbxV1
        '
        Me.chkbxV1.AutoSize = True
        Me.chkbxV1.BackColor = System.Drawing.Color.Transparent
        Me.chkbxV1.Location = New System.Drawing.Point(206, 199)
        Me.chkbxV1.Name = "chkbxV1"
        Me.chkbxV1.Size = New System.Drawing.Size(15, 14)
        Me.chkbxV1.TabIndex = 123
        Me.chkbxV1.UseVisualStyleBackColor = False
        Me.chkbxV1.Visible = False
        '
        'chkbxV2
        '
        Me.chkbxV2.AutoSize = True
        Me.chkbxV2.BackColor = System.Drawing.Color.Transparent
        Me.chkbxV2.Location = New System.Drawing.Point(206, 234)
        Me.chkbxV2.Name = "chkbxV2"
        Me.chkbxV2.Size = New System.Drawing.Size(15, 14)
        Me.chkbxV2.TabIndex = 124
        Me.chkbxV2.UseVisualStyleBackColor = False
        Me.chkbxV2.Visible = False
        '
        'chkbxV3
        '
        Me.chkbxV3.AutoSize = True
        Me.chkbxV3.BackColor = System.Drawing.Color.Transparent
        Me.chkbxV3.Location = New System.Drawing.Point(206, 269)
        Me.chkbxV3.Name = "chkbxV3"
        Me.chkbxV3.Size = New System.Drawing.Size(15, 14)
        Me.chkbxV3.TabIndex = 125
        Me.chkbxV3.UseVisualStyleBackColor = False
        Me.chkbxV3.Visible = False
        '
        'chkbxV4
        '
        Me.chkbxV4.AutoSize = True
        Me.chkbxV4.BackColor = System.Drawing.Color.Transparent
        Me.chkbxV4.Location = New System.Drawing.Point(206, 304)
        Me.chkbxV4.Name = "chkbxV4"
        Me.chkbxV4.Size = New System.Drawing.Size(15, 14)
        Me.chkbxV4.TabIndex = 126
        Me.chkbxV4.UseVisualStyleBackColor = False
        Me.chkbxV4.Visible = False
        '
        'chkbxV5
        '
        Me.chkbxV5.AutoSize = True
        Me.chkbxV5.BackColor = System.Drawing.Color.Transparent
        Me.chkbxV5.Location = New System.Drawing.Point(206, 339)
        Me.chkbxV5.Name = "chkbxV5"
        Me.chkbxV5.Size = New System.Drawing.Size(15, 14)
        Me.chkbxV5.TabIndex = 127
        Me.chkbxV5.UseVisualStyleBackColor = False
        Me.chkbxV5.Visible = False
        '
        'rtxtMessage
        '
        Me.rtxtMessage.Location = New System.Drawing.Point(359, 154)
        Me.rtxtMessage.Name = "rtxtMessage"
        Me.rtxtMessage.Size = New System.Drawing.Size(300, 202)
        Me.rtxtMessage.TabIndex = 128
        Me.rtxtMessage.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(354, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 129
        Me.Label1.Text = "Message"
        '
        'btnAnnounce
        '
        Me.btnAnnounce.BackColor = System.Drawing.Color.White
        Me.btnAnnounce.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnounce.ForeColor = System.Drawing.Color.Black
        Me.btnAnnounce.Location = New System.Drawing.Point(535, 414)
        Me.btnAnnounce.Name = "btnAnnounce"
        Me.btnAnnounce.Size = New System.Drawing.Size(148, 61)
        Me.btnAnnounce.TabIndex = 130
        Me.btnAnnounce.Text = "Announce"
        Me.btnAnnounce.UseVisualStyleBackColor = False
        '
        'FrmAnnouncement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.Assignment.My.Resources.Resources.background1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 551)
        Me.Controls.Add(Me.btnAnnounce)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rtxtMessage)
        Me.Controls.Add(Me.chkbxV5)
        Me.Controls.Add(Me.chkbxV4)
        Me.Controls.Add(Me.chkbxV3)
        Me.Controls.Add(Me.chkbxV2)
        Me.Controls.Add(Me.chkbxV1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.chkbxAll)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmAnnouncement"
        Me.Text = "Announcement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkbxAll As CheckBox
    Friend WithEvents btnBack As Button
    Friend WithEvents chkbxV1 As CheckBox
    Friend WithEvents chkbxV2 As CheckBox
    Friend WithEvents chkbxV3 As CheckBox
    Friend WithEvents chkbxV4 As CheckBox
    Friend WithEvents chkbxV5 As CheckBox
    Friend WithEvents rtxtMessage As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAnnounce As Button
End Class
