Imports System.IO
Imports System.Net
Imports System.Net.Configuration
Imports System.Web.Script.Serialization
Imports Newtonsoft

Public Class Form4
    Dim language As String
    Dim source_language As String = "en"
    Dim target_language As String
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
        lblLanguage.Text = "Chinese"
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
    End Sub
    Sub Russia()
        lblLanguage.Text = "Russian"
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
        lblLanguage.Text = "Finnish"
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
    End Sub
    Private Sub Translator(sender As Object, e As EventArgs) Handles btnTranslate.Click
        Dim source_text As String = tbEnglish.Text
        Dim url As String = "https://api.mymemory.translated.net/get?q=" + source_text + "&langpair=" + source_language + "|" + target_language

        Try
            Dim request As HttpWebRequest = HttpWebRequest.Create(url)
            request.Proxy = Nothing
            'request.UserAgent = "test"

            Dim response As HttpWebResponse = request.GetResponse
            Dim response_stream As System.IO.Stream = response.GetResponseStream

            Dim stream_reader As New System.IO.StreamReader(response_stream)
            Dim data As String = stream_reader.ReadToEnd
            stream_reader.Close()

            Try
                Dim data_length As Integer = Len(data) - 100
                Dim trim_data As String = data.Substring(35, data_length)
                Dim quote_index As Integer = InStr(1, trim_data, ",")
                Dim subdata As String = trim_data.Substring(0, quote_index - 2)
                tbTranslation.Text = System.Text.RegularExpressions.Regex.Unescape(subdata)
            Catch ex As Exception
                tbTranslation.Text = "Error with code"
            End Try
        Catch ex As Exception
            tbTranslation.Text = "Error with translation API"
        End Try

    End Sub
    Private Sub rbtnHideEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnHideEnglish.CheckedChanged, rbtnHideTranslation.CheckedChanged

    End Sub
End Class