Imports System.Data.Odbc
Public Class Home
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub
    Private checks() As CheckBox
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username_label.Text = username
        userid_label.Text = "UserID : " & userid


        checks = New CheckBox() {array_check, vector_check, sorting_check, stack_check, queue_check, searching_check, linkedlist_check}
        query = "SELECT * FROM Log WHERE UserID = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@userid", userid)
        dml.Parameters.AddWithValue("@secid", secid)
        dr = dml.ExecuteReader
        Dim progress As Integer = 0
        While (dr.Read())
            checks(dr("SectionID") - 1).Checked = True
            progress += 1
        End While
        progressbar.Minimum = 0
        progressbar.Maximum = checks.Length()
        progressbar.Value = progress
    End Sub

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub array_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles array_gb.Click, array_text.Click
        secid = 1
        Dim f2 As New Array()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub sorting_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sorting_gb.Click, sorting_text.Click
        secid = 3
        Dim f2 As New SortMenu()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub stack_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles stack_gb.Click, stack_text.Click
        secid = 4
        Dim f2 As New stack()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub queue_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles queue_gb.Click, queue_text.Click
        secid = 5
        Dim f2 As New queue()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub searching_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles searching_gb.Click, searching_text.Click
        secid = 6
        Dim f2 As New SearchMenu()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub linkedlist_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles linkedlist_gb.Click, linkedlist_text.Click
        secid = 6
        Dim f2 As New LinkedList()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub vector_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles vector_gb.Click, vector_text.Click
        secid = 2
        Dim f2 As New Vector()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

End Class