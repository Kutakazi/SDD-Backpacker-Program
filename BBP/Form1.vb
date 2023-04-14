Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Bar_Button_Control(sender As Object, e As EventArgs) Handles btnExit.Click, btnInfo.Click, btnMinimize.Click
        Select Case sender.name
            Case "btnExit"
                If MsgBox("Are you sure you want to exit?", vbOKCancel + vbDefaultButton2, "Confirm Exit") = vbOK Then
                    End
                End If
            Case "btnInfo"
                Dim form2 As New Form2
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
End Class