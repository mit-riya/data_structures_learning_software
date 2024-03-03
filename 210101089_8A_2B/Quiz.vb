Imports System.Data.Odbc

Public Class Quiz
    Dim score As Integer = 0 ' Variable to store the user's score
    Dim k As Integer = -1 ' Variable to keep track of the current question index
    Private SelectedOptions(10) As Integer ' Array to store the selected options for each question

    ' Event handler for the form closing event
    Private Sub FormClosedHandler(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        ' Close the current form when the new form is closed
        Me.Close()
    End Sub

    ' Structure to represent a quiz question
    Public Structure QuizQuestion
        Public Question As String ' Question text
        Public Option1 As String ' First option
        Public Option2 As String ' Second option
        Public Option3 As String ' Third option
        Public Option4 As String ' Fourth option
        Public CorrectOption As Integer ' Index of the correct option
    End Structure

    Dim quizQuestions As New List(Of QuizQuestion)() ' List to store quiz questions

    ' Event handler for the form load event
    Private Sub Quiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establish ODBC connection
        odbc_connection()

        ' Retrieve quiz questions from the database based on the section ID
        query = "SELECT * FROM Question WHERE SectionID = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@secid", secid)
        dr = dml.ExecuteReader()

        ' Read quiz questions from the database and add them to the quizQuestions list
        While dr.Read()
            Dim question As New QuizQuestion()
            question.Question = dr("QuestionText").ToString()
            question.Option1 = dr("Option1").ToString()
            question.Option2 = dr("Option2").ToString()
            question.Option3 = dr("Option3").ToString()
            question.Option4 = dr("Option4").ToString()
            question.CorrectOption = Convert.ToInt32(dr("CorrectAnswer"))
            quizQuestions.Add(question)
        End While
    End Sub

    ' Event handler for the 'proceed' button click event
    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        ' Check if it's the first question or if there are more questions to proceed
        If k = -1 OrElse k < 9 Then
            ' Enable radio buttons for selecting options
            option1_rb.Enabled = True
            option2_rb.Enabled = True
            option3_rb.Enabled = True
            option4_rb.Enabled = True
            ' Check the first option by default
            option1_rb.Checked = True
            ' Increment the question index
            k += 1
            ' Change the button text to 'Next'
            proceed_btn.Text = "Next"
            ' Display the question and options for the current question index
            que_label.Text = quizQuestions(k).Question
            option1_rb.Text = quizQuestions(k).Option1
            option2_rb.Text = quizQuestions(k).Option2
            option3_rb.Text = quizQuestions(k).Option3
            option4_rb.Text = quizQuestions(k).Option4
        ElseIf k = 9 Then
            ' Store the selected option for the last question
            SelectedOptions(k) = CInt(que_gb.Controls.OfType(Of RadioButton)().First(Function(rb) rb.Checked).Tag)
            ' Check if the selected option is correct and display appropriate message
            If SelectedOptions(k) = quizQuestions(k).CorrectOption Then
                MessageBox.Show("correct answer")
            Else
                MessageBox.Show("wrong answer: correct option is " & quizQuestions(k).CorrectOption.ToString())
            End If
            ' Calculate the total score based on selected options
            For i As Integer = 0 To 9
                If quizQuestions(i).CorrectOption = SelectedOptions(i) Then
                    score += 1
                End If
            Next
            ' Update user's score in the database
            UpdateUserScore()
            ' Display the user's score
            MessageBox.Show("Your score is: " & score)
            ' Navigate back to the home form
            Dim f2 As New Home()
            AddHandler f2.FormClosed, AddressOf FormClosedHandler
            f2.Show()
            Me.Hide()
        End If
    End Sub

    ' Method to update user's score in the database
    Private Sub UpdateUserScore()
        ' Check if the user has attempted the quiz for the current section before
        query = "SELECT * FROM Log WHERE UserID = ? and SectionID = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@userid", userid)
        dml.Parameters.AddWithValue("@secid", secid)
        dr = dml.ExecuteReader
        If dr.HasRows Then
            ' If user has attempted before, update the score
            query = "UPDATE Log SET Score = ? WHERE UserID = ? and SectionID = ?"
            dml = New OdbcCommand(query, connector)
            dml.Parameters.AddWithValue("@score", score)
            dml.Parameters.AddWithValue("@userid", userid)
            dml.Parameters.AddWithValue("@secid", secid)
            dml.ExecuteNonQuery()
        Else
            ' If it's the first attempt, insert a new record with the score
            query = "INSERT INTO Log values(?, ?, ?)"
            dml = New OdbcCommand(query, connector)
            dml.Parameters.AddWithValue("@userid", userid)
            dml.Parameters.AddWithValue("@secid", secid)
            dml.Parameters.AddWithValue("@score", score)
            dml.ExecuteNonQuery()
        End If
    End Sub
End Class
