Public Class Form3
    Public Property Country As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Country
        Select Case Country
            Case "Australia"
                Australia()
            Case "China"
                China()
            Case "Russia"
                Russia()
            Case "Finland"
                Finland()
        End Select
    End Sub
    Sub Australia()

    End Sub
    Sub China()

    End Sub
    Sub Russia()

    End Sub
    Sub Finland()

    End Sub
End Class