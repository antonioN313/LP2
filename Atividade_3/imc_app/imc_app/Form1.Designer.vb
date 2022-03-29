<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim lblPeso As System.Windows.Forms.Label
        Me.lblAltura = New System.Windows.Forms.Label()
        Me.lblIMC = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.mskbxPeso = New System.Windows.Forms.MaskedTextBox()
        Me.mskbxAltura = New System.Windows.Forms.MaskedTextBox()
        Me.txtIMC = New System.Windows.Forms.TextBox()
        lblPeso = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPeso
        '
        lblPeso.AutoSize = True
        lblPeso.Location = New System.Drawing.Point(47, 69)
        lblPeso.Name = "lblPeso"
        lblPeso.Size = New System.Drawing.Size(31, 13)
        lblPeso.TabIndex = 0
        lblPeso.Text = "Peso"
        '
        'lblAltura
        '
        Me.lblAltura.AutoSize = True
        Me.lblAltura.Location = New System.Drawing.Point(47, 114)
        Me.lblAltura.Name = "lblAltura"
        Me.lblAltura.Size = New System.Drawing.Size(34, 13)
        Me.lblAltura.TabIndex = 1
        Me.lblAltura.Text = "Altura"
        '
        'lblIMC
        '
        Me.lblIMC.AutoSize = True
        Me.lblIMC.Location = New System.Drawing.Point(47, 160)
        Me.lblIMC.Name = "lblIMC"
        Me.lblIMC.Size = New System.Drawing.Size(26, 13)
        Me.lblIMC.TabIndex = 2
        Me.lblIMC.Text = "IMC"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(114, 214)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(213, 214)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'mskbxPeso
        '
        Me.mskbxPeso.Location = New System.Drawing.Point(136, 69)
        Me.mskbxPeso.Mask = "900.00"
        Me.mskbxPeso.Name = "mskbxPeso"
        Me.mskbxPeso.Size = New System.Drawing.Size(152, 20)
        Me.mskbxPeso.TabIndex = 8
        '
        'mskbxAltura
        '
        Me.mskbxAltura.Location = New System.Drawing.Point(136, 114)
        Me.mskbxAltura.Mask = "0.00"
        Me.mskbxAltura.Name = "mskbxAltura"
        Me.mskbxAltura.Size = New System.Drawing.Size(152, 20)
        Me.mskbxAltura.TabIndex = 9
        '
        'txtIMC
        '
        Me.txtIMC.Location = New System.Drawing.Point(136, 160)
        Me.txtIMC.Name = "txtIMC"
        Me.txtIMC.Size = New System.Drawing.Size(152, 20)
        Me.txtIMC.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 342)
        Me.Controls.Add(Me.txtIMC)
        Me.Controls.Add(Me.mskbxAltura)
        Me.Controls.Add(Me.mskbxPeso)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblIMC)
        Me.Controls.Add(Me.lblAltura)
        Me.Controls.Add(lblPeso)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAltura As System.Windows.Forms.Label
    Friend WithEvents lblIMC As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents mskbxPeso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskbxAltura As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtIMC As System.Windows.Forms.TextBox

End Class
