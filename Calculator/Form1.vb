Public Class Form1
    Dim Operand1 As Int64
    Dim Operand2 As Int64
    Dim op As String
    Dim Ans As Int64
    Private Sub CmdON_Click(sender As Object, e As EventArgs) Handles CmdON.Click

    End Sub

    Private Sub CmdOne_Click(sender As Object, e As EventArgs) Handles CmdOne.Click
        TxtDisplay.AppendText(1)
    End Sub

    Private Sub CmdTwo_Click(sender As Object, e As EventArgs) Handles CmdTwo.Click
        TxtDisplay.AppendText(2)
    End Sub

    Private Sub CmdThree_Click(sender As Object, e As EventArgs) Handles CmdThree.Click
        TxtDisplay.AppendText(3)
    End Sub

    Private Sub CmdFour_Click(sender As Object, e As EventArgs) Handles CmdFour.Click
        TxtDisplay.AppendText(4)
    End Sub

    Private Sub CmdFive_Click(sender As Object, e As EventArgs) Handles CmdFive.Click
        TxtDisplay.AppendText(5)
    End Sub

    Private Sub CmdSix_Click(sender As Object, e As EventArgs) Handles CmdSix.Click
        TxtDisplay.AppendText(6)
    End Sub

    Private Sub Cmd7_Click(sender As Object, e As EventArgs) Handles Cmd7.Click
        TxtDisplay.AppendText(7)
    End Sub

    Private Sub CmdEight_Click(sender As Object, e As EventArgs) Handles CmdEight.Click
        TxtDisplay.AppendText(8)
    End Sub

    Private Sub CmdNine_Click(sender As Object, e As EventArgs) Handles CmdNine.Click
        TxtDisplay.AppendText(9)
    End Sub

    Private Sub CmdZero_Click(sender As Object, e As EventArgs) Handles CmdZero.Click
        TxtDisplay.AppendText(0)
    End Sub

    Private Sub CmdDEL_Click(sender As Object, e As EventArgs) Handles CmdDEL.Click

    End Sub

    Private Sub CmdAC_Click(sender As Object, e As EventArgs) Handles CmdAC.Click
        TxtDisplay.Text = ""
    End Sub

    Private Sub CmdMultiply_Click(sender As Object, e As EventArgs) Handles CmdMultiply.Click
        Operand1 = TxtDisplay.Text
        op = "x"
        TxtDisplay.Text = ""
    End Sub

    Private Sub CmdDivide_Click(sender As Object, e As EventArgs) Handles CmdDivide.Click
        Operand1 = TxtDisplay.Text
        op = "/"
        TxtDisplay.Text = ""
    End Sub

    Private Sub CmdPlus_Click(sender As Object, e As EventArgs) Handles CmdPlus.Click
        Operand1 = TxtDisplay.Text
        op = "+"
        TxtDisplay.Text = ""
    End Sub

    Private Sub CmdMinus_Click(sender As Object, e As EventArgs) Handles CmdMinus.Click
        Operand1 = TxtDisplay.Text
        op = "-"
        TxtDisplay.Text = ""
    End Sub

    Private Sub CmdANS_Click(sender As Object, e As EventArgs) Handles CmdANS.Click
        TxtDisplay.AppendText(Ans)
    End Sub

    Private Sub CmdEquals_Click(sender As Object, e As EventArgs) Handles CmdEquals.Click
        Operand2 = TxtDisplay.Text
        If op = "x" Then
            Ans = Operand1 * Operand2
        ElseIf op = "/" Then
            Ans = Operand1 / Operand2
        ElseIf op = "+" Then
            Ans = Operand1 + Operand2
        ElseIf op = "-" Then
            Ans = Operand1 - Operand2
        End If
        TxtDisplay.Text = Ans
    End Sub

    Private Sub TxtDisplay_TextChanged(sender As Object, e As EventArgs) Handles TxtDisplay.TextChanged

    End Sub
End Class
