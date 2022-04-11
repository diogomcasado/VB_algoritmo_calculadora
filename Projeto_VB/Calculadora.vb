Public Class Calculadora

    Dim valor_inicial As Double
    Dim primeiro_operador As Boolean
    Dim operador As Boolean
    Dim operacao As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click
        Dim button = CType(sender, Button)
        If operador Then
            operador = False
            If button.Text.Equals(".") Then
                TextBox1.Text = "0."
            Else
                TextBox1.Text = button.Text
            End If
        Else
            If button.Text.Equals(".") Then
                If Not TextBox1.Text.Contains(".") Then
                    TextBox1.Text += "."
                End If
            Else
                If Not TextBox1.Text.Equals("0") Then
                    TextBox1.Text += button.Text
                Else
                    TextBox1.Text = button.Text
                End If
            End If
        End If
    End Sub
    Private Sub Calculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valor_inicial = 0
        primeiro_operador = True
        operador = False
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = "0"
        valor_inicial = 0
        primeiro_operador = True
        operador = False
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click, Button16.Click, Button14.Click, Button13.Click
        Dim button = CType(sender, Button)
        operador = True
        If primeiro_operador Then
            valor_inicial = Double.Parse(TextBox1.Text)
            primeiro_operador = False
        Else
            Select Case operacao
                Case "+"
                    valor_inicial = valor_inicial + Double.Parse(TextBox1.Text)
                Case "-"
                    valor_inicial = valor_inicial - Double.Parse(TextBox1.Text)
                Case "/"
                    valor_inicial = valor_inicial / Double.Parse(TextBox1.Text)
                Case "X"
                    valor_inicial = valor_inicial * Double.Parse(TextBox1.Text)
            End Select
            TextBox1.Text = valor_inicial.ToString
        End If
        operacao = button.Text
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        operador = True
        primeiro_operador = True
        Select Case operacao
            Case "+"
                valor_inicial = valor_inicial + Double.Parse(TextBox1.Text)
            Case "-"
                valor_inicial = valor_inicial - Double.Parse(TextBox1.Text)
            Case "/"
                valor_inicial = valor_inicial / Double.Parse(TextBox1.Text)
            Case "X"
                valor_inicial = valor_inicial * Double.Parse(TextBox1.Text)
        End Select
        TextBox1.Text = valor_inicial
    End Sub
End Class