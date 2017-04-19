Imports MySql.Data.MySqlClient
Public Class Form7
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

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ds, ds2, ds3 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
                Exit Sub
            Else

                ds2 = BClass.GetShortlistedid
                ds3 = BClass.GetAllInfoOfShortlisted()


                dgvdisplay.DataSource = ds3.Tables("Datas")
                For i As Integer = 0 To ds2.Tables("Datas").Rows.Count - 1
                    Dim pp As String = ds2.Tables("Datas").Rows(i)!Personal_Details_ID & "_" & ds2.Tables("Datas").Rows(i)!First_Name
                    cboshortlisted.Items.Add(pp)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cboshortlisted_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboshortlisted.SelectedIndexChanged
        Dim ds As New DataSet

        Dim result As String
        Dim BClass As New BusinessClass
        Try
            result = BClass.getConnection
            If result = "true" Then
                ds = BClass.GetShortlistDetailsById(cboshortlisted.Text.Substring(0, 13))
                If ds.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("no data found in the database")
                Else
                    dgvdisplay.DataSource = ds.Tables("Datas")
                End If
            Else
                MsgBox("Error in connection")
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
                resReject = BClass.UpdateToReject(cboshortlisted.Text.Substring(0, 13))
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

    Private Sub picapprove_Click(sender As Object, e As EventArgs) Handles picapprove.Click
        Dim BClass As New BusinessClass
        Dim results As String
        Dim resapprove As String
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("You are not connected to the database")
            Else
                resapprove = BClass.UpdateToApprove(cboshortlisted.Text.Substring(0, 13))

                If resapprove <> "true" Then
                    MsgBox("not updated" + resapprove)
                Else
                    MsgBox("Approved")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ds, ds2, ds3 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection

            If result <> "true" Then
                MsgBox("no connection")
            Else


                ds3 = BClass.GetAllInfoOfShortlisted()

                If ds3.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else

                    dgvdisplay.DataSource = ds3.Tables("Datas")
                    Me.dgvdisplay.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Shortlist Refresh" + ex.Message.ToString)
        End Try

    End Sub
End Class