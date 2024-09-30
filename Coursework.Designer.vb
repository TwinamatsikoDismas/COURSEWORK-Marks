<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Coursework
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LblGRADINGSCALECALCULATOR = New Label()
        LblEnterMarks = New Label()
        LblGrade = New Label()
        btnEvaluate = New Button()
        txtEnterMarks = New TextBox()
        SuspendLayout()
        ' 
        ' LblGRADINGSCALECALCULATOR
        ' 
        LblGRADINGSCALECALCULATOR.AutoSize = True
        LblGRADINGSCALECALCULATOR.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblGRADINGSCALECALCULATOR.Location = New Point(217, 65)
        LblGRADINGSCALECALCULATOR.Name = "LblGRADINGSCALECALCULATOR"
        LblGRADINGSCALECALCULATOR.Size = New Size(301, 30)
        LblGRADINGSCALECALCULATOR.TabIndex = 0
        LblGRADINGSCALECALCULATOR.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' LblEnterMarks
        ' 
        LblEnterMarks.AutoSize = True
        LblEnterMarks.Location = New Point(199, 143)
        LblEnterMarks.Name = "LblEnterMarks"
        LblEnterMarks.Size = New Size(69, 15)
        LblEnterMarks.TabIndex = 1
        LblEnterMarks.Text = "Enter Marks"
        ' 
        ' LblGrade
        ' 
        LblGrade.AutoSize = True
        LblGrade.Location = New Point(372, 197)
        LblGrade.Name = "LblGrade"
        LblGrade.Size = New Size(38, 15)
        LblGrade.TabIndex = 2
        LblGrade.Text = "Grade"
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(324, 238)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(141, 23)
        btnEvaluate.TabIndex = 3
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' txtEnterMarks
        ' 
        txtEnterMarks.Location = New Point(292, 140)
        txtEnterMarks.Name = "txtEnterMarks"
        txtEnterMarks.Size = New Size(226, 23)
        txtEnterMarks.TabIndex = 4
        ' 
        ' Coursework
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtEnterMarks)
        Controls.Add(btnEvaluate)
        Controls.Add(LblGrade)
        Controls.Add(LblEnterMarks)
        Controls.Add(LblGRADINGSCALECALCULATOR)
        Name = "Coursework"
        Text = "GRADING CALCULATOR"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblGRADINGSCALECALCULATOR As Label
    Friend WithEvents LblEnterMarks As Label
    Friend WithEvents LblGrade As Label
    Friend WithEvents btnEvaluate As Button
    Friend WithEvents txtEnterMarks As TextBox

End Class
