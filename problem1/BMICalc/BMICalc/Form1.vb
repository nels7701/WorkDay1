Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click
        Dim hst As String
        Dim wst As String

        hst = txtHeight.Text
        wst = txtWeight.Text
        Dim h, w, bmi As Double
        h = CDbl(hst)
        w = CDbl(wst)
        bmi = (h * 703) / w ^ 2
        Dim bmitext As String
        TextBox1.Text = CStr(bmi)
        





    End Sub
End Class
