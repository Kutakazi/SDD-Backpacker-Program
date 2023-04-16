Public Class Form2
    Public Property Current_Form As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llblGithub.Links(0).LinkData = "https://github.com/Kutakazi/BBP"
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
                Me.Close()
        End Select
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGithub.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
    Sub Case1()
        lblTitle.Text = "Main Page"
        lblInstructions1.Text = "Click On A Flag To Choose Country"
        lblInstructions2.Text = "Click On Return Button To Go To Previous Form"
        lblInstructions3.Text = "Click On Information Button To Open Information"
        lblInstructions4.Text = "Click On Minimize Button To Minimize Form"
        lblInstructions5.Text = "Click On Exit Button To Exit Program"
    End Sub
    Sub Case3()
        lblTitle.Text = "General Information"
        lblInstructions1.Text = "Click On Translator Button To Open Translator"
        lblInstructions2.Text = "Click On Landmarks Button To Open Landmarks"
        lblInstructions3.Text = "Click On Currency Converter Button To Open Currency Converter"
        lblInstructions4.Text = "Click On Map To Enlarge Map"
        lblInstructions5.Text = ""
    End Sub
    Sub Case4()
        lblTitle.Text = "Translator"
        lblInstructions1.Text = "Click On Hide English Radio Button To Hide English"
        lblInstructions2.Text = "Click On Hide Translation Radio Button To Hide Translation"
        lblInstructions3.Text = "Click On A Selected Radio Button To Deselect Radio Button"
        lblInstructions4.Text = "Enter Text In The Text Box And Click The Translate Button To Translate Custom Phrases"
        lblInstructions5.Text = "Check Flip Translations To Reverse Language Translation"
    End Sub
    Sub Case5()
        lblTitle.Text = "Landmarks"
        lblInstructions1.Text = "Click On Control Button To Play And Pause The Slideshow"
        lblInstructions2.Text = "Click Previous To Go Back A Slide"
        lblInstructions3.Text = "Click Next To Go Forward A Slide"
        lblInstructions4.Text = "Click On The Link Lable To Be Brought To The Google Maps Page Of The Landmark"
        lblInstructions5.Text = ""
    End Sub
    Sub Case6()
        lblTitle.Text = "Converter"
        lblInstructions1.Text = "Use Drop Down Menus To Choose Languages"
        lblInstructions2.Text = "Enter A Float Into The Text Box And Click The Convert Button To Convert Amount"
        lblInstructions3.Text = "Check Flip Conversion To Reverse Currency Conversion"
        lblInstructions4.Text = ""
        lblInstructions5.Text = ""
    End Sub
End Class