Public Class popup
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Dim ds, ds2, ds3 As New DataSet

        'Dim dd, a, cc, kk As String
        'Dim BClass As New BusinessClass
        'Dim result As String
        'result = BClass.getConnection
        'If result <> "true" Then
        '    MsgBox("no connection" + result)
        '    Exit Sub
        'Else
        '    ds = BClass.getApplicantID()
        '    If (ds.Tables("data").Rows.Count = 0) Then
        '        MsgBox("no users found")
        '        Exit Sub
        '    End If
        '    ' ds = BClass.GetLogin(txtid.Text.Trim)
        '    For i As Integer = 0 To ds.Tables("data").Rows.Count - 1
        '        dd = ds.Tables("data").Rows(i)!Applicant_id
        '        If (txtid.Text <> dd) Then
        '            MsgBox("ID not found in the database")
        '            Exit Sub
        '        End If
        '    Next

        Dim ds As New DataSet
        Dim BClass As New BusinessClass
        Dim result, ccc As String
        Dim ds2, ds3 As New DataSet

        Dim dd, a, cc, kk As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection" + result)
            Else
                ' MsgBox("" + ds.Tables("Applicant").Rows(i)!Id)
                Form1.txtintervieweeid.Text = cbotest.Text
                ds2 = BClass.detailsById(cbotest.Text)
                If (ds2.Tables("dtApplicantDetails").Rows.Count = 0) Then
                    MsgBox("This ID number is not found in the database")
                Else

                    a = ds2.Tables("dtApplicantDetails").Rows(0)!FirstName
                    dd = ds2.Tables("dtApplicantDetails").Rows(0)!Surname
                    kk = ds2.Tables("dtApplicantDetails").Rows(0)!ShortlistPoints

                    ds3 = BClass.GetLogin(LoginForm1.UsernameTextBox.Text)
                    cc = ds3.Tables("Worker").Rows(0)!Username
                    Form1.txtsurname.Text = dd
                    Form1.txtname.Text = a
                    Form1.txtinterviewer.Text = cc
                    Form1.lblname.Text = ("Welcome" + " " + cc + " " + "you are interviewing" + " " + a)
                    Form1.txtshortlist.Text = kk

                    Form1.Show()
                    Me.Close()

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbotest.SelectedIndex = -1
        cbotest.Focus()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbotest.Focus()

        Dim ds As New DataSet
        Dim BClass As New BusinessClass
        Dim result, ccc As String
        Try
            result = BClass.getConnection
            If result <> "true" Then
                MsgBox("no connection" + result)
            Else
                ds = BClass.GetAllInfoOfShortlisted()


                For i As Integer = 0 To ds.Tables("Datas").Rows.Count - 1
                    ccc = ds.Tables("Datas").Rows(i)!ID_number
                    cbotest.Items.Add(ccc)

                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub cbotest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotest.SelectedIndexChanged
        Dim ds As New DataSet
        Dim BClass As New BusinessClass
        Dim result, ccc As String
        Dim ds2, ds3 As New DataSet

        Dim dd, a, cc, kk As String
        Try
            result = BClass.getConnection

            If result <> "true" Then
                MsgBox("no connection" + result)
            Else

                ds2 = BClass.detailsById(cbotest.Text)

                a = ds2.Tables("dtApplicantDetails").Rows(0)!FirstName
                dd = ds2.Tables("dtApplicantDetails").Rows(0)!Surname

                kk = ds2.Tables("dtApplicantDetails").Rows(0)!ShortlistPoints
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub
End Class