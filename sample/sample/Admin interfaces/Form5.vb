Imports MySql.Data.MySqlClient
Public Class Formaccept
    Private Sub btnback_Click(sender As Object, e As EventArgs)
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub piclogoff_Click(sender As Object, e As EventArgs) Handles piclogoff.Click

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

    Private Sub Formaccept_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds, ds2, ds3, ds4 As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else
                ds3 = BClass.GetAllInfoOfApproved()
                ds2 = BClass.GetApprovedId()
                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else
                    dgvdisplay.DataSource = ds3.Tables("Datas")
                    Me.dgvdisplay.Refresh()
                    For a As Integer = 0 To ds2.Tables("Datas").Rows.Count - 1
                        cboAproved.Items.Add(ds2.Tables("Datas").Rows(a)!ID_number + "_" + ds2.Tables("Datas").Rows(a)!FirstName)
                    Next

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub cboAproved_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAproved.SelectedIndexChanged
        Dim ds, ds2 As New DataSet
        Dim BClass As New BusinessClass
        Dim result, d As String
        Try
            result = BClass.getConnection

            If result <> "true" Then
                MsgBox("no connection")
            Else
                'cboid.SelectedIndex = -1
                ds2 = BClass.GetApprovedDetailsById(cboAproved.Text.Substring(0, 13))
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim ds, ds2, ds3, ds4 As New DataSet
        Dim BClass As New BusinessClass
        Dim result As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection")
            Else
                ds3 = BClass.GetAllInfoOfApproved()

                If ds2.Tables("Datas").Rows.Count = 0 Then
                    MsgBox("database is empty")
                Else

                    dgvdisplay.DataSource = ds3.Tables("Datas")
                    Me.dgvdisplay.Refresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub picreport_Click(sender As Object, e As EventArgs) Handles picreport.Click

    End Sub
End Class