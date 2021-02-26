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

    Public Overrides Function toString() As String
        If Me.imaginary = 0 Then
            Return Me.real.ToString("0.00")
        Else
            If Me.imaginary > 0 Then
                Return Me.real.ToString("0.00") & "+" & Me.imaginary.ToString("0.00") & "i"
            Else
                Return Me.real.ToString("0.00") & "+" & (-CInt(Me.imaginary.ToString("0.00"))) & "i"
            End If
        End If
    End Function
End Class