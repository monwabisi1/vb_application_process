
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim BClass As New BusinessClass
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles picclear.Click
        txttotal.Clear()
        cbointerview.Text = ""
        txtsurname.Clear()
        cboscrum.Text = ""
        cbofit.Text = ""
        cbopresentation.Text = ""
        txtpercent.Text = ""
        txtshortlist.Clear()
        txtname.Clear()
        txtsurname.Clear()
        txtintervieweeid.Text = ""
        popup.Show()

    End Sub

    Private Sub piccalculate_Click(sender As Object, e As EventArgs) Handles piccalculate.Click
        txttotal.Text = CInt(cbofit.Text) + CInt(cbointerview.Text) + CInt(txtshortlist.Text) + CInt(cbopresentation.Text) + CInt(cboscrum.Text)
        txtpercent.Text = CInt(txttotal.Text) / 50 * 100



        If cbointerview.Text = "" Then
            MsgBox("select interview points")
            cbointerview.Focus()
        End If
        If cboscrum.SelectedIndex = -1 Then
            MsgBox("Please select scrum points")
            cboscrum.Focus()
        End If

        If cbofit.SelectedIndex = -1 Then
            MsgBox("Please select fit points")
            cbofit.Focus()
        End If


        If cbopresentation.SelectedIndex = -1 Then
            MsgBox("Please select points")
            cbopresentation.Focus()
        End If


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboscrum.Focus()

    End Sub

    Private Sub picsave_Click(sender As Object, e As EventArgs) Handles picsave.Click
        txttotal.Text = CInt(cbofit.Text) + CInt(cbointerview.Text) + CInt(txtshortlist.Text) + CInt(cbopresentation.Text) + CInt(cboscrum.Text)
        txtpercent.Text = CInt(txttotal.Text) / 50 * 100

        Dim ds As New DataSet
        Dim ids As Integer
        Dim res As String
        Dim result As String
        result = BClass.getConnection()
        Try
            If result = "true" Then
                If cbointerview.Text = "" Then
                    MsgBox("select interview points")
                    cbointerview.Focus()
                    Exit Sub
                End If
                If cboscrum.SelectedIndex = -1 Then
                    MsgBox("Please select scrum points")
                    cboscrum.Focus()
                    Exit Sub
                End If

                If cbofit.SelectedIndex = -1 Then
                    MsgBox("Please select fit points")
                    cbofit.Focus()
                    Exit Sub
                End If
                res = BClass.AddInterview(txtinterviewer.Text, txtintervieweeid.Text, txtsurname.Text, txtname.Text, CInt(cbofit.SelectedItem), CInt(cboscrum.Text), CInt(cbointerview.Text), CInt(cbopresentation.Text), CInt(txtshortlist.Text), CInt(txttotal.Text), CInt(txtpercent.Text))
                If res = "true" Then
                    MsgBox("Applied Succesfully")
                Else
                    MsgBox("Not added" + res)
                End If
            Else
                MsgBox("connection error" + result)
            End If
        Catch ex As Exception
            ex.Message.ToString()
        End Try
    End Sub
End Class