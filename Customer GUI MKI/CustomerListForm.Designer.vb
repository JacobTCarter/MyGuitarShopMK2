<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerListForm
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
        Me.back = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'back
        '
        Me.back.Location = New System.Drawing.Point(713, 415)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(75, 23)
        Me.back.TabIndex = 0
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = True
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(713, 12)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(75, 23)
        Me.logout.TabIndex = 1
        Me.logout.Text = "Log Out"
        Me.logout.UseVisualStyleBackColor = True
        '
        'CustomerListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.back)
        Me.Name = "CustomerListForm"
        Me.Text = "CustomerListForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents back As Button
    Friend WithEvents logout As Button
End Class
