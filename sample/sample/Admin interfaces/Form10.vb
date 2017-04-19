Imports MySql.Data.MySqlClient
Public Class form10
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Try

            Dim ans As Integer
            ans = MsgBox("Are you sure want to logout of the application?", vbYesNo + vbQuestion, "Confirm Message")
            If ans = MsgBoxResult.No Then
                Exit Sub
            Else
                Application.Exit()

            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picreport.Click

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds, ds2, ds3, ds4, ds5 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else
                'race
                ds4 = BClass.GetApplicantRace()
                If ds4.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else
                    For a As Integer = 0 To ds4.Tables("Datas").Rows.Count - 1
                        cborace.Items.Add(ds4.Tables("Datas").Rows(a)!Race)

                    Next
                End If
                'gender
                ds3 = BClass.GetApplicantGender()
                If ds3.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                    Exit Sub
                Else
                    For a As Integer = 0 To ds3.Tables("Datas").Rows.Count - 1
                        cbogender.Items.Add(ds3.Tables("Datas").Rows(a)!Gender)

                    Next
                End If
                'field of study
                ds = BClass.GetApplicantfield()
                If ds.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                    Exit Sub
                Else
                    For a As Integer = 0 To ds.Tables("Datas").Rows.Count - 1
                        cbofield.Items.Add(ds.Tables("Datas").Rows(a)!Field_Of_Study)

                    Next
                End If
                'city
                ds5 = BClass.GetApplicantcity()
                If ds5.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                    Exit Sub

                Else
                    For a As Integer = 0 To ds5.Tables("Datas").Rows.Count - 1
                        cbolocation.Items.Add(ds5.Tables("Datas").Rows(a)!City_Name)

                    Next
                End If
                ' all info
                ds2 = BClass.GetallApplicant()
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                    Exit Sub
                Else
                    dgvdisplay.DataSource = ds2.Tables("Datas")

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
    Private Sub cborace_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cborace.SelectedIndexChanged
        Dim dsRace As New DataSet
        Dim res As String

        Dim BClass As New BusinessClass
        Try
            res = BClass.getConnection

            If res = "true" Then
                dsRace = BClass.GetApplicantByRace(cborace.Text)
                dgvdisplay.DataSource = dsRace.Tables("Datas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cbogender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbogender.SelectedIndexChanged
        Dim dsGender As New DataSet
        Dim res As String

        Dim BClass As New BusinessClass
        Try
            res = BClass.getConnection

            If res = "true" Then
                dsGender = BClass.GetApplicantByGender(cbogender.Text)
                dgvdisplay.DataSource = dsGender.Tables("Datas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub cbolocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbolocation.SelectedIndexChanged
        Dim dsCity As New DataSet
        Dim res As String

        Dim BClass As New BusinessClass
        Try
            res = BClass.getConnection

            If res = "true" Then
                dsCity = BClass.GetApplicantByCity(cbolocation.Text)
                dgvdisplay.DataSource = dsCity.Tables("Datas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub


    Private Sub cbofield_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofield.SelectedIndexChanged
        Dim dsFieldOfStudy As New DataSet
        Dim res As String

        Dim BClass As New BusinessClass
        Try
            res = BClass.getConnection()

            If res = "true" Then
                dsFieldOfStudy = BClass.GetApplicantByFieldOfStudy(cbofield.Text)
                dgvdisplay.DataSource = dsFieldOfStudy.Tables("Datas")
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
                resReject = BClass.UpdateToReject(txtid.Text)
                If resReject <> "true" Then
                    MsgBox("not updated" + resReject)
                Else
                    MsgBox("rejected")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub picshortlist_Click(sender As Object, e As EventArgs) Handles picshortlist.Click
        Dim BClass As New BusinessClass
        Dim results As String
        Dim resReject As String
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("You are not connected to the database")
            Else
                resReject = BClass.UpdateToShortlist(txtid.Text)
                If resReject <> "true" Then
                    MsgBox("not updated" + resReject)
                Else
                    MsgBox("Shortlisted")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub



    Private Sub dgvdisplay_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdisplay.CellContentClick
        Dim value As Object = dgvdisplay.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If IsDBNull(value) Then
            txtid.Text = "" ' blank if dbnull values
        Else

            txtid.Text = CType(value, String)
        End If

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim ds2 As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else
                ds2 = BClass.Getfiltering(cbogender.Text, cborace.Text, cbolocation.Text, cbofield.Text)
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("There are no applicants found in the database")
                Else

                    dgvdisplay.DataSource = ds2.Tables("Datas")
                    txtid.Text = ds2.Tables("Datas").Rows(0)!Personal_Details_ID

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
                dgvdisplay.DataSource = ds2.Tables("Datas")

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class