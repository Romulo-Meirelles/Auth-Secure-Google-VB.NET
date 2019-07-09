Public Class Rename
    Public Property Senha As String
    Public Property Names As String
    Dim LOCAT As Point

    Private Sub MSG(ByVal Message As String)
        Dim Notic As New Notice
        Notic.Notice_lbl.Text = Message
        Notic.ShowDialog()
    End Sub
    Private Sub VisualStudioButton2_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton2.Click
        Me.Close()
    End Sub

    Private Sub VisualStudioButton1_Click(sender As System.Object, e As System.EventArgs) Handles VisualStudioButton1.Click

        If TextBox_Name.Text = "" Then
            MSG("Please enter a valid name.")
            Return
        End If

        If TextBox_Name.Text = Names Then
            Me.Close()
            Return
        End If

        If CheckName(TextBox_Name.Text, Senha) = True Then
            MSG("This name is already in use, choose another")
        Else
            UpdateName(Names, TextBox_Name.Text, Senha)
            LoadCode(Senha)
            Me.Close()
        End If
    End Sub

    Private Sub Rename_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        TextBox_Name.Text = Names
    End Sub
    Private Sub form_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub
    Private Sub form_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

    Private Sub VisualStudioGroupBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles VisualStudioGroupBox1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            LOCAT = e.Location
        End If
    End Sub


    Private Sub VisualStudioGroupBox1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles VisualStudioGroupBox1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - LOCAT
        End If
    End Sub

End Class