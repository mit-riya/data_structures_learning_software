Imports System.Data.Odbc
Public Class Quiz
    Dim score As Integer = 0
    Dim k As Integer = -1
    Private SelectedOptions(10) As Integer

    Public Structure QuizQuestion
        Public Question As String
        Public Option1 As String
        Public Option2 As String
        Public Option3 As String
        Public Option4 As String
        Public CorrectOption As Integer
    End Structure

    Dim quizQuestions As New List(Of QuizQuestion)()


    Private Sub Quiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        odbc_connection()

        query = "SELECT * FROM Question WHERE SectionID = ?"
        dml = New OdbcCommand(query, connector)
        dml.Parameters.AddWithValue("@secid", secid)
        dr = dml.ExecuteReader()

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

    Private Sub proceed_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles proceed_btn.Click
        If k = -1 Then
            option1_rb.Enabled = True
            option2_rb.Enabled = True
            option3_rb.Enabled = True
            option4_rb.Enabled = True
            option1_rb.Checked = True
            k += 1
            proceed_btn.Text = "Next"
            que_label.Text = quizQuestions(k).Question
            option1_rb.Text = quizQuestions(k).Option1
            option2_rb.Text = quizQuestions(k).Option2
            option3_rb.Text = quizQuestions(k).Option3
            option4_rb.Text = quizQuestions(k).Option4
        ElseIf k < 8 Then
            SelectedOptions(k) = CInt(que_gb.Controls.OfType(Of RadioButton)().First(Function(rb) rb.Checked).Tag)
            If SelectedOptions(k) = quizQuestions(k).CorrectOption Then
                MessageBox.Show("correct answer")
            Else
                MessageBox.Show("wrong answer: correct option is " & quizQuestions(k).CorrectOption.ToString())
            End If
            k += 1
            que_label.Text = quizQuestions(k).Question
            option1_rb.Text = quizQuestions(k).Option1
            option2_rb.Text = quizQuestions(k).Option2
            option3_rb.Text = quizQuestions(k).Option3
            option4_rb.Text = quizQuestions(k).Option4
        ElseIf k = 8 Then
            SelectedOptions(k) = CInt(que_gb.Controls.OfType(Of RadioButton)().First(Function(rb) rb.Checked).Tag)
            If SelectedOptions(k) = quizQuestions(k).CorrectOption Then
                MessageBox.Show("correct answer")
            Else
                MessageBox.Show("wrong answer:  correct option is " & quizQuestions(k).CorrectOption.ToString())
            End If
            k += 1
            proceed_btn.Text = "Submit"
            que_label.Text = quizQuestions(k).Question
            option1_rb.Text = quizQuestions(k).Option1
            option2_rb.Text = quizQuestions(k).Option2
            option3_rb.Text = quizQuestions(k).Option3
            option4_rb.Text = quizQuestions(k).Option4
        Else
            SelectedOptions(k) = CInt(que_gb.Controls.OfType(Of RadioButton)().First(Function(rb) rb.Checked).Tag)
            If SelectedOptions(k) = quizQuestions(k).CorrectOption Then
                MessageBox.Show("correct answer")
            Else
                MessageBox.Show("wrong answer:  correct option is " & quizQuestions(k).CorrectOption.ToString())
            End If
            For i As Integer = 0 To 9
                If quizQuestions(i).CorrectOption = SelectedOptions(i) Then
                    score += 1
                End If
            Next

            query = "SELECT * FROM Log WHERE UserID = ? and SectionID = ?"
            dml = New OdbcCommand(query, connector)
            dml.Parameters.AddWithValue("@userid", userid)
            dml.Parameters.AddWithValue("@secid", secid)
            dr = dml.ExecuteReader
            If dr.HasRows Then
                query = "UPDATE Log SET Score = ? WHERE UserID = ? and SectionID = ?"
                dml = New OdbcCommand(query, connector)
                dml.Parameters.AddWithValue("@score", score)
                dml.Parameters.AddWithValue("@userid", userid)
                dml.Parameters.AddWithValue("@secid", secid)
                dml.ExecuteNonQuery()

            Else
                query = "INSERT INTO Log values(?, ?, ?)"
                dml = New OdbcCommand(query, connector)
                dml.Parameters.AddWithValue("@userid", userid)
                dml.Parameters.AddWithValue("@secid", secid)
                dml.Parameters.AddWithValue("@score", score)
                dml.ExecuteNonQuery()
            End If

            MessageBox.Show("Your score is: " & score)
            Home.Show()
            Me.Close()
        End If
    End Sub
End Class