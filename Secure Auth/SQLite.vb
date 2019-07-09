Imports System.Data.SQLite
Imports System.IO
Imports Google.Authenticator
Imports System.Net
Imports ZXing.Aztec
'Imports System.Data.SqlClient
'Imports System.Data.OleDb

Module SQLite_Module
    'Declara as variaveis para a conexão.
    Dim SQLconnect As New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand
    '********** GERADOR DE CÓDIGO *************
    'DECLARA TFA COMO O AUTENTICADOR
    Dim TFA As New TwoFactorAuthenticator

    Public Function LoadCode(ByVal Password) As Boolean

        Try
            'reset container
            Form1.ContainerControlQuant = 0
            Form1.Total_Auth_lbl.Text = "Total Auth: " & 0
            Form1.Panel1.Controls.Clear()

            'Se conecta com o banco de dados.
            SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""

            'Abre a conexão com SQLite
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand

            Dim Query As String = "SELECT * FROM Secure_Auth"
            Dim sadapter As New SQLiteDataAdapter
            'Dim scommand As New SQLiteCommand
            Dim sqltable As New DataTable

            Dim i As Integer
            With SQLcommand
                .CommandText = Query
                .Connection = SQLconnect
            End With
            With sadapter
                .SelectCommand = SQLcommand
                .Fill(sqltable)
            End With

            'Dim GA As New ListViewGroup
            For i = 0 To sqltable.Rows.Count - 1

                Form1.Total_Auth_lbl.Text = "Total Auth: " & i

                Dim Name As String = sqltable.Rows(i)("Name")
                Dim EMail As String = sqltable.Rows(i)("EMail")
                Dim SecretKey As String = sqltable.Rows(i)("Code")
                Dim Company As String = sqltable.Rows(i)("Company")
                Dim Period As String = sqltable.Rows(i)("Period")

                Dim PIC As New PictureBox
                PIC.Width = 32
                PIC.Height = 32
                PIC.SizeMode = PictureBoxSizeMode.StretchImage

                TFA.TryUnmanagedAlgorithmOnFailure = True
                TFA.UseManagedSha1Algorithm = True
                TFA.DefaultClockDriftTolerance = System.TimeSpan.FromSeconds(30)

                Dim Setup = TFA.GenerateSetupCode(Name, SecretKey, PIC.Width, PIC.Height)
                Dim SetupName = Setup.Account
                Dim EncodedKey = Setup.ManualEntryKey


                PIC.Image = My.Resources.QRCODE_48x48


                Form1.Add(SetupName, EMail, TFA.GetCurrentPIN(DecodeFromBase32String(SecretKey)), PIC)
                Form1.ContainerControlQuant += 1
                Form1.Total_Auth_lbl.Text = "Total Auth: " & Form1.ContainerControlQuant

            Next

            'Fecha as conexoes
            SQLconnect.Close()
            Return True
        Catch
            SQLconnect.Close()
            Return False
        End Try
    End Function
    Public Function CreateDB(ByVal Password As String) As Boolean
        Try
            Dim Path As String = Directory.GetCurrentDirectory & "\Secure Auth Database.sad"

            If File.Exists(Path) Then
                Return False
            Else
                ''create db
                SQLiteConnection.CreateFile("Secure Auth Database.sad")
                ''sett conn details
                SQLconnect = New SQLiteConnection()
                SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""
                'Abre a conexão com SQLite
                SQLconnect.Open()
                SQLcommand = SQLconnect.CreateCommand
                'Cria tabela com o nome do Grupo
                SQLcommand.CommandText = "CREATE TABLE Secure_Auth (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Email TEXT, Code TEXT, Company TEXT, Period TEXT);"
                'Executa a Query Acima
                SQLcommand.ExecuteNonQuery()
                SQLconnect.Close()
                Return True
            End If

        Catch
            Return False
        End Try
    End Function

    Public Function VerifyPassword(ByVal Password As String) As Boolean
        Try
            'next time you open db use this code:
            SQLconnect = New SQLiteConnection()
            Using Query As New SQLiteCommand()
                SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""
                SQLconnect.Open()
                With Query
                    .Connection = SQLconnect
                    .CommandText = "SELECT * FROM Secure_Auth"
                End With
                Query.ExecuteNonQuery()
            End Using

            SQLconnect.Close()
            Return True
        Catch
            SQLconnect.Close()
            Return False
        End Try
    End Function

    Public Function ChangePassword(ByVal NewPassword As String, ByVal OldPassword As String) As Boolean

        Try
            SQLconnect = New SQLiteConnection()
            Using Query As New SQLiteCommand()
                SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & OldPassword & ""
                SQLconnect.Open()
                With Query
                    .Connection = SQLconnect
                    .CommandText = "SELECT * FROM Secure_Auth"
                End With
                Query.ExecuteNonQuery()
                SQLconnect.Close()
            End Using

            ''open and change password
            SQLconnect.Open()
            SQLconnect.ChangePassword(NewPassword)
            SQLconnect.Close()
            Return True
        Catch
            SQLconnect.Close()
            Return False
        End Try
    End Function
    Public Function CheckName(ByVal Name As String, ByVal Password As String) As Boolean

        Try
            SQLconnect = New SQLiteConnection()
            Using Query As New SQLiteCommand()
                SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""
                SQLconnect.Open()
                With Query
                    .Connection = SQLconnect
                    .CommandText = "SELECT * FROM Secure_Auth WHERE Name = @user"
                    .Parameters.AddWithValue("@user", Name)
                    .Prepare()
                End With

                Dim Reader As SQLite.SQLiteDataReader = Query.ExecuteReader

                If Reader.HasRows Then
                    Query.Parameters.Clear()
                    Reader.Close()
                    SQLconnect.Close()
                    'SQLconnect.Dispose()
                    Return True
                Else
                    Query.Parameters.Clear()
                    Reader.Close()
                    SQLconnect.Close()
                    '   SQLconnect.Dispose()
                    Return False
                End If
            End Using

        Catch
            SQLconnect.Close()
            Return False
        End Try
    End Function

    Public Function DeleteItem(ByVal Name As String, ByVal Password As String) As Boolean
        Try
            'next time you open db use this code:
            SQLconnect = New SQLiteConnection()
            Using Query As New SQLiteCommand()
                SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""
                SQLconnect.Open()
                With Query
                    .Connection = SQLconnect
                    .CommandText = "DELETE FROM Secure_Auth WHERE Name = @name"
                    .Parameters.AddWithValue("@name", Name)
                    .Prepare()
                End With

                Query.ExecuteNonQuery()
                Query.Parameters.Clear()
                SQLconnect.Close()
                Return True
            End Using

        Catch
            SQLconnect.Close()
            Return False
        End Try
    End Function

    Public Function InsertCode(ByVal Name As String, ByVal EMail As String, ByVal Code As String, ByVal Company As String, ByVal Password As String, Optional ByVal Period As Integer = 30) As Boolean
        Try
            'Se conecta com o banco de dados.
            SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""

            'Abre a conexão com SQLite
            SQLconnect.Open()
            SQLcommand = SQLconnect.CreateCommand

            'Cria tabela com o nome do Grupo
            SQLcommand.CommandText = "INSERT INTO Secure_Auth (Name, EMail, Code, Company, Period) values ('" & Name & "','" & EMail & "','" & Code & "','" & Company & "','" & Period & "')"

            'Executa a Query Acima
            SQLcommand.ExecuteNonQuery()

            'Fecha as conexoes
            SQLconnect.Close()
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Function UpdateName(ByVal Name As String, ByVal NewName As String, Password As String) As Boolean

        'next time you open db use this code:
        SQLconnect = New SQLiteConnection()
        Using Query As New SQLiteCommand()
            SQLconnect.ConnectionString = "Data Source=Secure Auth Database.sad; Version=3; Compress=False; Integrated Security=True; Password=" & Password & ""
            SQLconnect.Open()
            With Query
                .Connection = SQLconnect
                .CommandText = "UPDATE Secure_Auth SET Name = @newname WHERE Name = @name"
                .Parameters.AddWithValue("@name", Name)
                .Parameters.AddWithValue("@newname", NewName)
                .Prepare()
            End With

            Query.ExecuteNonQuery()
            Query.Parameters.Clear()
            SQLconnect.Close()
            Return True
        End Using


    End Function
End Module
