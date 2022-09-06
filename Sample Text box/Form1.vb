Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim SampleName As String
        SampleName = typeTextHere.Text

        MsgBox("You're Name " & SampleName & ".")


    End Sub
End Class
