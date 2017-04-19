Public Class LoginForm1
    Dim Bclass As New BusinessClass


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ds As New DataSet
        Dim result As String '= "true"
        Try
            result = Bclass.getConnection()
            If result <> "true" Then
                MsgBox("Database Integration failed...." + result)
                ' result = "yes" + "no"
            Else

                If cboposition.SelectedIndex = -1 Then
                    MsgBox("Select Please position")
                    Exit Sub
                End If
                If UsernameTextBox.Text = "" Then
                    MsgBox("enter some Username")
                    Exit Sub
                End If
                If PasswordTextBox.Text = "" Then
                    MsgBox("enter some Password")
                    Exit Sub
                End If
                ds = Bclass.GetLogin(UsernameTextBox.Text.Trim)
                If (ds.Tables("Worker").Rows.Count = 0) Then
                    MsgBox(" User not found")
                    Exit Sub
                End If

                If (cboposition.Text <> ds.Tables("Worker").Rows(0)!Position) Then
                    MsgBox(" position incorrect")
                    Exit Sub
                End If
                If (UsernameTextBox.Text.Trim <> ds.Tables("Worker").Rows(0)!Login_ID) Then
                    MsgBox(" username incorrect")
                    Exit Sub
                End If
                If (PasswordTextBox.Text.Trim <> ds.Tables("Worker").Rows(0)!Password) Then
                    MsgBox(" password incorrect")
                    Exit Sub
                End If
                If cboposition.Text = "Employee" Then
                    IDpopup.Show()
                    Form9.PictureBox1.Visible = False
                Else
                    Form4.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Login details" + " " + ex.Message.ToString)
        End Try


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Try

            Dim ans As Integer
            ans = MsgBox("Are you sure want to cancel logging into the application?", vbYesNo + vbQuestion, "Confirm Message")
            If ans = MsgBoxResult.No Then
                Exit Sub
            Else
                Me.Close()

            End If
            Exit Sub
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboposition.Focus()
        Dim result As String = "true"
        Dim ds As DataSet
        ''Try
        'MsgBox("HERE")

        result = Bclass.getConnection()
        If result <> "true" Then
            MsgBox("Database Integration failed...." + result, MsgBoxStyle.Information)
            Application.Exit()
        Else
            ds = Bclass.Getpositions()
            For i As Integer = 0 To ds.Tables("Worker").Rows.Count - 1
                cboposition.Items.Add(ds.Tables("Worker").Rows(i)!Position)
            Next

        End If
    End Sub

    Private Sub cboposition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboposition.SelectedIndexChanged

    End Sub
End Class
