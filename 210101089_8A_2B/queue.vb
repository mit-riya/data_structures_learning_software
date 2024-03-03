Public Class queue

    Dim myQueue As New Queue(Of String)
    Dim queueSize = 0

    Private Sub queue_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        queueSize = 0
        error_label.Text = ""
        For i As Integer = 1 To 10
            Dim LabelName As String = "QueueBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            myLabel.Text = ""
        Next
    End Sub

    Private Sub enqueue_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If queueSize = 10 Then
            error_label.Text = "Queue is full"
        ElseIf String.IsNullOrWhiteSpace(TextBox1.Text) Then
            error_label.Text = "Text Field is Empty"
        Else
            error_label.Text = ""
            myQueue.Enqueue(TextBox1.Text)
            queueSize = queueSize + 1
            update_queue()
        End If
    End Sub

    Private Sub dequeue_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        Dim myArray() As String = myQueue.ToArray()
        For i As Integer = 1 To 10
            Dim LabelName As String = "QueueBox" & i.ToString()
            Dim tabPage As TabPage = TabControl1.TabPages(1)
            Dim myLabel As Label = CType(tabPage.Controls.Find(LabelName, True).FirstOrDefault(), Label)
            If i < queueSize + 1 Then
                myLabel.Text = myArray(i - 1)
                'myLabel.BorderStyle = BorderStyle.FixedSingle
            Else
                myLabel.Text = ""
                'myLabel.BorderStyle = BorderStyle.None
            End If
        Next
    End Sub

    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f2 As New Quiz()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub
End Class