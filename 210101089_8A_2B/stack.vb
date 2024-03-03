Public Class stack

    ' Declare a stack of strings
    Dim myStack As New Stack(Of String)

    ' Variable to track the size of the stack
    Dim stackSize As Integer = 0

    ' Temporary variable for parsing integers
    Dim temp_int As Integer

    ' Form load event handler
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize labels and error message
        top_el.Text = ""
        error_label.Text = ""
        stackSize = 0

        ' Reset labels for stack elements
        For i As Integer = 1 To 10
            Dim LabelName As String = "StackBox" & i.ToString()
            Dim TopName As String = "Top" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            Dim TopLabel As Label = CType(tabPage.Controls.Find(TopName, True).FirstOrDefault(), Label)
            myLabel.Text = ""
            TopLabel.Text = ""
        Next
    End Sub

    ' Event handler for the "Push" button
    Private Sub StackPush_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackPush.Click
        ' Clear the top element display and error message
        top_el.Text = ""
        error_label.Text = ""

        ' Check if the stack is full
        If stackSize = 10 Then
            error_label.Text = "Stack is Full"
        ElseIf String.IsNullOrWhiteSpace(TextBox1.Text) Then
            ' Check if the text field is empty
            error_label.Text = "Text Field is Empty"
        ElseIf Integer.TryParse(TextBox1.Text, temp_int) Then
            ' Check if the input is an integer
            error_label.Text = ""
            ' Push the input onto the stack
            myStack.Push(TextBox1.Text)
            stackSize = stackSize + 1
            ' Update the visual representation of the stack
            update_stack()
        Else
            error_label.Text = "Input is not an integer"
        End If
    End Sub

    ' Event handler for the "Pop" button
    Private Sub StackPop_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackPop.Click
        ' Clear the top element display and error message
        top_el.Text = ""
        error_label.Text = ""

        ' Check if the stack is empty
        If stackSize = 0 Then
            error_label.Text = "Stack is Empty"
        Else
            error_label.Text = ""
            ' Pop the top element from the stack
            myStack.Pop()
            stackSize = stackSize - 1
            ' Update the visual representation of the stack
            update_stack()
        End If
    End Sub

    ' Event handler for the "Top" button
    Private Sub StackTop_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top_btn.Click
        ' Display the top element of the stack
        If stackSize = 0 Then
            top_el.Text = "null"
        Else
            top_el.Text = myStack.Peek()
        End If
    End Sub

    ' Update the visual representation of the stack
    Private Sub update_stack()
        ' Convert the stack to an array
        Dim myArray() As String = myStack.ToArray()
        ' Reverse the array to maintain the order
        System.Array.Reverse(myArray)

        ' Update the labels for stack elements
        For i As Integer = 1 To 10
            Dim LabelName As String = "StackBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            If i < stackSize + 1 Then
                ' Display the stack element
                myLabel.Text = myArray(i - 1)
            Else
                ' Clear the label if there are no elements
                myLabel.Text = ""
            End If

            ' Display the "Top" label for the top element
            Dim topName As String = "Top" & i.ToString()
            Dim topLabel As Label = CType(tabPage.Controls.Find(topName, True).FirstOrDefault(), Label)
            If i = stackSize Then
                topLabel.Text = "← Top"
            Else
                topLabel.Text = ""
            End If
        Next
    End Sub

    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for the "Home" button
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Open the Home form
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub

    ' Event handler for the "Quiz" button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Open the Quiz form
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub
End Class
