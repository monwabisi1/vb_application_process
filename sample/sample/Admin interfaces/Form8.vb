
Imports MySql.Data.MySqlClient
Public Class Form8
    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboid.SelectedIndex = -1
        dgvdisplay.Refresh()
        Dim ds, ds2, ds3 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else


                ds = BClass.GetApplicantPersonalName()
                '  ds = BClass.getAllinfoOnPersonal_loginDetails()
                ds2 = BClass.GetallApplicant()
                If ds2.Tables("system_login").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else
                    dgvdisplay.DataSource = ds2.Tables("system_login")
                    Me.dgvdisplay.Refresh()
                    For a As Integer = 0 To ds.Tables("system_login").Rows.Count - 1
                        cboid.Items.Add(ds.Tables("system_login").Rows(a)!Login_ID & "_" & ds.Tables("system_login").Rows(a)!First_Name)
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub piclogoff_Click(sender As Object, e As EventArgs) Handles piclogoff.Click



        Dim ans As Integer
        Try
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboid.SelectedIndexChanged

        Dim ds As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String
        Dim a As Integer
        Dim ds2, ds3 As New DataSet
        Dim dd, cc, kk As String
        Try
            result = BClass.getConnection

            If result <> "true" Then
                MsgBox("no connection" + result)
            Else

                ds2 = BClass.getAllApplicantByIDNumber(cboid.Text.Substring(0, 13))
                If ds2.Tables("system_login").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else
                    dgvdisplay.DataSource = ds2.Tables("system_login")
                    Me.dgvdisplay.Refresh()
                    '    ds = BClass.GetApplicantDetailsById(cboid.Text.Substring(0, 13))
                    'a = (ds.Tables("Datas").Rows(0)!ShortListPoints)
                    'If a <> (0) Then
                    '    MsgBox(" This person has  " + " " + CStr(ds.Tables("Datas").Rows(0)!ShortListPoints) + " " + " shortlist points therefore choose to either reject or shortlist them below")
                    'Else
                    'For i As Integer = 0 To ds.Tables("Datas").Rows.Count - 1
                    '    calculate_shortlist.txtgender.Text = ds.Tables("Datas").Rows(i)!Gender
                    '    calculate_shortlist.txtqualification.Text = ds.Tables("Datas").Rows(i)!Qualification_Name
                    '    calculate_shortlist.txtrace.Text = ds.Tables("Datas").Rows(i)!Race
                    'Next
                    ' MsgBox("" + ds.Tables("Applicant").Rows(i)!Id)
                    ''calculate_shortlist.lblname.Text = cboid.SelectedText
                    'ds2 = BClass.GetApplicantNameAndSurname(cboid.SelectedText)
                    'a = ds2.Tables("Datas").Rows(0)!Name
                    'dd = ds2.Tables("Datas").Rows(0)!Surname
                    'kk = ds2.Tables("dtApplicantDetails").Rows(0)!Shortlist
                    'ds3 = BClass.GetLogin(LoginForm1.UsernameTextBox.Text)
                    'cc = ds3.Tables("Worker").Rows(0)!Username
                    'Form1.txtsurname.Text = dd
                    'Form1.txtname.Text = a
                    'Form1.txtinterviewer.Text = cc
                    ' calculate_shortlist.lblname.Text = ("Welcome" + " " + dd + " " + "you are interviewing" + " " + a)
                    'Form1.txtshortlist.Text = kk
                    ' calculate_shortlist.Show()
                    ' Me.Hide()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs)
        Dim ds, ds2 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else
                cboid.SelectedIndex = -1
                ds2 = BClass.GetallApplicant()
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else
                    dgvdisplay.DataSource = ds2.Tables("Datas")
                    Me.dgvdisplay.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub picreject_Click(sender As Object, e As EventArgs) Handles picreject.Click
        Dim BClass As New BusinessClass
        Dim results As String
        Dim resReject As String
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("You are not connected to the database")
            Else
                resReject = BClass.UpdateToReject(cboid.Text.Substring(0, 13))
                If resReject <> "true" Then
                    MsgBox("not updated" + resReject)
                    Exit Sub
                Else
                    MsgBox("rejected")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub picshortlist_Click(sender As Object, e As EventArgs) Handles picshortlist.Click
        Dim BClass As New BusinessClass
        Dim results As String
        Dim shortlist As String
        Try
            results = BClass.getConnection

            If results <> "true" Then
                MsgBox("You are not connected to the database")
            Else
                shortlist = BClass.UpdateToShortlist(cboid.Text.Substring(0, 13))
                If shortlist <> "true" Then
                    MsgBox("not updated" + shortlist)
                    Exit Sub
                Else
                    MsgBox("Shortlisted")
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ds2 As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String
        Try
            result = BClass.getConnection
        If result <> "true" Then
            MsgBox("no connection")
        Else
            ds2 = BClass.GetallApplicant()
            If ds2.Tables("Datas").Rows.Count = 0 Then
                MsgBox("Database empty")
            Else
                dgvdisplay.DataSource = ds2.Tables("Datas")
                Me.dgvdisplay.Refresh()
            End If
        End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    'calculate_shortlist.lblname.Text = cboid.SelectedText
    'ds3 = BClass.GetLogin(LoginForm1.UsernameTextBox.Text)
    'cc = ds3.Tables("Worker").Rows(0)!Username
    'Form1.txtsurname.Text = dd
    'Form1.txtname.Text = a
    'Form1.txtinterviewer.Text = cc
    'Form1.lblname.Text = ("Welcome" + " " + cc + " " + "you are interviewing" + " " + a)
    ''Form1.txtshortlist.Text = kk
    'End Sub
End Class