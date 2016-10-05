Public Class Form1
    Dim chosen As Integer
    Public Shared price As Decimal
    Public Shared totalcost As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Today

        chosen = lbSweets.SelectedIndex
        lbsweetprice.SelectedIndex = chosen
        price = lbsweetprice.SelectedItem
        totalcost = totalcost + price

        chosen = lbBurger.SelectedIndex
        lbburgerprice.SelectedIndex = chosen
        price = lbburgerprice.SelectedItem
        totalcost = totalcost + price

        chosen = lbChicken.SelectedIndex
        lbchickenprice.SelectedIndex = chosen
        price = lbchickenprice.SelectedItem
        totalcost = totalcost + price

        chosen = lbSalad.SelectedIndex
        lbsaladprice.SelectedIndex = chosen
        price = lbsaladprice.SelectedItem
        totalcost = totalcost + price

        MsgBox(totalcost)
        Summary.Show()
    End Sub

    Private Sub btnSalad_Click(sender As Object, e As EventArgs) Handles btnSalad.Click
        lbBurger.Hide()
        lbChicken.Hide()
        lbSweets.Hide()
        lbSalad.Show()

    End Sub

    Private Sub btnBurger_Click(sender As Object, e As EventArgs) Handles btnBurger.Click
        lbBurger.Show()
        lbChicken.Hide()
        lbSweets.Hide()
        lbSalad.Hide()
    End Sub

    Private Sub btnChicken_Click(sender As Object, e As EventArgs) Handles btnChicken.Click
        lbBurger.Hide()
        lbChicken.Show()
        lbSweets.Hide()
        lbSalad.Hide()
    End Sub

    Private Sub btnSweets_Click(sender As Object, e As EventArgs) Handles btnSweets.Click
        lbBurger.Hide()
        lbChicken.Hide()
        lbSweets.Show()
        lbSalad.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbBurger.Hide()
        lbChicken.Hide()
        lbSweets.Hide()
        lbSalad.Hide()
    End Sub
End Class
