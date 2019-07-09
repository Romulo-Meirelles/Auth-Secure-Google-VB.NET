<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Waring
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Waring))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Title_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VisualStudioButton2 = New Secure_Auth.VisualStudioButton()
        Me.VisualStudioButton1 = New Secure_Auth.VisualStudioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Secure_Auth.My.Resources.Resources.Warning_48x48
        Me.PictureBox1.Location = New System.Drawing.Point(35, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Title_lbl
        '
        Me.Title_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_lbl.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Title_lbl.Location = New System.Drawing.Point(89, 41)
        Me.Title_lbl.Name = "Title_lbl"
        Me.Title_lbl.Size = New System.Drawing.Size(183, 48)
        Me.Title_lbl.TabIndex = 3
        Me.Title_lbl.Text = "Title"
        Me.Title_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(29, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 193)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'VisualStudioButton2
        '
        Me.VisualStudioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton2.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton2.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VisualStudioButton2.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton2.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton2.ImageAlignment = Secure_Auth.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton2.ImageChoice = Nothing
        Me.VisualStudioButton2.Location = New System.Drawing.Point(42, 308)
        Me.VisualStudioButton2.Name = "VisualStudioButton2"
        Me.VisualStudioButton2.ShowBorder = True
        Me.VisualStudioButton2.ShowImage = False
        Me.VisualStudioButton2.ShowText = True
        Me.VisualStudioButton2.Size = New System.Drawing.Size(75, 23)
        Me.VisualStudioButton2.TabIndex = 1
        Me.VisualStudioButton2.Text = "Cancel"
        Me.VisualStudioButton2.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'VisualStudioButton1
        '
        Me.VisualStudioButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioButton1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VisualStudioButton1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioButton1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.VisualStudioButton1.ImageAlignment = Secure_Auth.VisualStudioButton.__ImageAlignment.Left
        Me.VisualStudioButton1.ImageChoice = Nothing
        Me.VisualStudioButton1.Location = New System.Drawing.Point(167, 308)
        Me.VisualStudioButton1.Name = "VisualStudioButton1"
        Me.VisualStudioButton1.ShowBorder = True
        Me.VisualStudioButton1.ShowImage = False
        Me.VisualStudioButton1.ShowText = True
        Me.VisualStudioButton1.Size = New System.Drawing.Size(75, 23)
        Me.VisualStudioButton1.TabIndex = 0
        Me.VisualStudioButton1.Text = "Ok"
        Me.VisualStudioButton1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'Waring
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(280, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Title_lbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VisualStudioButton2)
        Me.Controls.Add(Me.VisualStudioButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Waring"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Waring"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudioButton1 As Secure_Auth.VisualStudioButton
    Friend WithEvents VisualStudioButton2 As Secure_Auth.VisualStudioButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Title_lbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
