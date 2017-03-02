Public Class Form1

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim dblGallons As Double = 0
        Dim dblMiles As Double = 0
        Dim dblMilesPerGallon As Double = 0

        Try
            dblGallons = CDbl(txtTotalGallons.Text)
            dblMiles = CDbl(txtTotalMiles.Text)

            ' Calculate the Miles per Gallon
            dblMilesPerGallon = dblMiles / dblGallons

            ' Display the results
            lblMilesPerGallon.Text = dblMilesPerGallon.ToString("n2")
        Catch ex As Exception
            lblStatus.Text = "ERROR: You must enter numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Clear the text boxes, the answer label and the status window for another calculation
        txtTotalGallons.Clear()
        txtTotalMiles.Clear()
        lblMilesPerGallon.Text = String.Empty
        lblStatus.Text = String.Empty

        txtTotalGallons.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
