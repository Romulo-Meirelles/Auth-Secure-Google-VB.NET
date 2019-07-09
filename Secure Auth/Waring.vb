Public Class Waring
    'Cole isso no form filho
    Private _ResultCaptcha As Boolean
    Public Property NameItem As String

    ReadOnly Property ResultCaptcha() As Boolean
        Get
            Return _ResultCaptcha
        End Get
    End Property
    Private Sub VisualStudioButton1_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton1.Click
        _ResultCaptcha = True
        Me.Close()
    End Sub

    Private Sub VisualStudioButton2_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton2.Click
        _ResultCaptcha = False
        Me.Close()
    End Sub

    Private Sub Waring_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Title_lbl.Text = "Remove " & NameItem & ":"
    End Sub
End Class