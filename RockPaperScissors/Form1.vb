Public Class Form1
    Dim intCompScore As Integer = 0
    Dim intHumanScore As Integer = 0

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case Me.rdoRock.Checked
            Case True
                Me.lblUserChoice.Text = "Rock"
                Select Case intCompThrow
                    Case 1
                        Me.lblResult.Text = "Tie..."
                    Case 2
                        Me.lblResult.Text = "Paper beats rock. Computer wins!"
                        Me.intCompScore += 1
                    Case 3
                        Me.lblResult.Text = "Rock beats scissors. Player Wins!!"
                        Me.intHumanScore += 1
                End Select
        End Select

        Select Case Me.rdoPaper.Checked
            Case True
                Me.lblUserChoice.Text = "Paper"
                Select Case intCompThrow
                    Case 1
                        Me.lblResult.Text = "Paper beats rock. Player wins!!"
                        Me.intHumanScore += 1
                    Case 2
                        Me.lblResult.Text = "Tie..."
                    Case 3
                        Me.lblResult.Text = "Scissors beats paper. Computer wins!!!"
                        Me.intCompScore += 1
                End Select
        End Select

        Select Case Me.rdoScissors.Checked
            Case True
                Me.lblUserChoice.Text = "Scissors!"
                Select Case intCompThrow
                    Case 1
                        Me.lblResult.Text = "Rock crushes scissors. Computer wins!"
                        Me.intCompScore += 1
                    Case 2
                        Me.lblResult.Text = "Scissors cuts paper. Player wins!!"
                        Me.intHumanScore += 1
                    Case 3
                        Me.lblResult.Text = "Tie..."
                    Case Else
                End Select
        End Select
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
    End Sub

    Private Sub btnPlayIf_Click(sender As Object, e As EventArgs) Handles btnPlayIf.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3

        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intCompThrow = 1 Then
            Me.lblCompChoice.Text = "Rock"
        ElseIf intCompThrow = 2 Then
            Me.lblCompChoice.Text = "Paper"
        ElseIf intCompThrow = 3 Then
            Me.lblCompChoice.Text = "Scissors"
        End If

        If Me.rdoRock.Checked = True Then
            Me.lblHumanChoice.Text = "Rock"
            If intCompThrow = 1 Then
                Me.lblResult.Text = "You tied!"
            ElseIf intCompThrow = 2 Then
                Me.lblResult.Text = "Paper covers rock. Computer wins."
                Me.intCompScore += 1
            ElseIf intCompThrow = 3 Then
                Me.lblResult.Text = "Rock crushes scissors. You win!"
                Me.intHumanScore += 1
            End If
        End If

        If Me.rdoPaper.Checked = True Then
            Me.lblHumanChoice.Text = "Paper"
            If intCompThrow = 1 Then
                Me.lblResult.Text = "Paper covers rock. You win!"
                Me.intHumanScore += 1
            ElseIf intCompThrow = 2 Then
                Me.lblResult.Text = "You tied!"
            ElseIf intCompThrow = 3 Then
                Me.lblResult.Text = "Scissors cuts paper. Computer wins."
                Me.intCompScore += 1
            End If
        End If

        If Me.rdoScissors.Checked = True Then
            Me.lblHumanChoice.Text = "Scissors"
            If intCompThrow = 1 Then
                Me.lblResult.Text = "Rock crushes scissors. Computer wins."
            ElseIf intCompThrow = 2 Then
                Me.intCompScore += 1
                Me.lblResult.Text = "Scissors cuts paper. You win!"
                Me.intHumanScore += 1
            ElseIf intCompThrow = 3 Then
                Me.lblResult.Text = "You tied!"
            End If
        End If
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
    End Sub
End Class
