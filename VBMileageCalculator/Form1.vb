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

        Try 'Add this line to start Try-Catch block
            'Set these values from the UI
            Distance = txtDistance.Text
            Gallons = txtGallons.Text

            'Check for zeroes
            If Distance = 0 Then
                'Cause an Exception to be thrown
                Throw New MyCustomException
            End If

            'Calculate the Mileage
            Mileage = Distance / Gallons

        Catch ex As DivideByZeroException
            'Catch Divide By Zero errors and use the object from
            'Microsoft's DivideByZeroException Class to show a Message
            'MessageBox.Show(Mileage.ToString, "Answer")
            MessageBox.Show(ex.Message)

        Catch ex As MyCustomException
            'Catch all MyCustomException errors,
            'Use the Object to show a custom error message
            MessageBox.Show(ex.Message)

        Catch
            'Catch any other type of Exception
            MessageBox.Show("There was an error")

        Finally
            'Put code here that you always want to run
            MessageBox.Show("Inside Finally")

        End Try

        MessageBox.Show(Mileage.ToString, "Answer")

    End Sub
End Class
