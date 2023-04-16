Imports System.Dynamic
Imports System.Net
Imports System.Net.WebRequestMethods
Imports System.Security.Policy
Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form6
    Dim sub_data As String
    Dim flip As Boolean = False
    Dim leftcur As String
    Dim rightcur As String
    Public Property Country As String
    Dim data As String
    Structure Record
        Dim text As String
        Dim Rate As Double
    End Structure
    Dim rates As Array
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbRight.DropDownStyle = ComboBoxStyle.DropDownList
        cbleft.DropDownStyle = ComboBoxStyle.DropDownList
        Select Case Country
            Case "Australia"
                cbRight.SelectedItem = "AUD (Australian Dollar)"
            Case "China"
                cbRight.SelectedItem = "CNY (Renminbi)"
            Case "Russia"
                cbRight.SelectedItem = "RUB (Russian Ruble)"
            Case "Finland"
                cbRight.SelectedItem = "EUR (Euro)"
        End Select
        cbleft.SelectedItem = "USD (United States Dollar)"
        lblExchangeLeft.Text = "? " & cbleft.SelectedItem
        lblExchangeRight.Text = "? " & cbRight.SelectedItem
        Change()
    End Sub
    Private Sub Visible_Change(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim form2 As Form2 = Application.OpenForms().OfType(Of Form2)().FirstOrDefault()
            If form2 IsNot Nothing Then
                form2.Current_Form = 6
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
                form2.Current_Form = 6
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
    Private Sub Change() Handles cbleft.SelectedIndexChanged, cbRight.SelectedIndexChanged
        Dim left As String = cbleft.SelectedItem
        Dim right As String = cbRight.SelectedItem
        If Not String.IsNullOrEmpty(left) Then
            leftcur = left.Substring(0, 3)
            lblAmountLeft.Text = "Amount In " & leftcur
        End If
        If Not String.IsNullOrEmpty(right) Then
            rightcur = right.Substring(0, 3)
            lblAmountRight.Text = "Amount In " & rightcur
        End If
        Update()
    End Sub
    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        If cb1.Checked Then
            lblConvertLeft.Text = "Convert To"
            lblConvertRight.Text = "Convert From"
            tbRight.ReadOnly = False
            tbLeft.ReadOnly = True
            flip = True
        Else
            lblConvertLeft.Text = "Convert From"
            lblConvertRight.Text = "Convert To"
            tbLeft.ReadOnly = False
            tbRight.ReadOnly = True
            flip = False
        End If
    End Sub
    Sub Update()
        Dim localTime As DateTime = DateTime.Now
        lblUpdate.Text = "Last Updated: " & localTime
        Dim Url As String = "https://api.freecurrencyapi.com/v1/latest?apikey=Ja3TYpjkBfQOrG4IGulrVOf9xWuXjxmJnL33fR4P&currencies=" & rightcur
        Dim request As HttpWebRequest = HttpWebRequest.Create(Url)
        request.Proxy = Nothing

        Dim response As HttpWebResponse = request.GetResponse
        Dim response_stream As System.IO.Stream = response.GetResponseStream

        Dim stream_reader As New System.IO.StreamReader(response_stream)
        Dim data As String = stream_reader.ReadToEnd
        stream_reader.Close()
        Dim data_length As Integer = Len(data) - 2
        Dim trim_data As String = data.Substring(0, data_length)
        Dim trim_length As Integer = Len(trim_data)
        sub_data = trim_data.Substring(15)
        lblExchangeLeft.Text = "1 USD (United States Dollar)"
        lblExchangeRight.Text = sub_data & " " & cbRight.SelectedItem
    End Sub
    Private Sub Convert(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim num_right As Single
        Dim num_left As Single
        Update()
        If flip = False And tbLeft.Text <> "" Then
            Single.TryParse(sub_data, num_right)
            Single.TryParse(tbLeft.Text, num_left)
            tbRight.Text = num_right * num_left
        ElseIf flip = True And tbRight.Text <> "" Then
            Single.TryParse(tbRight.Text, num_right)
            Single.TryParse(sub_data, num_left)
            tbLeft.Text = num_right / num_left
        Else
            MessageBox.Show("Please enter an amount to convert.")
        End If
    End Sub
    Private Sub tb_Change(sender As Object, e As EventArgs) Handles tbLeft.TextChanged, tbRight.TextChanged
        Dim Number As Single
        If Single.TryParse(sender.Text, Number) Then
        ElseIf sender.text <> "" Then
            MessageBox.Show("The input is not a float. Please enter a float.")
            sender.text = ""
        End If
    End Sub
End Class