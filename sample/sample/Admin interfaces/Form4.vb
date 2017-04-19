Public Class Form4

    Private Sub RadButtonElement7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement7.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub RadButtonElement6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement6.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub RadButtonElement5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement5.Click
        Form8.Show()
        Me.Close()
    End Sub
    Private Sub RadButtonElement4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement4.Click
        Form10.Show()
        Me.Close()

    End Sub

    Private Sub RadButtonElement3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement3.Click
        'Dim defaultValue As String 
        'Dim ds As New DataSet
        'Dim dd As String
        'Dim BClass As New BusinessClass
        'Dim result As String
        'result = BClass.getConnection
        'If result <> "true" Then
        '    MsgBox("no connection" + result)
        'Else
        '    ds = BClass.getApplicantID
        '    InputBox("please input the ID of the intervievee you are going to interview", "Identity Number of interviewee", defaultValue)
        '    dd = ds.Tables("Applicant").Rows(1)!Id
        '    If defaultValue <> dd Then
        '        MsgBox("ID not found in the Database")
        '    Else


        '     
        '    End If
        'End If
        popup.Show()

    End Sub

    Private Sub RadButtonElement8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement8.Click
        'Try

        '    Dim ans As Integer
        '    ans = MsgBox("Are you adding a new employee?", vbYesNo + vbQuestion, "Confirm Message")
        '    If ans = MsgBoxResult.No Then

        addapplicant2.picupdate.Hide()
        IDpopup.Show()

        '        'endsystem
        '    Else
        '        Form9.cbomunicipal.Visible = "false"
        '        Form9.cbocity.Visible = "false"
        '        'Form9.cbomunicipal2.Visible = "false"
        '        'Form9.cbocity2.Visible = "false"
        '        Form9.Show()
        '        Form9.picadd.Show()
        '        Form9.picupdate.Hide()

        '    End If
        '    Exit Sub
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Information)
        'End Try
        Me.Close()
    End Sub

    Private Sub RadButtonElement2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement2.Click
        Formaccept.Show()
        Me.Close()
    End Sub

    Private Sub RadButtonElement1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadButtonElement1.Click


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

    Private Sub RadButtonElement9_Click(sender As Object, e As EventArgs) Handles RadButtonElement9.Click
        Allemployees.Show()
        Me.Close()
    End Sub

    Private Sub RadButtonElement10_Click(sender As Object, e As EventArgs) Handles RadButtonElement10.Click
        addapplicant2.PictureBox4.Hide()
        AddApplicant.Show()
        Me.Close()
    End Sub
End Class