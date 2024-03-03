Public Class stack
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Dim myStack As New Stack(Of String)
    Dim stackSize = 0
    Dim temp_int As Integer

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        top_el.Text = ""
        error_label.Text = ""
        stackSize = 0
        For i As Integer = 1 To 10
            Dim LabelName As String = "StackBox" & i.ToString()
            Dim TopName As String = "Top" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            Dim TopLabel As Label = CType(tabPage.Controls.Find(TopName, True).FirstOrDefault(), Label)
            myLabel.Text = ""
            'myLabel.BorderStyle = BorderStyle.None
            TopLabel.Text = ""
        Next
    End Sub

    Private Sub StackPush_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackPush.Click
        top_el.Text = ""
        If stackSize = 10 Then
            error_label.Text = "Stack is Full"
        ElseIf String.IsNullOrWhiteSpace(TextBox1.Text) Then
            error_label.Text = "Text Field is Empty"
        ElseIf Integer.TryParse(TextBox1.Text, temp_int) Then
            error_label.Text = ""
            myStack.Push(TextBox1.Text)
            stackSize = stackSize + 1
            update_stack()
        Else
            error_label.Text = "Input is not an integer"
        End If

    End Sub

    Private Sub StackPop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StackPop.Click
        top_el.Text = ""
        If stackSize = 0 Then
            error_label.Text = "Stack is Empty"
        Else
            error_label.Text = ""
            myStack.Pop()
            stackSize = stackSize - 1
            update_stack()
        End If
    End Sub

    Private Sub StackTop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Top_btn.Click
        If stackSize = 0 Then
            top_el.Text = "null"
        Else
            top_el.Text = myStack.Peek()
        End If
    End Sub

    Private Sub update_stack()
        Dim myArray() As String = myStack.ToArray()
        System.Array.Reverse(myArray)
        For i As Integer = 1 To 10
            Dim LabelName As String = "StackBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            If i < stackSize + 1 Then
                myLabel.Text = myArray(i - 1)
                'myLabel.BorderStyle = BorderStyle.FixedSingle
            Else
                myLabel.Text = ""
                'myLabel.BorderStyle = BorderStyle.None
            End If
            Dim topName As String = "Top" & i.ToString()
            Dim topLabel As Label = CType(tabPage.Controls.Find(topName, True).FirstOrDefault(), Label)
            If i = stackSize Then
                topLabel.Text = "← Top"
            Else
                topLabel.Text = ""
            End If
        Next
    End Sub

    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub

End Class
