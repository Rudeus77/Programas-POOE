Module Module1



    Sub Main()

            Dim continuar As String = "s"
            While continuar = "s"
                Console.WriteLine("MENU")
                Console.WriteLine("1. Determinar si es mayor de edad.")
                Console.WriteLine("2. Determinar si un numero es positivo o negativo.")
                Console.WriteLine("3. Determinar descueto a monto de compra.")
                Console.WriteLine("4. Suma de numeros naturales.")
                Console.WriteLine("5. Tabla de multiplicar.")
                Console.WriteLine("6. Salir")
                Console.Write("Opcion:")


                Dim opcion As Integer = Console.ReadLine()
                Console.Clear()
                Select Case opcion
                    Case 1
                        mayorEdad()
                    Case 2
                        positivoNegativo()
                    Case 3
                        totalPagar()
                    Case 4
                        sumaNatural()
                    Case 5
                        tablaMultiplicar()

                End Select
            End While


        End Sub

        Sub mayorEdad()
            Dim edadIngresada As Integer = 0
            Dim mayorEdad As Integer = 18

            Console.Write("Ingrese su edad por favor: ")
            edadIngresada = Console.ReadLine()

            If edadIngresada >= mayorEdad Then
                Console.WriteLine("Eres mayor de edad.")

            Else
                Console.WriteLine("Eres menor de edad.")

            End If

            Console.ReadKey()

        End Sub

        Sub positivoNegativo()
            Dim numeroIngresado As Double


            Console.Write("Ingrese un número para determinar si es positivo o negativo: ")
            Dim input As String = Console.ReadLine()


            If Double.TryParse(input, numeroIngresado) Then
                If numeroIngresado > 0 Then
                    Console.WriteLine("Tu numero es positivo.")

                ElseIf (numeroIngresado < 0) Then
                    Console.WriteLine("Tu numero es negativo.")

                Else
                    Console.WriteLine("Tu numero es cero")

                End If

            End If


            Console.ReadKey()

        End Sub


        Sub totalPagar()

            Dim continuar As Boolean = True

            While continuar

                Console.Write("Ingrese el monto de la compra: $")
                Dim input As String = Console.ReadLine()


                If input.ToLower() = "salir" Then
                    continuar = False
                    Exit While
                End If


                Dim montoCompra As Double

                If Double.TryParse(input, montoCompra) Then
                    Dim descuento As Double
                    Dim totalPagar As Double


                    Select Case montoCompra
                        Case Is >= 1000
                            descuento = 0.3
                        Case Is >= 500
                            descuento = 0.2
                        Case Is >= 250
                            descuento = 0.1
                        Case Else
                            descuento = 0.05

                    End Select


                    Dim montoDescuento As Double = montoCompra * descuento
                    totalPagar = montoCompra - montoDescuento

                    Console.WriteLine($"Monto de compra: ${montoCompra}")
                    Console.WriteLine($"Descuento aplicado: {descuento * 100}%")
                    Console.WriteLine($"Monto del descuento: ${montoDescuento}")
                    Console.WriteLine($"Total a pagar: ${totalPagar}")

                    Console.ReadKey()

                End If
            End While


        End Sub

        Sub sumaNatural()
            Console.Write("Ingrese el valor para sumar: ")
            Dim n As Integer = Convert.ToInt64(Console.ReadLine())
            Dim suma As Integer = 0
            For i = 1 To n
                Console.Write("{0}", i)
                suma += i
                If i < n Then

                    Console.Write("+")
                Else
                    Console.Write("=")

                End If
            Next
            Console.WriteLine(suma)


        End Sub

        Sub tablaMultiplicar()
            Console.Write("tabla: ")
            Dim i = 1, ntabla As Integer = Console.ReadLine()

            For i = 1 To 10 Step 1
                Console.WriteLine("{0}x{1}={2}", ntabla, i, ntabla * i)
            Next

        End Sub


End Module
