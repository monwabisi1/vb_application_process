Public Class IDpopup
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtid.Text = ""
        txtid.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim ds1, ds As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String

        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection" + result)
            Else

                ds1 = BClass.GetApplicantPersonalId()
                Dim i As Integer
                '  For i As Integer = 0 To ds1.Tables("system_login").Rows.Count - 1
                'If (txtid.Text.Trim <> ds1.Tables("system_login").Rows(i)!Login_ID) Then
                '        MsgBox("ID not found in database")
                '        Exit Sub
                '    End If
                ' Next
                ds = BClass.GetAllApplicantDetailsByIDS(txtid.Text)
                MsgBox("details collect")
                If (ds.Tables("system_login").Rows.Count = 0) Then
                    MsgBox("Database is empty")
                    Exit Sub
                Else
                    MsgBox("information collecting for txts")
                    'login details
                    AddApplicant.txtid.Text = ds.Tables("system_login").Rows(0)!Login_ID
                    AddApplicant.cboposition.Text = ds.Tables("system_login").Rows(0)!Position_ID & " " & ds.Tables("system_login").Rows(0)!Position
                    AddApplicant.PasswordTextBox.Text = ds.Tables("system_login").Rows(0)!Password
                    AddApplicant.UsernameTextBox.Text = ds.Tables("system_login").Rows(0)!Email

                    '''''reference
                    addapplicant2.txtrefcell.Text = ds.Tables("system_login").Rows(0)!Contact_Number
                    addapplicant2.txtrefname.Text = ds.Tables("system_login").Rows(0)!Reference_Name
                    addapplicant2.txtrefemail.Text = ds.Tables("system_login").Rows(0)!Email_Address
                    addapplicant2.txtrefrelationship.Text = ds.Tables("system_login").Rows(0)!Relationship
                    '''''experience
                    addapplicant2.txtjobname.Text = ds.Tables("system_login").Rows(0)!Job_Name
                    addapplicant2.txtcompanyname.Text = ds.Tables("system_login").Rows(0)!Company_Name
                    addapplicant2.txtduties.Text = ds.Tables("system_login").Rows(0)!Duties
                    addapplicant2.dtpstart.Text = ds.Tables("system_login").Rows(0)!Start_Date
                    addapplicant2.dtpend.Text = ds.Tables("system_login").Rows(0)!End_Date
                    '''''address
                    AddApplicant.cbocity.Text = ds.Tables("system_login").Rows(0)!Province_Municipality_City_ID & " " & ds.Tables("system_login").Rows(0)!City_Name
                    AddApplicant.txtstreet.Text = ds.Tables("system_login").Rows(0)!Address_Line_1
                    AddApplicant.txtline2.Text = ds.Tables("system_login").Rows(0)!Address_Line_2
                    AddApplicant.txtline3.Text = ds.Tables("system_login").Rows(0)!Address_Line_3
                    AddApplicant.txtcode.Text = ds.Tables("system_login").Rows(0)!Postal_Code
                    'nationanlity
                    AddApplicant.cbonationality.Text = ds.Tables("system_login").Rows(0)!Nationality_ID & " " & ds.Tables("system_login").Rows(0)!Nationality
                    'license
                    ' AddApplicant.cbovehiclerestriction.Text = ds.Tables("system_login").Rows(0)!Vehicle_Restriction_ID & " " & AddApplicant.cbovehiclerestriction.Text = ds.Tables("system_login").Rows(0)!Vehicle_Restriction
                    AddApplicant.cbolicense.Text = ds.Tables("system_login").Rows(0)!Drivers_License_Code_ID & " " & ds.Tables("system_login").Rows(0)!Drivers_License_Code
                    'disability
                    If (ds.Tables("system_login").Rows(0)!Disability = 2) Then
                        AddApplicant.radyesdisable.Checked = True
                        AddApplicant.txtdisability.Text = (ds.Tables("system_login").Rows(0)!Disability_Type)
                    Else
                        AddApplicant.radnodisable.Checked = True
                    End If
                    'applicant details
                    AddApplicant.cbomarital.Text = ds.Tables("system_login").Rows(0)!Marital_Status_ID & " " & ds.Tables("system_login").Rows(0)!Marital_Status
                    AddApplicant.cbogender.Text = ds.Tables("system_login").Rows(0)!Gender_ID & " " & ds.Tables("system_login").Rows(0)!Gender
                    AddApplicant.cborace.Text = ds.Tables("system_login").Rows(0)!Race_ID & " " & ds.Tables("system_login").Rows(0)!Race
                    AddApplicant.txtsurname.Text = ds.Tables("system_login").Rows(0)!Surname
                    AddApplicant.txtname.Text = ds.Tables("system_login").Rows(0)!First_Name
                    AddApplicant.txtmiddlename.Text = ds.Tables("system_login").Rows(0)!Middle_Name
                    AddApplicant.txtcell.Text = ds.Tables("system_login").Rows(0)!Contact_Number
                    AddApplicant.txtaltcell.Text = ds.Tables("system_login").Rows(0)!Alt_Contact_Number
                    AddApplicant.txtskills.Text = ds.Tables("system_login").Rows(0)!Skills
                    AddApplicant.txtdependency.Text = ds.Tables("system_login").Rows(0)!Number_Of_Dependencies
                    'criminal record
                    If (ds.Tables("system_login").Rows(0)!Criminal_Record = 1) Then
                        AddApplicant.radyescrime.Checked = True
                    Else
                        AddApplicant.radnocrime.Checked = True
                    End If
                    '  AddApplicant.radyescrime.Text = ds.Tables("system_login").Rows(0)!Criminal_Record Or AddApplicant.radnocrime.Text = ds.Tables("system_login").Rows(0)!Criminal_Record
                    AddApplicant.cboprovince.Text = ds.Tables("system_login").Rows(0)!Province_ID & " " & ds.Tables("system_login").Rows(0)!Province_Name
                    AddApplicant.cbomunicipal.Text = ds.Tables("system_login").Rows(0)!Municipality_Province_ID & " " & ds.Tables("system_login").Rows(0)!Municipality_Name
                    'qualification form2 of add
                    addapplicant2.cboqualification.Text = ds.Tables("system_login").Rows(0)!Qualification_ID & " " & ds.Tables("system_login").Rows(0)!Qualification_Name
                    '& " " & ds.Tables("system_login").Rows(0)!Qualification_Name
                    'qualification status form2 of add
                    addapplicant2.cboqualificationstatus.Text = ds.Tables("system_login").Rows(0)!Qualification_Status_ID & " " & ds.Tables("system_login").Rows(0)!Qualification_Status
                    '& " " & ds.Tables("system_login").Rows(0)!Qualification_Status
                    'institution
                    addapplicant2.cboinstitution.Text = ds.Tables("system_login").Rows(0)!University_ID & " " & ds.Tables("system_login").Rows(0)!University_Name
                    '& " " & ds.Tables("system_login").Rows(0)!University_Name
                    'field of study
                    addapplicant2.txtfieldofstudy.Text = ds.Tables("system_login").Rows(0)!Field_Of_Study
                End If
            End If

            'End If
            AddApplicant.Show()
            Me.Close()


            'End If
        Catch ex As Exception
            MessageBox.Show("Error " + ex.Message.ToString)
        End Try
    End Sub

    Private Sub IDpopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class