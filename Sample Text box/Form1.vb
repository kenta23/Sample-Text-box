Public Class Form1

    Dim firstNum, SecondNum, sum, diff, product, quotient As Double


    Private Sub btnMultiplication_Click(sender As Object, e As EventArgs) Handles btnMultiplication.Click
        firstNum = txtFirstNum.Text  'initialize the first Text box
        SecondNum = txtSecondNum.Text 'initialize the second text box

        product = 0
        product = firstNum + SecondNum  'perform the operation of the two variables

        lblResult.Text = lblResult.Text & "" & product
        lblResult.Text = "The product is: " & product


    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        firstNum = txtFirstNum.Text  'initialize the first Text box
        SecondNum = txtSecondNum.Text 'initialize the second text box
        quotient = 0
        quotient = firstNum / SecondNum  'perform the operation of the two variables

        lblResult.Text = lblResult.Text & "" & quotient
        lblResult.Text = "The quotient is: " & quotient
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnAddition.Click
        firstNum = txtFirstNum.Text  'initialize the first Text box
        SecondNum = txtSecondNum.Text 'initialize the second text box
        sum = 0
        sum = firstNum + SecondNum  'perform the operation of the two variables

        lblResult.Text = lblResult.Text & "" & sum
        lblResult.Text = "The sum is: " & sum


    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub typeTextHere_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        firstNum = txtFirstNum.Text  'initialize the first Text box
        SecondNum = txtSecondNum.Text 'initialize the second text box
        diff = 0
        diff = firstNum - SecondNum  'perform the operation of the two variables

        lblResult.Text = lblResult.Text & "" & diff  'To reset the result everytime we compute the numbers 
        lblResult.Text = "The difference is " & diff
    End Sub
End Class
