Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim result As Double = num1 + num2

        lblResult.Text = "Result: " & result.ToString()

    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim result As Double = num1 - num2

        lblResult.Text = "Result: " & result.ToString()

    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim result As Double = num1 * num2

        lblResult.Text = "Result: " & result.ToString()

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim num1 As Double = CDbl(txtNum1.Text)
        Dim num2 As Double = CDbl(txtNum2.Text)
        Dim result As Double = num1 / num2

        lblResult.Text = "Result: " & result.ToString()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtNum1.Clear()
        txtNum2.Clear()
        lblResult.Text = "Enter Numbers To see Result"
    End Sub
End Class