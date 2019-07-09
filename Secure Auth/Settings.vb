Public Class Settingsss


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
    Private Sub Settings_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If My.Settings.OnTop = True Then
            AwaysTop_ckb.Checked = True
        Else
            AwaysTop_ckb.Checked = False
        End If

        If My.Settings.RequesPassword = True Then
            RequesPass_ckb.Checked = True
        Else
            RequesPass_ckb.Checked = False
        End If
    End Sub

    Private Sub AwaysTop_ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AwaysTop_ckb.CheckedChanged
        If AwaysTop_ckb.Checked = True Then
            My.Settings.OnTop = True
            My.Settings.Save()
            Form1.TopMost = True

        Else
            My.Settings.OnTop = False
            My.Settings.Save()
            Form1.TopMost = False

        End If
    End Sub
    Private Sub RequesPass_ckb_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RequesPass_ckb.CheckedChanged

        If RequesPass_ckb.Checked = True Then
            My.Settings.RequesPassword = True
            My.Settings.Save()
        Else
            My.Settings.RequesPassword = False
            My.Settings.Save()
        End If
    End Sub
    Private Sub VisualStudioButton1_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton1.Click

        'VERIFICA SE A CAIXA DO NOVO PASSWORD ESTA VAZIA
        If TextBox1_New_Pass.Text = "" Then
            MSG("Please enter a valid password", 2)
            TextBox1_New_Pass.Text = ""
            lTextBox2_Old_Password.Text = ""
            Return
        Else
            'VERIFICA SE A SENHA ATUA ESTA CORRETA
            If VerifyPassword(lTextBox2_Old_Password.Text) = True Then

                'CASO TUDO OCORRER BEM A SENHA SERÁ TROCADA
                If ChangePassword(TextBox1_New_Pass.Text, lTextBox2_Old_Password.Text) = True Then
                    MSG("Your password has been successfully modified!", 1)

                    My.Settings.Password = AES_Encrypt(TextBox1_New_Pass.Text, "SecureLine2019")
                    My.Settings.Save()
                    Form1.Senha = TextBox1_New_Pass.Text
                    TextBox1_New_Pass.Text = ""
                    lTextBox2_Old_Password.Text = ""
                    Me.Close()
                Else
                    MSG("Your password has not been modified by any mistake!", 2)
                    TextBox1_New_Pass.Text = ""
                    lTextBox2_Old_Password.Text = ""
                    Return
                End If
            Else
                MSG("The old password is not correct.", 2)
                TextBox1_New_Pass.Text = ""
                lTextBox2_Old_Password.Text = ""
                Return
            End If
        End If

    End Sub


End Class