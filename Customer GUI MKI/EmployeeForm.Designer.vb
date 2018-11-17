<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.close = New System.Windows.Forms.Button()
        Me.clockIn = New System.Windows.Forms.Button()
        Me.clockOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'close
        '
        Me.close.Location = New System.Drawing.Point(304, 59)
        Me.close.Name = "close"
        Me.close.Size = New System.Drawing.Size(75, 23)
        Me.close.TabIndex = 0
        Me.close.Text = "Close"
        Me.close.UseVisualStyleBackColor = True
        '
        'clockIn
        '
        Me.clockIn.Location = New System.Drawing.Point(109, 59)
        Me.clockIn.Name = "clockIn"
        Me.clockIn.Size = New System.Drawing.Size(75, 23)
        Me.clockIn.TabIndex = 1
        Me.clockIn.Text = "Clock In"
        Me.clockIn.UseVisualStyleBackColor = True
        '
        'clockOut
        '
        Me.clockOut.Location = New System.Drawing.Point(190, 59)
        Me.clockOut.Name = "clockOut"
        Me.clockOut.Size = New System.Drawing.Size(82, 23)
        Me.clockOut.TabIndex = 2
        Me.clockOut.Text = "Clock Out"
        Me.clockOut.UseVisualStyleBackColor = True
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 124)
        Me.Controls.Add(Me.clockOut)
        Me.Controls.Add(Me.clockIn)
        Me.Controls.Add(Me.close)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents close As Button
    Friend WithEvents clockIn As Button
    Friend WithEvents clockOut As Button
End Class
