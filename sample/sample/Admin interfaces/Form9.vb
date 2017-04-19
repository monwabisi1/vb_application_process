Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class Form9

    Dim BClass As New BusinessClass
    ' Dim msyqlconn As String
    Private Sub btnback_Click(ByVal sender As Object, ByVal e As EventArgs)
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox1.Click
        Form4.Show()

        Me.Close()

    End Sub

    Private Sub Form9_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        'cbomunicipal.Visible = "false"
        'cbocity.Visible = "false"
        'cbomunicipal2.Visible = "false"
        'cbocity2.Visible = "false"
        cboposition.Items.Add("Manager")
        cboposition.Items.Add("Admin")
        cboposition.Items.Add("Member")
        cboposition.Items.Add("Employee")
        cboposition.Items.Add("HR Manager")

        cboprovince.Items.Add("Eastern Cape")
        cboprovince.Items.Add("Free State")
        cboprovince.Items.Add("Gauteng")
        cboprovince.Items.Add("Western Cape")
        cboprovince.Items.Add("Northen Cape")
        cboprovince.Items.Add("KwaZulu-Natal")
        cboprovince.Items.Add("Limpopo")
        cboprovince.Items.Add("North West")
        cboprovince.Items.Add("Mpumalanga")

        'cboprovince2.Items.Add("Eastern Cape")
        'cboprovince2.Items.Add("Free State")
        'cboprovince2.Items.Add("Gauteng")
        'cboprovince2.Items.Add("Western Cape")
        'cboprovince2.Items.Add("Northen Cape")
        'cboprovince2.Items.Add("KwaZulu-Natal")
        'cboprovince2.Items.Add("Limpopo")
        'cboprovince2.Items.Add("North West")
        'cboprovince2.Items.Add("Mpumalanga")
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PictureBox5.Click


        Try

            Dim ans As Integer
            ans = MsgBox("Are you sure want to logout of the application?", vbYesNo + vbQuestion, "Confirm Message")
            If ans = MsgBoxResult.No Then
                'endsystem
            Else

                Application.Exit()

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Public Function validateEmail(emailAddress) As Boolean
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]*@(?:[\-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return "True"
        Else
            Return "False"
        End If
    End Function
    Private Sub picadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picadd.Click
        '    Dim ds As New DataSet
        '    Dim res As String
        '    Dim result As String
        '    Try
        '        result = BClass.getConnection()

        '        If result <> "true" Then
        '            MsgBox("error in connection" + result)
        '            Exit Sub
        '        Else
        '            If txtname.Text.Trim = "" Then
        '                MsgBox("Enter your name please")
        '                txtname.Focus()
        '                Exit Sub
        '            End If
        '            If (txtsurname.Text.Trim.ToUpper) = "" Then
        '                MsgBox("Enter your Surname")
        '                txtsurname.Focus()
        '                Exit Sub
        '            End If
        '            If IsNumeric(txtsurname.Text.Trim.ToUpper.Length) = "false" Then
        '                MsgBox("Enter a surname that is only alphabets")
        '                txtsurname.Focus()
        '                Exit Sub
        '            End If
        '            If txtid.Text.Trim.ToUpper = "" Then
        '                MsgBox("Enter your Id")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If IsNumeric(txtid.Text.Trim) = "false" Then
        '                MsgBox("Your ID must have digits only")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If (txtid.Text.Trim.Length <> 13) Then
        '                MsgBox("your ID should be 13 digits long")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If txtid.Text.Substring(2, 2) > 12 Then
        '                MsgBox("Your ID number is incorrect check the month of birth section")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If txtid.Text.Substring(4, 2) > 31 Then
        '                MsgBox("Your ID number is incorrect check the day of birth section")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If txtid.Text.Substring(10, 1) <> 0 Then
        '                MsgBox("You are not a S.A citizen")
        '                txtid.Focus()
        '                Exit Sub
        '            End If
        '            If txtid.Text.Substring(6, 1) > 4 Then
        '                Dim gender As String
        '                gender = "Male"
        '                cbogender.Text = gender
        '            End If
        '            'If txtid.Text.Substring(6, 1) < 5 Then
        '            '    Dim gender As String
        '            '    gender = "Female"
        '            '    txtgender.Text = gender
        '            'End If
        '            'If cborace.SelectedIndex = -1 Then
        '            '    MsgBox("Select you race")
        '            '    cborace.Focus()
        '            '    Exit Sub
        '            'End If
        '            'txtgender.ReadOnly = False
        '            If cboposition.SelectedIndex = -1 Then
        '                MsgBox("Select you position")
        '                cboposition.Focus()
        '                Exit Sub
        '            End If
        '            If (UsernameTextBox.Text.Trim) = "" Then
        '                MsgBox("Enter a username")
        '                UsernameTextBox.Focus()
        '                Exit Sub
        '            End If
        '            If PasswordTextBox.Text.Trim = "" Then
        '                MsgBox("Enter a password")
        '                PasswordTextBox.Focus()
        '                Exit Sub
        '            End If


        '            If txtcell.Text.Trim.ToUpper = "" Then
        '                MsgBox("enter your Phone number")
        '                txtcell.Focus()
        '                Exit Sub
        '            End If
        '            If IsNumeric(txtcell.Text.Trim) = "False" Then
        '                MsgBox("celphone must be digits only")
        '                txtcell.Focus()
        '                Exit Sub
        '            End If
        '            If txtcell.Text.Substring(0, 1) <> 0 Then
        '                MsgBox("phone number must start with a zero")
        '                Exit Sub
        '            End If
        '            If txtcell.Text.Substring(1, 1) = 0 Then
        '                MsgBox("pleasee enter correct phone number like 0738995305 or 0434394567 ")
        '                Exit Sub
        '            End If
        '            If txtcell.Text.Substring(2, 1) = 0 Then
        '                MsgBox("pleasee enter correct phone number like 0738995305 or 0434394567 ")
        '                Exit Sub
        '            End If

        '            'Dim phoneNumber As New Regex("\d{3}-\d{3}-\d{4}")
        '            'If phoneNumber.IsMatch(txtcell.Text) Then
        '            '    txtcell.Text = "Valid phone number"
        '            'Else
        '            '    txtcell.Text = "Not Valid phone number"
        '            'End If
        '            Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        '            If email.IsMatch(txtemail.Text) Then
        '                MsgBox("valid email")
        '            Else
        '                MsgBox("invalid email")
        '                Exit Sub
        '            End If

        '            If (txtcell.Text.Trim.Length <> 10) Then
        '                MsgBox("Enter a 10 digit cellphone number")
        '                txtcell.Focus()
        '                Exit Sub
        '            End If


        '            'If validateEmail(txtemail.Text) = " True" Then
        '            '    MsgBox("good")
        '            'Else
        '            '    MsgBox("bad")
        '            'End If
        '            'If txtemail.Text.Trim = "" Then
        '            '    MsgBox("enter an email address")
        '            'End If
        '            'If txtstreet.Text.Trim.ToUpper = "" Then
        '            '    MsgBox("enter your street name")
        '            '    txtstreet.Focus()
        '            '    Exit Sub

        '            'End If
        '            'If IsNumeric(txtstreet.Text.Trim.ToUpper.Length) = "false" Then
        '            '    MsgBox("your street name must have alphabets only")
        '            '    txtstreet.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cboprovince.SelectedIndex = -1 Then
        '            '    MsgBox("Select your province")
        '            '    cboprovince.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cbomunicipal.SelectedIndex = -1 Then
        '            '    MsgBox(" select your municipality")
        '            '    txtcode2.Focus()
        '            '    cbomunicipal.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cbocity.SelectedIndex = -1 Then
        '            '    MsgBox("select your city")
        '            '    cbocity.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If txtcode.Text.Trim = "" Then
        '            '    MsgBox("Enter your  4 digit postal code")
        '            '    txtcode.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If (txtcode.Text.Trim.Length <> 4) Then
        '            '    MsgBox("postal code should be 4 digits only")
        '            '    txtcode.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If IsNumeric(txtcode.Text.Trim) = "False" Then
        '            '    MsgBox("your postal code must have numbers only")
        '            '    txtcode.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If txtstreet2.Text.Trim.ToUpper = "" Then
        '            '    MsgBox("enter your street name")
        '            '    txtstreet2.Focus()
        '            '    Exit Sub
        '            'End If

        '            'If IsNumeric(txtstreet2.Text.Trim.ToUpper.Length) = "false" Then
        '            '    MsgBox("your street name must have alphabets only")
        '            '    txtstreet2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cboprovince2.SelectedIndex = -1 Then
        '            '    MsgBox("Select your province")
        '            '    cboprovince2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cbomunicipal2.SelectedIndex = -1 Then
        '            '    MsgBox(" select your municipality")
        '            '    cbomunicipal2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If cbocity2.SelectedIndex = -1 Then
        '            '    MsgBox("select your city")
        '            '    cbocity2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If txtcode2.Text.Trim = "" Then
        '            '    MsgBox("enter your postal code")
        '            '    txtcode2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If (txtcode2.Text.Trim.Length <> 4) Then
        '            '    MsgBox("postal code should be 4 digits only")
        '            '    txtcode2.Focus()
        '            '    Exit Sub
        '            'End If
        '            'If IsNumeric(txtcode2.Text.Trim.Length) = "False" Then
        '            '    MsgBox("your postal code must have numbers only")
        '            '    txtcode2.Focus()
        '            '    Exit Sub
        '            'End If






        '            res = BClass.AddEmployees(txtid.Text, txtsurname.Text, txtname.Text, txtcell.Text, txtemail.Text, UsernameTextBox.Text, PasswordTextBox.Text, cboposition.Text, txtstreet.Text, txtline2.Text, txtline3.Text, cboprovince.Text, cbocity.Text, cbomunicipal.Text, CInt(txtcode.Text), cbogender.Text, cborace.Text)
        '            If res = "true" Then

        '                MsgBox("Added Succesfully")

        '                Exit Sub
        '            Else
        '                MsgBox("error" + res)
        '                Exit Sub
        '            End If

        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show(ex.Message.ToString)

        '    End Try
        '    '  If txtid.Text.Substring(4, 2) > 31 Then
        '    '  MsgBox("not valid date")
        '    '  End If
        '    '      If txtid.Text.Substring(9, 1) <> 0 Then
        '    '     MsgBox("you are not a south african")
        '    ' End If
        '    ' If txtid.Text.Substring(10, 1) <> 8 Then
        '    ' MsgBox("something wrong with you second last digit of your id")
        '    'End If


    End Sub

    Private Sub cbomunicipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomunicipal.SelectedIndexChanged
        cbocity.Items.Clear()
        cbocity.Visible = "true"
        Try

            If (cbomunicipal.Text = "BCMM") Then
                cbocity.Items.Add("East London")
                cbocity.Items.Add("Dimbaza")
                cbocity.Items.Add("Bisho")
                cbocity.Items.Add("Mdantsane")
                cbocity.Items.Add("Kidd's Beach")
                cbocity.Items.Add("King William Town")
                cbocity.Items.Add("Phakamisa")
                cbocity.Items.Add("Zwelitsha")
                Exit Sub

            End If

            If (cbomunicipal.Text = "Nelson Mandela  Metro") Then
                cbocity.Items.Add("Bethelsdorp")
                cbocity.Items.Add("Bloemendal")
                cbocity.Items.Add("Blue Horizon Bay")
                cbocity.Items.Add("Clarendon Marine")
                cbocity.Items.Add("Despatch")
                cbocity.Items.Add("KwaNobuhle")
                cbocity.Items.Add("Motherwell")
                cbocity.Items.Add("Port Elizabeth")
                cbocity.Items.Add("Uitenhage")
                Exit Sub

            End If


            If cbomunicipal.Text = "Mnquma" Then
                cbocity.Items.Add("Nqgamakhwe")
                cbocity.Items.Add("Kentani")
                cbocity.Items.Add("Butterworth")
                Exit Sub


            End If

            If cbomunicipal.Text = "Matatiele" Then
                cbocity.Items.Add("Cedarville")
                cbocity.Items.Add("Matatiele")
                Exit Sub

            End If
            If cbomunicipal.Text = "Mbizana" Then
                cbocity.Items.Add("bizana")
                Exit Sub

            End If
            If cbomunicipal.Text = "Ntabankulu" Then
                cbocity.Items.Add("Ntabankulu")
                Exit Sub

            End If
            If cbomunicipal.Text = "Umzimvubu" Then
                cbocity.Items.Add("eMaxesibeni (Mount Ayliff)")
                cbocity.Items.Add("Mount Frere")
                Exit Sub

            End If


            If cbomunicipal.Text = "Amahlathi " Then
                cbocity.Items.Add(" Cathcart")
                cbocity.Items.Add("Kei Road")
                cbocity.Items.Add("Keiskammahoek")
                cbocity.Items.Add(" Stutterheim")
                Exit Sub
            End If

            If cbomunicipal.Text = "Great Kei" Then
                cbocity.Items.Add(" Amatola Coastal")
                cbocity.Items.Add("Kei Mouth")
                cbocity.Items.Add("Komga")
                cbocity.Items.Add(" Morgan Bay")
                Exit Sub
            End If

            If cbomunicipal.Text = "Mbhashe " Then
                cbocity.Items.Add("Dutywa")
                cbocity.Items.Add("Elliotdale")
                cbocity.Items.Add("Willowvale")
                Exit Sub

            End If
            If cbomunicipal.Text = "Ngqushwa " Then
                cbocity.Items.Add("Hamburg")
                cbocity.Items.Add("Peddie")
                Exit Sub

            End If
            If cbomunicipal.Text = "Raymond Mhlaba" Then
                cbocity.Items.Add("Adelaide")
                cbocity.Items.Add("Fort Beaufort")
                cbocity.Items.Add("Middeldrift")
                cbocity.Items.Add("Seymore")
                cbocity.Items.Add("Hogsback")
                cbocity.Items.Add("Alice")
                Exit Sub
            End If

            If cbomunicipal.Text = "Emalahleni " Then
                cbocity.Items.Add("Lady Frere")
                cbocity.Items.Add(" Indwe")
                cbocity.Items.Add("Dordrecht,a")
                Exit Sub

            End If
            If cbomunicipal.Text = "Engcobo" Then
                cbocity.Items.Add("Engcobo")
                Exit Sub
            End If
            If cbomunicipal.Text = "Enoch Mgijima" Then
                cbocity.Items.Add(" Sada")
                cbocity.Items.Add("Sterkstroom")
                cbocity.Items.Add("Tarkastad")
                cbocity.Items.Add("Whittleseae")
                cbocity.Items.Add("Queenstown")
                cbocity.Items.Add("Molteno")
                cbocity.Items.Add("Hofmeyr")
                Exit Sub
            End If
            If cbomunicipal.Text = "Intsika Yethu " Then
                cbocity.Items.Add("Tsomo")
                cbocity.Items.Add("Cofimvaba")
                Exit Sub
            End If
            If cbomunicipal.Text = "Inxuba Yethemba" Then
                cbocity.Items.Add("Cradock")
                cbocity.Items.Add(" Middelburg")
                cbocity.Items.Add("Mount Zebra National Park")
                Exit Sub

            End If
            If cbomunicipal.Text = "Sakhisizwe " Then
                cbocity.Items.Add("Cala")
                cbocity.Items.Add("Elliot")
                Exit Sub
            End If
            If cbomunicipal.Text = "Elundini" Then
                cbocity.Items.Add(" Ugie")
                cbocity.Items.Add(" Mount Fletcher")
                Exit Sub

            End If
            If cbomunicipal.Text = "Senqu " Then
                cbocity.Items.Add(" Sterkspruit")
                cbocity.Items.Add("Rossouw")
                cbocity.Items.Add("Lady Grey")
                cbocity.Items.Add(" Barkly East")
                Exit Sub
            End If
            If cbomunicipal.Text = "Walter Sisulu " Then
                cbocity.Text = "Walter Sisulu"
                Exit Sub
            End If
            If cbomunicipal.Text = "Ingquza Hill" Then
                cbocity.Items.Add(" Lusikisiki")
                cbocity.Items.Add("Flagstaff")
                Exit Sub
            End If
            If cbomunicipal.Text = "King Sabata Dalindyebo" Then
                cbocity.Items.Add(" Mthatha (previously Umtata)")
                cbocity.Items.Add("Mqanduli")
                Exit Sub
            End If
            If cbomunicipal.Text = "Mhlontlo" Then
                cbocity.Items.Add(" Qumbu")
                cbocity.Items.Add("Tsolo")
                Exit Sub
            End If
            If cbomunicipal.Text = "Nyandeni" Then
                cbocity.Items.Add(" Ngqeleni")
                cbocity.Items.Add("Libode")
                Exit Sub
            End If
            If cbomunicipal.Text = "Port St Johns " Then
                cbocity.Items.Add("Port St Johns")
                Exit Sub

            End If
            If cbomunicipal.Text = "Blue Crane Route " Then
                cbocity.Items.Add("Somerset East")
                cbocity.Items.Add("Petersburg")
                cbocity.Items.Add("Pearston")
                cbocity.Items.Add("Cookhouse")
                Exit Sub
            End If


            If cbomunicipal.Text = "Dr Beyers Naudé  " Then
                cbocity.Items.Add("Jansenville")
                cbocity.Items.Add("Graaff-Reinet")
                cbocity.Items.Add("Adendorp")
                cbocity.Items.Add("Aberdeen")
                cbocity.Items.Add("Rietbron")
                cbocity.Items.Add("Nieu-Bethesda")
                cbocity.Items.Add("Klipplaat")
                cbocity.Items.Add("Kendrew")
                cbocity.Items.Add("Waterford")
                cbocity.Items.Add("Steytlerville")
                cbocity.Items.Add("Willowmore")
                Exit Sub
            End If

            If cbomunicipal.Text = "Kouga " Then
                cbocity.Items.Add("Cape St Francis")
                cbocity.Items.Add("Hankey")
                cbocity.Items.Add("Humansdorp")
                cbocity.Items.Add("Jeffreys Bay")
                cbocity.Items.Add("Loerie")
                cbocity.Items.Add("Oyster Bay")
                cbocity.Items.Add("Patensie")
                cbocity.Items.Add("St Francis Bay")
                cbocity.Items.Add("Thornhill")
                Exit Sub

            End If
            If cbomunicipal.Text = "Koukamma  " Then
                cbocity.Items.Add("Clarkson")
                cbocity.Items.Add("Kareedouw")
                cbocity.Items.Add("Krakeel River")
                cbocity.Items.Add("Louterwater")
                cbocity.Items.Add("Misgund")
                cbocity.Items.Add("Nompumelelo")
                cbocity.Items.Add("Sanddrif")
                cbocity.Items.Add("Woodlands")
                cbocity.Items.Add("Storms River")
                cbocity.Items.Add("Joubertina")
                Exit Sub
            End If


            If cbomunicipal.Text = "Makana " Then
                cbocity.Items.Add("Alicedale")
                cbocity.Items.Add("Grahamstown")
                cbocity.Items.Add("Riebeek East")
                cbocity.Items.Add("Sidbury")
                Exit Sub
            End If


            If cbomunicipal.Text = "Ndlambe " Then
                cbocity.Items.Add(" Alexandria")
                cbocity.Items.Add("Bathurst")
                cbocity.Items.Add(" Boknes / Cannon Rocks")
                cbocity.Items.Add("Bushmans River")
                cbocity.Items.Add("Kenton -on-Sea")
                cbocity.Items.Add("Port Alfred")
                cbocity.Items.Add("Seafield")
                Exit Sub

            End If
            If cbomunicipal.Text = "Sundays River Valley" Then
                cbocity.Items.Add("Addo")
                cbocity.Items.Add("Kirkwood")
                cbocity.Items.Add("Paterson")
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub cbocity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocity.SelectedIndexChanged

    End Sub

    Private Sub cbomunicipal2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboprovince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboprovince.SelectedIndexChanged

        cbomunicipal.Visible = "true"
        If cboprovince.Text = "Eastern Cape" Then

            cbomunicipal.Items.Add("BCMM")
            cbomunicipal.Items.Add("Nelson Mandela  Metro")
            cbomunicipal.Items.Add("Matatiele")
            cbomunicipal.Items.Add("Mbizana")
            cbomunicipal.Items.Add("Ntabankulu")
            cbomunicipal.Items.Add("Umzimvubu")
            cbomunicipal.Items.Add("Amahlathi ")
            cbomunicipal.Items.Add("Great Kei")
            cbomunicipal.Items.Add("Mbhashe ")
            cbomunicipal.Items.Add("Mnquma")
            cbomunicipal.Items.Add("Ngqushwa ")
            cbomunicipal.Items.Add("Raymond Mhlaba")
            cbomunicipal.Items.Add("Emalahleni ")
            cbomunicipal.Items.Add("Engcobo")
            cbomunicipal.Items.Add("Enoch Mgijima")
            cbomunicipal.Items.Add("Intsika Yethu ")
            cbomunicipal.Items.Add("Inxuba Yethemba")
            cbomunicipal.Items.Add("Sakhisizwe ")
            cbomunicipal.Items.Add("Elundini")
            cbomunicipal.Items.Add("Senqu ")
            cbomunicipal.Items.Add("Walter Sisulu ")
            cbomunicipal.Items.Add("Ingquza Hill")
            cbomunicipal.Items.Add("Mhlontlo")
            cbomunicipal.Items.Add("Nyandeni")
            cbomunicipal.Items.Add("Port St Johns ")
            cbomunicipal.Items.Add("Blue Crane Route ")
            cbomunicipal.Items.Add("Dr Beyers Naudé  ")
            cbomunicipal.Items.Add("Kouga ")
            cbomunicipal.Items.Add("Koukamma  ")
            cbomunicipal.Items.Add("Makana ")
            cbomunicipal.Items.Add("Ndlambe ")
            cbomunicipal.Items.Add("Sundays River Valley")
            cbomunicipal.Items.Add("Nyandeni")
            cbomunicipal.Refresh()

        End If
    End Sub

    Private Sub picupdate_Click(sender As Object, e As EventArgs) Handles picupdate.Click
        Dim results As String
        Dim res As String
        Dim BClass As New BusinessClass
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("not connected to db")
            Else


                If txtname.Text.Trim = "" Then
                    MsgBox("Enter your name please")
                    txtname.Focus()
                    Exit Sub
                End If
                If (txtsurname.Text.Trim.ToUpper) = "" Then
                    MsgBox("Enter your Surname")
                    txtsurname.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtsurname.Text.Trim.ToUpper.Length) = "false" Then
                    MsgBox("Enter a surname that is only alphabets")
                    txtsurname.Focus()
                    Exit Sub
                End If
                If txtid.Text.Trim.ToUpper = "" Then
                    MsgBox("Enter your Id")
                    txtid.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtid.Text.Trim) = "false" Then
                    MsgBox("Your ID must have digits only")
                    txtid.Focus()
                    Exit Sub
                End If
                If (txtid.Text.Trim.Length <> 13) Then
                    MsgBox("your ID should be 13 digits long")
                    txtid.Focus()
                    Exit Sub
                End If
                If txtid.Text.Substring(2, 2) > 12 Then
                    MsgBox("Your ID number is incorrect check the month of birth section")
                    txtid.Focus()
                    Exit Sub
                End If
                If txtid.Text.Substring(4, 2) > 31 Then
                    MsgBox("Your ID number is incorrect check the day of birth section")
                    txtid.Focus()
                    Exit Sub
                End If
                If txtid.Text.Substring(10, 1) <> 0 Then
                    MsgBox("You are not a S.A citizen")
                    txtid.Focus()
                    Exit Sub
                End If
                If txtid.Text.Substring(6, 1) > 4 Then
                    Dim gender As String
                    gender = "Male"
                    cbogender.Text = gender
                End If
                If txtid.Text.Substring(6, 1) < 5 Then
                    Dim gender As String
                    gender = "Female"
                    cbogender.Text = gender
                End If
                If cborace.Text = "" Then
                    MsgBox("Select you race")
                    cborace.Focus()
                    Exit Sub
                End If
                If cboposition.Text = "" Then
                    MsgBox("Select you position")
                    cboposition.Focus()
                    Exit Sub
                End If
                If (UsernameTextBox.Text.Trim) = "" Then
                    MsgBox("Enter a username")
                    UsernameTextBox.Focus()
                    Exit Sub
                End If
                If PasswordTextBox.Text.Trim = "" Then
                    MsgBox("Enter a password")
                    PasswordTextBox.Focus()
                    Exit Sub
                End If


                If txtcell.Text.Trim.ToUpper = "" Then
                    MsgBox("enter your Phone number")
                    txtcell.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtcell.Text.Trim) = "False" Then
                    MsgBox("celphone must be digits only")
                    txtcell.Focus()
                    Exit Sub
                End If
                If txtcell.Text.Substring(0, 1) <> 0 Then
                    MsgBox("phone number must start with a zero")
                    Exit Sub
                End If
                If txtcell.Text.Substring(1, 1) = 0 Then
                    MsgBox("pleasee enter correct phone number like 0738995305 or 0434394567 ")
                    Exit Sub
                End If
                If txtcell.Text.Substring(2, 1) = 0 Then
                    MsgBox("pleasee enter correct phone number like 0738995305 or 0434394567 ")
                    Exit Sub
                End If


                Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                If Not (email.IsMatch(txtemail.Text)) Then
                    MsgBox("invalid email")
                    Exit Sub
                End If

                If (txtcell.Text.Trim.Length <> 10) Then
                    MsgBox("Enter a 10 digit cellphone number")
                    txtcell.Focus()
                    Exit Sub
                End If


                If txtemail.Text.Trim = "" Then
                    MsgBox("enter an email address")
                End If
                If txtstreet.Text.Trim.ToUpper = "" Then
                    MsgBox("enter your street name")
                    txtstreet.Focus()
                    Exit Sub

                End If
                If IsNumeric(txtstreet.Text.Trim.ToUpper.Length) = "false" Then
                    MsgBox("your street name must have alphabets only")
                    txtstreet.Focus()
                    Exit Sub
                End If
                If cboprovince.Text = "" Then
                    MsgBox("Select your province")
                    cboprovince.Focus()
                    Exit Sub
                End If
                If cbomunicipal.Text = "" Then
                    MsgBox(" select your municipality")

                    cbomunicipal.Focus()
                    Exit Sub
                End If
                If cbocity.Text = "" Then
                    MsgBox("select your city")
                    cbocity.Focus()
                    Exit Sub
                End If
                If txtcode.Text.Trim = "" Then
                    MsgBox("Enter your  4 digit postal code")
                    txtcode.Focus()
                    Exit Sub
                End If
                If (txtcode.Text.Trim.Length <> 4) Then
                    MsgBox("postal code should be 4 digits only")
                    txtcode.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtcode.Text.Trim) = "False" Then
                    MsgBox("your postal code must have numbers only")
                    txtcode.Focus()
                    Exit Sub
                End If


                res = BClass.UpdateEmployees(txtid.Text, txtsurname.Text, txtname.Text, txtcell.Text, txtemail.Text, UsernameTextBox.Text, PasswordTextBox.Text, cboposition.Text, txtstreet.Text, txtline2.Text, txtline3.Text, cboprovince.Text, cbomunicipal.Text, cbocity.Text, CInt(txtcode.Text), cbogender.Text, cborace.Text)
                If res = "true" Then
                    MsgBox("successfully updated")
                Else
                    ' txtname.Text = res
                    MsgBox("not  updated" + " " + res)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub
End Class