Imports System.Data.Odbc

Public Class Home

    ' Event handler for form closed
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Array to hold CheckBox controls
    Private checks() As CheckBox

    ' Event handler for form load
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Display username and user ID
        username_label.Text = username
        userid_label.Text = "UserID : " & userid

        ' Array of CheckBoxes
        checks = New CheckBox() {array_check, vector_check, sorting_check, stack_check, queue_check, searching_check, linkedlist_check}

        ' SQL query to select user progress from database
        query = "SELECT * FROM Log WHERE UserID = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@userid", userid)
        dml.Parameters.AddWithValue("@secid", secid)
        dr = dml.ExecuteReader

        ' Initialize progress counter
        Dim progress As Integer = 0

        ' Iterate through the result set
        While (dr.Read())
            ' Check corresponding CheckBox based on user progress
            checks(dr("SectionID") - 1).Checked = True
            progress += 1
        End While

        ' Set progress bar properties
        progressbar.Minimum = 0
        progressbar.Maximum = checks.Length()
        progressbar.Value = progress
    End Sub

    ' Event handler for logout button click
    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        ' Navigate to login form
        Dim f2 As New Login()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for array group box click
    Private Sub array_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles array_gb.Click, array_text.Click
        secid = 1
        ' Navigate to array form
        Dim f2 As New Array()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for sorting group box click
    Private Sub sorting_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sorting_gb.Click, sorting_text.Click
        secid = 3
        ' Navigate to sorting menu form
        Dim f2 As New SortMenu()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for stack group box click
    Private Sub stack_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles stack_gb.Click, stack_text.Click
        secid = 4
        ' Navigate to stack form
        Dim f2 As New stack()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for queue group box click
    Private Sub queue_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles queue_gb.Click, queue_text.Click
        secid = 5
        ' Navigate to queue form
        Dim f2 As New queue()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for searching group box click
    Private Sub searching_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles searching_gb.Click, searching_text.Click
        secid = 6
        ' Navigate to searching menu form
        Dim f2 As New SearchMenu()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for linked list group box click
    Private Sub linkedlist_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles linkedlist_gb.Click, linkedlist_text.Click
        secid = 6
        ' Navigate to linked list form
        Dim f2 As New LinkedList()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for vector group box click
    Private Sub vector_gb_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles vector_gb.Click, vector_text.Click
        secid = 2
        ' Navigate to vector form
        Dim f2 As New Vector()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

End Class
