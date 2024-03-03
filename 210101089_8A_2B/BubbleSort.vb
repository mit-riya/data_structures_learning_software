Public Class BubbleSort

    ' Declare variables
    Dim length As Integer
    Dim elementBoxes As New List(Of TextBox)() ' List to hold TextBox controls for array elements
    Dim delayMilliseconds As Integer = 1000 ' Delay time for visualization
    Dim lineLabel As New Label() ' Label for visualization line
    Dim elementLabels As New List(Of Label)() ' List to hold Label controls

    ' Event handler for form load
    Private Sub BubbleSort_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Display explanation of bubble sort algorithm
        Label3.Text = "Bubble Sort is the simplest sorting algorithm that works by repeatedly swapping the adjacent elements if they are in the wrong order."
        Dim explanation As String = "In this algorithm," & vbCrLf &
            vbCrLf &
            "1. Traverse from left and compare adjacent elements and the higher one is placed at right side. " & vbCrLf &
            vbCrLf &
            "2. In this way, the largest element is moved to the rightmost end at first. " & vbCrLf &
            vbCrLf &
            "3. This process is then continued to find the second largest and place it and so on until the data is sorted."
        Label5.Text = explanation
    End Sub

    ' Event handler for the Sort button click
    Private Sub btnSort_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ' Clear existing TextBoxes, Labels, and lineLabel
        For Each textBox In elementBoxes
            Panel1.Controls.Remove(textBox)
        Next
        For Each labelBox In elementLabels
            Panel1.Controls.Remove(labelBox)
        Next
        Panel1.Controls.Remove(lineLabel)
        Panel1.Refresh()
        Threading.Thread.Sleep(delayMilliseconds)
        ' Clear the list of TextBoxes
        elementBoxes.Clear()
        ' Sort and display the array
        SortAndDisplayArray()
    End Sub

    ' Function to sort and display the array
    Private Sub SortAndDisplayArray()
        ' Get input from the TextBox and split it into an array
        Dim inputArray As String() = txtInput.Text.Split(","c)
        Dim flag As Boolean = True
        length = inputArray.Length

        ' Convert the string array to a double array
        Dim doubleArray(length - 1) As Double
        For i As Integer = 0 To inputArray.Length - 1
            If Double.TryParse(inputArray(i), doubleArray(i)) Then
            Else
                flag = False
                MessageBox.Show("Invalid Input")
                Exit For
            End If
        Next
        If flag = True Then
            ' Check if array is large enough to visualize
            If length > 14 Then
                ' Display sorted array without visualization
                SortArray(doubleArray)
            Else
                ' Initialize TextBoxes for array elements
                InitializeElementBoxes()
                ' Display the original array
                DisplayArray(doubleArray)
                ' Perform sorting and display the sorted array with visualization
                BubbleSortAndDisplay(doubleArray)
            End If
        Else
            txtInput.Clear()
        End If
    End Sub

    ' Function to visualize swapping of elements
    Private Sub VisualizeSwap(ByVal index1 As Integer, ByVal index2 As Integer)
        ' Highlight the TextBoxes representing the elements being swapped
        Dim textBoxName1 As String = "txtElement" & (index1 + 1).ToString()
        Dim textBoxName2 As String = "txtElement" & (index2 + 1).ToString()

        Dim elementTextBox1 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName1, True).FirstOrDefault(), TextBox)
        Dim elementTextBox2 As TextBox = DirectCast(Panel1.Controls.Find(textBoxName2, True).FirstOrDefault(), TextBox)

        If elementTextBox1 IsNot Nothing AndAlso elementTextBox2 IsNot Nothing Then
            ' Visualize swapping by changing TextBox colors
            elementTextBox1.BackColor = Color.Green
            elementTextBox2.BackColor = Color.Green
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds) ' Pause for visualization (adjust as needed)
            ' Restore original colors
            elementTextBox1.BackColor = SystemColors.Window
            elementTextBox2.BackColor = SystemColors.Window
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
        End If
    End Sub

    ' Function to sort the array using Bubble Sort algorithm
    Private Sub BubbleSortAndDisplay(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim temp As Double
        ' Add lineLabel for visualization
        Panel1.Controls.Add(lineLabel)
        lineLabel.BringToFront()

        For i As Integer = 0 To n - 2
            ' Add label for each sorting step
            Dim labelBox As New Label
            Dim labelBoxName As String = "Step - " & (i + 1).ToString()
            labelBox.Location = New Point(50, 150)
            labelBox.Font = New Font(labelBox.Font.FontFamily, 10, labelBox.Font.Style)
            labelBox.Text = labelBoxName
            Panel1.Controls.Add(labelBox)
            ' Set lineLabel position
            lineLabel.Location = New Point(elementBoxes(n - i - 1).Right + 1, 175)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)

            For j As Integer = 0 To n - i - 2
                ' Visualize swapping
                VisualizeSwap(j, j + 1)
                If arr(j) > arr(j + 1) Then
                    ' Swap elements
                    temp = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = temp
                    ' Move TextBoxes for visualization
                    Dim textBox As New TextBox()
                    textBox.Name = "temp"
                    textBox.Size = New Size(60, 40)
                    textBox.Location = New Point(elementBoxes(j + 1).Left, 225)
                    textBox.TextAlign = HorizontalAlignment.Center
                    textBox.Text = elementBoxes(j + 1).Text
                    elementBoxes(j + 1).Text = ""
                    elementBoxes.Add(textBox)
                    Panel1.Controls.Add(textBox)
                    Panel1.Refresh()
                    Threading.Thread.Sleep(delayMilliseconds)
                    elementBoxes(j + 1).Text = elementBoxes(j).Text
                    elementBoxes(j).Text = ""
                    Panel1.Refresh()
                    Threading.Thread.Sleep(delayMilliseconds)
                    elementBoxes(j).Text = textBox.Text
                    Panel1.Controls.Remove(textBox)
                    Panel1.Refresh()
                    Threading.Thread.Sleep(delayMilliseconds)
                End If
            Next
            ' Remove label after sorting step
            Panel1.Controls.Remove(labelBox)
            Panel1.Refresh()
            Threading.Thread.Sleep(delayMilliseconds)
        Next
    End Sub

    ' Function to display the sorted array when it is too large for visualization
    Private Sub SortArray(ByVal arr As Double())
        Dim n As Integer = arr.Length
        Dim key As Double
        For i As Integer = 0 To n - 2
            For j As Integer = 0 To n - i - 2
                If arr(j) > arr(j + 1) Then
                    ' Swap elements
                    key = arr(j)
                    arr(j) = arr(j + 1)
                    arr(j + 1) = key
                End If
            Next
        Next
        ' Display message and sorted array
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

    ' Function to initialize TextBoxes for displaying array elements
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
        ' Add lineLabel for visualization
        lineLabel.BorderStyle = BorderStyle.Fixed3D
        lineLabel.Size = New Size(5, 30)
        lineLabel.BackColor = Color.Blue
    End Sub

    ' Function to display the original array in TextBoxes
    Private Sub DisplayArray(ByVal arr As Double())
        For i As Integer = 0 To arr.Length - 1
            Dim textBoxName As String = "txtElement" & (i + 1).ToString()
            Dim elementTextBox As TextBox = DirectCast(Panel1.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            If elementTextBox IsNot Nothing Then
                elementTextBox.Text = arr(i)
            End If
        Next
    End Sub

    ' Event handler for form closed
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Event handler for quiz button click
    Private Sub quiz_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quiz_btn.Click
        Dim f2 As New Home()
        AddHandler f2.FormClosed, AddressOf FormClosedHandler
        ' Show the Home form
        f2.Show()
        Me.Hide()
    End Sub
End Class
