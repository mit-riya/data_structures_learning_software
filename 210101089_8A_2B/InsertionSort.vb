Public Class InsertionSort

    ' Declare variables
    Dim length As Integer
    Dim elementBoxes As New List(Of TextBox)()
    Dim delayMilliseconds As Integer = 1000
    Dim lineLabel As New Label()
    Dim elementLabels As New List(Of Label)()

    ' Load event handler for the form
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Display explanation of insertion sort algorithm
        Label3.Text = "Insertion sort is a simple sorting algorithm that works similarly to the way you sort playing cards in your hands. The array is virtually split into a sorted and an unsorted part. Values from the unsorted part are picked and placed in the correct position in the sorted part."
        Dim explanation As String = "In this algorithm," & vbCrLf &
            vbCrLf &
            "1. Start with the second element and consider it as the current element. " & vbCrLf &
            vbCrLf &
            "2. Compare the current element with the elements before it." & vbCrLf &
            vbCrLf &
            "3. If the current element is smaller than any of the elements before it, shift those elements one position to the right." & vbCrLf &
            vbCrLf &
            "4. Repeat steps 2 and 3 until you find the correct position for the current element." & vbCrLf &
            vbCrLf &
            "5. Insert the current element into its correct position." & vbCrLf &
            vbCrLf &
            "6. Move to the next element and repeat the process until the entire array is sorted."
        Label5.Text = explanation
    End Sub

    ' Click event handler for the sort button
    Private Sub btnSort_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ' Remove existing elements from the panel
        For Each textBox In elementBoxes
            Panel1.Controls.Remove(textBox)
        Next
        For Each labelBox In elementLabels
            Panel1.Controls.Remove(labelBox)
        Next
        Panel1.Controls.Remove(lineLabel)
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds)
        ' Clear the lists
        elementBoxes.Clear()
        ' Call the method to sort and display the array
        SortAndDisplayArray()
    End Sub

    ' Method to sort and display the array
    Private Sub SortAndDisplayArray()
        ' Get input from the TextBox and split it into an array
        Dim inputArray As String() = txtInput.Text.Split(","c)
        Dim flag As Boolean = True
        length = inputArray.Length

        ' Convert the string array to a double array
        Dim intArray(length - 1) As Double
        For i As Integer = 0 To inputArray.Length - 1
            If Double.TryParse(inputArray(i), intArray(i)) Then
            Else
                flag = False
                MessageBox.Show("Invalid Input")
                Exit For
            End If
        Next
        If flag = True Then
            ' Check if array is too large for visualization
            If length > 20 Then
                ' Call the method to sort the array
                SortArray(intArray)
            Else
                ' Initialize TextBoxes for displaying array elements
                InitializeElementBoxes()
                ' Display the original array
                DisplayArray(intArray)
                ' Perform sorting and display the sorted array
                InsertionSortAndDisplay(intArray)
            End If
        Else
            txtInput.Clear()
        End If
    End Sub

    ' Method to highlight the TextBoxes representing the elements being swapped
    Private Sub VisualizeSwap(ByVal index1 As Integer)
        Dim textBoxName1 As String = "txtElement" & (index1 + 1).ToString()
        Dim textBoxName2 As String = "temp"

        Dim elementTextBox1 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName1, True).FirstOrDefault(), TextBox)
        Dim elementTextBox2 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName2, True).FirstOrDefault(), TextBox)

        If elementTextBox1 IsNot Nothing AndAlso elementTextBox2 IsNot Nothing Then
            ' Highlight TextBoxes in green
            elementTextBox1.BackColor = Color.Green
            elementTextBox2.BackColor = Color.Green
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds) ' Pause for visualization
            ' Restore original colors
            elementTextBox1.BackColor = SystemColors.Window
            elementTextBox2.BackColor = SystemColors.Window
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
        End If
    End Sub

    ' Method to sort the array using insertion sort algorithm
    Private Sub SortArray(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim key As String
        For i As Integer = 1 To n - 1
            Dim j As Integer = i - 1
            key = arr(i)
            While j >= 0 AndAlso arr(j) > key
                ' Shift the elements to the right
                arr(j + 1) = arr(j)
                j = j - 1
            End While
            ' Place the key in its correct position
            arr(j + 1) = key
        Next
        ' Display the sorted array
        Dim labelBox As New Label
        Dim labelBoxName As String = "Array is too big to show the visualization. The sorted array is shown below."
        labelBox.Location = New Point(50, 150)
        labelBox.AutoSize = True
        labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
        labelBox.Text = labelBoxName
        Dim arrayBox As New Label
        Dim arrayBoxName As String = String.Join(", ", arr)
        arrayBox.Location = New Point(50, 200)
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

    ' Method to initialize TextBoxes for displaying array elements
    Private Sub InitializeElementBoxes()
        For i As Integer = 0 To (length - 1)
            Dim textBox As New TextBox()
            textBox.Name = "txtElement" & (i + 1).ToString()
            textBox.Size = New Size(60, 40)
            textBox.Location = New Point(50 + i * 70, 175)
            textBox.TextAlign = HorizontalAlignment.Center
            elementBoxes.Add(textBox)
            Panel1.Controls.Add(textBox)
        Next
        ' Create a line label to separate input from output
        lineLabel.BorderStyle = BorderStyle.Fixed3D
        lineLabel.Size = New Size(5, 30)
        lineLabel.BackColor = Color.Blue
    End Sub

    ' Method to display array elements in TextBoxes
    Private Sub DisplayArray(ByVal arr As Double())
        For i As Integer = 0 To arr.Length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            If elementTextBox IsNot Nothing Then
                elementTextBox.Text = arr(i)
            End If
        Next
    End Sub

    ' Method to perform insertion sort and display the sorting process
    Private Sub InsertionSortAndDisplay(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim key As String
        ' Add a line label to show the current element being processed
        Panel1.Controls.Add(lineLabel)
        lineLabel.BringToFront()

        For i As Integer = 1 To n - 1
            ' Add a label to show the current step
            Dim labelBox As New Label
            Dim labelBoxName As String = "Step - " & (i).ToString()
            labelBox.Location = New Point(50, 150)
            labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
            labelBox.Text = labelBoxName
            Panel1.Controls.Add(labelBox)
            ' Move the line label to the position of the current element
            lineLabel.Location = New Point(elementBoxes(i - 1).Right + 1, 175)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)

            Dim j As Integer = i - 1
            key = arr(i)

            ' Create a temporary TextBox to visualize the movement of elements
            Dim textBox As New TextBox()
            textBox.Name = "temp"
            textBox.Size = New Size(60, 40)
            textBox.Location = New Point(elementBoxes(i).Left, 225)
            textBox.TextAlign = HorizontalAlignment.Center
            textBox.Text = elementBoxes(i).Text
            elementBoxes.Add(textBox)
            Panel1.Controls.Add(textBox)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)

            While j >= 0 AndAlso arr(j) > key
                ' Visualize the swapping process
                VisualizeSwap(j)
                ' Shift the elements to the right
                arr(j + 1) = arr(j)
                ' Update the TextBox values
                elementBoxes(j + 1).Text = elementBoxes(j).Text
                elementBoxes(j).Text = ""
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                j = j - 1
            End While

            ' Restore colors and remove temporary TextBox
            Dim t As Integer = j
            While t >= 0
                VisualizeSwap(t)
                t = t - 1
            End While
            Panel1.Controls.Remove(textBox)
            Panel1.Controls.Remove(labelBox)
            Panel1.Refresh()

            ' Place the key in its correct position
            arr(j + 1) = key
            elementBoxes(j + 1).Text = key.ToString()

            ' Display the updated array
            DisplayArray(arr)
        Next

        ' Move the line label to the last position
        lineLabel.Location = New Point(elementBoxes(n - 1).Right + 1, 175)
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds)
    End Sub

    ' Event handler for form closing
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for quiz button
    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        ' Open the quiz form
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        f2.Show()
        Me.Hide()
    End Sub
End Class
