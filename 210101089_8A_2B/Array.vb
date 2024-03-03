Public Class Array
    ' Global Variables
    Dim n As Integer = 0 ' Variable to store the total number of TextBoxes
    Dim i As Integer = 0 ' Variable to store the index for accessing/updating TextBoxes

    ' Event handler to close the current form when another form is closed
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        Me.Close()
    End Sub

    ' Event handler for the Insert button click
    Private Sub Insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert_btn.Click
        ' Increment the count of TextBoxes
        n = n + 1

        ' Create a new TextBox dynamically
        Dim textBox As New TextBox()
        textBox.Name = "TextBox" & (n - 1).ToString() ' Set the Name property for identification
        textBox.Location = New Point(5 + 50 * (n - 1), 5) ' Adjust the location of the TextBox
        textBox.Size = New Size(45, 45) ' Set the size of the TextBox
        textBox.Text = insert_textbox.Text ' Set the text of the TextBox
        textBox.BackColor = Color.PaleTurquoise ' Set the background color of the TextBox
        textBox.ForeColor = Color.Black ' Set the text color of the TextBox
        textBox.ReadOnly = True ' Set the TextBox as read-only

        ' Add the TextBox to the Panel control
        show_panel.Controls.Add(textBox)

        ' Update the display with the current count of TextBoxes
        Size_display.Text = n
    End Sub

    ' Event handler for the Access button click
    Private Sub Access_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Access_btn.Click
        ' Validate the input index
        If Integer.TryParse(access_textbox.Text, i) Then
            If i < n And i >= 0 Then
                ' Construct the name of the TextBox based on the index
                Dim str As String
                str = "TextBox" & access_textbox.Text

                ' Find the TextBox with the specified name
                Dim textBoxToAccess As TextBox = DirectCast(show_panel.Controls(str), TextBox)

                ' Access the content of the TextBox if found
                If textBoxToAccess IsNot Nothing Then
                    access_display.Text = textBoxToAccess.Text
                End If
            Else
                access_display.Text = "Index out of range." ' Display error message for out of range index
            End If
        Else
            access_textbox.Text = "Invalid input." ' Display error message for invalid input
        End If
    End Sub

    ' Event handler for the Update button click
    Private Sub Update_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Update_btn.Click
        ' Validate the input index
        If Integer.TryParse(update_textbox.Text, i) Then
            If i < n And i >= 0 Then
                ' Construct the name of the TextBox based on the index
                Dim str As String
                str = "TextBox" & update_textbox.Text

                ' Find the TextBox with the specified name
                Dim textBoxToUpdate As TextBox = DirectCast(show_panel.Controls(str), TextBox)

                ' Update the content of the TextBox if found
                If textBoxToUpdate IsNot Nothing Then
                    textBoxToUpdate.Text = new_num_txbx.Text
                    textBoxToUpdate.ForeColor = Color.Red ' Change the text color for indication
                End If
            Else
                update_textbox.Text = "Out of range." ' Display error message for out of range index
            End If
        Else
            update_textbox.Text = "Invalid Input." ' Display error message for invalid input
        End If
    End Sub

    ' Event handler for the Sum button click
    Private Sub Sum_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Sum_btn.Click
        Dim sum As Integer = 0

        ' Loop through all TextBoxes and sum their values
        For i As Integer = 0 To n - 1
            Dim str As String
            str = "TextBox" & i.ToString() ' Construct the name of the TextBox based on the index
            Dim textBox As TextBox = DirectCast(show_panel.Controls(str), TextBox)

            If textBox IsNot Nothing Then
                Dim x As Integer
                If Integer.TryParse(textBox.Text, x) Then
                    sum = sum + x
                End If
            End If
        Next

        ' Display the sum in the designated TextBox
        sum_textbox.Text = sum.ToString()
    End Sub

    ' Event handler for the Reset button click
    Private Sub Reset_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reset_btn.Click
        ' Clear all TextBoxes and reset controls
        show_panel.Controls.Clear()
        insert_textbox.Clear()
        access_textbox.Clear()
        update_textbox.Clear()
        sum_textbox.Clear()
        new_num_txbx.Clear()
        Size_display.Clear()
        access_display.Clear()
    End Sub

    ' Event handler for the Quiz button click
    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        ' Show the Quiz form
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for the Home button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Show the Home form
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub
End Class
