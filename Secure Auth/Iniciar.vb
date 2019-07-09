Imports System.Data.SQLite
Imports System.IO
Public Class Iniciar
    'Declara as variaveis para a conexão.
    Dim SQLconnect As New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    ' Dim PASS As New Criptografia
    Dim Path As String = Directory.GetCurrentDirectory & "\Secure Auth Database.sad"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'ESCONDE O FORM
        Me.Hide()

        'VERIFICA SE HÁ O ARQUIVO DATABASE
        If File.Exists(Path) Then

            'CASO O SUARIO INICIO COM ONTOP FORM
            If My.Settings.OnTop = True Then
                Form1.TopMost = True
            End If

            'VERIFICA SE O USUARIO MARCOU A OPÇÃO SEMPRE INICIAR COM SENHA.
            If My.Settings.RequesPassword = True Then
                Dim Password As New Password_Start
                Password.Show()
                Return
            End If


            'VERIFICA SE A SENHA AUTOMATICAMENTE SALVA SE ESTA CORRETA
            If VerifyPassword(AES_Decrypt(My.Settings.Password, "SecureLine2019")) = True Then
                Form1.Senha = AES_Decrypt(My.Settings.Password, "SecureLine2019")
                Form1.Show()
                Return
            Else
                PasswordDataBase.Show()
                Return
            End If


        Else
            PasswordDataBase.Show()
            Return
        End If

    End Sub
End Class
