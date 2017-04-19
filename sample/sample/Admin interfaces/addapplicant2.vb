Imports System.Text.RegularExpressions
Imports System.Globalization
Public Class addapplicant2
    Dim Bclass As New BusinessClass
    Private Sub addapplicant2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'picupdate.Visible = True
        grpref2.Visible = False
        dtpstart.Format = DateTimePickerFormat.Custom
        dtpstart.CustomFormat = "yyyy-MM-dd"
        dtpend.Format = DateTimePickerFormat.Custom
        dtpend.CustomFormat = "yyyy-MM-dd"
        Dim result As String = "true"
        Dim ds, ds2, ds3, ds4, ds5, ds6, ds7, ds8 As DataSet
        Try

            result = Bclass.getConnection()
            If result <> "true" Then
                MsgBox("Database Integration failed...." + result, MsgBoxStyle.Information)
                Application.Exit()
            Else


                ds2 = Bclass.getAllUniversity
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no institutions found")
                    Exit Sub
                Else
                    For i As Integer = 0 To ds2.Tables("Datas").Rows.Count - 1
                        cboinstitution.Items.Add(ds2.Tables("Datas").Rows(i)!University_ID & " " & ds2.Tables("Datas").Rows(i)!University_Name)
                    Next
                End If


                ds3 = Bclass.getAllqualifications
                If ds3.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no qualifications found")
                    Exit Sub
                Else
                    For o As Integer = 0 To ds3.Tables("Datas").Rows.Count - 1
                        cboqualification.Items.Add(ds3.Tables("Datas").Rows(o)!Qualification_ID & " " & ds3.Tables("Datas").Rows(o)!Qualification_Name)
                    Next
                End If





                ds5 = Bclass.getAllqualificationStatus()
                If ds5.Tables("Datas").Rows.Count = 0 Then
                    MessageBox.Show("Database empty no Fields of study found")
                    Exit Sub
                Else
                    For l As Integer = 0 To ds5.Tables("Datas").Rows.Count - 1
                        cboqualificationstatus.Items.Add(ds5.Tables("Datas").Rows(l)!Qualification_Status_ID & " " & ds5.Tables("Datas").Rows(l)!Qualification_Status)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs)
        cboqualificationstatus.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click, PictureBox3.Click
        grpref2.Visible = True
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AddApplicant.Show()
        Me.Close()
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

    Private Sub picupdate_Click(sender As Object, e As EventArgs) Handles picupdate.Click
        'calling  methods for adding New applicant data Not updating 
        Dim BClass As New BusinessClass
        Dim results As String
        Dim res, city, gender, marital, nationality, race, license, vehicle, position, institution, qualification, licensestatus As String
        Dim qualificationstatus As String
        Dim p As String
        'Dim institution, qualification As Integer

        dtpstart.Format = DateTimePickerFormat.Custom
        dtpstart.CustomFormat = "yyyy-MM-dd"
        dtpend.Format = DateTimePickerFormat.Custom
        dtpend.CustomFormat = "yyyy-MM-dd"
        ' Dim name As New Regex("s\D//g")

        Dim disability, criminal As Integer
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("no connect to the databses" + results)
            Else



                If cboinstitution.Text = "" Then
                    MsgBox("select your institution")
                    cboinstitution.Focus()
                    Exit Sub
                End If

                If cboqualification.Text = "" Then
                    MsgBox("select your qualification ")
                    cboqualificationstatus.Focus()
                    Exit Sub
                End If

                If cboqualificationstatus.Visible = True And cboqualificationstatus.Text = "" Then
                    MsgBox("select your qualification status reason for not completing the qualification")
                    cboqualificationstatus.Focus()
                    Exit Sub
                End If
                If (txtfieldofstudy.Text = "") Then
                    MsgBox("input your field of study ")
                    txtfieldofstudy.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtfieldofstudy.Text) Then
                    MsgBox("input your field of study only in alphabets ")
                    txtfieldofstudy.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtduties.Text) Then
                    MsgBox("your duties should be alphabets")
                    txtduties.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtjobname.Text) Then
                    MsgBox("The company should be alphabets")
                    txtjobname.Focus()
                    Exit Sub
                End If
                If txtrefname.Text = "" Then
                    MsgBox("input a reference name ")
                    txtrefname.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtrefname.Text) Then
                    MsgBox("The name of your reference should be alphabets")
                    txtrefname.Focus()
                    Exit Sub
                End If
                If (txtrefcell.Text.Trim.Length <> 10) Then
                    MsgBox("Enter a 10 digit cellphone number")
                    txtrefcell.Focus()
                    Exit Sub
                End If


                If Not IsNumeric(txtrefcell.Text.Trim) Then
                    MsgBox("cellphone must be digits only")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(0, 1) <> 0 Then
                    MsgBox("reference's cellphone number must start with a zero")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(1, 1) = 0 Then
                    MsgBox("please enter correct phone number for the refernce like 0738995305 or 0434394567 ")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(2, 1) = 0 Then
                    MsgBox("please enter correct phone number for the refernce like 0738995305 or 0434394567 ")
                    Exit Sub
                    txtrefcell.Focus()
                End If
                If txtrefrelationship.Text = "" Then
                    MsgBox("input the relationship between you and  your reference  ")
                    txtrefrelationship.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtrefrelationship.Text) Then
                    MsgBox("The relationship between you and  your reference should be alphabets")
                    txtrefrelationship.Focus()
                    Exit Sub
                End If
                Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                If Not (email.IsMatch(txtrefemail.Text)) Then

                    MsgBox("invalid email for reference")
                    Exit Sub
                End If
                '
                ' reference 2



                If grpref2.Visible = True Then
                    If (txtrefcell2.Text.Trim.Length <> 10) Then
                        MsgBox("Enter a 10 digit cellphone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Trim.ToUpper = "" Then
                        MsgBox("enter your Phone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If (txtrefcell2.Text.Trim.Length <> 10) Then
                        MsgBox("Enter a 10 digit cellphone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If Not IsNumeric(txtrefcell2.Text.Trim) Then
                        MsgBox("cellphone must be digits only")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(0, 1) <> 0 Then
                        MsgBox("phone number must start with a zero")
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(1, 1) = 0 Then
                        MsgBox("please enter correct phone number like 0738995305 or 0434394567 ")
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(2, 1) = 0 Then
                        MsgBox("please enter correct phone number like 0738995305 or 0434394567 ")
                        Exit Sub
                    End If
                    If txtrefcell2.Text = " " Then
                        MsgBox("enter reference cell number for the second referenced person")
                    End If
                    Dim email2 As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                    If email2.IsMatch(txtrefemail2.Text) Then

                    Else
                        MsgBox("invalid email for reference")
                        Exit Sub
                    End If
                    If txtrefrelationship2.Text = " " Then
                        MsgBox("enter relationship of the second reference ")
                        Exit Sub
                    End If
                End If
                If AddApplicant.radyesdisable.Checked = "true" Then
                    disability = 2

                Else
                    disability = 1

                End If
                If AddApplicant.radyescrime.Checked = "true" Then
                    criminal = 1

                Else
                    criminal = 0

                End If


                qualification = BClass.Num(cboqualification.Text)

                city = BClass.Num(AddApplicant.cbocity.Text)

                gender = BClass.Num(AddApplicant.cbogender.Text)

                marital = BClass.Num(AddApplicant.cbomarital.Text)

                nationality = BClass.Num(AddApplicant.cbonationality.Text)

                race = BClass.Num(AddApplicant.cborace.Text)

                license = BClass.Num(AddApplicant.cbolicense.Text)

                position = BClass.Num(AddApplicant.cboposition.Text)

                institution = BClass.Num(cboinstitution.Text)
                ' MsgBox(institution)
                qualificationstatus = BClass.Num(cboqualificationstatus.Text)

                licensestatus = BClass.Num(AddApplicant.cbostatus.Text)


                res = BClass.Addapplicant(AddApplicant.txtid.Text, position,
                                      AddApplicant.PasswordTextBox.Text, AddApplicant.txtemail.Text,
                                       AddApplicant.txtdisability.Text,
                                       race, marital, gender, nationality, disability, AddApplicant.txtsurname.Text, AddApplicant.txtname.Text,
                                      AddApplicant.txtmiddlename.Text, AddApplicant.txtcell.Text,
                                       AddApplicant.txtaltcell.Text, criminal,
                                       AddApplicant.txtskills.Text, AddApplicant.txtdependency.Text, city, AddApplicant.txtstreet.Text,
                                       AddApplicant.txtline2.Text, AddApplicant.txtline3.Text, AddApplicant.txtcode.Text,
                                      qualification, institution, qualificationstatus,
                                      txtfieldofstudy.Text, txtrefcell.Text, txtrefname.Text,
                                      txtrefemail.Text, txtrefrelationship.Text, txtjobname.Text, txtcompanyname.Text, txtduties.Text,
                                   CDate(dtpstart.Text), CDate(dtpend.Text), license, licensestatus)

                If res = "true" Then

                    MsgBox("Added Succesfully")

                    Exit Sub
                Else
                    MsgBox("not added" + res)
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString + " hey here")

        End Try
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        dtpstart.Format = DateTimePickerFormat.Custom
        dtpstart.CustomFormat = "yyyy-MM-dd"
        dtpend.Format = DateTimePickerFormat.Custom
        dtpend.CustomFormat = "yyyy-MM-dd"
        Dim BClass As New BusinessClass
        Dim results As String
        Dim resupdate, city, gender, marital, nationality, race, license, vehicle, position, institution, qualification, licensestatus As String
        Dim qualificationstatus As String
        Dim p As String
        ' Dim name As New Regex("s\D//g")

        Dim disability, criminal As Integer
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("no connect to the databses" + results)
            Else



                If cboinstitution.Text = "" Then
                    MsgBox("select your institution")
                    cboinstitution.Focus()
                    Exit Sub
                End If

                If cboqualification.Text = "" Then
                    MsgBox("select your qualification ")
                    cboqualificationstatus.Focus()
                    Exit Sub
                End If

                If cboqualificationstatus.Visible = True And cboqualificationstatus.Text = "" Then
                    MsgBox("select your qualification status reason for not completing the qualification")
                    cboqualificationstatus.Focus()
                    Exit Sub
                End If
                If (txtfieldofstudy.Text = "") Then
                    MsgBox("input your field of study ")
                    txtfieldofstudy.Focus()
                    Exit Sub
                End If

                If IsNumeric(txtfieldofstudy.Text) Then
                    MsgBox("input your field of study only in alphabets ")
                    txtfieldofstudy.Focus()
                    Exit Sub
                End If



                If IsNumeric(txtduties.Text) Then
                    MsgBox("your duties should be alphabets")
                    txtduties.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtjobname.Text) Then
                    MsgBox("The company should be alphabets")
                    txtjobname.Focus()
                    Exit Sub
                End If
                If txtrefname.Text = "" Then
                    MsgBox("input a reference name ")
                    txtrefname.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtrefname.Text) Then
                    MsgBox("The name of your reference should be alphabets")
                    txtrefname.Focus()
                    Exit Sub
                End If
                If (txtrefcell.Text.Trim.Length <> 10) Then
                    MsgBox("Enter a 10 digit cellphone number")
                    txtrefcell.Focus()
                    Exit Sub
                End If


                If Not IsNumeric(txtrefcell.Text.Trim) Then
                    MsgBox("cellphone must be digits only")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(0, 1) <> 0 Then
                    MsgBox("reference's cellphone number must start with a zero")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(1, 1) = 0 Then
                    MsgBox("please enter correct phone number for the refernce like 0738995305 or 0434394567 ")
                    txtrefcell.Focus()
                    Exit Sub
                End If
                If txtrefcell.Text.Substring(2, 1) = 0 Then
                    MsgBox("please enter correct phone number for the refernce like 0738995305 or 0434394567 ")
                    Exit Sub
                    txtrefcell.Focus()
                End If
                If txtrefrelationship.Text = "" Then
                    MsgBox("input the relationship between you and  your reference  ")
                    txtrefrelationship.Focus()
                    Exit Sub
                End If
                If IsNumeric(txtrefrelationship.Text) Then
                    MsgBox("The relationship between you and  your reference should be alphabets")
                    txtrefrelationship.Focus()
                    Exit Sub
                End If
                Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                If Not (email.IsMatch(txtrefemail.Text)) Then

                    MsgBox("invalid email for reference")
                    Exit Sub
                End If
                'Button1.Visible = True
                ' reference 2



                If grpref2.Visible = True Then
                    If (txtrefcell2.Text.Trim.Length <> 10) Then
                        MsgBox("Enter a 10 digit cellphone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Trim.ToUpper = "" Then
                        MsgBox("enter your Phone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If (txtrefcell2.Text.Trim.Length <> 10) Then
                        MsgBox("Enter a 10 digit cellphone number")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If Not IsNumeric(txtrefcell2.Text.Trim) Then
                        MsgBox("cellphone must be digits only")
                        txtrefcell2.Focus()
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(0, 1) <> 0 Then
                        MsgBox("phone number must start with a zero")
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(1, 1) = 0 Then
                        MsgBox("please enter correct phone number like 0738995305 or 0434394567 ")
                        Exit Sub
                    End If
                    If txtrefcell2.Text.Substring(2, 1) = 0 Then
                        MsgBox("please enter correct phone number like 0738995305 or 0434394567 ")
                        Exit Sub
                    End If
                    If txtrefcell2.Text = " " Then
                        MsgBox("enter reference cell number for the second referenced person")
                    End If
                    Dim email2 As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
                    If email2.IsMatch(txtrefemail2.Text) Then

                    Else
                        MsgBox("invalid email for reference")
                        Exit Sub
                    End If
                    If txtrefrelationship2.Text = " " Then
                        MsgBox("enter relationship of the second reference ")
                        Exit Sub
                    End If
                End If
                If AddApplicant.radyesdisable.Checked = "true" Then
                    disability = 2

                Else
                    disability = 1

                End If
                If AddApplicant.radyescrime.Checked = "true" Then
                    criminal = 1

                Else
                    criminal = 0

                End If

                'If cboinstitution.Text = " " Then
                '    MsgBox("select your institution ")
                '    cboinstitution.Focus()
                '    Exit Sub
                'End If
                'Dim test As String

                qualification = BClass.Num(cboqualification.Text)

                city = BClass.Num(AddApplicant.cbocity.Text)

                gender = BClass.Num(AddApplicant.cbogender.Text)

                marital = BClass.Num(AddApplicant.cbomarital.Text)

                nationality = BClass.Num(AddApplicant.cbonationality.Text)

                race = BClass.Num(AddApplicant.cborace.Text)

                license = BClass.Num(AddApplicant.cbolicense.Text)

                'vehicle = BClass.Num(AddApplicant.cbostatus.Text)
                'MsgBox(vehicle)
                position = BClass.Num(AddApplicant.cboposition.Text)

                institution = BClass.Num(cboinstitution.Text)

                qualificationstatus = BClass.Num(cboqualificationstatus.Text)

                licensestatus = BClass.Num(AddApplicant.cbostatus.Text)

                resupdate = BClass.updateapplicant(AddApplicant.txtid.Text, position,
                                      AddApplicant.PasswordTextBox.Text, AddApplicant.UsernameTextBox.Text, AddApplicant.txtdisability.Text,
                                       race, marital, gender, nationality, disability, AddApplicant.txtsurname.Text, AddApplicant.txtname.Text,
                                      AddApplicant.txtmiddlename.Text, AddApplicant.txtcell.Text,
                                       AddApplicant.txtaltcell.Text, criminal,
                                       AddApplicant.txtskills.Text, AddApplicant.txtdependency.Text, city, AddApplicant.txtstreet.Text,
                                       AddApplicant.txtline2.Text, AddApplicant.txtline3.Text, AddApplicant.txtcode.Text,
                                      qualification, institution, qualificationstatus,
                                      txtfieldofstudy.Text, txtrefcell.Text, txtrefname.Text,
                                      txtrefemail.Text, txtrefrelationship.Text, txtjobname.Text, txtcompanyname.Text, txtduties.Text,
                                      dtpstart.Text, dtpend.Text, license, licensestatus)

                If resupdate = "true" Then

                    MsgBox("updated Succesfully")

                    Exit Sub
                Else
                    MsgBox("not updated" & resupdate)
                    Exit Sub
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString & " hey here")

        End Try
    End Sub

End Class