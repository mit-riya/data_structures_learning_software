Public Class BinarySearch

    Dim numbers() As Integer
    Dim length As Integer
    Dim elementBoxes As New List(Of TextBox)()
    Dim delayMilliseconds As Integer = 1000
    Dim elementLabels As New List(Of Label)()

    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    Private Sub BinarySearch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Label3.Text = "Binary Search is defined as a searching algorithm used in a sorted array by repeatedly dividing the search interval in half."
        Dim explanation As String = "In this algorithm," & vbCrLf &
            vbCrLf &
            "1. Divide the search space into two halves by finding the middle index mid." & vbCrLf &
            vbCrLf &
            "2. Compare the middle element of the search space with the key." & vbCrLf &
            vbCrLf &
            "3. If the key is found at middle element, the process is terminated." & vbCrLf &
            vbCrLf &
            "4. If the key is not found at middle element, choose which half will be used as the next search space." & vbCrLf &
            "   - If the key is smaller than the middle element, then the left side is used for next search." & vbCrLf &
            "   - If the key is larger than the middle element, then the right side is used for next search." & vbCrLf &
            vbCrLf &
            "4. This process is continued until the key is found or the total search space is exhausted."
        Label5.Text = explanation
    End Sub

    Private Sub btnSort_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        Dim target As Integer = Integer.Parse(TargetTextBox.Text)
        Dim index As Integer
        If length > 14 Then
            index = BinarySearch(numbers, target)
        Else
            index = BinarySearchWithVisualisation(numbers, target)
        End If
        If index <> -1 Then
            MessageBox.Show(String.Format("Element {0} found at index {1}", target, index))
        Else
            MessageBox.Show("Element not found")
        End If
        For i As Integer = 0 To length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            elementTextBox.BackColor = Color.White
        Next
    End Sub

    Private Function BinarySearchWithVisualisation(ByVal arr() As Integer, ByVal target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1

        While left <= right
            Dim mid As Integer = left + (right - left) \ 2
            Dim textBoxName As String = "txtElement" & (mid + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            elementTextBox.BackColor = Color.Green
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
            If arr(mid) = target Then
                elementTextBox.BackColor = Color.Yellow
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                Return mid
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                right = mid - 1
            End If
            UpdateVisualization(arr, left, right)
        End While
        Return -1     ' Element not found
    End Function

    Private Sub UpdateVisualization(ByVal arr() As Integer, ByVal left As Integer, ByVal right As Integer)
        ' Change the background color of text boxes based on whether the index is within the range [left, right]
        For i As Integer = 0 To arr.Length - 1
            If i < left Or i > right Then
                Dim textBoxName As String = "txtElement" & (i + 1).ToString()
                Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
                elementTextBox.BackColor = Color.Gray
            End If
        Next
        ' Optionally add a slight delay for visualization
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds) ' 500 milliseconds delay
    End Sub

    Private Function BinarySearch(ByVal arr() As Integer, ByVal target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1

        While left <= right
            Dim mid As Integer = left + (right - left) \ 2
            If arr(mid) = target Then
                Return mid
            ElseIf arr(mid) < target Then
                left = mid + 1
            Else
                right = mid - 1
            End If
        End While

        Return -1 ' Element not found
    End Function

    Private Sub SortArray(ByVal arr As Integer())
        Dim labelBox As New Label
        Dim labelBoxName As String = "Array is too big to show the visualization. The sorted array is shown below."
        labelBox.Location = New Point(50, 250)
        labelBox.AutoSize = True
        labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
        labelBox.Text = labelBoxName
        Dim arrayBox As New Label
        Dim arrayBoxName As String = String.Join(", ", arr)
        arrayBox.Location = New Point(50, 300)
        arrayBox.AutoSize = True
        arrayBox.Font = New Font(arrayBox.Font.FontFamily, 10, arrayBox.Font.Style)
        arrayBox.Text = arrayBoxName
        elementLabels.Add(labelBox)
        elementLabels.Add(arrayBox)
        Panel1.Controls.Add(labelBox)
        Panel1.Controls.Add(arrayBox)
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds)
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        For Each textBox In elementBoxes
            ' Remove the TextBox from the form's Controls collection
            Panel1.Controls.Remove(textBox)
        Next
        For Each labelBox In elementLabels
            ' Remove the TextBox from the form's Controls collection
            Panel1.Controls.Remove(labelBox)
        Next
        elementBoxes.Clear()
        SortAndDisplayArray()
    End Sub

    Private Sub SortAndDisplayArray()
        Dim inputArray As String() = txtInput.Text.Split(","c)
        ReDim numbers(inputArray.Length - 1)
        Dim flag As Boolean = True
        length = inputArray.Length

        For i As Integer = 0 To inputArray.Length - 1
            If Integer.TryParse(inputArray(i), numbers(i)) Then
            Else
                flag = False
                MessageBox.Show("Invalid Input")
                Exit For
            End If
        Next

        If flag = True Then
            System.Array.Sort(numbers)
            If length > 14 Then
                SortArray(numbers)
            Else
                InitializeElementBoxes()
                DisplayArray(numbers)
            End If
        Else
            txtInput.Clear()
        End If
    End Sub

    Private Sub InitializeElementBoxes()
        ' Create and position TextBoxes for displaying array elements
        For i As Integer = 0 To (length - 1)
            Dim textBox As New TextBox()
            textBox.Name = "txtElement" & (i + 1).ToString()
            textBox.Size = New Size(60, 40)
            textBox.Location = New Point(50 + i * 70, 250)
            textBox.TextAlign = HorizontalAlignment.Center
            elementBoxes.Add(textBox)
            Panel1.Controls.Add(textBox)
        Next

    End Sub

    Private Sub DisplayArray(ByVal arr As Integer())
        ' Display array elements in separate TextBox controls
        For i As Integer = 0 To arr.Length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            If elementTextBox IsNot Nothing Then
                elementTextBox.Text = arr(i)
            End If
        Next
    End Sub

    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the BubbleSort form
        f2.Show()
        Me.Hide()
    End Sub
End Class
