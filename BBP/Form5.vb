Imports System.Security.Cryptography.X509Certificates

Public Class Form5
    Public Property Country As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub Visible_Change(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim form2 As Form2 = Application.OpenForms().OfType(Of Form2)().FirstOrDefault()
            If form2 IsNot Nothing Then
                form2.Current_Form = 5
                form2.Update_Info()
            End If
        End If
    End Sub
    Private Sub Button_Control(sender As Object, e As EventArgs) Handles btnExit.Click, btnInfo.Click, btnMinimize.Click, btnReturn.Click
        Select Case sender.name
            Case "btnExit"
                If MsgBox("Are you sure you want to exit?", vbOKCancel + vbDefaultButton2, "Confirm Exit") = vbOK Then
                    End
                End If
            Case "btnInfo"
                For Each frm As Form In My.Application.OpenForms
                    If frm.Name = "Form2" AndAlso frm.Visible Then
                        Return
                    End If
                Next
                Dim form2 As New Form2()
                form2.Current_Form = 5
                form2.Show()
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
    Sub PreviousImg(sender As Object, e As EventArgs) Handles btnPrev.Click

    End Sub
    Sub NextImg(sender As Object, e As EventArgs) Handles btnNext.Click

    End Sub
    Sub Australia()
        lblCountry.Text = ""
    End Sub
    Sub China()

    End Sub
    Sub Russia()

    End Sub
    Sub Finland()

    End Sub
End Class