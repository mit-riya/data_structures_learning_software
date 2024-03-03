Imports System.Data.Odbc
Public Class Register
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        error_label.ForeColor = Color.Red
        error_label.Text = ""
        Me.AcceptButton = signup_btn
        'username_tb.Focus = True
    End Sub

    Private Sub signup_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signup_btn.Click

        If String.IsNullOrWhiteSpace(username_tb.Text) Then
            error_label.Text = "Error: enter a valid username."
            Return
        ElseIf String.IsNullOrWhiteSpace(email_tb.Text) Then
            error_label.Text = "Error: enter a valid email."
            Return
        ElseIf String.IsNullOrEmpty(password_tb.Text) Then
            error_label.Text = "Error: enter a valid password."
            Return
        End If


        query = "SELECT * FROM User where Email = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@email", email_tb.Text)
        dr = dml.ExecuteReader
        If dr.HasRows = True Then
            error_label.Text = "Error : email already registered."
            Return
        End If


        query = "INSERT INTO User (Username, Email, Password) values(?, ?, ?);"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@username", username_tb.Text)
        dml.Parameters.AddWithValue("@email", email_tb.Text)
        dml.Parameters.AddWithValue("@password", password_tb.Text)
        dml.ExecuteNonQuery()

        MessageBox.Show("Registration successful..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub login_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles login_link.LinkClicked
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub
End Class