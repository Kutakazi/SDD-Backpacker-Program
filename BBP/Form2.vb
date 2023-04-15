Public Class Form2
    Public Property Current_Form As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llblGithub.Links.Add(0, 11, "https://github.com/Kutakazi/BBP")
        Update_Info()
    End Sub
    Public Sub Update_Info()
        Select Case Current_Form
            Case 1
                Case1()
            Case 3
                Case3()
            Case 4
                Case4()
            Case 5
                Case5()
            Case 6
                Case6()
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
                For Each frm As Form In My.Application.OpenForms
                    If frm.Name = "Form1" AndAlso frm.Visible Then
                        Me.Close()
                        Return
                    End If
                Next
                Dim form1 As New Form1()
                form1.Show()
                Me.Close()
        End Select
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGithub.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Sub Case1()
        lblTitle.Text = "Main Page"
        lblInstructions1.Text = ""
        lblInstructions2.Text = ""
        lblInstructions3.Text = ""
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
    Sub Case3()
        lblTitle.Text = "General Information"
        lblInstructions1.Text = ""
        lblInstructions2.Text = ""
        lblInstructions3.Text = ""
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
    Sub Case4()
        lblTitle.Text = "Translator"
        lblInstructions1.Text = ""
        lblInstructions2.Text = ""
        lblInstructions3.Text = ""
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
    Sub Case5()
        lblTitle.Text = "Landmarks"
        lblInstructions1.Text = ""
        lblInstructions2.Text = ""
        lblInstructions3.Text = ""
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
    Sub Case6()
        lblTitle.Text = "Convertor"
        lblInstructions1.Text = ""
        lblInstructions2.Text = ""
        lblInstructions3.Text = ""
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
End Class