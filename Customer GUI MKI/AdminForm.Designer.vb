<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Me.employeeListButton = New System.Windows.Forms.Button()
        Me.productListButton = New System.Windows.Forms.Button()
        Me.employeeList = New System.Windows.Forms.Label()
        Me.productList = New System.Windows.Forms.Label()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.logOutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'employeeListButton
        '
        Me.employeeListButton.Location = New System.Drawing.Point(147, 29)
        Me.employeeListButton.Name = "employeeListButton"
        Me.employeeListButton.Size = New System.Drawing.Size(82, 23)
        Me.employeeListButton.TabIndex = 0
        Me.employeeListButton.Text = "Go"
        Me.employeeListButton.UseVisualStyleBackColor = True
        '
        'productListButton
        '
        Me.productListButton.Location = New System.Drawing.Point(147, 58)
        Me.productListButton.Name = "productListButton"
        Me.productListButton.Size = New System.Drawing.Size(82, 23)
        Me.productListButton.TabIndex = 1
        Me.productListButton.Text = "Go"
        Me.productListButton.UseVisualStyleBackColor = True
        '
        'employeeList
        '
        Me.employeeList.AutoSize = True
        Me.employeeList.Location = New System.Drawing.Point(45, 32)
        Me.employeeList.Name = "employeeList"
        Me.employeeList.Size = New System.Drawing.Size(96, 17)
        Me.employeeList.TabIndex = 2
        Me.employeeList.Text = "Employee List"
        '
        'productList
        '
        Me.productList.AutoSize = True
        Me.productList.Location = New System.Drawing.Point(45, 58)
        Me.productList.Name = "productList"
        Me.productList.Size = New System.Drawing.Size(83, 17)
        Me.productList.TabIndex = 3
        Me.productList.Text = "Product List"
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(298, 89)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 4
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'logOutButton
        '
        Me.logOutButton.Location = New System.Drawing.Point(12, 89)
        Me.logOutButton.Name = "logOutButton"
        Me.logOutButton.Size = New System.Drawing.Size(75, 23)
        Me.logOutButton.TabIndex = 5
        Me.logOutButton.Text = "Log Out"
        Me.logOutButton.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(385, 129)
        Me.Controls.Add(Me.logOutButton)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.productList)
        Me.Controls.Add(Me.employeeList)
        Me.Controls.Add(Me.productListButton)
        Me.Controls.Add(Me.employeeListButton)
        Me.Name = "AdminForm"
        Me.Text = "AdminForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents employeeListButton As Button
    Friend WithEvents productListButton As Button
    Friend WithEvents employeeList As Label
    Friend WithEvents productList As Label
    Friend WithEvents closeButton As Button
    Friend WithEvents logOutButton As Button
End Class
