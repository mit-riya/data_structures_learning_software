Public Class LinearSearch
    Dim delayMilliseconds As Integer = 1000
    Dim matchFlags() As Boolean ' Array to store match flags for each item in the ListBox

    Private Sub LinearSearch_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Set DrawMode to OwnerDrawFixed
        ListBox1.DrawMode = DrawMode.OwnerDrawFixed
        Label2.Text = "Linear Search is defined as a sequential search algorithm that starts at one end and goes through each element of a list until the desired element is found, otherwise the search continues till the end of the data set."
    End Sub

    Private Sub btnLoadList_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadList.Click
        ' Clear existing items and match flags
        ListBox1.Items.Clear()
        ReDim matchFlags(0)

        ' Split the input string by commas and add each item to the ListBox
        Dim items As String() = txtInputList.Text.Split(",")
        For Each item As String In items
            ' Trim to remove any extra spaces
            ListBox1.Items.Add(item)
            ' Add a corresponding flag for each item, initialized as false
            ReDim Preserve matchFlags(ListBox1.Items.Count - 1)
            matchFlags(ListBox1.Items.Count - 1) = False
        Next
    End Sub

    Private Sub btnSearch_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' Get the search string from the textbox
        Dim searchString As String = txtSearchValue.Text.ToLower()

        ' Initialize match count
        Dim matchCount As Integer = 0

        ' Reset match flags
        For i As Integer = 0 To ListBox1.Items.Count - 1
            matchFlags(i) = False
        Next

        ' Check if the ListBox has items
        If ListBox1.Items.Count > 0 Then
            ' Loop through the listbox items to find the search string
            For i As Integer = 0 To ListBox1.Items.Count - 1
                ' Highlight the current item being searched
                ListBox1.SelectedIndex = i
                ListBox1.TopIndex = i

                ' Check if the current item matches the search string
                If ListBox1.Items(i).ToString().ToLower() = searchString Then
                    matchFlags(i) = True ' Set the match flag to true for the matching item
                    matchCount += 1 ' Increment match count
                End If

                ' Pause for visualization (adjust as needed)
                Threading.Thread.Sleep(delayMilliseconds)

                ' Clear the selection after each iteration
                ListBox1.ClearSelected()
            Next

            ' Force the ListBox to redraw to reflect the changes in item color
            ListBox1.Refresh()

            ' Display the number of times the element was found
            MessageBox.Show("Search completed. Element found " & matchCount.ToString() & " times.")
        Else
            ' Display a message if the list is empty
            MessageBox.Show("The list is empty.")
        End If
        For i As Integer = 0 To ListBox1.Items.Count - 1
            matchFlags(i) = False
        Next
        ListBox1.Refresh()
    End Sub

    Private Sub ListBox1_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        If e.Index >= 0 AndAlso e.Index < ListBox1.Items.Count Then
            ' Draw the background color of the item based on its selection state
            If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds)
                e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, SystemBrushes.HighlightText, e.Bounds, StringFormat.GenericDefault)
            ElseIf matchFlags(e.Index) Then
                ' Change the background color to a different color for matching items
                e.Graphics.FillRectangle(Brushes.Green, e.Bounds)
                e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, Brushes.Black, e.Bounds, StringFormat.GenericDefault)
            Else
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds)
                e.Graphics.DrawString(ListBox1.Items(e.Index).ToString(), e.Font, SystemBrushes.ControlText, e.Bounds, StringFormat.GenericDefault)
            End If
        End If
    End Sub

End Class
