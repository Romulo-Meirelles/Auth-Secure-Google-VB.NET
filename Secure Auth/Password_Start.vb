Imports System.IO

Public Class Password_Start
    Dim Path As String = Directory.GetCurrentDirectory & "\Secure Auth Database.sad"

    Private Sub MSG(ByVal Message As String, ByVal Erro As Int16)
        Dim Notic As New Notice

        If Erro = 1 Then
            Notic.Notice_lbl.Text = Message
            Notic.Notice_lbl.ForeColor = Color.LimeGreen
            Notic.ShowDialog()
            Return
        ElseIf Erro = 2 Then
            Notic.Notice_lbl.Text = Message
            Notic.Notice_lbl.ForeColor = Color.Red
            Notic.ShowDialog()
            Return
        End If

        Notic.Notice_lbl.Text = Message
        Notic.ShowDialog()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If File.Exists(Path) Then
            If VerifyPassword(TextBox1.Text) = True Then

                Form1.Senha = TextBox1.Text
                Form1.Show()
                Me.Close()
                Return
            Else
                MSG("Invalid Password!", 2)
                TextBox1.Text = ""
                Return
            End If
        Else
            PasswordDataBase.Show()
            Return
        End If
    End Sub

    Private Sub VisualStudioButton1_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton1.Click
        End
    End Sub
    Private Sub Password_Start_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TextBox1.Select()
        TextBox1.Focus()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            e.Handled = True

            If File.Exists(Path) Then
                If VerifyPassword(TextBox1.Text) = True Then

                    Form1.Senha = TextBox1.Text
                    Form1.Show()
                    Me.Close()
                    Return
                Else
                    MSG("Invalid Password!", 2)
                    TextBox1.Text = ""
                    Return
                End If
            Else
                PasswordDataBase.Show()
                Return
            End If
        End If
    End Sub

    Private Sub TextBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class