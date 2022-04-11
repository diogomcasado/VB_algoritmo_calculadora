<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Algoritmo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNumero = New System.Windows.Forms.TextBox()
        Me.ButtonAdicionar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox0a25 = New System.Windows.Forms.TextBox()
        Me.TextBox26a50 = New System.Windows.Forms.TextBox()
        Me.TextBox51a75 = New System.Windows.Forms.TextBox()
        Me.TextBox76a100 = New System.Windows.Forms.TextBox()
        Me.ButtonLimpar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 98)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Processar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(41, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insira valor entre 0 e 100:"
        '
        'TextBoxNumero
        '
        Me.TextBoxNumero.Location = New System.Drawing.Point(221, 56)
        Me.TextBoxNumero.Name = "TextBoxNumero"
        Me.TextBoxNumero.Size = New System.Drawing.Size(40, 23)
        Me.TextBoxNumero.TabIndex = 2
        '
        'ButtonAdicionar
        '
        Me.ButtonAdicionar.Location = New System.Drawing.Point(289, 52)
        Me.ButtonAdicionar.Name = "ButtonAdicionar"
        Me.ButtonAdicionar.Size = New System.Drawing.Size(87, 29)
        Me.ButtonAdicionar.TabIndex = 3
        Me.ButtonAdicionar.Text = "Adicionar"
        Me.ButtonAdicionar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(40, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero de valores entre 0 e 25:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(40, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Numero de valores entre 26 e 50:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(40, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Numero de valores entre 51 a 75:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(40, 232)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(236, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Numero de valores entre 76 a 100:"
        '
        'TextBox0a25
        '
        Me.TextBox0a25.Location = New System.Drawing.Point(282, 142)
        Me.TextBox0a25.Name = "TextBox0a25"
        Me.TextBox0a25.ReadOnly = True
        Me.TextBox0a25.Size = New System.Drawing.Size(41, 23)
        Me.TextBox0a25.TabIndex = 8
        '
        'TextBox26a50
        '
        Me.TextBox26a50.Location = New System.Drawing.Point(282, 171)
        Me.TextBox26a50.Name = "TextBox26a50"
        Me.TextBox26a50.ReadOnly = True
        Me.TextBox26a50.Size = New System.Drawing.Size(41, 23)
        Me.TextBox26a50.TabIndex = 9
        '
        'TextBox51a75
        '
        Me.TextBox51a75.Location = New System.Drawing.Point(282, 200)
        Me.TextBox51a75.Name = "TextBox51a75"
        Me.TextBox51a75.ReadOnly = True
        Me.TextBox51a75.Size = New System.Drawing.Size(41, 23)
        Me.TextBox51a75.TabIndex = 10
        '
        'TextBox76a100
        '
        Me.TextBox76a100.Location = New System.Drawing.Point(282, 229)
        Me.TextBox76a100.Name = "TextBox76a100"
        Me.TextBox76a100.ReadOnly = True
        Me.TextBox76a100.Size = New System.Drawing.Size(41, 23)
        Me.TextBox76a100.TabIndex = 11
        '
        'ButtonLimpar
        '
        Me.ButtonLimpar.Location = New System.Drawing.Point(289, 98)
        Me.ButtonLimpar.Name = "ButtonLimpar"
        Me.ButtonLimpar.Size = New System.Drawing.Size(87, 29)
        Me.ButtonLimpar.TabIndex = 12
        Me.ButtonLimpar.Text = "Limpar"
        Me.ButtonLimpar.UseVisualStyleBackColor = True
        '
        'Algoritmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 280)
        Me.Controls.Add(Me.ButtonLimpar)
        Me.Controls.Add(Me.TextBox76a100)
        Me.Controls.Add(Me.TextBox51a75)
        Me.Controls.Add(Me.TextBox26a50)
        Me.Controls.Add(Me.TextBox0a25)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAdicionar)
        Me.Controls.Add(Me.TextBoxNumero)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Algoritmo"
        Me.Text = "Algoritmo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumero As TextBox
    Friend WithEvents ButtonAdicionar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox0a25 As TextBox
    Friend WithEvents TextBox26a50 As TextBox
    Friend WithEvents TextBox51a75 As TextBox
    Friend WithEvents TextBox76a100 As TextBox
    Friend WithEvents ButtonLimpar As Button
End Class
