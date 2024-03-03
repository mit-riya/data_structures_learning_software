Imports System.Threading

Public Class LinkedList
    ' Global Variables
    Dim n As Integer = 0 'size of linked list
    Dim i As Integer = 0

    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    Private Sub insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert_btn.Click
        Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls("Null_tb"), TextBox)
        If textBoxToUpdate IsNot Nothing Then
            LL_panel.Controls.Remove(textBoxToUpdate)
        End If
        n = n + 1

        Dim textBox As New TextBox()
        textBox.Name = "TextBox" & (n - 1).ToString() 'TextBox0, TextBox1...
        textBox.Location = New Point(5 + 50 * (n - 1), 5) 'Adjust location as needed
        textBox.Size = New Size(45, 45) 'Adjust size as needed
        textBox.Text = insert_tb.Text
        textBox.BackColor = Color.PaleTurquoise
        textBox.ForeColor = Color.Black
        textBox.ReadOnly = True

        LL_panel.Controls.Add(textBox)

        If n = 1 Then
            Dim l1 As New Label()
            l1.Name = "head"
            l1.Location = New Point(5, 35) 'Adjust location as needed
            l1.Size = New Size(45, 45) 'Adjust size as needed
            l1.Text = "Head"
            l1.ForeColor = Color.Black

            LL_panel.Controls.Add(l1)
        End If

        Dim dummy_tb As New TextBox()
        dummy_tb.Name = "Null_tb"
        dummy_tb.Location = New Point(5 + 50 * (n), 5) 'Adjust location as needed
        dummy_tb.Size = New Size(45, 45) 'Adjust size as needed
        dummy_tb.Text = "NULL"
        dummy_tb.BackColor = Color.PaleTurquoise
        dummy_tb.ForeColor = Color.Black
        dummy_tb.ReadOnly = True
        LL_panel.Controls.Add(dummy_tb)
    End Sub

    Private Sub update_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_btn.Click
        Dim flag As Integer = 0
        For i As Integer = 0 To n - 1
            Dim str As String
            str = "TextBox" & i.ToString() 'TextBoxi, for index i

            ' Find the TextBox with a specific name
            Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls(str), TextBox)
            If textBoxToUpdate IsNot Nothing Then
                textBoxToUpdate.BackColor = Color.Red

                wait(1)    'sleep for 1 sec
                textBoxToUpdate.BackColor = Color.PaleTurquoise

                If textBoxToUpdate.Text = update_tb.Text Then
                    textBoxToUpdate.BackColor = Color.Green
                    textBoxToUpdate.Text = new_num_tb.Text
                    flag = 1
                    Exit For
                End If
            End If
        Next

        If flag = 0 Then   'If not found
            update_tb.Text = "Not found"
        End If
    End Sub

    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        Dim flag As Integer = 0
        For i As Integer = 0 To n - 1
            Dim str As String
            str = "TextBox" & i.ToString() 'TextBoxi, for index i

            ' Find the TextBox with a specific name
            Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls(str), TextBox)
            If textBoxToUpdate IsNot Nothing Then
                textBoxToUpdate.BackColor = Color.Red

                wait(1)    'sleep for 1 sec
                textBoxToUpdate.BackColor = Color.PaleTurquoise


                If textBoxToUpdate.Text = delete_tb.Text Then
                    LL_panel.Controls.Remove(textBoxToUpdate)
                    flag = 1
                    Exit For
                End If
            End If
        Next

        If flag = 0 Then   'If not found
            delete_tb.Text = "Not found"
        End If
    End Sub

    Private Sub search_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_btn.Click
        For i As Integer = 0 To n - 1
            Dim str As String
            str = "TextBox" & i.ToString() 'TextBoxi, for index i

            ' Find the TextBox with a specific name
            Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls(str), TextBox)
            If textBoxToUpdate IsNot Nothing Then
                textBoxToUpdate.BackColor = Color.Red

                wait(1)    'sleep for 1 sec
                textBoxToUpdate.BackColor = Color.PaleTurquoise

                If textBoxToUpdate.Text = search_tb.Text Then
                    textBoxToUpdate.BackColor = Color.Green
                    search_tb.Text = "Found"
                    Exit For
                End If
            End If
        Next

        If search_tb.Text <> "Found" Then   'If not found
            search_tb.Text = "Not found"
        End If
    End Sub

    Private Sub reverse_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To n - 1
            Dim str As String
            str = "TextBox" & i.ToString() 'TextBoxi, for index i

            ' Find the TextBox with a specific name
            Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls(str), TextBox)
            If textBoxToUpdate IsNot Nothing Then
                textBoxToUpdate.BackColor = Color.Red

                wait(1)    'sleep for 1 sec
                textBoxToUpdate.BackColor = Color.PaleTurquoise

                If textBoxToUpdate.Text = search_tb.Text Then
                    textBoxToUpdate.BackColor = Color.Green
                    search_tb.Text = "Found"
                    Exit For
                End If
            End If
        Next

        If search_tb.Text <> "Found" Then   'If not found
            search_tb.Text = "Not found"
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        LL_panel.Controls.Clear()
        insert_tb.Clear()
        search_tb.Clear()
        update_tb.Clear()
        delete_tb.Clear()
        new_num_tb.Clear()
    End Sub

    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub
End Class