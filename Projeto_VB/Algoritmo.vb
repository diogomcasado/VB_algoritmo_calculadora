Public Class Algoritmo
    Dim valores As New ArrayList

    Dim Int0a25 As Integer = 0
    Dim Int25a50 As Integer = 0
    Dim Int50a75 As Integer = 0
    Dim Int75a100 As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonAdicionar.Click
        If IsNumeric(TextBoxNumero.Text) Then
            If TextBoxNumero.Text > 100 Or TextBoxNumero.Text < 0 Then
                MessageBox.Show("Valor inválido. Insira um valor entre 0 e 100 inclusive.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                valores.Add(TextBoxNumero.Text)
            End If
        Else
            MessageBox.Show("Valor invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        TextBoxNumero.ResetText()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Int0a25 = 0
        Int25a50 = 0
        Int50a75 = 0
        Int75a100 = 0

        For i As Integer = 0 To valores.Count - 1
            If valores(i) < 25 Then
                Int0a25 += 1
                Continue For
            ElseIf valores(i) < 50 Then
                Int25a50 += 1
                Continue For
            ElseIf valores(i) < 75 Then
                Int50a75 += 1
                Continue For
            ElseIf valores(i) < 100 Then
                Int75a100 += 1
                Continue For
            End If
        Next

        TextBox0a25.Text = Int0a25
        TextBox26a50.Text = Int25a50
        TextBox51a75.Text = Int50a75
        TextBox76a100.Text = Int75a100


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles ButtonLimpar.Click

        TextBox0a25.ResetText()
        TextBox26a50.ResetText()
        TextBox51a75.ResetText()
        TextBox76a100.ResetText()

        valores.Clear()
    End Sub
End Class