Imports System.Data.Odbc
Public Class Login

    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        If String.IsNullOrWhiteSpace(username_tb.Text) Then
            error_label.Text = "Warning: username must be some non-space string"
            Return
        ElseIf String.IsNullOrWhiteSpace(password_tb.Text) Then
            error_label.Text = "Warning: password must be some non-space string"
            Return
        End If
        query = "SELECT * FROM User WHERE Username = ? AND Password = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@username", username_tb.Text)
        dml.Parameters.AddWithValue("@password", password_tb.Text)
        dr = dml.ExecuteReader
        If dr.HasRows = True Then
            dr.Read()
            username = dr("UserName").ToString()
            userid = dr("UserID")
            ' MessageBox.Show("Logged in successfully", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            ' Close the current login form
            Dim f2 As New Home()
            AddHandler f2.FormClosed, AddressOf FormClosedHandler
            ' Show the BubbleSort form
            f2.Show()
            Me.Hide()
        Else
            error_label.Text = "Warning: wrong username or password"
            ' MessageBox.Show("Log in failed", "Failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        odbc_connection()
        error_label.ForeColor = Color.Red
        error_label.Text = ""
        Me.AcceptButton = login_btn
        'username_tb.Focus = True
    End Sub

    Private Sub ShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpass_cb.CheckedChanged
        If showpass_cb.Checked() Then
            password_tb.UseSystemPasswordChar = False
        Else
            password_tb.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub register_ll_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles register_ll.LinkClicked
        Dim f2 As New Register()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

End Class
