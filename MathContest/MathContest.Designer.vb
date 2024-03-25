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
        Me.InputOneTextBox = New System.Windows.Forms.TextBox()
        Me.Input2TextBox = New System.Windows.Forms.TextBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.AdditionRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(70, 54)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(203, 31)
        Me.NameTextBox.TabIndex = 0
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(318, 54)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(39, 31)
        Me.AgeTextBox.TabIndex = 1
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(389, 54)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(39, 31)
        Me.GradeTextBox.TabIndex = 2
        '
        'InputOneTextBox
        '
        Me.InputOneTextBox.Location = New System.Drawing.Point(70, 125)
        Me.InputOneTextBox.Name = "InputOneTextBox"
        Me.InputOneTextBox.Size = New System.Drawing.Size(203, 31)
        Me.InputOneTextBox.TabIndex = 3
        '
        'Input2TextBox
        '
        Me.Input2TextBox.Location = New System.Drawing.Point(61, 199)
        Me.Input2TextBox.Name = "Input2TextBox"
        Me.Input2TextBox.Size = New System.Drawing.Size(203, 31)
        Me.Input2TextBox.TabIndex = 4
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(70, 277)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(203, 31)
        Me.UserTextBox.TabIndex = 5
        '
        'AdditionRadioButton
        '
        Me.AdditionRadioButton.AutoSize = True
        Me.AdditionRadioButton.Location = New System.Drawing.Point(365, 178)
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
        Me.SubtractionRadioButton.Location = New System.Drawing.Point(365, 223)
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
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(365, 267)
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
        Me.DivideRadioButton.Location = New System.Drawing.Point(365, 302)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(119, 29)
        Me.DivideRadioButton.TabIndex = 9
        Me.DivideRadioButton.TabStop = True
        Me.DivideRadioButton.Text = "Division"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(699, 71)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(179, 85)
        Me.SubmitButton.TabIndex = 10
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(699, 162)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(179, 85)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(699, 253)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(179, 85)
        Me.SummaryButton.TabIndex = 12
        Me.SummaryButton.Text = "Su&mmary"
        Me.SummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(699, 344)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(179, 85)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "&Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 494)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.DivideRadioButton)
        Me.Controls.Add(Me.MultiplyRadioButton)
        Me.Controls.Add(Me.SubtractionRadioButton)
        Me.Controls.Add(Me.AdditionRadioButton)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.Input2TextBox)
        Me.Controls.Add(Me.InputOneTextBox)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Name = "MathContest"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents InputOneTextBox As TextBox
    Friend WithEvents Input2TextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents AdditionRadioButton As RadioButton
    Friend WithEvents SubtractionRadioButton As RadioButton
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummaryButton As Button
    Friend WithEvents ExitButton As Button
End Class
