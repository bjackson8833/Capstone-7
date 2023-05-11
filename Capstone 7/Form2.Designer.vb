<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblYou = New System.Windows.Forms.Label()
        Me.btnReveal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblYou
        '
        Me.lblYou.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYou.Location = New System.Drawing.Point(243, 132)
        Me.lblYou.Name = "lblYou"
        Me.lblYou.Size = New System.Drawing.Size(606, 112)
        Me.lblYou.TabIndex = 0
        Me.lblYou.Text = "You Rolled........"
        '
        'btnReveal
        '
        Me.btnReveal.Font = New System.Drawing.Font("Microsoft Sans Serif", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReveal.Location = New System.Drawing.Point(322, 307)
        Me.btnReveal.Name = "btnReveal"
        Me.btnReveal.Size = New System.Drawing.Size(420, 101)
        Me.btnReveal.TabIndex = 1
        Me.btnReveal.Text = "&Reveal"
        Me.btnReveal.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 547)
        Me.Controls.Add(Me.btnReveal)
        Me.Controls.Add(Me.lblYou)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblYou As Label
    Friend WithEvents btnReveal As Button
End Class
