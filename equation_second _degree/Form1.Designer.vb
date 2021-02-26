<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbl_statement_1 = New System.Windows.Forms.Label()
        Me.lbl_equation = New System.Windows.Forms.Label()
        Me.lbl_statetment_2 = New System.Windows.Forms.Label()
        Me.lbl_coefficientA = New System.Windows.Forms.Label()
        Me.lbl_coefficientC = New System.Windows.Forms.Label()
        Me.txt_coefficientA = New System.Windows.Forms.TextBox()
        Me.txt_CoefficientB = New System.Windows.Forms.TextBox()
        Me.txt_coefficientC = New System.Windows.Forms.TextBox()
        Me.lbl_coefficientB = New System.Windows.Forms.Label()
        Me.btn_calculate = New System.Windows.Forms.Button()
        Me.lbl_root1 = New System.Windows.Forms.Label()
        Me.lbl_root2 = New System.Windows.Forms.Label()
        Me.lbl_result_description = New System.Windows.Forms.Label()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_statement_1
        '
        Me.lbl_statement_1.AutoSize = True
        Me.lbl_statement_1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_statement_1.Location = New System.Drawing.Point(6, 9)
        Me.lbl_statement_1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lbl_statement_1.Name = "lbl_statement_1"
        Me.lbl_statement_1.Size = New System.Drawing.Size(564, 28)
        Me.lbl_statement_1.TabIndex = 0
        Me.lbl_statement_1.Text = "Given the general formula for solving second degree equations:"
        '
        'lbl_equation
        '
        Me.lbl_equation.AutoSize = True
        Me.lbl_equation.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_equation.Location = New System.Drawing.Point(257, 72)
        Me.lbl_equation.Name = "lbl_equation"
        Me.lbl_equation.Size = New System.Drawing.Size(251, 46)
        Me.lbl_equation.TabIndex = 1
        Me.lbl_equation.Text = "Ax^2+Bx+C =0"
        '
        'lbl_statetment_2
        '
        Me.lbl_statetment_2.AutoSize = True
        Me.lbl_statetment_2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_statetment_2.Location = New System.Drawing.Point(6, 150)
        Me.lbl_statetment_2.Name = "lbl_statetment_2"
        Me.lbl_statetment_2.Size = New System.Drawing.Size(547, 28)
        Me.lbl_statetment_2.TabIndex = 2
        Me.lbl_statetment_2.Text = "Please, insert values in the parameters for obtaining the roots:"
        '
        'lbl_coefficientA
        '
        Me.lbl_coefficientA.AutoSize = True
        Me.lbl_coefficientA.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_coefficientA.Location = New System.Drawing.Point(24, 208)
        Me.lbl_coefficientA.Name = "lbl_coefficientA"
        Me.lbl_coefficientA.Size = New System.Drawing.Size(174, 37)
        Me.lbl_coefficientA.TabIndex = 3
        Me.lbl_coefficientA.Text = "Coefficient A:"
        '
        'lbl_coefficientC
        '
        Me.lbl_coefficientC.AutoSize = True
        Me.lbl_coefficientC.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_coefficientC.Location = New System.Drawing.Point(25, 353)
        Me.lbl_coefficientC.Name = "lbl_coefficientC"
        Me.lbl_coefficientC.Size = New System.Drawing.Size(174, 37)
        Me.lbl_coefficientC.TabIndex = 5
        Me.lbl_coefficientC.Text = "Coefficient C:"
        '
        'txt_coefficientA
        '
        Me.txt_coefficientA.Location = New System.Drawing.Point(204, 202)
        Me.txt_coefficientA.Name = "txt_coefficientA"
        Me.txt_coefficientA.Size = New System.Drawing.Size(83, 43)
        Me.txt_coefficientA.TabIndex = 6
        '
        'txt_CoefficientB
        '
        Me.txt_CoefficientB.Location = New System.Drawing.Point(204, 275)
        Me.txt_CoefficientB.Name = "txt_CoefficientB"
        Me.txt_CoefficientB.Size = New System.Drawing.Size(83, 43)
        Me.txt_CoefficientB.TabIndex = 7
        '
        'txt_coefficientC
        '
        Me.txt_coefficientC.Location = New System.Drawing.Point(204, 353)
        Me.txt_coefficientC.Name = "txt_coefficientC"
        Me.txt_coefficientC.Size = New System.Drawing.Size(83, 43)
        Me.txt_coefficientC.TabIndex = 8
        '
        'lbl_coefficientB
        '
        Me.lbl_coefficientB.AutoSize = True
        Me.lbl_coefficientB.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_coefficientB.Location = New System.Drawing.Point(26, 281)
        Me.lbl_coefficientB.Name = "lbl_coefficientB"
        Me.lbl_coefficientB.Size = New System.Drawing.Size(172, 37)
        Me.lbl_coefficientB.TabIndex = 4
        Me.lbl_coefficientB.Text = "Coefficient B:"
        '
        'btn_calculate
        '
        Me.btn_calculate.ForeColor = System.Drawing.Color.DarkCyan
        Me.btn_calculate.Location = New System.Drawing.Point(597, 386)
        Me.btn_calculate.Name = "btn_calculate"
        Me.btn_calculate.Size = New System.Drawing.Size(145, 46)
        Me.btn_calculate.TabIndex = 9
        Me.btn_calculate.Text = "Calculate"
        Me.btn_calculate.UseVisualStyleBackColor = True
        '
        'lbl_root1
        '
        Me.lbl_root1.AutoSize = True
        Me.lbl_root1.Location = New System.Drawing.Point(364, 202)
        Me.lbl_root1.Name = "lbl_root1"
        Me.lbl_root1.Size = New System.Drawing.Size(0, 37)
        Me.lbl_root1.TabIndex = 10
        Me.lbl_root1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_root2
        '
        Me.lbl_root2.AutoSize = True
        Me.lbl_root2.Location = New System.Drawing.Point(364, 275)
        Me.lbl_root2.Name = "lbl_root2"
        Me.lbl_root2.Size = New System.Drawing.Size(0, 37)
        Me.lbl_root2.TabIndex = 11
        Me.lbl_root2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_result_description
        '
        Me.lbl_result_description.AutoSize = True
        Me.lbl_result_description.Location = New System.Drawing.Point(364, 334)
        Me.lbl_result_description.Name = "lbl_result_description"
        Me.lbl_result_description.Size = New System.Drawing.Size(0, 37)
        Me.lbl_result_description.TabIndex = 12
        '
        'btn_clean
        '
        Me.btn_clean.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.btn_clean.Location = New System.Drawing.Point(437, 386)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(133, 46)
        Me.btn_clean.TabIndex = 13
        Me.btn_clean.Text = "Clean"
        Me.btn_clean.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 450)
        Me.Controls.Add(Me.btn_clean)
        Me.Controls.Add(Me.lbl_result_description)
        Me.Controls.Add(Me.lbl_root2)
        Me.Controls.Add(Me.lbl_root1)
        Me.Controls.Add(Me.btn_calculate)
        Me.Controls.Add(Me.txt_coefficientC)
        Me.Controls.Add(Me.txt_CoefficientB)
        Me.Controls.Add(Me.txt_coefficientA)
        Me.Controls.Add(Me.lbl_coefficientC)
        Me.Controls.Add(Me.lbl_coefficientB)
        Me.Controls.Add(Me.lbl_coefficientA)
        Me.Controls.Add(Me.lbl_statetment_2)
        Me.Controls.Add(Me.lbl_equation)
        Me.Controls.Add(Me.lbl_statement_1)
        Me.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_statement_1 As Label
    Friend WithEvents lbl_equation As Label
    Friend WithEvents lbl_statetment_2 As Label
    Friend WithEvents lbl_coefficientA As Label
    Friend WithEvents lbl_coefficientC As Label
    Friend WithEvents txt_coefficientA As TextBox
    Friend WithEvents txt_CoefficientB As TextBox
    Friend WithEvents txt_coefficientC As TextBox
    Friend WithEvents lbl_coefficientB As Label
    Friend WithEvents btn_calculate As Button
    Friend WithEvents lbl_root1 As Label
    Friend WithEvents lbl_root2 As Label
    Friend WithEvents lbl_result_description As Label
    Friend WithEvents btn_clean As Button
End Class
