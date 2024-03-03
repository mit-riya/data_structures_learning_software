Public Class SelectionSort

    ' Variables to store the length of the array, TextBox controls for elements,
    ' delay duration for visualization, a label for visualizing sorting steps,
    ' and labels for displaying information
    Dim length As Integer
    Dim elementBoxes As New List(Of TextBox)()
    Dim delayMilliseconds As Integer = 1000
    Dim lineLabel As New Label()
    Dim elementLabels As New List(Of Label)()

    ' Event handler for the form load event
    Private Sub SelectionSort_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set explanation text for the sorting algorithm
        Label3.Text = "Selection sort is a simple and efficient sorting algorithm that works by repeatedly selecting the smallest (or largest) element from the unsorted portion of the list and moving it to the sorted portion of the list. "
        ' Provide step-by-step explanation of the algorithm
        Dim explanation As String = "In this algorithm," & vbCrLf &
            vbCrLf &
            "1. Start with the first element as the current minimum. " & vbCrLf &
            vbCrLf &
            "2. Compare this element with the rest of the elements in the array to find the minimum element." & vbCrLf &
            vbCrLf &
            "3. Swap the minimum element found with the first element." & vbCrLf &
            vbCrLf &
            "4. Repeat the above steps for the subarray starting from the second element, then the third, and so on, until the entire array is sorted."
        Label5.Text = explanation
    End Sub

    ' Event handler for the sort button click
    Private Sub btnSort_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ' Clear the panel of previous elements
        For Each textBox In elementBoxes
            Panel1.Controls.Remove(textBox)
        Next
        For Each labelBox In elementLabels
            Panel1.Controls.Remove(labelBox)
        Next
        Panel1.Controls.Remove(lineLabel)
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds)
        ' Clear the list of TextBox controls
        elementBoxes.Clear()
        ' Call the sorting function
        SortAndDisplayArray()
    End Sub

    ' Function to sort and display the array
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
            ' If the array length is greater than 20, simply display the sorted array
            If length > 20 Then
                SortArray(intArray)
            Else
                ' Initialize TextBox controls for displaying array elements
                InitializeElementBoxes()
                ' Display the original array
                DisplayArray(intArray)
                ' Perform sorting and display the sorted array
                BubbleSortAndDisplay(intArray)
            End If
        Else
            ' Clear the input if it's invalid
            txtInput.Clear()
        End If
    End Sub

    ' Function to visualize swapping of elements
    Private Sub VisualizeSwap(ByVal index1 As Integer)
        ' Highlight the TextBoxes representing the elements being swapped
        Dim textBoxName1 As String = "txtElement" & (index1 + 1).ToString()
        Dim textBoxName2 As String = "temp"

        Dim elementTextBox1 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName1, True).FirstOrDefault(), TextBox)
        Dim elementTextBox2 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName2, True).FirstOrDefault(), TextBox)

        If elementTextBox1 IsNot Nothing AndAlso elementTextBox2 IsNot Nothing Then
            ' Highlight the TextBoxes
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

    ' Function to perform selection sort
    Private Sub SortArray(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim key As String
        Dim min_index As Integer
        ' Iterate through the array for selection sort
        For i As Integer = 0 To n - 2
            ' Initialize minimum index
            min_index = i
            ' Find minimum element in unsorted part
            For j As Integer = i + 1 To n - 1
                If arr(j) < arr(min_index) Then
                    min_index = j
                End If
            Next
            ' Swap minimum element with first element if not the same
            If min_index <> i Then
                key = arr(min_index)
                arr(min_index) = arr(i)
                arr(i) = key
            End If
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

    ' Function to initialize TextBox controls for displaying array elements
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
        lineLabel.BorderStyle = BorderStyle.Fixed3D
        lineLabel.Size = New Size(5, 30)
        lineLabel.BackColor = Color.Blue
    End Sub

    ' Function to display array elements in TextBox controls
    Private Sub DisplayArray(ByVal arr As Double())
        For i As Integer = 0 To arr.Length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            If elementTextBox IsNot Nothing Then
                elementTextBox.Text = arr(i)
            End If
        Next
    End Sub

    ' Function to perform bubble sort and visualize the process
    Private Sub BubbleSortAndDisplay(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim temp As String
        Dim min_index As Integer
        ' Add a line label for visualization
        Panel1.Controls.Add(lineLabel)
        lineLabel.BringToFront()

        For i As Integer = 0 To n - 2
            min_index = i
            ' Add a label to display sorting step
            Dim labelBox As New Label
            Dim labelBoxName As String = "Step - " & (i + 1).ToString()
            labelBox.Location = New Point(50, 150)
            labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
            labelBox.Text = labelBoxName
            Panel1.Controls.Add(labelBox)
            ' Position the line label
            lineLabel.Location = New Point(elementBoxes(i).Left - 10, 175)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
            ' Create a TextBox to visualize the selected element
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
            ' Remove the temporary TextBox
            Panel1.Controls.Remove(textBox)
            Panel1.Refresh()
            Threading.Thread.Sleep(1000)

            ' Iterate through the remaining elements to find the minimum
            For j As Integer = i + 1 To n - 1
                ' Create a TextBox to visualize the minimum element
                Dim textBoxTemp As New TextBox()
                textBoxTemp.Name = "temp"
                textBoxTemp.Size = New Size(60, 40)
                textBoxTemp.Location = New Point(elementBoxes(j).Left, 225)
                textBoxTemp.TextAlign = HorizontalAlignment.Center
                textBoxTemp.Text = arr(min_index)
                elementBoxes.Add(textBoxTemp)
                Panel1.Controls.Add(textBoxTemp)
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                ' Visualize swapping if a smaller element is found
                VisualizeSwap(j)
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                ' Update the minimum index if a smaller element is found
                If arr(j) < arr(min_index) Then
                    min_index = j
                    ' Update the visualization with the new minimum element
                    textBoxTemp.Text = ""
                    Panel1.Refresh()
                    Threading.Thread.Sleep(delayMilliseconds)
                    textBoxTemp.Text = arr(min_index)
                    Panel1.Refresh()
                    Threading.Thread.Sleep(delayMilliseconds)
                End If
                ' Remove the temporary TextBox
                Panel1.Controls.Remove(textBoxTemp)
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
            Next

            ' Swap elements if necessary
            If min_index <> i Then
                Dim textBoxTemp As New TextBox()
                textBoxTemp.Name = "temp"
                textBoxTemp.Size = New Size(60, 40)
                textBoxTemp.Location = New Point(elementBoxes(min_index).Left, 225)
                textBoxTemp.TextAlign = HorizontalAlignment.Center
                Panel1.Controls.Add(textBoxTemp)
                textBoxTemp.Text = arr(min_index)
                elementBoxes.Add(textBoxTemp)
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                ' Visualize swapping
                Dim textBoxName As String = "txtElement" & (min_index + 1).ToString()
                Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
                elementTextBox.Text = ""
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                elementTextBox.Text = arr(i)
                Dim firstBoxName As String = "txtElement" & (i + 1).ToString()
                Dim firstTextBox As TextBox = DirectCast(Panel1.Controls.Find(firstBoxName, True).FirstOrDefault(), TextBox)
                firstTextBox.Text = ""
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                firstTextBox.Text = textBoxTemp.Text
                textBoxTemp.Text = ""
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                ' Remove the temporary TextBox
                Panel1.Controls.Remove(textBoxTemp)
                Panel1.Refresh()
                Threading.Thread.Sleep(delayMilliseconds)
                ' Swap elements in the array
                temp = arr(min_index)
                arr(min_index) = arr(i)
                arr(i) = temp
            End If

            ' Remove the label indicating the sorting step
            Panel1.Controls.Remove(labelBox)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
        Next
    End Sub

    ' Event handler for the form closed event
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for the quiz button click
    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        ' Open the Home form
        Dim f2 As New Home()
        ' Add event handler for closing the new form
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the Home form
        f2.Show()
        ' Hide the current form
        Me.Hide()
    End Sub

End Class
