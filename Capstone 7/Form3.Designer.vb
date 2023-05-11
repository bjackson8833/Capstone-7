<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblWould = New System.Windows.Forms.Label()
        Me.btnG2 = New System.Windows.Forms.Button()
        Me.btnS2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWould
        '
        Me.lblWould.AutoSize = True
        Me.lblWould.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWould.Location = New System.Drawing.Point(12, 133)
        Me.lblWould.Name = "lblWould"
        Me.lblWould.Size = New System.Drawing.Size(985, 73)
        Me.lblWould.TabIndex = 0
        Me.lblWould.Text = "Would you like to guess or solve?"
        '
        'btnG2
        '
        Me.btnG2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnG2.Location = New System.Drawing.Point(192, 295)
        Me.btnG2.Name = "btnG2"
        Me.btnG2.Size = New System.Drawing.Size(220, 107)
        Me.btnG2.TabIndex = 1
        Me.btnG2.Text = "Guess"
        Me.btnG2.UseVisualStyleBackColor = True
        '
        'btnS2
        '
        Me.btnS2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS2.Location = New System.Drawing.Point(504, 295)
        Me.btnS2.Name = "btnS2"
        Me.btnS2.Size = New System.Drawing.Size(220, 107)
        Me.btnS2.TabIndex = 2
        Me.btnS2.Text = "Solve"
        Me.btnS2.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 450)
        Me.Controls.Add(Me.btnS2)
        Me.Controls.Add(Me.btnG2)
        Me.Controls.Add(Me.lblWould)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblWould As Label
    Friend WithEvents btnG2 As Button
    Friend WithEvents btnS2 As Button
End Class
