Public Class Fastfood
    Dim preco_mFina As Integer = 8
    Dim preco_mMedia As Integer = 9
    Dim preco_mGrossa As Integer = 10
    Dim preco_bacon As Integer = 1
    Dim preco_fiambre As Integer = 1
    Dim preco_azeitona As Integer = 1
    Dim preco_cogumelo As Integer = 1
    Dim preco_cebola As Integer = 1
    Dim preco_camarao As Integer = 1
    Dim preco_milho As Integer = 1

    Dim preco_coca As Integer = 2
    Dim preco_pepsi As Integer = 2
    Dim preco_sprite As Integer = 2
    Dim preco_ice_limao As Integer = 2
    Dim preco_ice_pessego As Integer = 2
    Dim preco_fanta As Integer = 2
    Dim preco_agua As Integer = 2

    Dim valor_total As Integer = 0

    Sub Add_to_list(ByVal produto As String, ByVal preco As Integer)
        Dim arr As String() = New String(3) {}
        Dim itm As ListViewItem
        'add items to ListView
        arr(0) = produto
        arr(1) = preco
        itm = New ListViewItem(arr)
        ListView1.Items.Add(itm)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If valor_total = 0 Then
            MessageBox.Show("Pedido invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Me.Close()
            MessageBox.Show("O seu pedido foi efetuado", "Pedido efetuado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox2.SelectedItem = "" Then
            MessageBox.Show("Valor invalido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Select Case ComboBox2.SelectedItem
                Case "Coca-Cola Zero"
                    Add_to_list(ComboBox2.SelectedItem, preco_coca)
                    valor_total = valor_total + preco_coca
                Case "Pepsi"
                    Add_to_list(ComboBox2.SelectedItem, preco_pepsi)
                    valor_total = valor_total + preco_pepsi
                Case "Sprite"
                    Add_to_list(ComboBox2.SelectedItem, preco_sprite)
                    valor_total = valor_total + preco_sprite
                Case "Ice Tea Limão"
                    Add_to_list(ComboBox2.SelectedItem, preco_ice_limao)
                    valor_total = valor_total + preco_ice_limao
                Case "Ice Tea Pessego"
                    Add_to_list(ComboBox2.SelectedItem, preco_ice_pessego)
                    valor_total = valor_total + preco_ice_pessego
                Case "Fanta"
                    Add_to_list(ComboBox2.SelectedItem, preco_fanta)
                    valor_total = valor_total + preco_fanta
                Case "Água"
                    Add_to_list(ComboBox2.SelectedItem, preco_agua)
                    valor_total = valor_total + preco_agua
            End Select

            Label6.Text = valor_total

        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListView1.Items.Clear()
        valor_total = 0
        Label6.Text = valor_total

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pizza As String
        Dim preco As Integer
        If Not (RadioButton1.Checked Or RadioButton2.Checked Or RadioButton3.Checked) Then
            MessageBox.Show("Selecione o tipo de massa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Not (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Or CheckBox4.Checked Or CheckBox5.Checked Or CheckBox6.Checked Or CheckBox7.Checked) Then
            MessageBox.Show("Selecione no minimo um ingrediente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If RadioButton1.Checked Then
                Add_to_list(RadioButton1.Text, 123)
                pizza = RadioButton1.Text
                preco = preco_mFina
                valor_total = valor_total + preco_mFina

            ElseIf RadioButton2.Checked Then
                Add_to_list(RadioButton2.Text, 123)
                pizza = RadioButton2.Text
                preco = preco_mMedia
                valor_total = valor_total + preco_mMedia

            ElseIf RadioButton3.Checked Then
                Add_to_list(RadioButton3.Text, 123)
                pizza = RadioButton3.Text
                preco = preco_mGrossa
                valor_total = valor_total + preco_mGrossa
            End If

            If CheckBox1.Checked Then
                pizza = pizza + ", " + CheckBox1.Text
                preco = preco + preco_bacon
                valor_total = valor_total + preco_bacon
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If

            If CheckBox2.Checked Then
                pizza = pizza + ", " + CheckBox2.Text
                preco = preco + preco_fiambre
                valor_total = valor_total + preco_fiambre
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If
            If CheckBox3.Checked Then
                pizza = pizza + ", " + CheckBox3.Text
                preco = preco + preco_azeitona
                valor_total = valor_total + preco_azeitona
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If
            If CheckBox4.Checked Then
                pizza = pizza + ", " + CheckBox4.Text
                preco = preco + preco_cogumelo
                valor_total = valor_total + preco_cogumelo
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If
            If CheckBox5.Checked Then
                pizza = pizza + ", " + CheckBox5.Text
                preco = preco + preco_cebola
                valor_total = valor_total + preco_cebola
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If
            If CheckBox6.Checked Then
                pizza = pizza + ", " + CheckBox6.Text
                preco = preco + preco_camarao
                valor_total = valor_total + preco_camarao
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If
            If CheckBox7.Checked Then
                pizza = pizza + ", " + CheckBox7.Text
                preco = preco + preco_milho
                valor_total = valor_total + preco_milho
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                Add_to_list(pizza, preco)
            End If

            Label6.Text = valor_total


        End If

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        'ListView1.Items.Remove(ListView1.Items(ListView1.FocusedItem.Index))
    End Sub

    Private Sub Fastfood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Columns(0).Width = 350
        ListView1.Columns(1).Width = 50
    End Sub
End Class

