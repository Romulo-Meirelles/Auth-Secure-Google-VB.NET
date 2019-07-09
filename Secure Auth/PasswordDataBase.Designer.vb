<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordDataBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswordDataBase))
        Me.VisualStudioContainer1 = New Secure_Auth.VisualStudioContainer()
        Me.DontForget_lbl = New System.Windows.Forms.Label()
        Me.Wrong_Pass_lbl = New System.Windows.Forms.Label()
        Me.VisualStudioButton1 = New Secure_Auth.VisualStudioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New Secure_Auth.VisualStudioNormalTextBox()
        Me.Timer_WrongPass = New System.Windows.Forms.Timer(Me.components)
        Me.VisualStudioButton2 = New Secure_Auth.VisualStudioButton()
        Me.VisualStudioContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VisualStudioContainer1
        '
        Me.VisualStudioContainer1.AllowClose = True
        Me.VisualStudioContainer1.AllowMinimize = True
        Me.VisualStudioContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioButton2)
        Me.VisualStudioContainer1.Controls.Add(Me.DontForget_lbl)
        Me.VisualStudioContainer1.Controls.Add(Me.Wrong_Pass_lbl)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioButton1)
        Me.VisualStudioContainer1.Controls.Add(Me.Label1)
        Me.VisualStudioContainer1.Controls.Add(Me.TextBox1)
        Me.VisualStudioContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioContainer1.FontSize = 12
        Me.VisualStudioContainer1.Form = Me
        Me.VisualStudioContainer1.FormOrWhole = Secure_Auth.VisualStudioContainer.__FormOrWhole.WholeApplication
        Me.VisualStudioContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1.IconStyle = Secure_Auth.VisualStudioContainer.__IconStyle.FormIcon
        Me.VisualStudioContainer1.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1.MaximumSize = New System.Drawing.Size(400, 200)
        Me.VisualStudioContainer1.MinimumSize = New System.Drawing.Size(400, 200)
        Me.VisualStudioContainer1.Name = "VisualStudioContainer1"
        Me.VisualStudioContainer1.ShowIcon = True
        Me.VisualStudioContainer1.Size = New System.Drawing.Size(400, 200)
        Me.VisualStudioContainer1.TabIndex = 0
        Me.VisualStudioContainer1.Text = "Password Database."
        '
        'DontForget_lbl
        '
        Me.DontForget_lbl.AutoSize = True
        Me.DontForget_lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DontForget_lbl.Location = New System.Drawing.Point(167, 116)
        Me.DontForget_lbl.Name = "DontForget_lbl"
        Me.DontForget_lbl.Size = New System.Drawing.Size(192, 13)
        Me.DontForget_lbl.TabIndex = 4
        Me.DontForget_lbl.Text = "Do not forget the password, write down"
        Me.DontForget_lbl.Visible = False
        '
        'Wrong_Pass_lbl
        '
        Me.Wrong_Pass_lbl.AutoSize = True
        Me.Wrong_Pass_lbl.ForeColor = System.Drawing.Color.Red
        Me.Wrong_Pass_lbl.Location = New System.Drawing.Point(39, 116)
        Me.Wrong_Pass_lbl.Name = "Wrong_Pass_lbl"
        Me.Wrong_Pass_lbl.Size = New System.Drawing.Size(91, 13)
        Me.Wrong_Pass_lbl.TabIndex = 3
        Me.Wrong_Pass_lbl.Text = "Wrong Password."
        Me.Wrong_Pass_lbl.Visible = False
        '
        'VisualStudioButton1
        '
        Me.VisualStudioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VisualStudioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.VisualStudioButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton1.ImageAlignment = Secure_Auth.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton1.ImageChoice = Nothing
        Me.VisualStudioButton1.Location = New System.Drawing.Point(284, 143)
        Me.VisualStudioButton1.Name = "VisualStudioButton1"
        Me.VisualStudioButton1.ShowBorder = True
        Me.VisualStudioButton1.ShowImage = False
        Me.VisualStudioButton1.ShowText = True
        Me.VisualStudioButton1.Size = New System.Drawing.Size(75, 23)
        Me.VisualStudioButton1.TabIndex = 2
        Me.VisualStudioButton1.Text = "Save"
        Me.VisualStudioButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Location = New System.Drawing.Point(39, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inside your new Password Database."
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BackgroundColour = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(41, 88)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.Multiline = False
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = False
        Me.TextBox1.Size = New System.Drawing.Size(318, 25)
        Me.TextBox1.Style = Secure_Auth.VisualStudioNormalTextBox.Styles.NotRounded
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TextBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Timer_WrongPass
        '
        Me.Timer_WrongPass.Interval = 3000
        '
        'VisualStudioButton2
        '
        Me.VisualStudioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VisualStudioButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.VisualStudioButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton2.ImageAlignment = Secure_Auth.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton2.ImageChoice = Nothing
        Me.VisualStudioButton2.Location = New System.Drawing.Point(203, 143)
        Me.VisualStudioButton2.Name = "VisualStudioButton2"
        Me.VisualStudioButton2.ShowBorder = True
        Me.VisualStudioButton2.ShowImage = False
        Me.VisualStudioButton2.ShowText = True
        Me.VisualStudioButton2.Size = New System.Drawing.Size(75, 23)
        Me.VisualStudioButton2.TabIndex = 5
        Me.VisualStudioButton2.Text = "Cancel"
        Me.VisualStudioButton2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PasswordDataBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.VisualStudioContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "PasswordDataBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password DataBase"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.VisualStudioContainer1.ResumeLayout(False)
        Me.VisualStudioContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudioContainer1 As Secure_Auth.VisualStudioContainer
    Friend WithEvents VisualStudioButton1 As Secure_Auth.VisualStudioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As Secure_Auth.VisualStudioNormalTextBox
    Friend WithEvents Wrong_Pass_lbl As System.Windows.Forms.Label
    Friend WithEvents Timer_WrongPass As System.Windows.Forms.Timer
    Friend WithEvents DontForget_lbl As System.Windows.Forms.Label
    Friend WithEvents VisualStudioButton2 As Secure_Auth.VisualStudioButton
End Class
