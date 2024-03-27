<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.AdditionRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.OperationsGroupBox = New System.Windows.Forms.GroupBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.InformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserInputsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OperationsGroupBox.SuspendLayout()
        Me.InformationGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.UserInputsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(7, 59)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(203, 31)
        Me.NameTextBox.TabIndex = 0
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(255, 59)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(39, 31)
        Me.AgeTextBox.TabIndex = 1
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(327, 59)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(39, 31)
        Me.GradeTextBox.TabIndex = 2
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(18, 79)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(203, 31)
        Me.FirstNumberTextBox.TabIndex = 3
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(18, 162)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(203, 31)
        Me.SecondNumberTextBox.TabIndex = 4
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(18, 244)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(203, 31)
        Me.StudentAnswerTextBox.TabIndex = 5
        '
        'AdditionRadioButton
        '
        Me.AdditionRadioButton.AutoSize = True
        Me.AdditionRadioButton.Location = New System.Drawing.Point(43, 60)
        Me.AdditionRadioButton.Name = "AdditionRadioButton"
        Me.AdditionRadioButton.Size = New System.Drawing.Size(121, 29)
        Me.AdditionRadioButton.TabIndex = 6
        Me.AdditionRadioButton.TabStop = True
        Me.AdditionRadioButton.Text = "Addition"
        Me.AdditionRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractionRadioButton
        '
        Me.SubtractionRadioButton.AutoSize = True
        Me.SubtractionRadioButton.Location = New System.Drawing.Point(42, 95)
        Me.SubtractionRadioButton.Name = "SubtractionRadioButton"
        Me.SubtractionRadioButton.Size = New System.Drawing.Size(152, 29)
        Me.SubtractionRadioButton.TabIndex = 7
        Me.SubtractionRadioButton.TabStop = True
        Me.SubtractionRadioButton.Text = "Subtraction"
        Me.SubtractionRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(42, 130)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(169, 29)
        Me.MultiplyRadioButton.TabIndex = 8
        Me.MultiplyRadioButton.TabStop = True
        Me.MultiplyRadioButton.Text = "Multiplication"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(42, 165)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(119, 29)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Division"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(11, 30)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(179, 85)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(11, 121)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(179, 85)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(11, 212)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(179, 85)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "Su&mmary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(11, 303)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(179, 85)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Location = New System.Drawing.Point(6, 27)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(68, 25)
        Me.NameLabel.TabIndex = 14
        Me.NameLabel.Text = "Name"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(2, 51)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(122, 25)
        Me.FirstNumberLabel.TabIndex = 15
        Me.FirstNumberLabel.Text = "1st Number"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(2, 127)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(129, 25)
        Me.SecondNumberLabel.TabIndex = 16
        Me.SecondNumberLabel.Text = "2nd Number"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(2, 210)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(163, 25)
        Me.StudentAnswerLabel.TabIndex = 17
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'OperationsGroupBox
        '
        Me.OperationsGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.AdditionRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.SubtractionRadioButton)
        Me.OperationsGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.OperationsGroupBox.Location = New System.Drawing.Point(337, 147)
        Me.OperationsGroupBox.Name = "OperationsGroupBox"
        Me.OperationsGroupBox.Size = New System.Drawing.Size(267, 235)
        Me.OperationsGroupBox.TabIndex = 18
        Me.OperationsGroupBox.TabStop = False
        Me.OperationsGroupBox.Text = "Math Operations"
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Location = New System.Drawing.Point(250, 27)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(50, 25)
        Me.AgeLabel.TabIndex = 19
        Me.AgeLabel.Text = "Age"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Location = New System.Drawing.Point(322, 27)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(71, 25)
        Me.GradeLabel.TabIndex = 20
        Me.GradeLabel.Text = "Grade"
        '
        'InformationGroupBox
        '
        Me.InformationGroupBox.Controls.Add(Me.GradeLabel)
        Me.InformationGroupBox.Controls.Add(Me.AgeLabel)
        Me.InformationGroupBox.Controls.Add(Me.NameLabel)
        Me.InformationGroupBox.Controls.Add(Me.GradeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.AgeTextBox)
        Me.InformationGroupBox.Controls.Add(Me.NameTextBox)
        Me.InformationGroupBox.Location = New System.Drawing.Point(61, 34)
        Me.InformationGroupBox.Name = "InformationGroupBox"
        Me.InformationGroupBox.Size = New System.Drawing.Size(602, 107)
        Me.InformationGroupBox.TabIndex = 21
        Me.InformationGroupBox.TabStop = False
        Me.InformationGroupBox.Text = "Student Information"
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.SummaryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(716, 34)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(219, 407)
        Me.ButtonsGroupBox.TabIndex = 22
        Me.ButtonsGroupBox.TabStop = False
        '
        'UserInputsGroupBox
        '
        Me.UserInputsGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.UserInputsGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.UserInputsGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.UserInputsGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.UserInputsGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.UserInputsGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.UserInputsGroupBox.Location = New System.Drawing.Point(61, 147)
        Me.UserInputsGroupBox.Name = "UserInputsGroupBox"
        Me.UserInputsGroupBox.Size = New System.Drawing.Size(250, 304)
        Me.UserInputsGroupBox.TabIndex = 23
        Me.UserInputsGroupBox.TabStop = False
        Me.UserInputsGroupBox.Text = "Current Math Problem"
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 589)
        Me.Controls.Add(Me.UserInputsGroupBox)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.InformationGroupBox)
        Me.Controls.Add(Me.OperationsGroupBox)
        Me.Name = "MathContest"
        Me.Text = "Form1"
        Me.OperationsGroupBox.ResumeLayout(False)
        Me.OperationsGroupBox.PerformLayout()
        Me.InformationGroupBox.ResumeLayout(False)
        Me.InformationGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.UserInputsGroupBox.ResumeLayout(False)
        Me.UserInputsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents AdditionRadioButton As RadioButton
    Friend WithEvents SubtractionRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents NameLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents OperationsGroupBox As GroupBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents GradeLabel As Label
    Friend WithEvents InformationGroupBox As GroupBox
    Friend WithEvents ButtonsGroupBox As GroupBox
    Friend WithEvents UserInputsGroupBox As GroupBox
End Class
