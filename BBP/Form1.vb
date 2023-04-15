Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Visible_Change(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim form2 As Form2 = Application.OpenForms().OfType(Of Form2)().FirstOrDefault()
            If form2 IsNot Nothing Then
                form2.Current_Form = 1
                form2.Update_Info()
            End If
        End If
    End Sub
    Private Sub Bar_Button_Control(sender As Object, e As EventArgs) Handles btnExit.Click, btnInfo.Click, btnMinimize.Click
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
                form2.Current_Form = 1
                form2.Show()
            Case "btnMinimize"
                Me.WindowState = FormWindowState.Minimized
        End Select
    End Sub
    Private Sub pbMain_Image_Change_On_Hover(sender As Object, e As EventArgs) Handles btnAustralia.MouseHover, btnChina.MouseHover, btnRussia.MouseHover, btnFinland.MouseHover
        Select Case sender.name
            Case "btnAustralia"
                pbMain.BackgroundImage = My.Resources.auslandmarkmain
            Case "btnChina"
                pbMain.BackgroundImage = My.Resources.chinalandmarkmain
            Case "btnRussia"
                pbMain.BackgroundImage = My.Resources.russianlandmarkmain
            Case "btnFinland"
                pbMain.BackgroundImage = My.Resources.finlandlandmarkmain
        End Select
    End Sub
    Private Sub pbMain_Image_change_On_Leave(sender As Object, e As EventArgs) Handles btnAustralia.MouseLeave, btnChina.MouseLeave, btnRussia.MouseLeave, btnFinland.MouseLeave
        pbMain.BackgroundImage = My.Resources.world
    End Sub
    Private Sub Switch_Forms(sender As Object, e As EventArgs) Handles btnAustralia.Click, btnChina.Click, btnRussia.Click, btnFinland.Click
        Dim Form3 As New Form3
        Select Case sender.name
            Case "btnAustralia"
                Form3.Country = "Australia"
            Case "btnChina"
                Form3.Country = "China"
            Case "btnRussia"
                Form3.Country = "Russia"
            Case "btnFinland"
                Form3.Country = "Finland"
        End Select
        Me.Hide()
        Form3.StartPosition = FormStartPosition.Manual
        Form3.Location = Me.Location
        Form3.Show()
        Form3.Show()
    End Sub
End Class