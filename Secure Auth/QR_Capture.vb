Imports System.Drawing
Imports ZXing.Common
Imports ZXing
Imports ZXing.QrCode
Imports Google.Authenticator
Public Class QR_Capture
    Dim LOCAT As Point
    Dim pic As Bitmap = New Bitmap(190, 190)
    Dim gfx As Graphics = Graphics.FromImage(pic)

    '********** GERADOR DE CÓDIGO *************
    'DECLARA TFA COMO O AUTENTICADOR
    Dim TFA As New TwoFactorAuthenticator

    'Cole isso no form filho
    Public _Result As String

    ReadOnly Property ResultCaptcha() As String
        Get
            Return _Result
        End Get
    End Property
    Private Sub MSG(ByVal Message As String)
        Dim Notic As New Notice
        Notic.Notice_lbl.Text = Message
        Notic.ShowDialog()
    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDoubleClick
        Call PegarCodigo()
    End Sub
    Function PegarCodigo() As String
        Try
            Dim Reader As New BarcodeReader()
            PictureBox1.Image = pic
            Dim result As Result = Reader.Decode(pic)
            Dim decoded As String = result.ToString().Trim()

            If Not decoded.Contains("otpauth://") Then

                MSG("Invalid QRCode!")
                Return Nothing
            Else
               
                Dim F1 As String = Nothing


                If decoded.Contains("otpauth://totp/") Then
                    F1 = decoded.Replace("otpauth://totp/", "<name>")
                Else
                End If

                If F1.Contains(":") Then
                    F1 = F1.Replace(":", "</name><email>")
                Else
                    F1 = F1.Replace("?secret=", "</name><code>")
                End If

                If F1.Contains("?secret=") Then
                    F1 = F1.Replace("?secret=", "</email><code>")
                Else
                End If

                If F1.Contains("&issuer=") Then
                    F1 = F1.Replace("&issuer=", "</code><company>")
                Else
                    F1 = F1 + "</code>"
                End If

                If F1.Contains("&period=") Then
                    F1 = F1.Replace("&period=", "</company><period>")
                    F1 = F1 + "</period>"
                Else
                    F1 = F1 + "</company>"
                End If


                _Result = F1
                Me.Close()
                Return decoded
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub PictureBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If

        If e.Button = Windows.Forms.MouseButtons.Right Then
            If Me.Height = 200 And Me.Width = 200 Then
                Me.Height = 250
                Me.Width = 250

            ElseIf Me.Height = 250 And Me.Width = 250 Then
                Me.Height = 300
                Me.Width = 300

            ElseIf Me.Height = 300 And Me.Width = 300 Then
                Me.Height = 350
                Me.Width = 350

            ElseIf Me.Height = 350 And Me.Width = 350 Then
                Me.Height = 200
                Me.Width = 200

            End If

        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            gfx.CopyFromScreen(New Point(Me.Location.X + PictureBox1.Location.X + 4, Me.Location.Y + PictureBox1.Location.Y + 30), New Point(0, 0), pic.Size)
            PictureBox1.Image = pic
            PictureBox1.Image = Nothing

        Catch
        End Try
    End Sub
    Dim Timer As Integer = 30
    Private Sub Timer_Exit_Tick(sender As System.Object, e As System.EventArgs) Handles Timer_Exit.Tick
        If Timer = 0 Then
            Dim Timer As Integer = 30
            Timer_Exit.Stop()
            Me.Close()
        Else
            Timer -= 1
            Label1.Text = "Timer: " & Timer.ToString
        End If
    End Sub

    Private Sub Capture_QR_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.Hide()
        Timer = 30
        MSG("Drag the player on the screen to the destination and two clicks to capture, right-click to increase the player.")
        Me.Show()
        Timer_Exit.Start()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Dim Timer As Integer = 30
        Timer_Exit.Stop()
        Me.Close()
    End Sub
End Class