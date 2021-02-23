Public Class Equiation
    Property x1 As Complex
    Property x2 As Complex
    Property a As Double
    Property b As Double
    Property c As Double
    Public Sub New(pa As Double, pb As Double, pc As Double)
        Me.a = pa
        Me.b = pb
        Me.c = pc
        Me.x1 = New Complex : Me.x2 = New Complex

    End Sub

    Public Function Calculate() As Double

        Dim delta As Double
        delta = Math.Pow(Me.b, 2) - 4 * Me.a * Me.c

        Select Case delta
            Case Is > 0
                Me.x1.real = (-Me.b + Math.Sqrt(delta)) / (2 * Me.a)
                Me.x1.imaginary = 0
                Me.x2.real = (-Me.b + Math.Sqrt(delta)) / (2 * Me.a)
                Me.x2.imaginary = 0

            Case = 0
                Me.x1.real = -Me.b / (2 * Me.a)
                Me.x1.imaginary = 0
                Me.x2 = Me.x1

            Case < 0
                Me.x1.real = -Me.b / (2 * Me.a)
                Me.x1.imaginary = Math.Sqrt(-delta) / (2 * Me.a)
                Me.x2.real = -Me.b / (2 * Me.a)
                Me.x2.imaginary = Math.Sqrt(-delta) / (2 * Me.a)
        End Select
        Return delta


    End Function

End Class
