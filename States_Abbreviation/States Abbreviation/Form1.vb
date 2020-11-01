Public Class Form1
    Private Sub lblAbbreviation_Click(sender As Object, e As EventArgs) Handles lableState.Click

    End Sub

    Private Sub btnVirginia_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        ' Display Virginia abbreviation in label
        lblAbbreviation.Text = "VA"
    End Sub

    Private Sub btnNorthCarolina_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        'Display North Carolina abbrevation in label
        lblAbbreviation.Text = "NC"
    End Sub

    Private Sub btnWashington_Click(sender As Object, e As EventArgs) Handles btnWashington.Click
        'Display Washington abbrevaition in label
        lblAbbreviation.Text = "WA"
    End Sub

    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        'Display Georgia abbrevaiton in label
        lblAbbreviation.Text = "GA"
    End Sub

    Private Sub btnAlabama_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        'Display Alabama abbrevation in label
        lblAbbreviation.Text = "AL"
    End Sub

    Private Sub btnFlorida_Click(sender As Object, e As EventArgs) Handles btnFlorida.Click
        'Display Florida abbrevaition in label
        lblAbbreviation.Text = "FL"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub picStates_Click(sender As Object, e As EventArgs) Handles picStates.Click
        MessageBox.Show("Thank you for using our map! Please click the button control to view the State abbreviation.", "Information")
    End Sub
End Class
