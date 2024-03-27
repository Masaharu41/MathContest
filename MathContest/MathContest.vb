'Owen Fujii
'RCET 2265
'Spring 2024
'Math Contest
'https://github.com/Masaharu41/MathContest.git

Option Strict On
Option Explicit On


Public Class MathContest
    'TODO
    '[*] Verify Grade is within range
    '[*] Verify Age is withing range
    '[] Get and track user name as a letter string
    '[] Display errors 
    '[*] Prevent submission until name, age, and grade are correct
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
        SummaryButton.Enabled = False
        FirstNumberTextBox.Enabled = False
        SecondNumberTextBox.Enabled = False
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameTextBox.Enabled = True
        AgeTextBox.Enabled = True
        GradeTextBox.Enabled = True
        GradeTextBox.Text = ""
        NameTextBox.Text = ""
        AgeTextBox.Text = ""
        FirstNumberTextBox.Text = ""
        SecondNumberTextBox.Text = ""
    End Sub
    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged
        SubmitButton.Enabled = MasterVerfication()
    End Sub

    Private Sub GradeTextBox_TextChanged(sender As Object, e As EventArgs) Handles GradeTextBox.TextChanged
        SubmitButton.Enabled = MasterVerfication()

    End Sub
    Private Sub AgeTextBox_TextChanged(sender As Object, e As EventArgs) Handles AgeTextBox.TextChanged
        SubmitButton.Enabled = MasterVerfication()
    End Sub


    Function GradeVerified(grade As String) As Boolean
        'verifies grade is first an integer and then checks that it is within range
        Dim integerGrade As Integer

        Try
            integerGrade = CInt(GradeTextBox.Text)
        Catch ex As Exception
            'testing purpose only write to log file later
            ' MsgBox("Grade Must be a Integer!")
            Return False
        End Try

        If 1 <= integerGrade And integerGrade <= 4 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function AgeVerified(age As String) As Boolean
        'verifies that age is an integer and within range 
        Dim integerAge As Integer

        Try
            integerAge = CInt(AgeTextBox.Text)
        Catch ex As Exception
            'testing purpose only write to log file later
            '  MsgBox("Age Must be a Integer!")
            Return False
        End Try

        If 7 <= integerAge And integerAge <= 11 Then
            Return True
        Else
            Return False
        End If

    End Function
    Function MasterVerfication() As Boolean
        'this verifies that the student has input a name 
        Dim nameIsLetters As Boolean
        nameIsLetters = System.Text.RegularExpressions.Regex.IsMatch(NameTextBox.Text, "^[A-Za-z]+$")
        If String.IsNullOrEmpty(NameTextBox.Text) Or String.IsNullOrEmpty(AgeTextBox.Text) Or String.IsNullOrEmpty(GradeTextBox.Text) Then
            Return False
        ElseIf AgeVerified(AgeTextBox.Text) = True And GradeVerified(GradeTextBox.Text) = True And nameIsLetters = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'Disable user from changing their name, age, and grade until they clear
        NameTextBox.Enabled = False
        AgeTextBox.Enabled = False
        GradeTextBox.Enabled = False
        If SameName(NameTextBox.Text) = True Then
            FirstNumberTextBox.Text = CStr(IntegerGenerator())
            SecondNumberTextBox.Text = CStr(IntegerGenerator())
        Else

        End If


        'If SameName(NameTextBox.Text) = True Then

        'End If
    End Sub

    'save for later
    Function SameName(name As String) As Boolean
        Static priorName As String
        If priorName = name Then
            Return True

        Else
            priorName = name
            Return False
        End If
    End Function

    'Save for later 
    'Function ValidIntegers() As Boolean
    '    Dim firstInteger As Integer
    '    Dim secondInteger As Integer

    '    If String.IsNullOrEmpty(FirstNumberTextBox.Text) Then
    '        Return False
    '    Else
    '        Try

    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Function

    Function IntegerGenerator() As Integer
        Dim randomInteger As Integer
        Randomize()
        randomInteger = CInt((Rnd() * 10) * (Rnd() * 10))
        Return randomInteger
    End Function

    Function ValidAnswer() As Boolean
        Dim userAsInteger As Integer
        If String.IsNullOrEmpty(StudentAnswerTextBox.Text) Then
            Return False
        Else
            Try
                userAsInteger = CInt(StudentAnswerTextBox.Text)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End If

    End Function

    Function DoOperationCompare() As Boolean
        'Dim addition As Boolean
        'Dim subtraction As Boolean
        'Dim multiplication As Boolean
        'Dim division As Boolean
        Dim math As Integer

        'addition = AdditionRadioButton.Enabled
        'subtraction = SubtractionRadioButton.Enabled
        'multiplication = MultiplyRadioButton.Enabled
        'division = DivideRadioButton.Enabled

        If AdditionRadioButton.Checked = True Then
            math = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text)

        ElseIf SubtractionRadioButton.Checked = True Then
            math = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text)

        ElseIf MultiplyRadioButton.Checked = True Then
            math = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text)
        ElseIf SubtractionRadioButton.Checked = True Then
            math = CInt(FirstNumberTextBox.Text) \ CInt(SecondNumberTextBox.Text)



        End If

        If math = CInt(StudentAnswerTextBox.Text) Then
            Return True
        Else
            Return False

        End If


    End Function

End Class
