Imports System.Data.Odbc

Public Class Login

    ' Event handler to close the current form when another form is closed
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub

    ' Event handler for the login button click
    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        ' Validate username and password fields
        If String.IsNullOrWhiteSpace(username_tb.Text) Then
            error_label.Text = "Warning: username must be some non-space string"
            Return
        ElseIf String.IsNullOrWhiteSpace(password_tb.Text) Then
            error_label.Text = "Warning: password must be some non-space string"
            Return
        End If

        ' Query to check user credentials
        Dim query As String = "SELECT * FROM User WHERE Username = ? AND Password = ?"
        Dim dml As New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@username", username_tb.Text)
        dml.Parameters.AddWithValue("@password", password_tb.Text)
        Dim dr As OdbcDataReader = dml.ExecuteReader

        ' If user exists, log them in and show the Home form
        If dr.HasRows = True Then
            dr.Read()
            username = dr("UserName").ToString()
            userid = dr("UserID")

            ' Close the current login form and show the Home form
            Dim f2 As New Home()
            AddHandler f2.FormClosed, AddressOf FormClosedHandler
            f2.Show()
            Me.Hide()
        Else
            ' Display error message for invalid credentials
            error_label.Text = "Warning: wrong username or password"
        End If
    End Sub

    ' Event handler for the form load
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize ODBC connection
        odbc_connection()

        ' Set initial error label text and color
        error_label.ForeColor = Color.Red
        error_label.Text = ""

        ' Set login button as the default button for the form
        Me.AcceptButton = login_btn
    End Sub

    ' Event handler for the show password checkbox change
    Private Sub ShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpass_cb.CheckedChanged
        ' Show/hide password based on checkbox state
        password_tb.UseSystemPasswordChar = Not showpass_cb.Checked()
    End Sub

    ' Event handler for the register link click
    Private Sub register_ll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles register_ll.LinkClicked
        ' Show the Register form
        Dim f2 As New Register()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

End Class
