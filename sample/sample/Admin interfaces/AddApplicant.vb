Imports System.Text.RegularExpressions

Public Class AddApplicant
    Dim Bclass As New BusinessClass
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label25.Click

    End Sub

    Private Sub cborace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cborace.SelectedIndexChanged

    End Sub

    Private Sub AddApplicant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblspecify.Visible = False
        txtdisability.Visible = False
        Dim result As String = "true"
        Dim ds, ds2, ds3, ds4, ds5, ds6, ds7, ds8 As DataSet
        Try

            result = Bclass.getConnection()
            If result <> "true" Then
                MsgBox("Database Integration failed...." + result, MsgBoxStyle.Information)
                Application.Exit()
            Else


                ds2 = Bclass.getAllgender()
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no Genders found")
                    Exit Sub
                Else
                    For i As Integer = 0 To ds2.Tables("Datas").Rows.Count - 1
                        cbogender.Items.Add(ds2.Tables("Datas").Rows(i)!Gender_ID & " " & ds2.Tables("Datas").Rows(i)!Gender)
                    Next
                End If


                ds3 = Bclass.getAllNationality()
                If ds3.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no nationalities found")
                    Exit Sub
                Else
                    For o As Integer = 0 To ds3.Tables("Datas").Rows.Count - 1
                        cbonationality.Items.Add((ds3.Tables("Datas").Rows(o)!Nationality_ID) & " " & (ds3.Tables("Datas").Rows(o)!Nationality))
                    Next
                End If

                ds4 = Bclass.getAllMarital
                If ds4.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no Marital Statuses found")
                    Exit Sub
                Else
                    For p As Integer = 0 To ds4.Tables("Datas").Rows.Count - 1
                        cbomarital.Items.Add(ds4.Tables("Datas").Rows(p)!Marital_Status_ID & " " & ds4.Tables("Datas").Rows(p)!Marital_Status)
                    Next
                End If



                ds5 = Bclass.GetApplicantRace()
                If ds5.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no races Statuses found")
                    Exit Sub
                Else
                    For l As Integer = 0 To ds5.Tables("Datas").Rows.Count - 1
                        cborace.Items.Add(ds5.Tables("Datas").Rows(l)!Race_ID & " " & ds5.Tables("Datas").Rows(l)!Race)
                    Next
                End If

                ds6 = Bclass.GetAllposition()
                If ds6.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no positions found")
                    Exit Sub
                Else
                    For s As Integer = 0 To ds6.Tables("Datas").Rows.Count - 1
                        cboposition.Items.Add(ds6.Tables("Datas").Rows(s)!Position_ID & " " & ds6.Tables("Datas").Rows(s)!Position)
                    Next
                End If


                ds7 = Bclass.getAllLicense()
                If ds7.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no drivers licenses")
                    Exit Sub
                Else
                    For f As Integer = 0 To ds7.Tables("Datas").Rows.Count - 1
                        cbolicense.Items.Add(ds7.Tables("Datas").Rows(f)!Drivers_License_Code_ID & " " & ds7.Tables("Datas").Rows(f)!Drivers_License_Code)
                    Next

                End If
                ds = Bclass.getAllStatus()
                If ds.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no status found")
                    Exit Sub
                Else

                    For t As Integer = 0 To ds.Tables("Datas").Rows.Count - 1
                        cbostatus.Items.Add(ds.Tables("Datas").Rows(t)!Drivers_License_Status_ID & " " & ds.Tables("Datas").Rows(t)!Drivers_License_Status)
                    Next

                End If

                ds8 = Bclass.getAllProvinces()
                If ds8.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no positions found")
                    Exit Sub
                Else
                    For d As Integer = 0 To ds8.Tables("Datas").Rows.Count - 1
                        cboprovince.Items.Add(ds8.Tables("Datas").Rows(d)!Province_Name)
                    Next
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try


    End Sub

    Private Sub radyesdisable_CheckedChanged(sender As Object, e As EventArgs) Handles radyesdisable.CheckedChanged
        lblspecify.Visible = True
        txtdisability.Visible = True
        If radyesdisable.Checked Then

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ds As New DataSet

        'If txtname.Text.Trim = "" Then
        '    MsgBox("Enter your name please")
        '    txtname.Focus()
        '    Exit Sub
        'End If
        'If IsNumeric(txtname.Text.Trim.ToUpper) Then
        '    MsgBox("name must be alphabets")
        '    txtname.Focus()
        '    Exit Sub

        'End If


        'If (txtsurname.Text.Trim.ToUpper) = "" Then
        '    MsgBox("Enter your surname")
        '    txtsurname.Focus()
        '    Exit Sub
        'End If
        'If IsNumeric(txtsurname.Text.Trim.ToUpper) Then
        '    MsgBox("Enter a surname that is only alphabets")
        '    txtsurname.Focus()
        '    Exit Sub
        'End If

        'If txtid.Text.Trim.ToUpper = "" Then
        '    MsgBox("Enter your Id")
        '    txtid.Focus()
        '    Exit Sub
        'End If
        'If IsNumeric(txtid.Text.Trim) = False Then
        '    MsgBox("Your ID must have digits only")
        '    txtid.Focus()
        '    Exit Sub
        'End If
        'If (txtid.Text.Trim.Length <> 13) Then
        '    MsgBox("your ID should be 13 digits long")
        '    txtid.Focus()
        '    Exit Sub
        'End If
        'If txtid.Text.Substring(2, 2) > 12 Then
        '    MsgBox("Your ID number is incorrect check the month of birth section")
        '    txtid.Focus()
        '    Exit Sub
        'End If
        'If txtid.Text.Substring(4, 2) > 31 Then
        '    MsgBox("Your ID number is incorrect check the day of birth section")
        '    txtid.Focus()
        '    Exit Sub
        'End If
        'If cbogender.Text = "" Then
        '    MsgBox("Select your gender")
        '    cbogender.Focus()
        '    Exit Sub
        'End If
        'If cbomarital.Text = "" Then
        '    MsgBox("Select your marital status")
        '    cbomarital.Focus()
        '    Exit Sub
        'End If
        'If txtdependency.Text.Trim.ToUpper <> "" Then

        '    If IsNumeric(txtdependency.Text.Trim.ToUpper) = False Then
        '        MsgBox("The number of dependency must be digits only")
        '        txtdependency.Focus()
        '        Exit Sub
        '    End If
        'End If
        'If cbonationality.Text = "" Then
        '    MsgBox("Select your Nationality")
        '    cbonationality.Focus()
        '    Exit Sub
        'End If
        'If cborace.Text = "" Then
        '    MsgBox("Select your Race")
        '    cborace.Focus()
        '    Exit Sub
        'End If

        'If radnocrime.Checked = False And radyescrime.Checked = False Then
        '    MsgBox("select radio button yes or no , do you have a criminal record ")
        '    Exit Sub
        'End If
        'If radnodisable.Checked = False And radyesdisable.Checked = False Then
        '    MsgBox("select radio button yes or no , are  you disabled ? ")
        '    Exit Sub
        'End If

        'If radyesdisable.Checked = True Then

        '    If (txtdisability.Text.Trim.ToUpper) = "" Then
        '        MsgBox("Enter your disability")
        '        txtdisability.Focus()
        '        Exit Sub
        '    End If
        'End If

        'If txtcell.Text.Trim.ToUpper = "" Then
        '    MsgBox("Enter your cellphone number")
        '    txtcell.Focus()
        '    Exit Sub
        'End If
        'If (txtcell.Text.Trim.Length <> 10) Then
        '    MsgBox("Enter a 10 digit cellphone number")
        '    txtcell.Focus()
        '    Exit Sub
        'End If
        'If IsNumeric(txtcell.Text.Trim) = False Then
        '    MsgBox("cellphone number must be digits only")
        '    txtcell.Focus()
        '    Exit Sub
        'End If
        'If txtcell.Text.Substring(0, 1) <> 0 Then
        '    MsgBox("cellphone number must start with a zero")
        '    txtcell.Focus()
        '    Exit Sub
        'End If
        'If txtcell.Text.Substring(1, 1) = 0 Then
        '    MsgBox("please enter correct phone number e.g(0738995305 or 0434394567) ")
        '    txtcell.Focus()
        '    Exit Sub
        'End If
        'If txtcell.Text.Substring(2, 1) = 0 Then
        '    MsgBox("please enter correct phone number e.g(0738995305 or 0434394567)")
        '    txtcell.Focus()
        '    Exit Sub
        'End If

        ''Dim phoneNumber As New Regex("\d{3}-\d{3}-\d{4}")
        ''If phoneNumber.IsMatch(txtcell.Text) Then
        ''    txtcell.Text = "Valid phone number"
        ''Else
        ''    txtcell.Text = "Not Valid phone number"
        ''End If




        'If txtaltcell.Text.Trim.ToUpper <> "" Then
        '    If (txtaltcell.Text.Trim.Length <> 10) Then
        '        MsgBox("Enter a 10 digit cellphone number")
        '        txtaltcell.Focus()
        '        Exit Sub
        '    End If
        '    If IsNumeric(txtaltcell.Text.Trim) = "False" Then
        '        MsgBox("alternative cellphone number must be digits only")
        '        txtaltcell.Focus()
        '        Exit Sub
        '    End If
        '    If txtaltcell.Text.Substring(0, 1) <> 0 Then
        '        MsgBox("alternative cellphone number must start with a zero")
        '        Exit Sub
        '    End If
        '    If txtaltcell.Text.Substring(1, 1) = 0 Then
        '        MsgBox("please enter a correct alternative cellphone number eg(0738995305 or 0434394567) ")
        '        Exit Sub
        '    End If
        '    If txtaltcell.Text.Substring(2, 1) = 0 Then
        '        MsgBox("please enter a correct alternative cellphone number eg(0738995305 or 0434394567) ")
        '        Exit Sub
        '    End If
        'End If
        'Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        'If Not (email.IsMatch(txtemail.Text)) Then

        '    MsgBox("invalid email address")
        '    Exit Sub
        'End If

        'If cbolicense.Text = "" Then
        '    MsgBox("select licence code ")
        '    cbolicense.Focus()
        'End If
        'If cbolicense.SelectedIndex <> 0 Then
        '    If cbovehiclerestriction.Text = "" Then
        '        MsgBox("select vehicle restriction it you have a drivers license")
        '        cbovehiclerestriction.Focus()
        '    End If
        'End If
        'If cboposition.SelectedIndex = -1 Then
        '    MsgBox("Select you position")
        '    cboposition.Focus()
        '    Exit Sub
        'End If
        'If (UsernameTextBox.Text.Trim) = "" Then
        '    MsgBox("Enter a username")
        '    UsernameTextBox.Focus()
        '    Exit Sub
        'End If
        'If PasswordTextBox.Text.Trim = "" Then
        '    MsgBox("Enter a password")
        '    PasswordTextBox.Focus()
        '    Exit Sub
        'End If

        'If txtstreet.Text.Trim = "" Then
        '    MsgBox("enter your line1 address")
        '    txtstreet.Focus()
        '    Exit Sub
        'End If

        'If (txtline2.Text.Trim.ToUpper) = "" Then
        '    MsgBox("Enter your line 2 address")
        '    txtline2.Focus()
        '    Exit Sub
        'End If




        'If cboprovince.SelectedIndex = -1 Then
        '    MsgBox("Select your province")
        '    cboprovince.Focus()
        '    Exit Sub
        'End If
        'If cbomunicipal.SelectedIndex = -1 Then
        '    MsgBox(" select your municipality")
        '    cbomunicipal.Focus()

        '    Exit Sub
        'End If
        'If cbocity.SelectedIndex = -1 Then
        '    MsgBox("select your city")
        '    cbocity.Focus()
        '    Exit Sub
        'End If
        'If txtcode.Text.Trim = "" Then
        '    MsgBox("Enter your  4 digit postal code")
        '    txtcode.Focus()
        '    Exit Sub
        'End If
        'If (txtcode.Text.Trim.Length <> 4) Then
        '    MsgBox("postal code should be 4 digits only")
        '    txtcode.Focus()
        '    Exit Sub
        'End If
        'If Not (IsNumeric(txtcode.Text.Trim)) Then
        '    MsgBox("your postal code must have numbers only")
        '    txtcode.Focus()
        '    Exit Sub
        'End If


        addapplicant2.Show()

    End Sub

    Private Sub radnodisable_CheckedChanged(sender As Object, e As EventArgs) Handles radnodisable.CheckedChanged
        lblspecify.Visible = False
        txtdisability.Visible = False
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Try

            Dim ans As Integer
            ans = MsgBox("Are you sure want to logout of the application?", vbYesNo + vbQuestion, "Confirm Message")
            If ans = MsgBoxResult.No Then
                Exit Sub 'endsystem
            Else
                Application.Exit()

            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub cboprovince_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboprovince.SelectedIndexChanged
        Dim dsProvince As New DataSet
        Dim results As String
        cbomunicipal.Items.Clear()

        results = Bclass.getConnection()
        If results <> "true" Then
            MsgBox("you are connnected to the database")
        Else
            'testing
            dsProvince = Bclass.getAllManicipalitytest(cboprovince.Text)
            For i As Integer = 0 To dsProvince.Tables("Datas").Rows().Count - 1
                cbomunicipal.Items.Add(dsProvince.Tables("datas").Rows(i)!Municipality_Name)
            Next
            Exit Sub


        End If
    End Sub

    Private Sub cbomunicipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbomunicipal.SelectedIndexChanged
        Dim ds, dsmun As New DataSet
        Dim results As String

        cbocity.Items.Clear()
        Try
            results = Bclass.getConnection()
            If results <> "true" Then
                MsgBox("you are connnected to the database")
            Else
                'TESTING
                dsmun = Bclass.getAllCitiesBasedOnMunicipality(cboprovince.Text, cbomunicipal.Text)
                For i As Integer = 0 To dsmun.Tables("Datas").Rows().Count - 1
                    cbocity.Items.Add(dsmun.Tables("Datas").Rows(i)!Province_Municipality_City_ID & " " & dsmun.Tables("Datas").Rows(i)!City_Name)
                Next


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

End Class