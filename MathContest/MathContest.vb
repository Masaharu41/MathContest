'Owen Fujii
'RCET 2265
'Spring 2024
'Math Contest
'https://github.com/Masaharu41/MathContest.git

Option Strict On
Option Explicit On


Public Class MathContest
    'TODO
    '[] Verify Grade is within range
    '[] Verify Age is withing range
    '[] Get and track user name as a letter string
    '[] Display errors 
    '[] Prevent submission until name, age, and grade are correct
    '[] Verify that user inputs are integers
    '[] require user submission for answer
    '[] complete operation specified by radio buttons
    '[] compare the user input to operation output
    '[] track how many times user has submitted and had the correct answer
    '[] create as user trackable answer sheet that can be displayed but is erased once the name is changed
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Loader(sender As Object, e As EventArgs) Handles Me.Load
        GradeTextBox.Text = ""
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        SubmitButton.Enabled = False

    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        Dim verfiedGrade As Boolean
        If String.IsNullOrEmpty(GradeTextBox.Text) Then
            SubmitButton.Enabled = False
        Else
            verfiedGrade = GradeVerified(GradeTextBox.Text)
            'Msg for testing purposes only
            If verfiedGrade = True Then
                SubmitButton.Enabled = True
                ' MsgBox("Valid input")
            ElseIf verfiedGrade = False Then
                SubmitButton.Enabled = False
                ' MsgBox("Invalid input")
            End If
        End If

    End Sub

    Function GradeVerified(grade As String) As Boolean
        Dim integerGrade As Integer

        Try
            integerGrade = CInt(GradeTextBox.Text)
        Catch ex As Exception
            'testing purpose only write to log file later
            MsgBox("Grade Must be a Integer!")
            Return False
        End Try

        If 1 <= integerGrade And integerGrade <= 4 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        Dim verfiedAge As Boolean
        If String.IsNullOrEmpty(AgeTextBox.Text) Then
            SubmitButton.Enabled = False
        Else
            verfiedAge = AgeVerified(AgeTextBox.Text)
            If verfiedAge = True Then
                SubmitButton.Enabled = verfiedAge
            ElseIf verfiedAge = False Then
                SubmitButton.Enabled = False
            End If
        End If
    End Sub

    Function AgeVerified(age As String) As Boolean
        Dim integerAge As Integer

        Try
            integerAge = CInt(AgeTextBox.Text)
        Catch ex As Exception
            'testing purpose only write to log file later
            MsgBox("Age Must be a Integer!")
            Return False
        End Try

        If 7 <= integerAge And integerAge <= 11 Then
            Return True
        Else
            Return False
        End If

    End Function
End Class
