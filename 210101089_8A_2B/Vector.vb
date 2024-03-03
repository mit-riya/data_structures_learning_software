Option Explicit On

Public Class Vector
    ' Global Variables
    Dim n As Integer = 0   'size
    Dim i As Integer = 0   'index
    Dim temp As Integer

    'Insert button function
    Private Sub Insert_elem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert_elem.Click
        'Check whether input enetered is numerical or not
        If Integer.TryParse(insert_textbox.Text, temp) Then
            'Check if number is within range
            If temp <= 1000 And temp >= -1000 Then
                n = n + 1   'update size of vector
                Dim textBox As New TextBox()   'add new element named TextBox_i
                textBox.Name = "TextBox" & (n - 1).ToString()
                textBox.Location = New Point(5 + 50 * (n - 1), 5) 'Adjust location as needed
                textBox.Size = New Size(45, 45) 'Adjust size as needed
                textBox.Text = insert_textbox.Text
                textBox.BackColor = Color.PaleTurquoise
                textBox.ForeColor = Color.Black
                textBox.ReadOnly = True

                Panel1.Controls.Add(textBox)  'Add textbox to panel
                Size_display.Text = n  'update size display
            Else
                insert_textbox.Text = "Range error"
            End If
        Else
            insert_textbox.Text = "Invalid Input"
        End If
    End Sub

    'Access index button 
    Private Sub Access_index_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Access_index.Click
        'Check whether index is an integer and within range
        If Integer.TryParse(access_textbox.Text, i) Then
            If i < n And i >= 0 Then
                ' Find the TextBox with a specific name
                Dim str As String
                str = "TextBox" & access_textbox.Text 'TextBoxi, for index i
                Dim textBoxToAccess As TextBox = DirectCast(Panel1.Controls(str), TextBox)

                ' Access the content of the TextBox
                If textBoxToAccess IsNot Nothing Then
                    access_display.Text = textBoxToAccess.Text
                End If
            Else
                access_display.Text = "Index out of range."
            End If
        Else
            access_textbox.Text = "Invalid input."
        End If
    End Sub

    'Clears all input/output
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        n = 0
        i = 0
        Panel1.Controls.Clear()
        insert_textbox.Clear()
        access_textbox.Clear()
        update_textbox.Clear()
        remove_textbox.Clear()
        new_num_txbx.Clear()
        Size_display.Clear()
        access_display.Clear()
    End Sub

    'Update an element in vector
    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        'Check whether index is an integer and within range
        If Integer.TryParse(update_textbox.Text, i) Then
            If i < n And i >= 0 Then
                'Check whether new number is an integer and within range
                If Integer.TryParse(new_num_txbx.Text, temp) Then
                    If temp <= 1000 And temp >= -1000 Then
                        ' Find the TextBox with a specific name
                        Dim str As String
                        str = "TextBox" & update_textbox.Text 'TextBoxi, for index i
                        Dim textBoxToUpdate As TextBox = DirectCast(Panel1.Controls(str), TextBox)

                        ' Update the content of the TextBox
                        If textBoxToUpdate IsNot Nothing Then
                            textBoxToUpdate.Text = new_num_txbx.Text
                            textBoxToUpdate.ForeColor = Color.Red
                        End If
                    Else
                        new_num_txbx.Text = "Range error"  'new number outside range
                    End If
                Else
                    new_num_txbx.Text = "Invalid Input"   'new number is not integer
                End If
            Else
                update_textbox.Text = "Range error"   'index out of range
            End If
        Else
            update_textbox.Text = "Invalid Input."    'index not integer
        End If
    End Sub

    'Delete element from vector
    Private Sub Remove_elem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_elem.Click
        'Check whether index is an integer and within range
        If Integer.TryParse(remove_textbox.Text, i) Then
            If i < n And i >= 0 Then
                ' Find the TextBox with a specific name
                Dim str As String
                str = "TextBox" & remove_textbox.Text 'TextBoxi, for index i
                Dim textBoxToUpdate As TextBox = DirectCast(Panel1.Controls(str), TextBox)

                ' Remove the TextBox
                If textBoxToUpdate IsNot Nothing Then
                    Panel1.Controls.Remove(textBoxToUpdate)
                End If
            Else
                remove_textbox.Text = "Range error"  'index out of range
            End If
        Else
            remove_textbox.Text = "Invalid Input."   'index not an integer
        End If
    End Sub
End Class