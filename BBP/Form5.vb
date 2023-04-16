Imports System.Security.Cryptography.X509Certificates
Imports System.Collections.Generic
Imports System.Runtime.Remoting
Public Class Form5
    Dim status As Boolean = True
    Dim index As Integer = 0
    Structure Record
        Dim name As String
        Dim image As Image
        Dim link As String
    End Structure
    Dim landmarks As Array
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
        lblTitle.Text = landmarks(0).name
        pbMain.BackgroundImage = landmarks(0).image
        llblGoogleMaps.Links(0).LinkData = landmarks(0).link
        tmr1.Start()
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
    Sub Australia()
        lblCountry.Text = "Australian Landmarks"
        Dim record1 As New Record
        Dim record2 As New Record
        Dim record3 As New Record
        Dim record4 As New Record
        Dim record5 As New Record
        Dim record6 As New Record
        Dim record7 As New Record
        Dim record8 As New Record
        Dim record9 As New Record
        Dim record10 As New Record
        record1.name = "Sydney Opera House"
        record1.link = "https://www.google.com/maps/place/Sydney+Opera+House/@-33.8567844,151.213108,17z/data=!4m6!3m5!1s0x6b12ae665e892fdd:0x3133f8d75a1ac251!8m2!3d-33.8567844!4d151.2152967!16zL20vMDZfbm0"
        record1.image = My.Resources.Aus1
        record2.name = "Sydney Harbour Bridge"
        record2.link = "https://www.google.com/maps/place/Sydney+Harbour+Bridge/@-33.8523063,151.2107871,15z/data=!4m2!3m1!1s0x0:0x68948eb717c0c43e?sa=X&ved=2ahUKEwiskpTC66z-AhWYmFYBHT1KBOMQ_BJ6BQiZARAI"
        record2.image = My.Resources.Aus2
        record3.name = "Bondi Beach"
        record3.link = "https://www.google.com/maps/place/Bondi+Beach/@-33.8923672,151.2780784,17z/data=!3m1!4b1!4m6!3m5!1s0x6b12ad9c447281c7:0x20c31809c62de978!8m2!3d-33.8914755!4d151.2766845!16zL20vMDIwNzcy"
        record3.image = My.Resources.Aus3
        record4.name = "Queen Victoria Building"
        record4.link = "https://www.google.com/maps/place/Queen+Victoria+Building/@-33.871722,151.2067078,15z/data=!4m6!3m5!1s0x6b12ae3c36fc2c21:0xbf6ac40e233d3415!8m2!3d-33.871722!4d151.2067078!16zL20vMDZsMXdk"
        record4.image = My.Resources.Aus4
        record5.name = "Twelve Apostles"
        record5.link = "https://www.google.com/maps/place/Twelve+Apostles/@-38.6621015,143.1050917,15z/data=!4m6!3m5!1s0xaa829e11284f6811:0xd1ed6bbc329b8df0!8m2!3d-38.6621015!4d143.1050917!16zL20vMDEyZjBu"
        record5.image = My.Resources.Aus5
        record6.name = "Three Sisters walk"
        record6.link = "https://www.google.com/maps/place/Three+Sisters+walk/@-33.7323128,150.3140787,15z/data=!4m6!3m5!1s0x6b126e9b18072287:0x46c4113cc389ea6!8m2!3d-33.7323128!4d150.3140787!16zL20vMDNweXow"
        record6.image = My.Resources.Aus6
        record7.name = "Sydney Tower Eye"
        record7.link = "https://www.google.com/maps/place/Sydney+Tower+Eye/@-33.8703155,151.2088801,15z/data=!4m6!3m5!1s0x6b12ae3fb870a0cb:0xe21b547d906c24ca!8m2!3d-33.8703155!4d151.2088801!16zL20vMDJsN3k3"
        record7.image = My.Resources.Aus7
        record8.name = "Australian War Memorial"
        record8.link = "https://www.google.com/maps/place/Australian+War+Memorial/@-35.2811355,149.1484327,15z/data=!4m2!3m1!1s0x0:0x41ef86ae38d42ce6?sa=X&ved=2ahUKEwiU18TZ76z-AhWg-jgGHZ_zDOYQ_BJ6BAh_EAg"
        record8.image = My.Resources.Aus8
        record9.name = "Uluru"
        record9.link = "https://www.google.com/maps/place/Uluru/@-25.3456562,131.0196362,14z/data=!3m1!4b1!4m6!3m5!1s0x2b236c2b6d625223:0x43a8cd4d9bc55f21!8m2!3d-25.3444277!4d131.0368822!16zL20vMF81eGM"
        record9.image = My.Resources.Aus9
        record10.name = "Parliament House"
        record10.link = "https://www.google.com/maps/place/Parliament+House/@-35.307029,149.1249623,15z/data=!4m2!3m1!1s0x0:0x567943f526daa249?sa=X&ved=2ahUKEwjY1fWb8Kz-AhXfwzgGHc8tAFAQ_BJ6BAh8EAg"
        record10.image = My.Resources.Aus10
        landmarks = {record1, record2, record3, record4, record5, record6, record7, record8, record9, record10}
    End Sub
    Sub China()
        lblCountry.Text = "Chinese Landmarks"
        Dim record1 As New Record
        Dim record2 As New Record
        Dim record3 As New Record
        Dim record4 As New Record
        Dim record5 As New Record
        Dim record6 As New Record
        Dim record7 As New Record
        Dim record8 As New Record
        Dim record9 As New Record
        Dim record10 As New Record
        record1.name = "Great Wall of China"
        record1.link = "https://www.google.com/maps/place/Great+Wall+of+China/@40.4319077,116.5703749,15z/data=!4m6!3m5!1s0x35f121d7687f2ccf:0xd040259b950522df!8m2!3d40.4319077!4d116.5703749!16zL20vMGQyZHEw"
        record1.image = My.Resources.China1
        record2.name = "Emperor Qinshihuang's Mausoleum Site Museum"
        record2.link = "https://www.google.com/maps/place/Emperor+Qinshihuang's+Mausoleum+Site+Museum/@34.3841153,109.2784918,15z/data=!4m6!3m5!1s0x3664a72d821403a3:0xc3e33e74e9e33fc7!8m2!3d34.3841153!4d109.2784918!16zL20vMDEzMXBx"
        record2.image = My.Resources.China2
        record3.name = "Forbidden City"
        record3.link = "https://www.google.com/maps/place/Forbidden+City/@39.9168038,116.3971621,15z/data=!4m6!3m5!1s0x35f052e94515d43d:0x674e2bd4dd3079f!8m2!3d39.9168038!4d116.3971621!16zL20vMGowYjI"
        record3.image = My.Resources.China3
        record4.name = "Summer Palace"
        record4.link = "https://www.google.com/maps/place/Summer+Palace/@39.9999823,116.2754606,15z/data=!4m2!3m1!1s0x0:0x45d9b1774c04a132?sa=X&ved=2ahUKEwi_3Yqwiq3-AhWy7zgGHZnMDukQ_BJ6BQiLARAI"
        record4.image = My.Resources.China4
        record5.name = "The Bund"
        record5.link = "https://www.google.com/maps/place/The+Bund/@31.2402611,121.490577,15z/data=!4m2!3m1!1s0x0:0x4d56fbed10d1af64?sa=X&ved=2ahUKEwjc7qewiq3-AhXu8DgGHd5aCNEQ_BJ6BQiKARAI"
        record5.image = My.Resources.China5
        record6.name = "Temple of Heaven"
        record6.link = "https://www.google.com/maps/place/Temple+of+Heaven/@39.8821803,116.4066056,15z/data=!4m2!3m1!1s0x0:0x372c15453b110e6a?sa=X&ved=2ahUKEwigiJScjK3-AhUzxDgGHaWIAHgQ_BJ6BQijARAI"
        record6.image = My.Resources.China6
        record7.name = "Leshan Giant Buddha"
        record7.link = "https://www.google.com/maps/place/Leshan+Giant+Buddha/@29.5441309,103.7715369,15z/data=!4m2!3m1!1s0x0:0x129642f46b1c443e?sa=X&ved=2ahUKEwjdiemwiq3-AhWQ4jgGHWc6CbwQ_BJ6BQiOARAI"
        record7.image = My.Resources.China7
        record8.name = "Potala Palace"
        record8.link = "https://www.google.com/maps/place/Potala+Palace/@29.6554942,91.1185792,15z/data=!4m2!3m1!1s0x0:0x4ae80d857ec10c19?sa=X&ved=2ahUKEwimtYmxiq3-AhXWwjgGHQp6AdwQ_BJ6BQiXARAI"
        record8.image = My.Resources.China8
        record9.name = "Tiger Leaping Gorge"
        record9.link = "https://www.google.com/maps/place/Tiger+Leaping+Gorge/@27.18939,100.113878,15z/data=!4m6!3m5!1s0x3720e825fc6ccfa9:0xb8609916f2ea8cca!8m2!3d27.18939!4d100.113878!16zL20vMDY0ZDJz"
        record9.image = My.Resources.China9
        record10.name = "Tiananmen Square"
        record10.link = "https://www.google.com/maps/place/Tiananmen+Square/@39.9054895,116.3976317,15z/data=!4m6!3m5!1s0x36637698dc4374d9:0x2aea2ec9ad545913!8m2!3d39.9054895!4d116.3976317!16zL20vMGM0NjM"
        record10.image = My.Resources.China10
        landmarks = {record1, record2, record3, record4, record5, record6, record7, record8, record9, record10}
    End Sub
    Sub Russia()
        lblCountry.Text = "Russian Landmarks"
        Dim record1 As New Record
        Dim record2 As New Record
        Dim record3 As New Record
        Dim record4 As New Record
        Dim record5 As New Record
        Dim record6 As New Record
        Dim record7 As New Record
        Dim record8 As New Record
        Dim record9 As New Record
        Dim record10 As New Record
        record1.name = "The Moscow Kremlin"
        record1.link = "https://www.google.com/maps/place/The+Moscow+Kremlin/@55.7520233,37.6174994,15z/data=!4m2!3m1!1s0x0:0xa886bf5a3d9b2e68?sa=X&ved=2ahUKEwim3vzHj63-AhU8-TgGHYDMDFMQ_BJ6BQiOARAI"
        record1.image = My.Resources.Russia1
        record2.name = "St. Basil's Cathedral"
        record2.link = "https://www.google.com/maps/place/St.+Basil's+Cathedral/@55.7525229,37.6230868,15z/data=!4m2!3m1!1s0x0:0xa4cf168ae7cb3ae5?sa=X&ved=2ahUKEwjWxYHQj63-AhVazTgGHRrWCz8Q_BJ6BQiwARAI"
        record2.image = My.Resources.Russia2
        record3.name = "Peterhof"
        record3.link = "https://www.google.com/maps/place/Peterhof/@59.8863041,29.9085976,15z/data=!4m2!3m1!1s0x0:0x1c82ffc2f406bf1?sa=X&ved=2ahUKEwjWnbPQj63-AhW_8zgGHcaEAFMQ_BJ6BQiaARAI"
        record3.image = My.Resources.Russia3
        record4.name = "Catherine Palace"
        record4.link = "https://www.google.com/maps/place/Catherine+Palace/@59.716123,30.3956531,15z/data=!4m6!3m5!1s0x4696216c38496ba3:0x950bc1b43408f196!8m2!3d59.716123!4d30.3956531!16zL20vMDM4ZHh4"
        record4.image = My.Resources.Russia4
        record5.name = "Red Square"
        record5.link = "https://www.google.com/maps/place/Red+Square/@55.7539303,37.620795,15z/data=!4m2!3m1!1s0x0:0x7c347d506b52311f?sa=X&ved=2ahUKEwio5u_Qj63-AhXw9jgGHbvQCcUQ_BJ6BQifARAI"
        record5.image = My.Resources.Russia5
        record6.name = "Winter Palace"
        record6.link = "https://www.google.com/maps/place/Winter+Palace/@59.9403958,30.3137962,15z/data=!4m2!3m1!1s0x0:0x214f8f2811596776?sa=X&ved=2ahUKEwipwojRj63-AhW6imMGHcfWAaUQ_BJ6BQiZARAI"
        record6.image = My.Resources.Russia6
        record7.name = "Savior on the Spilled Blood"
        record7.link = "https://www.google.com/maps/place/Savior+on+the+Spilled+Blood/@59.9401,30.3289,15z/data=!4m2!3m1!1s0x0:0x3e676f3bea7153b7?sa=X&ved=2ahUKEwj97p3Rj63-AhXO-jgGHaJQAJUQ_BJ6BQieARAI"
        record7.image = My.Resources.Russia7
        record8.name = "Bolshoi Theatre"
        record8.link = "https://www.google.com/maps/place/Bolshoi+Theatre/@55.7601335,37.6186486,15z/data=!4m2!3m1!1s0x0:0x93a829189a1d29f2?sa=X&ved=2ahUKEwjO9bPRj63-AhW9nGMGHSF4ACoQ_BJ6BQiYARAI"
        record8.image = My.Resources.Russia8
        record9.name = "Kul Sharif Mosque"
        record9.link = "https://www.google.com/maps/place/Kul+Sharif+Mosque/@55.7983713,49.1052366,15z/data=!4m2!3m1!1s0x0:0x22fb803f48c5e908?sa=X&ved=2ahUKEwievsjRj63-AhUx6jgGHaexD0MQ_BJ6BQicARAI"
        record9.image = My.Resources.Russia9
        record10.name = "Peter and Paul Fortress"
        record10.link = "https://www.google.com/maps/place/Peter+and+Paul+Fortress/@59.9500019,30.3166718,15z/data=!4m6!3m5!1s0x4696316ad47e244d:0xba3d555ac7f032e7!8m2!3d59.9500019!4d30.3166718!16zL20vMDNrcW10"
        record10.image = My.Resources.Russia10
        landmarks = {record1, record2, record3, record4, record5, record6, record7, record8, record9, record10}
    End Sub
    Sub Finland()
        lblCountry.Text = "Finnish Landmarks"
        Dim record1 As New Record
        Dim record2 As New Record
        Dim record3 As New Record
        Dim record4 As New Record
        Dim record5 As New Record
        Dim record6 As New Record
        Dim record7 As New Record
        Dim record8 As New Record
        Dim record9 As New Record
        Dim record10 As New Record
        record1.name = "Helsinki Cathedral"
        record1.link = "https://www.google.com/maps/place/Helsinki+Cathedral/@60.1704191,24.9521651,15z/data=!4m2!3m1!1s0x0:0x28a7d7b40911eba2?sa=X&ved=2ahUKEwifvtHaka3-AhWw-DgGHYWFA0oQ_BJ6BQiVARAI"
        record1.image = My.Resources.Finland1
        record2.name = "Senate Square"
        record2.link = "https://www.google.com/maps/place/Senate+Square/@60.1694794,24.9522867,15z/data=!4m2!3m1!1s0x0:0xbc57e32cb4d908ca?sa=X&ved=2ahUKEwiR4ufaka3-AhWm8DgGHaTEA1wQ_BJ6BQiXARAI"
        record2.image = My.Resources.Finland2
        record3.name = "Temppeliaukion Church"
        record3.link = "https://www.google.com/maps/place/Temppeliaukion+Church/@60.172995,24.925234,15z/data=!4m6!3m5!1s0x46920a3167360cb1:0x80bafdaf2781439f!8m2!3d60.172995!4d24.925234!16s%2Fm%2F027xrts"
        record3.image = My.Resources.Finland3
        record4.name = "Uspenski Cathedral"
        record4.link = "https://www.google.com/maps/place/Uspenski+Cathedral/@60.1685436,24.95995,15z/data=!4m2!3m1!1s0x0:0xa03dca3ae6b14ca9?sa=X&ved=2ahUKEwivlprbka3-AhWP-TgGHSMPCxAQ_BJ6BQigARAI"
        record4.image = My.Resources.Finland4
        record5.name = "Esplanadi"
        record5.link = "https://www.google.com/maps/place/Esplanadi/@60.1674815,24.9476095,15z/data=!4m2!3m1!1s0x0:0xf00b5523c15ba30?sa=X&ved=2ahUKEwiowa_bka3-AhWr6jgGHawvAFMQ_BJ6BQiCARAI"
        record5.image = My.Resources.Finland5
        record6.name = "Turku Castle"
        record6.link = "https://www.google.com/maps/place/Turku+Castle/@60.4353436,22.2286991,15z/data=!4m2!3m1!1s0x0:0x5ed53f5d606fb500?sa=X&ved=2ahUKEwi2x8Lbka3-AhVo3jgGHSJYBFsQ_BJ6BQiVARAI"
        record6.image = My.Resources.Finland6
        record7.name = "Market Square"
        record7.link = "https://www.google.com/maps/place/Market+Square/@60.1676653,24.9536778,15z/data=!4m2!3m1!1s0x0:0xc5acf882c8111bd5?sa=X&ved=2ahUKEwiB6tzbka3-AhWi6jgGHWohACAQ_BJ6BAhkEAg"
        record7.image = My.Resources.Finland7
        record8.name = "Santa Claus Village"
        record8.link = "https://www.google.com/maps/place/Santa+Claus+Village/@66.5436144,25.8471973,15z/data=!4m2!3m1!1s0x0:0xd7f9b9e4341d7ed3?sa=X&ved=2ahUKEwj0y_Pbka3-AhU-xDgGHf0mDe0Q_BJ6BQiNARAI"
        record8.image = My.Resources.Finland8
        record9.name = "Olavinlinna "
        record9.link = "https://www.google.com/maps/place/Olavinlinna/@61.8639386,28.9010692,15z/data=!4m2!3m1!1s0x0:0x9b4df47cb2f74cb8?sa=X&ved=2ahUKEwjCpozcka3-AhWP8zgGHWWzCjkQ_BJ6BQiYARAI"
        record9.image = My.Resources.Finland9
        record10.name = "Kamppi Chapel"
        record10.link = "https://www.google.com/maps/place/Kamppi+Chapel/@60.1694694,24.9360043,15z/data=!4m2!3m1!1s0x0:0x29b2a333242dd14e?sa=X&ved=2ahUKEwjj2LDcka3-AhXA-zgGHf_OCAMQ_BJ6BQiSARAI"
        record10.image = My.Resources.Finland10
        landmarks = {record1, record2, record3, record4, record5, record6, record7, record8, record9, record10}
    End Sub
    Private Sub Control(sender As Object, e As EventArgs) Handles btnControl.Click
        If status = True Then
            status = False
            btnControl.BackgroundImage = My.Resources.Play
            tmr1.Stop()
        Else
            status = True
            btnControl.BackgroundImage = My.Resources.Pause
            tmr1.Start()
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr1.Tick
        If index > 9 Then
            index = 0
        End If
        lblTitle.Text = landmarks(index).name
        pbMain.BackgroundImage = landmarks(index).image
        llblGoogleMaps.Links(0).LinkData = landmarks(index).link
        index = index + 1
    End Sub
    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        If status = True Then
            tmr1.Stop()
        End If
        If index - 1 < 0 Then
            index = 9
        Else
            index = index - 1
        End If
        lblTitle.Text = landmarks(index).name
        pbMain.BackgroundImage = landmarks(index).image
        llblGoogleMaps.Links(0).LinkData = landmarks(index).link
        If status = True Then
            tmr1.Start()
        End If
    End Sub
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If status = True Then
            tmr1.Stop()
        End If
        If index + 1 > 9 Then
            index = 0
        Else
            index = index + 1
        End If
        lblTitle.Text = landmarks(index).name
        pbMain.BackgroundImage = landmarks(index).image
        llblGoogleMaps.Links(0).LinkData = landmarks(index).link
        If status = True Then
            tmr1.Start()
        End If
    End Sub
    Private Sub Link_Clicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llblGoogleMaps.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub
End Class