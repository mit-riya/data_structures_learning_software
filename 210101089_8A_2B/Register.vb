Imports System.Data.Odbc

Public Class Register

    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for when the form loads
    Private Sub Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set error_label text color to red
        error_label.ForeColor = Color.Red
        ' Clear error_label text
        error_label.Text = ""
        ' Set signup_btn as the accept button (activated when Enter key is pressed)
        Me.AcceptButton = signup_btn
        ' Set focus to username_tb textbox
        ' username_tb.Focus = True
    End Sub

    ' Event handler for signup button click
    Private Sub signup_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signup_btn.Click
        ' Check if username, email, and password fields are empty
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

        ' Check if email already exists in the database
        Dim query As String = "SELECT * FROM User WHERE Email = ?"
        Dim dml As New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@email", email_tb.Text)
        Dim dr As OdbcDataReader = dml.ExecuteReader
        If dr.HasRows = True Then
            error_label.Text = "Error: email already registered."
            Return
        End If

        ' Insert new user data into the database
        query = "INSERT INTO User (Username, Email, Password) VALUES (?, ?, ?);"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@username", username_tb.Text)
        dml.Parameters.AddWithValue("@email", email_tb.Text)
        dml.Parameters.AddWithValue("@password", password_tb.Text)
        dml.ExecuteNonQuery()

        ' Show registration success message
        MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Open the login form
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for login link clicked
    Private Sub login_link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles login_link.LinkClicked
        ' Open the login form
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

End Class
