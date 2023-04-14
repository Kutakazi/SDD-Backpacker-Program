Public Class Form3
    Public Property Country As String
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Country
        lblTitle.Text = Country
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
    Private Sub Button_Control(sender As Object, e As EventArgs) Handles btnExit.Click, btnInfo.Click, btnMinimize.Click, btnReturn.Click, btnTranslator.Click, btnConverter.Click, btnLandmarks.Click, pbFlag.Click
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
            Case "btnReturn"
                Dim form1 As New Form1
                Me.Hide()
                form1.Show()
            Case "btnTranslator"
                Dim form4 As New Form4
                form4.Country = Country
                Me.Hide()
                form4.Show()
            Case "btnLandmarks"
                Dim form5 As New Form5
                form5.Country = Country
                Me.Hide()
                form5.Show()
            Case "btnConverter"
                Dim form6 As New Form6
                form6.Country = Country
                Me.Hide()
                form6.Show()
            Case "pbFlag"
                Dim form7 As New Form7
                form7.Country = Country

        End Select
    End Sub
    Sub Australia()
        pbFlag.BackgroundImage = My.Resources.Aus
        pbMap.BackgroundImage = My.Resources.MapAus
        lblPopulation.Text = "Population: 25,890,773"
        lblCurrency.Text = "Currency: Australian Dollar (AUD)"
        lblCapital.Text = "Capital City: Canberra"
        lblReligion.Text = "Major Religion: Christianity"
        lblGeneralInfo.Text = "Australia, officially the Commonwealth of Australia, is a sovereign country comprising the mainland of the Australian continent, the island of Tasmania, and numerous smaller islands. Australia is the largest country by area in Oceania and the world's sixth-largest country. Australia is the oldest, flattest, and driest inhabited continent, with the least fertile soils. It is a megadiverse country, and its size gives it a wide variety of landscapes and climates, with deserts in the centre, tropical rainforests in the north-east, tropical savannas in the north, and mountain ranges in the south-east."
    End Sub
    Sub China()
        pbFlag.BackgroundImage = My.Resources.China
        pbMap.BackgroundImage = My.Resources.MapChina
        lblPopulation.Text = "Population: 1,411,778,724"
        lblCurrency.Text = "Currency: Renminbi (CNY)"
        lblCapital.Text = "Capital City: Beijing"
        lblReligion.Text = "Major Religion: No Religion / Folk"
        lblGeneralInfo.Text = "China, officially the People's Republic of China (PRC), is a country in East Asia. It is the world's most populous country, with a population exceeding 1.4 billion, slightly ahead of India. China spans the equivalent of five time zones and borders fourteen countries by land, the most of any country in the world, tied with Russia. With an area of approximately 9.6 million square kilometres (3,700,000 sq mi), it is the world's third largest country by total land area. The country consists of 22 provinces, five autonomous regions, four municipalities, and two special administrative regions."
    End Sub
    Sub Russia()
        pbFlag.BackgroundImage = My.Resources.Russia
        pbMap.BackgroundImage = My.Resources.MapRussia
        lblPopulation.Text = "Population: 147,182,123"
        lblCurrency.Text = "Currency: Ruble (RUB)"
        lblCapital.Text = "Capital City: Moscow"
        lblReligion.Text = "Major Religion: Christianity"
        lblGeneralInfo.Text = "Russia, or the Russian Federation, is a transcontinental country spanning Eastern Europe and Northern Asia. It is the largest country in the world, encompassing one-eighth of Earth's inhabitable landmass. Russia extends across eleven time zones and shares land boundaries with fourteen countries. It is the world's ninth-most populous country and Europe's most populous country. The country's capital and largest city is Moscow. Saint Petersburg is Russia's cultural centre and second-largest city."
    End Sub
    Sub Finland()
        pbFlag.BackgroundImage = My.Resources.Finland
        pbMap.BackgroundImage = My.Resources.MapFinland
        lblPopulation.Text = "Population: 5,614,571"
        lblCurrency.Text = "Currency: Euro (EUR)"
        lblCapital.Text = "Capital City: Helsinki"
        lblReligion.Text = "Major Religion: Christianity"
        lblGeneralInfo.Text = "Finland, officially the Republic of Finland, is a Nordic country in Northern Europe. It borders Sweden to the northwest, Norway to the north, and Russia to the east, with the Gulf of Bothnia to the west and the Gulf of Finland to the south, across from Estonia. Finland covers an area of 338,455 square kilometres (130,678 sq mi) with a population of 5.6 million. Helsinki is the capital and largest city. The vast majority of the population are ethnic Finns. Finnish and Swedish are the official languages, Swedish is the native language of 5.2% of the population."
    End Sub
End Class