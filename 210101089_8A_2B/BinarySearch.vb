Public Class BinarySearch

    ' Declare variables and lists for managing the binary search operation
    Dim numbers() As Integer ' Array to store input numbers
    Dim length As Integer ' Length of the input array
    Dim delayMilliseconds As Integer = 1000 ' Delay time for visualization
    Dim elementBoxes As New List(Of TextBox)() ' List to store TextBox controls for displaying array elements
    Dim elementLabels As New List(Of Label)() ' List to store Label controls for displaying messages

    ' Event handler for the form closing event
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for the form load event
    Private Sub BinarySearch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Display an explanation of the binary search algorithm
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

    ' Event handler for the 'Search' button click event
    Private Sub btnSort_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ' Retrieve the target value to search for
        Dim target As Integer = Integer.Parse(TargetTextBox.Text)
        Dim index As Integer
        ' Perform binary search with or without visualization based on the size of the input array
        If length > 14 Then
            index = BinarySearch(numbers, target)
        Else
            index = BinarySearchWithVisualisation(numbers, target)
        End If
        ' Display the search result
        If index <> -1 Then
            MessageBox.Show(String.Format("Element {0} found at index {1}", target, index))
        Else
            MessageBox.Show("Element not found")
        End If
        ' Reset the background color of TextBox controls
        For i As Integer = 0 To length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            elementTextBox.BackColor = Color.White
        Next
    End Sub

    ' Method to perform binary search with visualization
    Private Function BinarySearchWithVisualisation(ByVal arr() As Integer, ByVal target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1

        ' Perform binary search iteratively
        While left <= right
            Dim mid As Integer = left + (right - left) \ 2
            Dim textBoxName As String = "txtElement" & (mid + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            ' Highlight the middle element
            elementTextBox.BackColor = Color.Green
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
            ' Compare the middle element with the target
            If arr(mid) = target Then
                ' If target found, highlight and return the index
                elementTextBox.BackColor = Color.Yellow
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                Return mid
            ElseIf arr(mid) < target Then
                ' If target is greater, search in the right half
                left = mid + 1
            Else
                ' If target is smaller, search in the left half
                right = mid - 1
            End If
            ' Update the visualization to reflect the new search space
            UpdateVisualization(arr, left, right)
        End While
        Return -1 ' Element not found
    End Function

    ' Method to update the visualization of the search space
    Private Sub UpdateVisualization(ByVal arr() As Integer, ByVal left As Integer, ByVal right As Integer)
        ' Change the background color of TextBox controls based on the current search space
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

    ' Method to perform binary search without visualization
    Private Function BinarySearch(ByVal arr() As Integer, ByVal target As Integer) As Integer
        Dim left As Integer = 0
        Dim right As Integer = arr.Length - 1

        ' Perform binary search iteratively
        While left <= right
            Dim mid As Integer = left + (right - left) \ 2
            If arr(mid) = target Then
                ' If target found, return the index
                Return mid
            ElseIf arr(mid) < target Then
                ' If target is greater, search in the right half
                left = mid + 1
            Else
                ' If target is smaller, search in the left half
                right = mid - 1
            End If
        End While
        Return -1 ' Element not found
    End Function

    ' Method to display the sorted array when it's too large for visualization
    Private Sub SortArray(ByVal arr As Integer())
        ' Create a label to inform the user that the array is too big to show visualization
        Dim labelBox As New Label
        Dim labelBoxName As String = "Array is too big to show the visualization. The sorted array is shown below."
        labelBox.Location = New Point(50, 250)
        labelBox.AutoSize = True
        labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
        labelBox.Text = labelBoxName

        ' Create a label to display the sorted array
        Dim arrayBox As New Label
        Dim arrayBoxName As String = String.Join(", ", arr)
        arrayBox.Location = New Point(50, 300)
        arrayBox.AutoSize = True
        arrayBox.Font = New Font(arrayBox.Font.FontFamily, 10, arrayBox.Font.Style)
        arrayBox.Text = arrayBoxName

        ' Add the labels to the list of element labels
        elementLabels.Add(labelBox)
        elementLabels.Add(arrayBox)

        ' Add the labels to the panel
        Panel1.Controls.Add(labelBox)
        Panel1.Controls.Add(arrayBox)

        ' Refresh the panel to display the labels
        Panel1.Refresh()

        ' Add a slight delay for visualization
        Threading.Thread.Sleep(delayMilliseconds)
    End Sub


    ' Event handler for the 'Load' button click event
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        ' Clear existing TextBox and Label controls from the form
        For Each textBox In elementBoxes
            Panel1.Controls.Remove(textBox)
        Next
        For Each labelBox In elementLabels
            Panel1.Controls.Remove(labelBox)
        Next
        elementBoxes.Clear()
        ' Sort and display the input array
        SortAndDisplayArray()
    End Sub


    ' Method to sort and display the input array
    Private Sub SortAndDisplayArray()
        Dim inputArray As String() = txtInput.Text.Split(","c)
        ReDim numbers(inputArray.Length - 1)
        Dim flag As Boolean = True
        length = inputArray.Length

        ' Convert input array elements to integers
        For i As Integer = 0 To inputArray.Length - 1
            If Integer.TryParse(inputArray(i), numbers(i)) Then
            Else
                flag = False
                MessageBox.Show("Invalid Input")
                Exit For
            End If
        Next

        If flag = True Then
            ' Sort the array if input is valid
            System.Array.Sort(numbers)
            If length > 14 Then
                ' Display the sorted array if it's too large for visualization
                SortArray(numbers)
            Else
                ' Initialize and display TextBox controls for array elements
                InitializeElementBoxes()
                DisplayArray(numbers)
            End If
        Else
            ' Clear the input TextBox if input is invalid
            txtInput.Clear()
        End If
    End Sub

    ' Method to initialize TextBox controls for displaying array elements
    Private Sub InitializeElementBoxes()
        ' Create and position TextBox controls for displaying array elements
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

    ' Method to display array elements in TextBox controls
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

    ' Event handler for the 'Back to Home' button click event
    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        ' Navigate back to the home form
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub
End Class