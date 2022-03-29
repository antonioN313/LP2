Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Double imc,altura,peso;
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        This.close()

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

    End Sub

    Private Sub mskbxAltura_Validated(sender As Object, e As EventArgs) Handles mskbxAltura.Validated
        If (mskbxAltura > 2.8) Then

        End If
    End Sub
End Class
