Public Class SearchMenu

    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for login button click
    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        ' Open the LinearSearch form
        Dim f2 As New LinearSearch()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the LinearSearch form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Button1 (Binary Search) click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open the BinarySearch form
        Dim f2 As New BinarySearch()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BinarySearch form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Button2 (Quiz) click
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Open the Quiz form
        Dim f2 As New Quiz()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the Quiz form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Button3 (Home) click
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Open the Home form
        Dim f2 As New Home()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the Home form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

End Class
