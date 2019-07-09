Public Class Informe_Code
    'Cole isso no form filho
    Public _Result As String

    ReadOnly Property Result() As String
        Get
            Return _Result
        End Get
    End Property

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Hide()
        Dim DialogResul As Windows.Forms.DialogResult
        DialogResul = QR_Capture.ShowDialog
        _Result = QR_Capture._Result
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Me.Hide()
        Form1.Hide()
        Dim DialogResul As Windows.Forms.DialogResult
        DialogResul = ManualCode.ShowDialog
        _Result = ManualCode._Result
        Me.Close()
    End Sub
End Class