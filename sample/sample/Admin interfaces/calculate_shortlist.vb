Public Class calculate_shortlist
    Private Sub calculate_shortlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picsave.Visible = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form8.cboid.SelectedIndex = -1
        Form8.dgvdisplay.Refresh()
        Form8.Show()
        Me.Close()
    End Sub

    Private Sub picCalculate_Click(sender As Object, e As EventArgs) Handles picCalculate.Click
        If txtqualificationpoints.Text.Trim.ToUpper = "" Then
            MsgBox("enter qualification points")
            txtqualificationpoints.Focus()
            Exit Sub
        End If
        If IsNumeric(txtqualificationpoints.Text.Trim) = "False" Then
            MsgBox("qualification points must be digits only")
            txtqualificationpoints.Focus()
            Exit Sub
        End If
        If txtracepoints.Text.Trim.ToUpper = "" Then
            MsgBox("enter race points")
            txtracepoints.Focus()
            Exit Sub
        End If
        If IsNumeric(txtracepoints.Text.Trim) = "False" Then
            MsgBox("Race points  must be digits only")
            txtracepoints.Focus()
            Exit Sub
        End If
        If txtgenderpoints.Text.Trim.ToUpper = "" Then
            MsgBox("enter Gender points")
            txtgenderpoints.Focus()
            Exit Sub
        End If
        If IsNumeric(txtgenderpoints.Text.Trim) = "False" Then
            MsgBox("Gender points  must be digits only")
            txtracepoints.Focus()
            Exit Sub
        End If
        If txtcoverpoints.Text.Trim.ToUpper = "" Then
            MsgBox("enter cover points")
            txtracepoints.Focus()
            Exit Sub
        End If
        If IsNumeric(txtcoverpoints.Text.Trim) = "False" Then
            MsgBox("Cover points must be digits only")
            txtracepoints.Focus()
            Exit Sub
        End If
        txtshortlistpoints.Text = CInt(txtqualificationpoints.Text) + CInt(txtgenderpoints.Text) + CInt(txtracepoints.Text) + CInt(txtcoverpoints.Text)
        picsave.Visible = True
    End Sub

    Private Sub picsave_Click(sender As Object, e As EventArgs) Handles picsave.Click
        Dim ds As New DataSet
        Dim res As String
        Dim results As String

        Dim BClass As New BusinessClass
        Try
            results = BClass.getConnection
            If results <> "true" Then
                MsgBox("error " + " " + results)

            Else

                res = BClass.UpdateApplicantsShortlist(Form8.cboid.Text.Substring(0, 13), CStr(txtshortlistpoints.Text))

                If res = "true" Then
                    MsgBox("successfully saved")
                    Form8.cboid.Text = ""
                    Form8.dgvdisplay.Refresh()
                    Form8.Show()
                    Me.Close()
                Else
                    MsgBox("not updated" + " " + res)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
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
End Class