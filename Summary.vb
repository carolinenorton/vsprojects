Public Class Summary
    Dim Messagestring As String

    Private Sub Summary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.lbBurger.SelectedIndex <> -1 Then
            lbSummary.Items.Add(Form1.lbBurger.SelectedItem)
        End If
        If Form1.lbChicken.SelectedIndex <> -1 Then
            lbSummary.Items.Add(Form1.lbChicken.SelectedItem)
        End If
        If Form1.lbSalad.SelectedIndex <> -1 Then
            lbSummary.Items.Add(Form1.lbSalad.SelectedItem)
        End If
        If Form1.lbSweets.SelectedIndex <> -1 Then
            lbSummary.Items.Add(Form1.lbSweets.SelectedItem)
        End If
        lbSummary.Refresh()


    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click

        Messagestring = "End of order it costs" + Str(Form1.totalcost)
        MsgBox(Messagestring)
        Me.Close()
    End Sub


End Class