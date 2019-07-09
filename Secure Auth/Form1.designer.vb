<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer_Copied = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_Count = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestaureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStudioContainer1 = New Secure_Auth.VisualStudioContainer()
        Me.Hide_btn = New System.Windows.Forms.Button()
        Me.Total_Auth_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Developed_lbl = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New Secure_Auth.VisualStudioRadialProgressBar()
        Me.Restore_BTN = New System.Windows.Forms.Button()
        Me.Backup_BTN = New System.Windows.Forms.Button()
        Me.Configuracao_BTN = New System.Windows.Forms.Button()
        Me.Remove_BTN = New System.Windows.Forms.Button()
        Me.Add_BTN = New System.Windows.Forms.Button()
        Me.GroupBox1 = New Secure_Auth.VisualStudioGroupBox()
        Me.OtherPanel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Copied_lbl = New System.Windows.Forms.Label()
        Me.VisualStudioSeperator1 = New Secure_Auth.VisualStudioSeperator()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.VisualStudioContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.OtherPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer_Copied
        '
        Me.Timer_Copied.Interval = 3000
        '
        'Timer_Count
        '
        Me.Timer_Count.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Secure Auth."
        Me.NotifyIcon1.BalloonTipTitle = "Secure Auth."
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Secure Auth."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaureToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 48)
        '
        'RestaureToolStripMenuItem
        '
        Me.RestaureToolStripMenuItem.Image = Global.Secure_Auth.My.Resources.Resources.restore_window_Green_16x16
        Me.RestaureToolStripMenuItem.Name = "RestaureToolStripMenuItem"
        Me.RestaureToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.RestaureToolStripMenuItem.Text = "Restaure"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Image = Global.Secure_Auth.My.Resources.Resources.close_window_Green_16x16
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'VisualStudioContainer1
        '
        Me.VisualStudioContainer1.AllowClose = True
        Me.VisualStudioContainer1.AllowMinimize = True
        Me.VisualStudioContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.VisualStudioContainer1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.VisualStudioContainer1.Controls.Add(Me.Hide_btn)
        Me.VisualStudioContainer1.Controls.Add(Me.Total_Auth_lbl)
        Me.VisualStudioContainer1.Controls.Add(Me.PictureBox1)
        Me.VisualStudioContainer1.Controls.Add(Me.Developed_lbl)
        Me.VisualStudioContainer1.Controls.Add(Me.ProgressBar1)
        Me.VisualStudioContainer1.Controls.Add(Me.Restore_BTN)
        Me.VisualStudioContainer1.Controls.Add(Me.Backup_BTN)
        Me.VisualStudioContainer1.Controls.Add(Me.Configuracao_BTN)
        Me.VisualStudioContainer1.Controls.Add(Me.Remove_BTN)
        Me.VisualStudioContainer1.Controls.Add(Me.Add_BTN)
        Me.VisualStudioContainer1.Controls.Add(Me.GroupBox1)
        Me.VisualStudioContainer1.Controls.Add(Me.VisualStudioSeperator1)
        Me.VisualStudioContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VisualStudioContainer1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioContainer1.FontSize = 12
        Me.VisualStudioContainer1.Form = Nothing
        Me.VisualStudioContainer1.FormOrWhole = Secure_Auth.VisualStudioContainer.__FormOrWhole.WholeApplication
        Me.VisualStudioContainer1.HoverColour = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.VisualStudioContainer1.IconStyle = Secure_Auth.VisualStudioContainer.__IconStyle.FormIcon
        Me.VisualStudioContainer1.Location = New System.Drawing.Point(0, 0)
        Me.VisualStudioContainer1.Name = "VisualStudioContainer1"
        Me.VisualStudioContainer1.ShowIcon = True
        Me.VisualStudioContainer1.Size = New System.Drawing.Size(300, 800)
        Me.VisualStudioContainer1.TabIndex = 0
        Me.VisualStudioContainer1.Text = "Secure Auth."
        '
        'Hide_btn
        '
        Me.Hide_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Hide_btn.FlatAppearance.BorderSize = 0
        Me.Hide_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Hide_btn.Image = Global.Secure_Auth.My.Resources.Resources.hide_32x32
        Me.Hide_btn.Location = New System.Drawing.Point(180, 38)
        Me.Hide_btn.Name = "Hide_btn"
        Me.Hide_btn.Size = New System.Drawing.Size(32, 32)
        Me.Hide_btn.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.Hide_btn, "Remove Authentication Code.")
        Me.Hide_btn.UseVisualStyleBackColor = True
        '
        'Total_Auth_lbl
        '
        Me.Total_Auth_lbl.AutoSize = True
        Me.Total_Auth_lbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Total_Auth_lbl.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Total_Auth_lbl.Location = New System.Drawing.Point(15, 99)
        Me.Total_Auth_lbl.Name = "Total_Auth_lbl"
        Me.Total_Auth_lbl.Size = New System.Drawing.Size(80, 19)
        Me.Total_Auth_lbl.TabIndex = 11
        Me.Total_Auth_lbl.Text = "Total Auth: "
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Secure_Auth.My.Resources.Resources.Information_48x48
        Me.PictureBox1.Location = New System.Drawing.Point(263, 772)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "Make a donation!")
        '
        'Developed_lbl
        '
        Me.Developed_lbl.AutoSize = True
        Me.Developed_lbl.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Developed_lbl.Location = New System.Drawing.Point(11, 776)
        Me.Developed_lbl.Name = "Developed_lbl"
        Me.Developed_lbl.Size = New System.Drawing.Size(162, 13)
        Me.Developed_lbl.TabIndex = 20
        Me.Developed_lbl.Text = "Developed by: Rômulo Meirelles."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Transparent
        Me.ProgressBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ProgressBar1.BaseColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.ProgressBar1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.ProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressBar1.Location = New System.Drawing.Point(247, 80)
        Me.ProgressBar1.Maximum = 30
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColour = System.Drawing.Color.Turquoise
        Me.ProgressBar1.RotationAngle = 360
        Me.ProgressBar1.Size = New System.Drawing.Size(40, 40)
        Me.ProgressBar1.StartingAngle = 360
        Me.ProgressBar1.TabIndex = 19
        Me.ProgressBar1.Text = "ProgressBar1"
        Me.ProgressBar1.TextColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.ToolTip1.SetToolTip(Me.ProgressBar1, "Time to restart the code")
        Me.ProgressBar1.Value = 30
        '
        'Restore_BTN
        '
        Me.Restore_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Restore_BTN.FlatAppearance.BorderSize = 0
        Me.Restore_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Restore_BTN.Image = Global.Secure_Auth.My.Resources.Resources.Restore_32x32
        Me.Restore_BTN.Location = New System.Drawing.Point(256, 38)
        Me.Restore_BTN.Name = "Restore_BTN"
        Me.Restore_BTN.Size = New System.Drawing.Size(32, 32)
        Me.Restore_BTN.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.Restore_BTN, "Restore Your Private Codes.")
        Me.Restore_BTN.UseVisualStyleBackColor = True
        '
        'Backup_BTN
        '
        Me.Backup_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Backup_BTN.FlatAppearance.BorderSize = 0
        Me.Backup_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Backup_BTN.Image = Global.Secure_Auth.My.Resources.Resources.Backup_32x32
        Me.Backup_BTN.Location = New System.Drawing.Point(218, 38)
        Me.Backup_BTN.Name = "Backup_BTN"
        Me.Backup_BTN.Size = New System.Drawing.Size(32, 32)
        Me.Backup_BTN.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.Backup_BTN, "Make Backup your Private Codes")
        Me.Backup_BTN.UseVisualStyleBackColor = True
        '
        'Configuracao_BTN
        '
        Me.Configuracao_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Configuracao_BTN.FlatAppearance.BorderSize = 0
        Me.Configuracao_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Configuracao_BTN.Image = Global.Secure_Auth.My.Resources.Resources.configuration_32x32
        Me.Configuracao_BTN.Location = New System.Drawing.Point(88, 38)
        Me.Configuracao_BTN.Name = "Configuracao_BTN"
        Me.Configuracao_BTN.Size = New System.Drawing.Size(32, 32)
        Me.Configuracao_BTN.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.Configuracao_BTN, "Open Configuration")
        Me.Configuracao_BTN.UseVisualStyleBackColor = True
        '
        'Remove_BTN
        '
        Me.Remove_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Remove_BTN.FlatAppearance.BorderSize = 0
        Me.Remove_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Remove_BTN.Image = Global.Secure_Auth.My.Resources.Resources.Exclude_32x32
        Me.Remove_BTN.Location = New System.Drawing.Point(50, 38)
        Me.Remove_BTN.Name = "Remove_BTN"
        Me.Remove_BTN.Size = New System.Drawing.Size(32, 32)
        Me.Remove_BTN.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.Remove_BTN, "Remove Authentication Code.")
        Me.Remove_BTN.UseVisualStyleBackColor = True
        '
        'Add_BTN
        '
        Me.Add_BTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Add_BTN.FlatAppearance.BorderSize = 0
        Me.Add_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Add_BTN.Image = Global.Secure_Auth.My.Resources.Resources.Add_32x32
        Me.Add_BTN.Location = New System.Drawing.Point(12, 38)
        Me.Add_BTN.Name = "Add_BTN"
        Me.Add_BTN.Size = New System.Drawing.Size(32, 32)
        Me.Add_BTN.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.Add_BTN, "Add new Authentication Code.")
        Me.Add_BTN.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BorderColour = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.OtherPanel)
        Me.GroupBox1.Controls.Add(Me.Copied_lbl)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GroupBox1.HeaderColour = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 122)
        Me.GroupBox1.MainColour = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 649)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.Text = "Secure Code 2FA"
        Me.GroupBox1.TextColour = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Box containing the codes")
        '
        'OtherPanel
        '
        Me.OtherPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.OtherPanel.Controls.Add(Me.Panel1)
        Me.OtherPanel.Location = New System.Drawing.Point(3, 29)
        Me.OtherPanel.Name = "OtherPanel"
        Me.OtherPanel.Size = New System.Drawing.Size(270, 616)
        Me.OtherPanel.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 616)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(4, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(263, 89)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Secure_Auth.My.Resources.Resources.Edit_32x32
        Me.PictureBox2.Location = New System.Drawing.Point(215, 28)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Copied_lbl
        '
        Me.Copied_lbl.AutoSize = True
        Me.Copied_lbl.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Copied_lbl.ForeColor = System.Drawing.Color.Chartreuse
        Me.Copied_lbl.Location = New System.Drawing.Point(198, 7)
        Me.Copied_lbl.Name = "Copied_lbl"
        Me.Copied_lbl.Size = New System.Drawing.Size(56, 19)
        Me.Copied_lbl.TabIndex = 9
        Me.Copied_lbl.Text = "Copied!"
        Me.Copied_lbl.Visible = False
        '
        'VisualStudioSeperator1
        '
        Me.VisualStudioSeperator1.AddEndNotch = False
        Me.VisualStudioSeperator1.BackColor = System.Drawing.Color.Transparent
        Me.VisualStudioSeperator1.FontColour = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.VisualStudioSeperator1.LineColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.VisualStudioSeperator1.Location = New System.Drawing.Point(12, 73)
        Me.VisualStudioSeperator1.Name = "VisualStudioSeperator1"
        Me.VisualStudioSeperator1.OnlyUnderlineText = False
        Me.VisualStudioSeperator1.ShowText = False
        Me.VisualStudioSeperator1.ShowTextAboveLine = False
        Me.VisualStudioSeperator1.Size = New System.Drawing.Size(276, 10)
        Me.VisualStudioSeperator1.TabIndex = 12
        Me.VisualStudioSeperator1.Text = "VisualStudioSeperator1"
        Me.VisualStudioSeperator1.TextAlignment = System.Drawing.StringAlignment.Center
        Me.VisualStudioSeperator1.TextLocation = Secure_Auth.VisualStudioSeperator.__TextLocation.Left
        Me.VisualStudioSeperator1.UnderlineText = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Secure_Auth.My.Resources.Resources.QRCODE_48x48
        Me.PictureBox3.Location = New System.Drawing.Point(177, 28)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 800)
        Me.Controls.Add(Me.VisualStudioContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 800)
        Me.MinimumSize = New System.Drawing.Size(300, 800)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Secure Auth"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.VisualStudioContainer1.ResumeLayout(False)
        Me.VisualStudioContainer1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.OtherPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStudioContainer1 As Secure_Auth.VisualStudioContainer
    Friend WithEvents Hide_btn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Total_Auth_lbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Developed_lbl As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As Secure_Auth.VisualStudioRadialProgressBar
    Friend WithEvents Restore_BTN As System.Windows.Forms.Button
    Friend WithEvents Backup_BTN As System.Windows.Forms.Button
    Friend WithEvents Configuracao_BTN As System.Windows.Forms.Button
    Friend WithEvents Remove_BTN As System.Windows.Forms.Button
    Friend WithEvents Add_BTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As Secure_Auth.VisualStudioGroupBox
    Friend WithEvents Copied_lbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VisualStudioSeperator1 As Secure_Auth.VisualStudioSeperator
    Friend WithEvents Timer_Copied As System.Windows.Forms.Timer
    Friend WithEvents Timer_Count As System.Windows.Forms.Timer
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RestaureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents OtherPanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox

End Class
