Public Class Form1
    Private Sub btnGetMileage_Click(sender As Object, e As EventArgs) Handles btnGetMileage.Click
        'Call the GetAswer() method
        GetAnswer()
        MessageBox.Show("Done")
    End Sub

    'Create a method to calculate mileage
    Public Sub GetAnswer()

        'Create three variables to work with
        Dim Mileage, Distance, Gallons As Decimal

        'Add code to set these values from the UI
        Distance = txtDistance.Text
        Gallons = txtGallons.Text
        Mileage = Distance / Gallons
        MessageBox.Show(Mileage.ToString, "Answer")
    End Sub
End Class
