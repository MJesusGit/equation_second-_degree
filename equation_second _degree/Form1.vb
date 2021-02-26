Public Class Form1

    Property eq As Equation

    Private Sub Form1_load(Sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_root1.Text = String.Empty
        lbl_root2.Text = String.Empty

    End Sub



    Private Sub btn_calculate_Click(sender As Object, e As EventArgs) Handles btn_calculate.Click
        Try
            eq = New Equation(Convert.ToDouble(txt_coefficientA.Text), Convert.ToDouble(txt_CoefficientB.Text), Convert.ToDouble(txt_coefficientC.Text))

        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End Try


        If eq.a = 0 Then
            MessageBox.Show("NOT A QUADRATIC", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


        Select Case eq.Calculate()
            Case > 0
                Me.lbl_root1.Text = eq.x1.real.ToString
                Me.lbl_root2.Text = eq.x2.real.ToString
                Me.lbl_result_description.Text = "Two real roots"
                Me.lbl_root1.ForeColor = Color.Blue
                Me.lbl_root2.ForeColor = Color.Blue
                Me.lbl_result_description.ForeColor = Color.Blue
            Case = 0
                Me.lbl_root1.Text = eq.x1.real.ToString
                Me.lbl_root2.Text = String.Empty
                Me.lbl_result_description.Text = "One real roots"
                Me.lbl_root1.ForeColor = Color.Blue
                Me.lbl_result_description.ForeColor = Color.Blue
            Case < 0

                Me.lbl_root1.Text = eq.x1.toString
                Me.lbl_root2.Text = eq.x2.toString
                Me.lbl_result_description.Text = "Two complex roots"
                Me.lbl_root1.ForeColor = Color.Red
                Me.lbl_root2.ForeColor = Color.Red
                Me.lbl_result_description.ForeColor = Color.Red

        End Select







    End Sub





End Class
