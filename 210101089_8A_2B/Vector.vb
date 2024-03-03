Option Explicit On

Public Class Vector
    ' Global Variables
    Dim n As Integer = 0
    Dim i As Integer = 0
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub Insert_elem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Insert_elem.Click
        n = n + 1
        Dim textBox As New TextBox()
        textBox.Name = "TextBox" & (n - 1).ToString()
        textBox.Location = New Point(5 + 50 * (n - 1), 5) 'Adjust location as needed
        textBox.Size = New Size(45, 45) 'Adjust size as needed
        textBox.Text = insert_textbox.Text
        textBox.BackColor = Color.PaleTurquoise
        textBox.ForeColor = Color.Black
        textBox.ReadOnly = True

        Panel1.Controls.Add(textBox)
        Size_display.Text = n
    End Sub

    Private Sub Access_index_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Access_index.Click
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

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        Panel1.Controls.Clear()
        insert_textbox.Clear()
        access_textbox.Clear()
        update_textbox.Clear()
        remove_textbox.Clear()
        new_num_txbx.Clear()
        Size_display.Clear()
        access_display.Clear()
    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        If Integer.TryParse(update_textbox.Text, i) Then
            If i < n And i >= 0 Then
                Dim str As String
                str = "TextBox" & update_textbox.Text 'TextBoxi, for index i

                ' Find the TextBox with a specific name
                Dim textBoxToUpdate As TextBox = DirectCast(Panel1.Controls(str), TextBox)

                ' Update the content of the TextBox
                If textBoxToUpdate IsNot Nothing Then
                    textBoxToUpdate.Text = new_num_txbx.Text
                    textBoxToUpdate.ForeColor = Color.Red
                End If
            Else
                update_textbox.Text = "Out of range."
            End If
        Else
            update_textbox.Text = "Invalid Input."
        End If
    End Sub

    Private Sub Remove_elem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove_elem.Click
        If Integer.TryParse(remove_textbox.Text, i) Then
            If i < n And i >= 0 Then
                Dim str As String
                str = "TextBox" & remove_textbox.Text 'TextBoxi, for index i

                ' Find the TextBox with a specific name
                Dim textBoxToUpdate As TextBox = DirectCast(Panel1.Controls(str), TextBox)

                ' Update the content of the TextBox
                If textBoxToUpdate IsNot Nothing Then
                    Panel1.Controls.Remove(textBoxToUpdate)
                End If
            Else
                remove_textbox.Text = "Out of range."
            End If
        Else
            remove_textbox.Text = "Invalid Input."
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub
End Class