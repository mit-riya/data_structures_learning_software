Imports System.Threading

Public Class LinkedList
    ' Global Variables
    Dim n As Integer = 0  'size of linked list
    Dim i As Integer = 0  'index
    Dim temp As Integer

    'wait function used in searching and traversing operations
    Private Sub wait(ByVal seconds As Integer)
        For i As Integer = 0 To seconds * 100
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub

    'insert button
    Private Sub insert_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insert_btn.Click
        'Check if input is integer and within range
        If Integer.TryParse(insert_tb.Text, temp) Then
            If temp <= 1000 And temp >= -1000 Then
                'remove null pointer
                Dim textBoxToUpdate As TextBox = DirectCast(LL_panel.Controls("Null_tb"), TextBox)
                If textBoxToUpdate IsNot Nothing Then
                    LL_panel.Controls.Remove(textBoxToUpdate)
                End If
                n = n + 1  'increment the size

                'create new element at end of list
                Dim textBox As New TextBox()
                textBox.Name = "TextBox" & (n - 1).ToString() 'TextBox0, TextBox1...
                textBox.Location = New Point(5 + 50 * (n - 1), 5) 'Adjust location as needed
                textBox.Size = New Size(45, 45) 'Adjust size as needed
                textBox.Text = insert_tb.Text
                textBox.BackColor = Color.PaleTurquoise
                textBox.ForeColor = Color.Black
                textBox.ReadOnly = True

                LL_panel.Controls.Add(textBox)

                'add head pointer if its the beginning of linked list
                If n = 1 Then
                    Dim l1 As New Label()
                    l1.Name = "head"
                    l1.Location = New Point(5, 35) 'Adjust location as needed
                    l1.Size = New Size(45, 45) 'Adjust size as needed
                    l1.Text = "Head"
                    l1.ForeColor = Color.Black

                    LL_panel.Controls.Add(l1)
                End If

                'add null pointer at the end
                Dim dummy_tb As New TextBox()
                dummy_tb.Name = "Null_tb"
                dummy_tb.Location = New Point(5 + 50 * (n), 5) 'Adjust location as needed
                dummy_tb.Size = New Size(45, 45) 'Adjust size as needed
                dummy_tb.Text = "NULL"
                dummy_tb.BackColor = Color.PaleTurquoise
                dummy_tb.ForeColor = Color.Black
                dummy_tb.ReadOnly = True
                LL_panel.Controls.Add(dummy_tb)
            Else
                insert_tb.Text = "Range error"
            End If
        Else
            insert_tb.Text = "Invalid Input"
        End If
    End Sub

    'update button
    Private Sub update_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update_btn.Click
        'Check if input is integer and within range
        If Integer.TryParse(update_tb.Text, temp) Then
            If temp <= 1000 And temp >= -1000 Then
                'check if new input is integer and within range
                If Integer.TryParse(new_num_tb.Text, temp) Then
                    If temp <= 1000 And temp >= -1000 Then
                        '-----------------------------------------------------------
                        Dim flag As Integer = 0 'indicates 1=found/0=not found
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
                        '------------------------------------------------------------------------
                    Else
                        new_num_tb.Text = "Range error"
                    End If
                Else
                    new_num_tb.Text = "Invalid Input"
                End If
            Else
                update_tb.Text = "Range error"
            End If
        Else
            update_tb.Text = "Invalid Input"
        End If
    End Sub

    'delete button
    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        'Check if input is integer and within range
        If Integer.TryParse(delete_tb.Text, temp) Then
            If temp <= 1000 And temp >= -1000 Then
                '---------------------------------------------
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
                '---------------------------------------------
            Else
                delete_tb.Text = "Range error"
            End If
        Else
            delete_tb.Text = "Invalid Input"
        End If
    End Sub

    'search button
    Private Sub search_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_btn.Click
        'Check if input is integer and within range
        If Integer.TryParse(search_tb.Text, temp) Then
            If temp <= 1000 And temp >= -1000 Then
                '---------------------------------------------
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
                '---------------------------------------------
            Else
                search_tb.Text = "Range error"
            End If
        Else
            search_tb.Text = "Invalid Input"
        End If
    End Sub

    'reset button
    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reset.Click
        n = 0
        i = 0
        LL_panel.Controls.Clear()
        insert_tb.Clear()
        search_tb.Clear()
        update_tb.Clear()
        delete_tb.Clear()
        new_num_tb.Clear()
    End Sub
    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        ' Create a new instance of the Home form
        Dim f2 As New Quiz()

        ' Add a handler to detect when the Home form is closed
        AddHandler f2.FormClosed, AddressOf FormClosedHandler

        ' Show the Home form
        f2.Show()

        ' Hide the current form (stack form)
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a new instance of the Home form
        Dim f2 As New Home()

        ' Add a handler to detect when the Home form is closed
        AddHandler f2.FormClosed, AddressOf FormClosedHandler

        ' Show the Home form
        f2.Show()

        ' Hide the current form (stack form)
        Me.Hide()
    End Sub
End Class