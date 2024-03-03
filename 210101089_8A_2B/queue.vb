Public Class queue
    ' Declare a queue to store string elements
    Dim myQueue As New Queue(Of String)
    ' Variable to store the size of the queue
    Dim queueSize = 0
    Dim temp_int As Integer

    Private Sub queue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Initialize queue size and clear error label
        queueSize = 0
        error_label.Text = ""
        ' Reset all label text in the queue display area
        For i As Integer = 1 To 10
            Dim LabelName As String = "QueueBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            myLabel.Text = ""
        Next
    End Sub

    Private Sub enqueue_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enqueue_btn.Click
        ' Enqueue an element to the queue
        If queueSize = 10 Then
            error_label.Text = "Queue is full"
        ElseIf String.IsNullOrWhiteSpace(TextBox1.Text) Then
            error_label.Text = "Text Field is Empty"
        ElseIf Integer.TryParse(TextBox1.Text, temp_int) Then
            error_label.Text = ""
            myQueue.Enqueue(TextBox1.Text)
            queueSize = queueSize + 1
            update_queue()
        Else
            error_label.Text = "Input is not an integer"
        End If
    End Sub

    Private Sub dequeue_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dequeue_btn.Click
        ' Dequeue an element from the queue
        If queueSize = 0 Then
            error_label.Text = "Queue is empty"
        Else
            error_label.Text = ""
            myQueue.Dequeue()
            queueSize = queueSize - 1
            update_queue()
        End If
    End Sub

    Private Sub update_queue()
        ' Update the queue display
        Dim myArray() As String = myQueue.ToArray()
        For i As Integer = 1 To 10
            Dim LabelName As String = "QueueBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            If i < queueSize + 1 Then
                ' Display elements in labels up to the current queue size
                myLabel.Text = myArray(i - 1)
            Else
                ' Clear labels beyond the current queue size
                myLabel.Text = ""
            End If
        Next
    End Sub

    ' Event handler for closing the form
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for the "Home" button click
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ' Create a new instance of the Home form
        Dim f2 As New Home()

        ' Add a handler to detect when the Home form is closed
        AddHandler f2.FormClosed, AddressOf FormClosedHandler

        ' Show the Home form
        f2.Show()

        ' Hide the current form (stack form)
        Me.Hide()
    End Sub

    ' Event handler for the "Quiz" button click
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' Create a new instance of the Quiz form
        Dim f2 As New Quiz()

        ' Add a handler to detect when the Quiz form is closed
        AddHandler f2.FormClosed, AddressOf FormClosedHandler

        ' Show the Quiz form
        f2.Show()

        ' Hide the current form (stack form)
        Me.Hide()
    End Sub



End Class
