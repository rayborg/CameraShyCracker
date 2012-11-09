<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LoadXBox = New System.Windows.Forms.TextBox
        Me.LoadYBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.LoadTestButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.wordListFileTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PassXBox = New System.Windows.Forms.TextBox
        Me.PassYBox = New System.Windows.Forms.TextBox
        Me.EncTextXBox = New System.Windows.Forms.TextBox
        Me.EncTextYBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PassTestButton = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.EncTestButton = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DelayBox = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoadXBox
        '
        Me.LoadXBox.Location = New System.Drawing.Point(100, 29)
        Me.LoadXBox.Name = "LoadXBox"
        Me.LoadXBox.Size = New System.Drawing.Size(100, 22)
        Me.LoadXBox.TabIndex = 1
        '
        'LoadYBox
        '
        Me.LoadYBox.Location = New System.Drawing.Point(100, 57)
        Me.LoadYBox.Name = "LoadYBox"
        Me.LoadYBox.Size = New System.Drawing.Size(100, 22)
        Me.LoadYBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LoadTestButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LoadYBox)
        Me.GroupBox1.Controls.Add(Me.LoadXBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 126)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Load Image Button Location"
        '
        'LoadTestButton
        '
        Me.LoadTestButton.Location = New System.Drawing.Point(68, 85)
        Me.LoadTestButton.Name = "LoadTestButton"
        Me.LoadTestButton.Size = New System.Drawing.Size(75, 32)
        Me.LoadTestButton.TabIndex = 3
        Me.LoadTestButton.Text = "Test"
        Me.LoadTestButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Y location:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "X location:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(14, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 42)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Crack!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'wordListFileTextBox
        '
        Me.wordListFileTextBox.Location = New System.Drawing.Point(91, 9)
        Me.wordListFileTextBox.Name = "wordListFileTextBox"
        Me.wordListFileTextBox.Size = New System.Drawing.Size(363, 22)
        Me.wordListFileTextBox.TabIndex = 0
        Me.wordListFileTextBox.Text = "Enter wordlist here with path/filename"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Wordlist:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(126, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 42)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Stop!"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Trying:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(94, 27)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 100
        Me.Label5.Text = "Number:"
        '
        'PassXBox
        '
        Me.PassXBox.Location = New System.Drawing.Point(102, 29)
        Me.PassXBox.Name = "PassXBox"
        Me.PassXBox.Size = New System.Drawing.Size(100, 22)
        Me.PassXBox.TabIndex = 4
        '
        'PassYBox
        '
        Me.PassYBox.Location = New System.Drawing.Point(102, 57)
        Me.PassYBox.Name = "PassYBox"
        Me.PassYBox.Size = New System.Drawing.Size(100, 22)
        Me.PassYBox.TabIndex = 5
        '
        'EncTextXBox
        '
        Me.EncTextXBox.Location = New System.Drawing.Point(97, 26)
        Me.EncTextXBox.Name = "EncTextXBox"
        Me.EncTextXBox.Size = New System.Drawing.Size(100, 22)
        Me.EncTextXBox.TabIndex = 7
        '
        'EncTextYBox
        '
        Me.EncTextYBox.Location = New System.Drawing.Point(97, 54)
        Me.EncTextYBox.Name = "EncTextYBox"
        Me.EncTextYBox.Size = New System.Drawing.Size(100, 22)
        Me.EncTextYBox.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "X location:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Y location:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "X location:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Y location:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PassTestButton)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.PassYBox)
        Me.GroupBox2.Controls.Add(Me.PassXBox)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 126)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Password Text Box Location"
        '
        'PassTestButton
        '
        Me.PassTestButton.Location = New System.Drawing.Point(70, 85)
        Me.PassTestButton.Name = "PassTestButton"
        Me.PassTestButton.Size = New System.Drawing.Size(75, 32)
        Me.PassTestButton.TabIndex = 6
        Me.PassTestButton.Text = "Test"
        Me.PassTestButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.EncTestButton)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.EncTextYBox)
        Me.GroupBox3.Controls.Add(Me.EncTextXBox)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 178)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 124)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Encrypted Text Box Location"
        '
        'EncTestButton
        '
        Me.EncTestButton.Location = New System.Drawing.Point(66, 86)
        Me.EncTestButton.Name = "EncTestButton"
        Me.EncTestButton.Size = New System.Drawing.Size(75, 32)
        Me.EncTestButton.TabIndex = 9
        Me.EncTestButton.Text = "Test"
        Me.EncTestButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.ProgressBar1)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Location = New System.Drawing.Point(240, 178)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 124)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cracking Progress"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Progress:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(95, 86)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 100
        '
        'DelayBox
        '
        Me.DelayBox.Location = New System.Drawing.Point(354, 310)
        Me.DelayBox.Name = "DelayBox"
        Me.DelayBox.Size = New System.Drawing.Size(68, 22)
        Me.DelayBox.TabIndex = 10
        Me.DelayBox.Text = "500"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(252, 313)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 17)
        Me.Label11.TabIndex = 100
        Me.Label11.Text = "Action delays:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(242, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(212, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Faster computers use less delay"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(428, 313)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 17)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "ms"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 364)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DelayBox)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.wordListFileTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "CameraShyCracker"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoadXBox As System.Windows.Forms.TextBox
    Friend WithEvents LoadYBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents wordListFileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PassXBox As System.Windows.Forms.TextBox
    Friend WithEvents PassYBox As System.Windows.Forms.TextBox
    Friend WithEvents EncTextXBox As System.Windows.Forms.TextBox
    Friend WithEvents EncTextYBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LoadTestButton As System.Windows.Forms.Button
    Friend WithEvents PassTestButton As System.Windows.Forms.Button
    Friend WithEvents EncTestButton As System.Windows.Forms.Button
    Friend WithEvents DelayBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
