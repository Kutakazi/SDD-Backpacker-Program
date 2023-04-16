Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Net.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form4
    Dim language As String
    Dim source_language As String = "en"
    Dim target_language As String
    Dim source_text As String
    Public Property Country As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Country
            Case "China"
                language = "zh"
                target_language = "zh"
                China()
            Case "Russia"
                language = "ru"
                target_language = "ru"
                Russia()
            Case "Finland"
                language = "fi"
                target_language = "fi"
                Finland()
        End Select
    End Sub
    Private Sub Visible_Change(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Me.Visible Then
            Dim form2 As Form2 = Application.OpenForms().OfType(Of Form2)().FirstOrDefault()
            If form2 IsNot Nothing Then
                form2.Current_Form = 4
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
                form2.Current_Form = 4
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
    Sub China()
        Dim arial As New Font("Arial", 14, FontStyle.Regular)
        lblTitle.Text = "Chinese Translator"
        lblLanguage.Text = "Chinese"
        rbtnHideTranslation.Text = "Hide Chinese"
        lblT1.Font = arial
        lblT2.Font = arial
        lblT3.Font = arial
        lblT4.Font = arial
        lblT5.Font = arial
        lblT6.Font = arial
        lblT7.Font = arial
        lblT8.Font = arial
        lblT9.Font = arial
        lblT10.Font = arial
        lblT1.Text = "你好吗？"
        lblT2.Text = "你能帮助我吗？"
        lblT3.Text = "可以问路吗？"
        lblT4.Text = "最近的火车站在哪？"
        lblT5.Text = "最近的餐厅在哪里？"
        lblT6.Text = "最近的自动取款机在哪里？"
        lblT7.Text = "最近的洗手间在哪里？"
        lblT8.Text = "最近的酒店在哪里？"
        lblT9.Text = "机场在哪里？"
        lblT10.Text = "最近的警察局在哪里？"
        tbTranslation.Font = arial
    End Sub
    Sub Russia()
        lblTitle.Text = "Russian Translator"
        lblLanguage.Text = "Russian"
        rbtnHideTranslation.Text = "Hide Russian"
        lblT1.Text = "Как дела?"
        lblT2.Text = "Вы можете помочь мне?"
        lblT3.Text = "Могу я спросить у вас дорогу?"
        lblT4.Text = "Где здесь ближайший ЖД вокзал?"
        lblT5.Text = "Где находится ближайший ресторан?"
        lblT6.Text = "Где ближайший банкомат?"
        lblT7.Text = "Где ближайший туалет?"
        lblT8.Text = "Где находится ближайший отель?"
        lblT9.Text = "Где аэропорт?"
        lblT10.Text = "Где находится ближайший полицейский участок?"
    End Sub
    Sub Finland()
        lblTitle.Text = "Finnish Translator"
        lblLanguage.Text = "Finnish"
        rbtnHideTranslation.Text = "Hide Finnish"
        lblT1.Text = "Miten menee?"
        lblT2.Text = "Voitko auttaa minua?"
        lblT3.Text = "Voinko kysyä ohjeita?"
        lblT4.Text = "Missä on lähin rautatieasema?"
        lblT5.Text = "Missä on lähin ravintola?"
        lblT6.Text = "Missä on lähin pankkiautomaatti?"
        lblT7.Text = "Missä on lähin wc?"
        lblT8.Text = "Missä on lähin hotelli?"
        lblT9.Text = "Missä on lentokenttä?"
        lblT10.Text = "Missä on lähin poliisiasema?"
    End Sub
    Private Sub Flip_Translation(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            lblLeft.Text = "Translation"
            lblRight.Text = "Enter Text"
            source_language = language
            target_language = "en"
            tbTranslation.ReadOnly = False
            tbEnglish.ReadOnly = True
        Else
            lblLeft.Text = "Enter Text"
            lblRight.Text = "Translation"
            source_language = "en"
            target_language = language
            tbEnglish.ReadOnly = False
            tbTranslation.ReadOnly = True
        End If
    End Sub
    Sub Check_Input(sender As Object, e As EventArgs) Handles btnTranslate.Click
        If CheckBox1.Checked And tbTranslation.Text <> "" Then
            source_text = tbTranslation.Text
            Translator()
        ElseIf tbEnglish.Text <> "" Then
            source_text = tbEnglish.Text
            Translator()
        Else
            MessageBox.Show("Please enter a message to translate.")
        End If
    End Sub
    Private Sub Translator()
        Dim url As String = "https://api.mymemory.translated.net/get?q=" + source_text + "&langpair=" + source_language + "|" + target_language

        Try
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing

            Dim response As HttpWebResponse = request.GetResponse
            Dim response_stream As System.IO.Stream = response.GetResponseStream

            Dim stream_reader As New System.IO.StreamReader(response_stream)
            Dim data As String = stream_reader.ReadToEnd
            stream_reader.Close()

            Try
                Dim data_length As Integer = Len(data) - 36
                Dim trim_data As String = data.Substring(35, data_length)
                Dim quote_index As Integer = InStr(1, trim_data, ",")
                Dim subdata As String = trim_data.Substring(0, quote_index - 2)
                If CheckBox1.Checked Then
                    tbEnglish.Text = System.Text.RegularExpressions.Regex.Unescape(subdata)
                Else
                    tbTranslation.Text = System.Text.RegularExpressions.Regex.Unescape(subdata)
                End If
            Catch ex As Exception
                If CheckBox1.Checked Then
                    tbEnglish.Text = "Error with code"
                Else
                    tbTranslation.Text = "Error with code"
                End If
            End Try
        Catch ex As Exception
            If CheckBox1.Checked Then
                tbEnglish.Text = "Error with translation API"
            Else
                tbTranslation.Text = "Error with translation API"
            End If
        End Try

    End Sub
    Private Sub Hide_English(sender As Object, e As EventArgs) Handles rbtnHideEnglish.Click
        If rbtnHideEnglish.Checked = True Then
            rbtnHideEnglish.Checked = False
            lblE1.Visible = True
            lblE2.Visible = True
            lblE3.Visible = True
            lblE4.Visible = True
            lblE5.Visible = True
            lblE6.Visible = True
            lblE7.Visible = True
            lblE8.Visible = True
            lblE9.Visible = True
            lblE10.Visible = True
            tbEnglish.Visible = True
        Else
            rbtnHideTranslation.Checked = False
            rbtnHideEnglish.Checked = True
            lblE1.Visible = False
            lblE2.Visible = False
            lblE3.Visible = False
            lblE4.Visible = False
            lblE5.Visible = False
            lblE6.Visible = False
            lblE7.Visible = False
            lblE8.Visible = False
            lblE9.Visible = False
            lblE10.Visible = False
            tbEnglish.Visible = False
            If lblT1.Visible = False Then
                lblT1.Visible = True
                lblT2.Visible = True
                lblT3.Visible = True
                lblT4.Visible = True
                lblT5.Visible = True
                lblT6.Visible = True
                lblT7.Visible = True
                lblT8.Visible = True
                lblT9.Visible = True
                lblT10.Visible = True
                tbTranslation.Visible = True
            End If
        End If
    End Sub
    Private Sub Hide_Translation(sender As Object, e As EventArgs) Handles rbtnHideTranslation.Click
        If rbtnHideTranslation.Checked Then
            rbtnHideTranslation.Checked = False
            lblT1.Visible = True
            lblT2.Visible = True
            lblT3.Visible = True
            lblT4.Visible = True
            lblT5.Visible = True
            lblT6.Visible = True
            lblT7.Visible = True
            lblT8.Visible = True
            lblT9.Visible = True
            lblT10.Visible = True
            tbTranslation.Visible = True
        Else
            rbtnHideEnglish.Checked = False
            rbtnHideTranslation.Checked = True
            lblT1.Visible = False
            lblT2.Visible = False
            lblT3.Visible = False
            lblT4.Visible = False
            lblT5.Visible = False
            lblT6.Visible = False
            lblT7.Visible = False
            lblT8.Visible = False
            lblT9.Visible = False
            lblT10.Visible = False
            tbTranslation.Visible = False
            If lblE1.Visible = False Then
                lblE1.Visible = True
                lblE2.Visible = True
                lblE3.Visible = True
                lblE4.Visible = True
                lblE5.Visible = True
                lblE6.Visible = True
                lblE7.Visible = True
                lblE8.Visible = True
                lblE9.Visible = True
                lblE10.Visible = True
                tbEnglish.Visible = True
            End If
        End If
    End Sub
End Class