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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoRock = New System.Windows.Forms.RadioButton()
        Me.rdoPaper = New System.Windows.Forms.RadioButton()
        Me.rdoScissors = New System.Windows.Forms.RadioButton()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblUserChoice = New System.Windows.Forms.Label()
        Me.lblHumanScore = New System.Windows.Forms.Label()
        Me.lblCompScore = New System.Windows.Forms.Label()
        Me.lblPlayerScore = New System.Windows.Forms.Label()
        Me.lblComputerScore = New System.Windows.Forms.Label()
        Me.btnPlayIf = New System.Windows.Forms.Button()
        Me.lblCompChoice = New System.Windows.Forms.Label()
        Me.lblHumanChoice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(80, 113)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(123, 67)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play Select Case"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Old English Text MT", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rock...Paper... Scissors!!"
        '
        'rdoRock
        '
        Me.rdoRock.AutoSize = True
        Me.rdoRock.Font = New System.Drawing.Font("Old English Text MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoRock.Location = New System.Drawing.Point(80, 78)
        Me.rdoRock.Name = "rdoRock"
        Me.rdoRock.Size = New System.Drawing.Size(67, 27)
        Me.rdoRock.TabIndex = 2
        Me.rdoRock.TabStop = True
        Me.rdoRock.Text = "Rock"
        Me.rdoRock.UseVisualStyleBackColor = True
        '
        'rdoPaper
        '
        Me.rdoPaper.AutoSize = True
        Me.rdoPaper.Font = New System.Drawing.Font("Old English Text MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPaper.Location = New System.Drawing.Point(207, 78)
        Me.rdoPaper.Name = "rdoPaper"
        Me.rdoPaper.Size = New System.Drawing.Size(75, 27)
        Me.rdoPaper.TabIndex = 3
        Me.rdoPaper.TabStop = True
        Me.rdoPaper.Text = "Paper"
        Me.rdoPaper.UseVisualStyleBackColor = True
        '
        'rdoScissors
        '
        Me.rdoScissors.AutoSize = True
        Me.rdoScissors.Font = New System.Drawing.Font("Old English Text MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoScissors.Location = New System.Drawing.Point(327, 78)
        Me.rdoScissors.Name = "rdoScissors"
        Me.rdoScissors.Size = New System.Drawing.Size(95, 27)
        Me.rdoScissors.TabIndex = 4
        Me.rdoScissors.TabStop = True
        Me.rdoScissors.Text = "Scissors"
        Me.rdoScissors.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(76, 223)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 24)
        Me.lblResult.TabIndex = 5
        '
        'lblUserChoice
        '
        Me.lblUserChoice.AutoSize = True
        Me.lblUserChoice.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserChoice.Location = New System.Drawing.Point(76, 183)
        Me.lblUserChoice.Name = "lblUserChoice"
        Me.lblUserChoice.Size = New System.Drawing.Size(0, 24)
        Me.lblUserChoice.TabIndex = 6
        '
        'lblHumanScore
        '
        Me.lblHumanScore.AutoSize = True
        Me.lblHumanScore.Location = New System.Drawing.Point(189, 259)
        Me.lblHumanScore.Name = "lblHumanScore"
        Me.lblHumanScore.Size = New System.Drawing.Size(0, 13)
        Me.lblHumanScore.TabIndex = 7
        '
        'lblCompScore
        '
        Me.lblCompScore.AutoSize = True
        Me.lblCompScore.Location = New System.Drawing.Point(273, 259)
        Me.lblCompScore.Name = "lblCompScore"
        Me.lblCompScore.Size = New System.Drawing.Size(0, 13)
        Me.lblCompScore.TabIndex = 8
        '
        'lblPlayerScore
        '
        Me.lblPlayerScore.AutoSize = True
        Me.lblPlayerScore.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerScore.Location = New System.Drawing.Point(113, 311)
        Me.lblPlayerScore.Name = "lblPlayerScore"
        Me.lblPlayerScore.Size = New System.Drawing.Size(118, 24)
        Me.lblPlayerScore.TabIndex = 9
        Me.lblPlayerScore.Text = "Player Score"
        '
        'lblComputerScore
        '
        Me.lblComputerScore.AutoSize = True
        Me.lblComputerScore.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerScore.Location = New System.Drawing.Point(243, 311)
        Me.lblComputerScore.Name = "lblComputerScore"
        Me.lblComputerScore.Size = New System.Drawing.Size(139, 24)
        Me.lblComputerScore.TabIndex = 10
        Me.lblComputerScore.Text = "Computer Score"
        '
        'btnPlayIf
        '
        Me.btnPlayIf.Font = New System.Drawing.Font("Old English Text MT", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlayIf.Location = New System.Drawing.Point(465, 113)
        Me.btnPlayIf.Name = "btnPlayIf"
        Me.btnPlayIf.Size = New System.Drawing.Size(125, 67)
        Me.btnPlayIf.TabIndex = 11
        Me.btnPlayIf.Text = "Play IfThenElseIf"
        Me.btnPlayIf.UseVisualStyleBackColor = True
        '
        'lblCompChoice
        '
        Me.lblCompChoice.AutoSize = True
        Me.lblCompChoice.Font = New System.Drawing.Font("Old English Text MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompChoice.Location = New System.Drawing.Point(442, 328)
        Me.lblCompChoice.Name = "lblCompChoice"
        Me.lblCompChoice.Size = New System.Drawing.Size(0, 20)
        Me.lblCompChoice.TabIndex = 12
        '
        'lblHumanChoice
        '
        Me.lblHumanChoice.AutoSize = True
        Me.lblHumanChoice.Font = New System.Drawing.Font("Old English Text MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumanChoice.Location = New System.Drawing.Point(552, 329)
        Me.lblHumanChoice.Name = "lblHumanChoice"
        Me.lblHumanChoice.Size = New System.Drawing.Size(0, 20)
        Me.lblHumanChoice.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Old English Text MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(386, 259)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Computer Choice"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Old English Text MT", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(525, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Human Choice"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 351)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHumanChoice)
        Me.Controls.Add(Me.lblCompChoice)
        Me.Controls.Add(Me.btnPlayIf)
        Me.Controls.Add(Me.lblComputerScore)
        Me.Controls.Add(Me.lblPlayerScore)
        Me.Controls.Add(Me.lblCompScore)
        Me.Controls.Add(Me.lblHumanScore)
        Me.Controls.Add(Me.lblUserChoice)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.rdoScissors)
        Me.Controls.Add(Me.rdoPaper)
        Me.Controls.Add(Me.rdoRock)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoRock As System.Windows.Forms.RadioButton
    Friend WithEvents rdoPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rdoScissors As System.Windows.Forms.RadioButton
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblUserChoice As System.Windows.Forms.Label
    Friend WithEvents lblHumanScore As System.Windows.Forms.Label
    Friend WithEvents lblCompScore As System.Windows.Forms.Label
    Friend WithEvents lblPlayerScore As System.Windows.Forms.Label
    Friend WithEvents lblComputerScore As System.Windows.Forms.Label
    Friend WithEvents btnPlayIf As System.Windows.Forms.Button
    Friend WithEvents lblCompChoice As System.Windows.Forms.Label
    Friend WithEvents lblHumanChoice As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
