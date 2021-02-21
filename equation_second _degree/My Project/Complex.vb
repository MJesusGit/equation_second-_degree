Public Class Complex
    Property real As Double
    Property imaginary As Double

    Property a As Double
        Get
            Return Me.real
        End Get
        Set(value As Double)
            Me.real = value

        End Set
    End Property

    Public Sub complex(a As Double, b As Double)
        Me.real = a
        Me.imaginary = b
    End Sub

End Class
