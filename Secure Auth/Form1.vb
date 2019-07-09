Imports System.Text.RegularExpressions
Imports System.Data.SQLite
Imports System.Data
Imports Google.Authenticator
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Imports System.Collections.Specialized
Imports System.Web.UI
Imports System.Web
Imports System.Net

Public Class Form1

    'Declara as variaveis para a conexão.
    Dim SQLconnect As New SQLiteConnection()
    Dim SQLcommand As SQLiteCommand

    'DECLARA OS OBJETOS
    Dim ProgressMaxValue As Integer = 30
    Dim ProgressValue As Integer
    Public ContainerControlQuant As Integer = 0
    Public Property Senha As String
    Dim NameItem As String
    Dim CountAdd As Integer = 0
    Dim TIM As String = Date.Now.Second

    Dim TFS As New SetupCode

    Private Sub MSG(ByVal Message As String, Optional ByVal Number As Int16 = Nothing)
        Dim Notic As New Notice

        If Number = 1 Then
            Notic.Notice_lbl.Text = Message
            Notic.ForeColor = Color.LimeGreen
            Notic.ShowDialog()
        ElseIf Number = 2 Then
            Notic.Notice_lbl.Text = Message
            Notic.ForeColor = Color.Red
            Notic.ShowDialog()
        Else
            Notic.Notice_lbl.Text = Message
            Notic.ShowDialog()
        End If

    End Sub
    Private Sub Configuracao_BTN_Click(sender As System.Object, e As System.EventArgs) Handles Configuracao_BTN.Click
        If Application.OpenForms.OfType(Of Settingsss)().Count() > 0 Then
            Settingsss.WindowState = FormWindowState.Normal
        Else
            Settingsss.Show()
        End If
    End Sub
    Private Sub Form1_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        If LoadCode(Senha) = True Then
        Else
            MSG("Database error, correct them!", 2)
        End If

        'COLOCA O VALOR DO MAX PROGRESS
        ProgressBar1.Value = ProgressMaxValue
        ProgressBar1.Maximum = ProgressMaxValue


        'SINCRONIZA O TIMER COM O RELOGIO DO COMPUTADOR
        If TIM < ProgressMaxValue Then
            Dim CONT As Integer = ProgressMaxValue - TIM
            ProgressBar1.Value = CONT
            Timer_Count.Start()
        ElseIf TIM > ProgressMaxValue Then
            Dim CONT As Integer = (TIM - ProgressMaxValue)
            ProgressBar1.Value = ProgressMaxValue - CONT
            Timer_Count.Start()
        End If


        'PARA O CONTADOR SE NÃO HOUVER NENHUM ITEM
        If Panel1.Controls.Count = 0 Then
            Timer_Count.Stop()
            ProgressBar1.Value = ProgressMaxValue
        End If

    End Sub
    Private Sub Add_BTN_Click(sender As System.Object, e As System.EventArgs) Handles Add_BTN.Click
        ' Dim Insert As Informe_Code

        If Application.OpenForms.OfType(Of Informe_Code)().Count() > 0 Then
            Informe_Code.WindowState = FormWindowState.Normal

        ElseIf Application.OpenForms.OfType(Of ManualCode)().Count() > 0 Then
            ManualCode.WindowState = FormWindowState.Normal

        ElseIf Application.OpenForms.OfType(Of QR_Capture)().Count() > 0 Then
            QR_Capture.WindowState = FormWindowState.Normal
        Else

            Dim DialogResul As Windows.Forms.DialogResult
            DialogResul = Informe_Code.ShowDialog


            Me.Show()

            If Informe_Code.Result <> "" Then



                Dim Nom As Regex
                Nom = New Regex("(?<=<name>).+(?=</name>)")
                Dim Nome As String = Nom.Match(Informe_Code.Result).Value



                Dim Ema As Regex
                Ema = New Regex("(?<=<email>).+(?=</email>)")
                Dim Email As String = Ema.Match(Informe_Code.Result).Value


                Dim Cod As Regex
                Cod = New Regex("(?<=<code>).+(?=</code>)")
                Dim Codigo As String = Cod.Match(Informe_Code.Result).Value



                Dim Comp As Regex
                Comp = New Regex("(?<=<company>).+(?=</company>)")
                Dim Company As String = Comp.Match(Informe_Code.Result).Value


                Dim Per As Regex
                Per = New Regex("(?<=<period>).+(?=</period>)")
                Dim Periodo As String = Per.Match(Informe_Code.Result).Value

                If Periodo = "" Then
                    Periodo = 30
                End If




                If Nome = "" Then
                    MSG("Null Name!", 2)
                    'limpa as cadeias para não retornar resultado nulo
                    Informe_Code._Result = Nothing
                    ManualCode._Result = Nothing
                    QR_Capture._Result = Nothing
                    Return
                End If

                If Codigo = "" Then
                    MSG("Null Code!", 2)
                    'limpa as cadeias para não retornar resultado nulo
                    Informe_Code._Result = Nothing
                    ManualCode._Result = Nothing
                    QR_Capture._Result = Nothing
                    Return
                End If


                Dim I As Integer = 1
                Dim Rep As String = Nome

                While CheckName(Nome, Senha) = True
                    Nome = Rep + " (" & I & ")"
                    I += 1
                End While

                If InsertCode(Nome, Email, Codigo, Company, Senha, Periodo) = True Then
                    'limpa as cadeias para não retornar resultado nulo
                    Informe_Code._Result = Nothing
                    ManualCode._Result = Nothing
                    QR_Capture._Result = Nothing

                Else
                    MSG("Unable to insert into database, check database integrity.", 2)
                End If

                LoadCode(Senha)
            Else

            End If


        End If


    End Sub
    Private Sub Remove_BTN_Click(sender As System.Object, e As System.EventArgs) Handles Remove_BTN.Click

        If NameItem = "" Then
            MSG("Choose Item!", 2)
        Else
            Me.Hide()
            Dim ResponseCaptcha As Boolean
            Dim SuaForm As New Waring
            SuaForm.NameItem = NameItem
            Dim DialogResul As Windows.Forms.DialogResult

            DialogResul = SuaForm.ShowDialog
            ResponseCaptcha = SuaForm.ResultCaptcha
            Me.Show()

            If ResponseCaptcha = True Then

                If CheckName(NameItem, Senha) = True Then

                    If DeleteItem(NameItem, Senha) = True Then
                        Call LoadCode(Senha)
                    Else
                        MSG("Impossible to delete.", 2)
                    End If
                Else
                    MSG("Can not, item does not exist.", 2)
                End If
            Else
                'Escolher cancelar
            End If
        End If

        'PARA O CONTADOR 
        If Panel1.Controls.Count = 0 Then
            Timer_Count.Stop()
            ProgressBar1.Value = ProgressMaxValue
        End If



    End Sub

    Public Sub Add(ByVal Name As String, ByVal EMail As String, ByVal CODIGO As String, ByVal Imagem As PictureBox)

        Dim Pan1 As Panel
        Dim Pan2 As Panel
        Dim Lab1 As Label
        Dim Lab2 As Label
        Dim Lab3 As Label
        Dim Pic As PictureBox
        Dim Pic2 As PictureBox

        'DECLARA O PAINEL E INSERE DENTRO DO PANEL1
        Pan2 = New Panel
        Pan2.BackColor = Color.FromArgb(45, 45, 48)
        Pan2.Dock = System.Windows.Forms.DockStyle.Top
        Pan2.Location = New System.Drawing.Point(3, 3)
        Pan2.Name = Name
        Pan2.Size = New System.Drawing.Size(267, 89)
        Pan2.BorderStyle = BorderStyle.None
        Pan2.TabIndex = 0
        AddHandler Pan2.Click, AddressOf Me.Get_Name
        Panel1.Controls.Add(Pan2)


        'INSERE UM PANEL SEPARADOR DENTRO DO PAN2
        Pan1 = New Panel
        Pan1.BackColor = Color.FromArgb(37, 37, 38)
        Pan1.Dock = System.Windows.Forms.DockStyle.Top
        Pan1.Size = New System.Drawing.Size(294, 5)
        Pan1.TabIndex = 1
        Pan2.Controls.Add(Pan1)

        'DECLARA A LABEL COM O NOME
        Lab1 = New Label
        Lab1.ForeColor = System.Drawing.Color.Turquoise
        Lab1.BackColor = Drawing.Color.Transparent
        Lab1.Location = New System.Drawing.Point(4, 5)
        Lab1.Name = "_Name" & CountAdd
        Lab1.Size = New System.Drawing.Size(186, 17)
        Lab1.TabIndex = 2
        Lab1.Text = Name
        Lab1.Visible = True
        Pan2.Controls.Add(Lab1)

        'DECLARA A LABEL COM O EMAIL
        Lab2 = New Label
        Lab2.ForeColor = System.Drawing.Color.White
        Lab2.BackColor = Drawing.Color.Transparent
        Lab2.Location = New System.Drawing.Point(4, 70)
        Lab2.Name = "_EMail" & CountAdd
        Lab2.Size = New System.Drawing.Size(250, 40)
        Lab2.TabIndex = 3
        Lab2.Text = EMail
        Lab2.Visible = True
        Pan2.Controls.Add(Lab2)

        'EDITAR ICONE PICTUREBOX
        Pic = New PictureBox
        Pic.Cursor = System.Windows.Forms.Cursors.Hand
        Pic.Image = Global.Secure_Auth.My.Resources.Resources.Edit_32x32
        Pic.Location = New System.Drawing.Point(230, 30)
        Pic.Name = Name
        Pic.Size = New System.Drawing.Size(32, 32)
        Pic.TabIndex = 0
        Pic.TabStop = False
        AddHandler Pic.Click, AddressOf Me.Edit_Name
        Pan2.Controls.Add(Pic)

        'QRCODE PICTUREBOX
        Pic2 = New PictureBox
        Pic2.Cursor = System.Windows.Forms.Cursors.Hand
        Pic2.Image = Imagem.Image
        Pic2.SizeMode = PictureBoxSizeMode.StretchImage
        Pic2.Location = New System.Drawing.Point(190, 30)
        Pic2.Name = Name
        Pic2.Size = New System.Drawing.Size(32, 32)
        Pic2.TabIndex = 0
        Pic2.TabStop = False
        AddHandler Pic.Click, AddressOf Me.QR_Code
        Pan2.Controls.Add(Pic2)

        'DECLARA A LABEL COM O CODIGO
        Lab3 = New Label
        Lab3.AutoSize = True
        Lab3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lab3.ForeColor = System.Drawing.Color.White
        Lab3.BackColor = Drawing.Color.Transparent
        Lab3.Location = New System.Drawing.Point(35, 32)
        Lab3.Name = "_Code" & CountAdd
        Lab3.Size = New System.Drawing.Size(97, 25)
        Lab3.TabIndex = 4
        Lab3.Cursor = Cursors.Hand
        Lab3.Text = CODIGO
        AddHandler Lab3.Click, AddressOf Me.Code_Copied
        Pan2.Controls.Add(Lab3)



        'SELECIONA O PAINEL PRINCIPAL
        Me.Panel1.Select()

        'COMEÇA A CONTAGEM
        Timer_Count.Start()
        CountAdd += 1
    End Sub
    Private Sub Get_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Panel = sender

        If selectedBtn.BackColor = Color.FromArgb(45, 45, 48) Then
            selectedBtn.BackColor = Color.LightBlue
            NameItem = selectedBtn.Name
            '  selectedBtn.Select()

        Else
            selectedBtn.BackColor = Color.FromArgb(45, 45, 48)
            NameItem = Nothing
        End If

    End Sub
    Private Sub QR_Code(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As PictureBox = sender
        'Dim wc As WebClient = New WebClient()
        'Dim ms As MemoryStream = New MemoryStream(wc.DownloadData(SetupCode.QrCodeSetupImageUrl))
        'selectedBtn.Image = Image.FromStream(ms)
    End Sub
    Private Sub Edit_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As PictureBox = sender

        If Application.OpenForms.OfType(Of Rename)().Count() > 0 Then
            Informe_Code.WindowState = FormWindowState.Normal
        Else
            Dim Renam As New Rename
            Renam.Names = selectedBtn.Name
            Renam.Senha = Senha
            Renam.Show()
        End If
    End Sub
    Private Sub Code_Copied(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim selectedBtn As Label = sender
        Clipboard.SetText(selectedBtn.Text)
        Copied_lbl.Visible = True
        Timer_Copied.Start()
    End Sub

    Private Sub InnerPanel_MouseEnter(sender As Object, e As EventArgs) Handles Panel1.MouseEnter, Panel1.MouseEnter
        Panel1.Select()
    End Sub
    Private Sensitivity As Integer = 5
    Private Sub Panel1_MouseWheel(sender As Object, e As MouseEventArgs) Handles Panel1.MouseWheel
        If Panel1.Bounds.Contains(e.Location) Then
            Panel1.VerticalScroll.Visible = False
            GroupBox1.VerticalScroll.Visible = False
            Dim vScrollPosition As Integer = Panel1.VerticalScroll.Value
            vScrollPosition -= Math.Sign(e.Delta) * Sensitivity
            vScrollPosition = Math.Max(0, vScrollPosition)
            vScrollPosition = Math.Min(vScrollPosition, Me.VerticalScroll.Maximum)
            Panel1.Invalidate()
        End If
    End Sub
    Private Sub Timer_Count_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Count.Tick

        If ProgressBar1.Value = 0 Then
            ProgressBar1.Value = ProgressMaxValue

            Panel1.Controls.Clear()
            LoadCode(Senha)

        Else

            ProgressBar1.Value -= 1
        End If
    End Sub


    Private Sub Timer_Copied_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Copied.Tick
        Copied_lbl.Visible = False
        Timer_Copied.Stop()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        End
    End Sub

    Private Sub RestaureToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RestaureToolStripMenuItem.Click
        If NotifyIcon1.Visible = True Then
            Me.Show()
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If NotifyIcon1.Visible = True Then
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            NotifyIcon1.Visible = False
        End If
    End Sub

    Private Sub Hide_btn_Click(sender As System.Object, e As System.EventArgs) Handles Hide_btn.Click
        If NotifyIcon1.Visible = False Then
            NotifyIcon1.Visible = True
            NotifyIcon1.BalloonTipTitle = "Secure Auth."
            NotifyIcon1.BalloonTipText = "Click twice to open."
            NotifyIcon1.ShowBalloonTip("3000")
            Me.Hide()
        End If

    End Sub

End Class




