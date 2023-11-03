Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' -- declare the variables
        Dim inumber1 As Integer
        Dim inumber2 As Integer
        Dim ians As Integer

        '-- assign textbox values to variables (Input)
        inumber1 = txtNumber1.Text
        inumber2 = txtNumber2.Text

        '-- prcess
        ians = inumber1 + inumber2

        '--assign result in inas to txtAnswer (Output)
        txtAnswer.Text = ians

    End Sub
End Class
