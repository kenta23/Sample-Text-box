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
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtFirstNum = New System.Windows.Forms.TextBox()
        Me.txtSecondNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddition
        '
        Me.btnAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddition.Location = New System.Drawing.Point(340, 51)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(132, 33)
        Me.btnAddition.TabIndex = 0
        Me.btnAddition.Text = "Addition"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(29, 55)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(132, 25)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "First number"
        '
        'txtFirstNum
        '
        Me.txtFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstNum.Location = New System.Drawing.Point(169, 52)
        Me.txtFirstNum.Name = "txtFirstNum"
        Me.txtFirstNum.Size = New System.Drawing.Size(98, 31)
        Me.txtFirstNum.TabIndex = 2
        '
        'txtSecondNum
        '
        Me.txtSecondNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecondNum.Location = New System.Drawing.Point(198, 107)
        Me.txtSecondNum.Name = "txtSecondNum"
        Me.txtSecondNum.Size = New System.Drawing.Size(69, 31)
        Me.txtSecondNum.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Second number"
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtraction.Location = New System.Drawing.Point(340, 113)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(132, 33)
        Me.btnSubtraction.TabIndex = 5
        Me.btnSubtraction.Text = "Subtraction"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiplication.Location = New System.Drawing.Point(478, 52)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(146, 33)
        Me.btnMultiplication.TabIndex = 6
        Me.btnMultiplication.Text = "Multiplication"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivision.Location = New System.Drawing.Point(478, 113)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(146, 33)
        Me.btnDivision.TabIndex = 7
        Me.btnDivision.Text = "Division"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(29, 231)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(327, 29)
        Me.lblResult.TabIndex = 8
        Me.lblResult.Text = "Please Perform the operation"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 305)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.txtSecondNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirstNum)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnAddition)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddition As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtFirstNum As TextBox
    Friend WithEvents txtSecondNum As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnMultiplication As Button
    Friend WithEvents btnDivision As Button
    Friend WithEvents lblResult As Label
End Class
