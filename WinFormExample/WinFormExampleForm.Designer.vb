<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HelloButton = New System.Windows.Forms.Button()
        Me.UserInput = New System.Windows.Forms.TextBox()
        Me.UserInputButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(1103, 642)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(142, 95)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'HelloButton
        '
        Me.HelloButton.Location = New System.Drawing.Point(945, 642)
        Me.HelloButton.Name = "HelloButton"
        Me.HelloButton.Size = New System.Drawing.Size(142, 95)
        Me.HelloButton.TabIndex = 2
        Me.HelloButton.Text = "Hello"
        Me.HelloButton.UseVisualStyleBackColor = True
        '
        'UserInput
        '
        Me.UserInput.Location = New System.Drawing.Point(98, 40)
        Me.UserInput.Name = "UserInput"
        Me.UserInput.Size = New System.Drawing.Size(938, 31)
        Me.UserInput.TabIndex = 0
        '
        'UserInputButton
        '
        Me.UserInputButton.Location = New System.Drawing.Point(804, 645)
        Me.UserInputButton.Name = "UserInputButton"
        Me.UserInputButton.Size = New System.Drawing.Size(118, 88)
        Me.UserInputButton.TabIndex = 1
        Me.UserInputButton.Text = "Update"
        Me.UserInputButton.UseVisualStyleBackColor = True
        '
        'WinFormExampleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 749)
        Me.Controls.Add(Me.UserInputButton)
        Me.Controls.Add(Me.UserInput)
        Me.Controls.Add(Me.HelloButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "WinFormExampleForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents HelloButton As Button
    Friend WithEvents UserInput As TextBox
    Friend WithEvents UserInputButton As Button
End Class
