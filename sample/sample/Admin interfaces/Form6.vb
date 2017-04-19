Imports MySql.Data.MySqlClient
Public Class Form6


    Private Sub btnback_Click(sender As Object, e As EventArgs)
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

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim ds, ds2, ds3 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
                Exit Sub
            Else

                ds2 = BClass.GetRejectedid
                ds3 = BClass.GetAllInfoOfRejected()

                For i As Integer = 0 To ds2.Tables("Datas").Rows.Count - 1
                    Dim pp As String = ds2.Tables("Datas").Rows(i)!Personal_Details_ID & "_" & ds2.Tables("Datas").Rows(i)!First_Name
                    cbosearch.Items.Add(pp)
                Next
                dgvdisplay.DataSource = ds3.Tables("Datas")

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
                resReject = BClass.UpdateToShortlist(cbosearch.Text.Substring(0, 13))
                If resReject <> "true" Then
                    MsgBox("not updated" + resReject)
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

    Private Sub cbosearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbosearch.SelectedIndexChanged
        Dim ds As New DataSet

        Dim result As String
        Dim BClass As New BusinessClass
        Try
            result = BClass.getConnection
            If result = "true" Then
                ds = BClass.GetRejectedDetailsById(cbosearch.Text.Substring(0, 13))
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ds, ds2, ds3, ds4 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else

                ds2 = BClass.GetAllInfoOfRejected()
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
End Class