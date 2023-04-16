Public Class Form7
    Public Property Country As String
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Map Of " & Country
        Select Case Country
            Case "Australia"
                pbMain.BackgroundImage = My.Resources.MapAus
                pbMain.Width = 546
                pbMain.Height = 591
                pbMain.Location = New Point(259, 90)
            Case "China"
                pbMain.BackgroundImage = My.Resources.MapChina
                pbMain.Width = 647
                pbMain.Height = 591
                pbMain.Location = New Point(209, 90)
            Case "Russia"
                pbMain.BackgroundImage = My.Resources.MapRussia
                pbMain.Width = 739
                pbMain.Height = 591
                pbMain.Location = New Point(163, 90)
            Case "Finland"
                pbMain.BackgroundImage = My.Resources.MapFinland
                pbMain.Width = 474
                pbMain.Height = 591
                pbMain.Location = New Point(295, 90)
        End Select
    End Sub
    Private Sub Button_Control(sender As Object, e As EventArgs) Handles btnExit.Click, btnMinimize.Click, btnReturn.Click
        Select Case sender.name
            Case "btnExit"
                If MsgBox("Are you sure you want to exit?", vbOKCancel + vbDefaultButton2, "Confirm Exit") = vbOK Then
                    End
                End If
            Case "btnMinimize"
                Me.WindowState = FormWindowState.Minimized
            Case "btnReturn"
                Dim form3 As New Form3
                form3.Country = Country
                Me.Hide()
                form3.StartPosition = FormStartPosition.Manual
                form3.Location = Me.Location
                form3.Show()
        End Select
    End Sub
End Class