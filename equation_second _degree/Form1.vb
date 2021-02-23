Public Class Form1

    Property eq As Equiation

    Private Sub Form1_load(Sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub



    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Try
            eq = New Equiation(Convert.ToDouble(txt_coefficientA), Convert.ToDouble(txt_CoefficientB), Convert.ToDouble(txt_coefficientC))

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End Try


        If eq.a = 0 Then
            MessageBox.Show("NOT A QUADRATIC", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Select Case eq.Calculate()
            Case Is > 0
                Me.lbl_root1.Text = eq.x1.real.ToString
                Me.lbl_root2.Text = eq.x2.real.ToString
                Me.lbl_result_description.ForeColor = Color.Blue
                Me.lbl_result_description.Text = "Two reals roots"

            Case = 0
                Me.lbl_root1.Text = eq.x1.real.ToString
                Me.lbl_root2.Text = eq.x2.real.ToString
                Me.lbl_result_description.ForeColor = Color.Blue
                Me.lbl_result_description.Text = "One real root"
            Case < 0
                Me.lbl_root1.Text = eq.x1.toString
                Me.lbl_root2.Text = eq.x2.real.ToString
                Me.lbl_result_description.ForeColor = Color.Red
                Me.lbl_result_description.Text = "Two complex roots"




        End Select



    End Sub






End Class
