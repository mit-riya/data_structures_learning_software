Public Class SortMenu

    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for Bubble Sort button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open the BubbleSort form
        Dim f2 As New BubbleSort()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Insertion Sort button click
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Open the InsertionSort form
        Dim f2 As New InsertionSort()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the InsertionSort form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Selection Sort button click
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Open the SelectionSort form
        Dim f2 As New SelectionSort()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the SelectionSort form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Quiz button click
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ' Open the Quiz form
        Dim f2 As New Quiz()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the Quiz form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

    ' Event handler for Home button click
    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
