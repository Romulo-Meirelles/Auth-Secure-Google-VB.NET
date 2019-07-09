Imports System.IO
Imports Secure_Auth.SQLite_Module
Public Class PasswordDataBase
    ' Dim PASS As New Criptografia
    Dim Path As String = Directory.GetCurrentDirectory & "\Secure Auth Database.sad"

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        If File.Exists(Path) Then
            Label1.Text = "Inside your Password Database."
        Else
            Label1.Text = "Inside your new Password Database."
            DontForget_lbl.Visible = True
        End If
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub VisualStudioButton1_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton1.Click
        On Error Resume Next
        If TextBox1.Text <> "" Then

            CreateDB(TextBox1.Text)


            If VerifyPassword(TextBox1.Text) = True Then

                My.Settings.Password = AES_Encrypt(TextBox1.Text, "SecureLine2019")
                My.Settings.Save()
                Me.Hide()
                Form1.Senha = AES_Decrypt(My.Settings.Password, "SecureLine2019")
                Form1.ShowDialog()

            Else
                Me.Show()
                Wrong_Pass_lbl.Text = "Wrong Password."
                Wrong_Pass_lbl.Visible = True
                Timer_WrongPass.Start()
            End If

        Else

            If File.Exists(Path) Then
                Wrong_Pass_lbl.Text = "Enter a Password."
                Wrong_Pass_lbl.Visible = True
                Timer_WrongPass.Start()
            Else
                Wrong_Pass_lbl.Text = "Enter a New Password."
                Wrong_Pass_lbl.Visible = True
                Timer_WrongPass.Start()
            End If
           
            Me.Show()
        End If


        
    End Sub

    Private Sub Timer_WrongPass_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_WrongPass.Tick
        Wrong_Pass_lbl.Visible = False
        Timer_WrongPass.Stop()
    End Sub

    Private Sub VisualStudioButton2_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton2.Click
        End
    End Sub
End Class