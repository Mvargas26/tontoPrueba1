Public Class frmPantallaJuego

#Region "Variables"
    Dim vec1() As Integer
    Dim vec2() As Integer

#End Region

#Region "Metodos"

    '//Asignamos numeros aleatorios a las picture box y subimos las imagenes
    Sub NumerosAleatorios(vector1() As Integer, lblInfoNumeros As Label, pic0 As PictureBox, pic1 As PictureBox,
                      pic2 As PictureBox, pic3 As PictureBox)

        Dim numeroAleatorio, contadorNumerosAleatorios As Integer
        Dim validaNumero As Boolean

        lblInfoNumeros.Text = ""
        vector1 = {0, 0, 0, 0}
        validaNumero = False
        contadorNumerosAleatorios = 0

        Do While (contadorNumerosAleatorios < 4)
            Randomize()
            numeroAleatorio = (CInt(Rnd() * 41)) + 1

            For i = 0 To 3 Step 1
                If vector1(i) = numeroAleatorio Then
                    validaNumero = True
                    Exit For
                Else
                    validaNumero = False

                End If
            Next

            If validaNumero = False Then
                For j = 0 To 3 Step 1
                    If vector1(j) = 0 Then
                        vector1(j) = numeroAleatorio
                        contadorNumerosAleatorios += 1
                        Exit For
                    End If
                Next
            End If

        Loop

        For k = 0 To 3 Step 1
            lblInfoNumeros.Text += Str(vector1(k))
            Select Case k
                Case 0

                    pic0.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 1
                    pic1.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 2
                    pic2.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
                Case 3
                    pic3.ImageLocation = "C:\Users\micha\source\repos\tonto3\tonto3\Imagenes\a" + Str(vector1(k)) + ".jpg"
            End Select
        Next
        txtInfo.ResetText()
    End Sub '// Fin metodo NumerosAleatorios

    Public Sub Parejas(iVector() As Integer, iVector2() As Integer)


        For i = 0 To iVector.Length - 1 Step 1
            For j = 0 To iVector2.Length - 1 Step 1
                txtInfo.Text = "El vector1 vale " + Str(vec1(i)) + " y el vector2 vale  " + Str(vec2(j))

            Next
        Next

    End Sub



    Private Sub btnRevolver_Click(sender As Object, e As EventArgs) Handles btnRevolver.Click
        NumerosAleatorios(vec1, lbl1, pic1, pic2, pic3, pic4)
        NumerosAleatorios(vec2, lbl2, pic5, pic6, pic7, pic8)
    End Sub

    Private Sub btnParejas_Click(sender As Object, e As EventArgs) Handles btnParejas.Click
        Parejas(vec1, vec2)
    End Sub



#End Region

End Class '//fin class
