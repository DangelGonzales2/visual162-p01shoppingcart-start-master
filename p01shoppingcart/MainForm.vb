Public Class MainForm

    Private categoria As String
    Private nombre_producto As String
    Private cantidad_productoA As Integer = 0
    Private cantidad_productoB As Integer = 0
    Private cantidad_productoC As Integer = 0
    Private cantidad_productoD As Integer = 0
    Private precio_producto_A As Double
    Private precio_producto_B As Double
    Private precio_producto_C As Double
    Private precio_producto_D As Double
    Private cantidad_producto_Total As Integer = 0
    Private precio_categoria As Double = 0
    Private precio_Total As Double = 0



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        categoria = "Hombre"

        Label2.Text = "Camisa de Algodon"
        Label3.Text = "120"
        Label4.Text = "Blazer Mezcla de Lana"
        Label5.Text = "240"
        Label6.Text = "Jersey Cuello Pico"
        Label7.Text = "160"
        Label8.Text = "Polo Cuello Redondo"
        Label9.Text = "70"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        categoria = "Mujeres"
        Label2.Text = "Polo Rayas Cuello Redondo"
        Label3.Text = "80"
        Label4.Text = "Chompa Lana Cuello Redondo"
        Label5.Text = "150"
        Label6.Text = "Casaca de Jean"
        Label7.Text = "220"
        Label8.Text = "Abrigo Mezcla Lana"
        Label9.Text = "270"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        categoria = "calzados"

        Label2.Text = "Zaptaos Oxfords"
        Label3.Text = "120"
        Label4.Text = "Zaptaos Derbey"
        Label5.Text = "140"
        Label6.Text = "Botines"
        Label7.Text = "160"
        Label8.Text = "Loafers"
        Label9.Text = "80"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        categoria = "Accesorios"
        Label2.Text = "Zaptaos Oxfords"
        Label3.Text = "120"
        Label4.Text = "Zaptaos Derbey"
        Label5.Text = "140"
        Label6.Text = "Botines"
        Label7.Text = "160"
        Label8.Text = "Loafers"
        Label9.Text = "80"
    End Sub


    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        If Val(Label10.Text) = 0 Then
            MsgBox("Cantidad Minima")
        ElseIf Val(Label10.Text) >= 0 Then

            cantidad_productoA -= 1
            Label10.Text = cantidad_productoA.ToString
        Else
            MsgBox("Cantidad Minima")
        End If


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If Val(Label10.Text) >= 0 Then
            cantidad_productoA += 1
            Label10.Text = cantidad_productoA.ToString
        ElseIf cantidad_productoA = 0 Then
            MsgBox("Cantidad Minima")

        Else

        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If Val(Label11.Text) = 0 Then
            MsgBox("Cantidad Minima")
        ElseIf Val(Label11.Text) >= 0 Then

            cantidad_productoB -= 1
            Label11.Text = cantidad_productoB.ToString
        Else
            MsgBox("Cantidad Minima")
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If Val(Label11.Text) >= 0 Then
            cantidad_productoB += 1
            Label11.Text = cantidad_productoB.ToString
        ElseIf cantidad_productoB = 0 Then
            MsgBox("Cantidad Minima")

        Else

        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Val(Label12.Text) = 0 Then
            MsgBox("Cantidad Minima")
        ElseIf Val(Label12.Text) >= 0 Then

            cantidad_productoC -= 1
            Label12.Text = cantidad_productoC.ToString
        Else
            MsgBox("Cantidad Minima")
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If Val(Label12.Text) >= 0 Then
            cantidad_productoC += 1
            Label12.Text = cantidad_productoC.ToString
        ElseIf cantidad_productoC = 0 Then
            MsgBox("Cantidad Minima")

        Else

        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If Val(Label13.Text) = 0 Then
            MsgBox("Cantidad Minima")
        ElseIf Val(Label13.Text) >= 0 Then

            cantidad_productoD -= 1
            Label13.Text = cantidad_productoC.ToString
        Else
            MsgBox("Cantidad Minima")
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If Val(Label13.Text) >= 0 Then
            cantidad_productoD += 1
            Label13.Text = cantidad_productoD.ToString
        ElseIf cantidad_productoD = 0 Then
            MsgBox("Cantidad Minima")

        Else

        End If
    End Sub

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Select Case categoria
            Case "Hombre"
                cantidad_productoA = Val(Label10.Text)
                cantidad_productoB = Val(Label11.Text)
                cantidad_productoC = Val(Label12.Text)
                cantidad_productoD = Val(Label13.Text)
                precio_producto_A = Val(Label3.Text)
                precio_producto_B = Val(Label5.Text)
                precio_producto_C = Val(Label7.Text)
                precio_producto_D = Val(Label9.Text)
                precio_categoria = (precio_producto_A * cantidad_productoA) + (precio_producto_B * cantidad_productoB) + (precio_producto_C * cantidad_productoC) + (precio_producto_D * cantidad_productoD)
                precio_Total = precio_Total + precio_categoria
                lblTotal.Text = precio_Total

            Case "Mujeres"
                cantidad_productoA = Val(Label10.Text)
                cantidad_productoB = Val(Label11.Text)
                cantidad_productoC = Val(Label12.Text)
                cantidad_productoD = Val(Label13.Text)
                precio_producto_A = Val(Label3.Text)
                precio_producto_B = Val(Label5.Text)
                precio_producto_C = Val(Label7.Text)
                precio_producto_D = Val(Label9.Text)
                precio_categoria = (precio_producto_A * cantidad_productoA) + (precio_producto_B * cantidad_productoB) + (precio_producto_C * cantidad_productoC) + (precio_producto_D * cantidad_productoD)
                precio_Total = precio_Total + precio_categoria
                lblTotal.Text = precio_Total
            Case "calzados"
            Case "Accesorios"

        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    End Sub
End Class