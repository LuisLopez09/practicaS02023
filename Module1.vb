Module Module1

    Sub Main()
        'Tipos de datos numeros
        Dim numero As Integer = 12
        Dim pulgada As Double = 2.54

        'Tipos de caracteres
        Dim letra As Char = "a"
        Dim cadena As String = "Programacion II"

        'Tipo de Booleano
        Dim condicion As Boolean = False

        Console.WriteLine(numero)
        Console.WriteLine(pulgada)
        Console.WriteLine(letra)
        Console.WriteLine(cadena)
        Console.WriteLine(condicion)

        'Declaracion y asignacion de Datos
        Dim num1 As Integer = 1
        Dim num2 As Integer = 1
        Dim suma As Integer = num1 + num2
        Console.WriteLine("numero 1 = " & num1 & "    numero 2 = " & num2 & "    suma = " & suma)

        REM Declarar variables en una sola linea
        Dim num01 As Double = 1.4, num02 As Double = 1.7, sumaD As Double = num01 + num02
        Console.WriteLine(num01 & " + " & num02 & " = " & sumaD)

        Dim numF As Single = 1.5
        Dim sumaDf = num01 + numF
        Console.WriteLine("la variable numF = " & numF.GetType.ToString)
        Console.WriteLine("la suma de un numero flotante y un double = " & sumaDf.GetType.ToString())

        'Declaraciones Explicitas y Implicitas
        Dim cadenaExplicita As String = "Programacion II - 2023"
        Dim cadenaImplicita = "Programacion II - 2023"
        Console.WriteLine("variable explicita = " & cadenaExplicita.GetType.ToString())
        Console.WriteLine("variable implicita = " & cadenaImplicita.GetType.ToString())

        Dim floatExplicita As Single = 4.5
        Dim floatImplicita = 4.5F
        Console.WriteLine("variable explicita = " & floatExplicita.GetType.ToString)
        Console.WriteLine("variable implicita = " & floatImplicita.GetType.ToString)

        'Paso por valor (ByVal) y Referencia (ByRef)
        NuevaR()

        'Paso por posicion y por nombre
        Dim materia = "Programacion II"
        materia = materia.ToUpper()
        Console.WriteLine(materia)
        materia = materia.ToLower()
        Console.WriteLine(materia)
    End Sub

    Sub NuevaR()
        Dim edad As Byte
        edad = 25

        Call otraR(edad)
        Console.WriteLine(edad)
    End Sub
    Sub otraR(ByRef edad As Byte)
        edad = edad * 2
    End Sub


End Module
