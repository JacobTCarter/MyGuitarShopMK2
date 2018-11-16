<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressForm
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
        Me.AddressID_TB = New System.Windows.Forms.TextBox()
        Me.CustomerID_TB = New System.Windows.Forms.TextBox()
        Me.AddressOne_TB = New System.Windows.Forms.TextBox()
        Me.AddressTwo_TB = New System.Windows.Forms.TextBox()
        Me.City_TB = New System.Windows.Forms.TextBox()
        Me.State_TB = New System.Windows.Forms.TextBox()
        Me.ZipCode_TB = New System.Windows.Forms.TextBox()
        Me.PhoneNumber_TB = New System.Windows.Forms.TextBox()
        Me.AddressID = New System.Windows.Forms.Label()
        Me.CustomerID = New System.Windows.Forms.Label()
        Me.AddressOne = New System.Windows.Forms.Label()
        Me.AddressTwo = New System.Windows.Forms.Label()
        Me.City = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.Label()
        Me.ZipCode = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.GetAddressIDButton = New System.Windows.Forms.Button()
        Me.GetCustomerIDButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddressID_TB
        '
        Me.AddressID_TB.Location = New System.Drawing.Point(145, 27)
        Me.AddressID_TB.Name = "AddressID_TB"
        Me.AddressID_TB.Size = New System.Drawing.Size(100, 22)
        Me.AddressID_TB.TabIndex = 0
        '
        'CustomerID_TB
        '
        Me.CustomerID_TB.Location = New System.Drawing.Point(145, 55)
        Me.CustomerID_TB.Name = "CustomerID_TB"
        Me.CustomerID_TB.Size = New System.Drawing.Size(100, 22)
        Me.CustomerID_TB.TabIndex = 1
        '
        'AddressOne_TB
        '
        Me.AddressOne_TB.Location = New System.Drawing.Point(145, 83)
        Me.AddressOne_TB.Name = "AddressOne_TB"
        Me.AddressOne_TB.Size = New System.Drawing.Size(100, 22)
        Me.AddressOne_TB.TabIndex = 2
        '
        'AddressTwo_TB
        '
        Me.AddressTwo_TB.Location = New System.Drawing.Point(145, 111)
        Me.AddressTwo_TB.Name = "AddressTwo_TB"
        Me.AddressTwo_TB.Size = New System.Drawing.Size(100, 22)
        Me.AddressTwo_TB.TabIndex = 3
        '
        'City_TB
        '
        Me.City_TB.Location = New System.Drawing.Point(145, 139)
        Me.City_TB.Name = "City_TB"
        Me.City_TB.Size = New System.Drawing.Size(100, 22)
        Me.City_TB.TabIndex = 4
        '
        'State_TB
        '
        Me.State_TB.Location = New System.Drawing.Point(145, 167)
        Me.State_TB.Name = "State_TB"
        Me.State_TB.Size = New System.Drawing.Size(100, 22)
        Me.State_TB.TabIndex = 5
        '
        'ZipCode_TB
        '
        Me.ZipCode_TB.Location = New System.Drawing.Point(145, 195)
        Me.ZipCode_TB.Name = "ZipCode_TB"
        Me.ZipCode_TB.Size = New System.Drawing.Size(100, 22)
        Me.ZipCode_TB.TabIndex = 6
        '
        'PhoneNumber_TB
        '
        Me.PhoneNumber_TB.Location = New System.Drawing.Point(145, 223)
        Me.PhoneNumber_TB.Name = "PhoneNumber_TB"
        Me.PhoneNumber_TB.Size = New System.Drawing.Size(100, 22)
        Me.PhoneNumber_TB.TabIndex = 7
        '
        'AddressID
        '
        Me.AddressID.AutoSize = True
        Me.AddressID.Location = New System.Drawing.Point(37, 27)
        Me.AddressID.Name = "AddressID"
        Me.AddressID.Size = New System.Drawing.Size(73, 17)
        Me.AddressID.TabIndex = 8
        Me.AddressID.Text = "AddressID"
        '
        'CustomerID
        '
        Me.CustomerID.AutoSize = True
        Me.CustomerID.Location = New System.Drawing.Point(37, 55)
        Me.CustomerID.Name = "CustomerID"
        Me.CustomerID.Size = New System.Drawing.Size(81, 17)
        Me.CustomerID.TabIndex = 9
        Me.CustomerID.Text = "CustomerID"
        '
        'AddressOne
        '
        Me.AddressOne.AutoSize = True
        Me.AddressOne.Location = New System.Drawing.Point(37, 83)
        Me.AddressOne.Name = "AddressOne"
        Me.AddressOne.Size = New System.Drawing.Size(91, 17)
        Me.AddressOne.TabIndex = 10
        Me.AddressOne.Text = "Address One"
        '
        'AddressTwo
        '
        Me.AddressTwo.AutoSize = True
        Me.AddressTwo.Location = New System.Drawing.Point(37, 111)
        Me.AddressTwo.Name = "AddressTwo"
        Me.AddressTwo.Size = New System.Drawing.Size(90, 17)
        Me.AddressTwo.TabIndex = 11
        Me.AddressTwo.Text = "Address Two"
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(37, 139)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(31, 17)
        Me.City.TabIndex = 12
        Me.City.Text = "City"
        '
        'State
        '
        Me.State.AutoSize = True
        Me.State.Location = New System.Drawing.Point(37, 167)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(41, 17)
        Me.State.TabIndex = 13
        Me.State.Text = "State"
        '
        'ZipCode
        '
        Me.ZipCode.AutoSize = True
        Me.ZipCode.Location = New System.Drawing.Point(37, 195)
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.Size = New System.Drawing.Size(65, 17)
        Me.ZipCode.TabIndex = 14
        Me.ZipCode.Text = "Zip Code"
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(37, 223)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(103, 17)
        Me.PhoneNumber.TabIndex = 15
        Me.PhoneNumber.Text = "Phone Number"
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(40, 272)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(75, 23)
        Me.SubmitButton.TabIndex = 16
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(121, 272)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 17
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(40, 301)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(75, 23)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(121, 301)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 19
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'GetAddressIDButton
        '
        Me.GetAddressIDButton.Location = New System.Drawing.Point(277, 27)
        Me.GetAddressIDButton.Name = "GetAddressIDButton"
        Me.GetAddressIDButton.Size = New System.Drawing.Size(162, 23)
        Me.GetAddressIDButton.TabIndex = 20
        Me.GetAddressIDButton.Text = "Get Using AddressID"
        Me.GetAddressIDButton.UseVisualStyleBackColor = True
        '
        'GetCustomerIDButton
        '
        Me.GetCustomerIDButton.Location = New System.Drawing.Point(277, 56)
        Me.GetCustomerIDButton.Name = "GetCustomerIDButton"
        Me.GetCustomerIDButton.Size = New System.Drawing.Size(162, 23)
        Me.GetCustomerIDButton.TabIndex = 21
        Me.GetCustomerIDButton.Text = "Get Using CustomerID"
        Me.GetCustomerIDButton.UseVisualStyleBackColor = True
        '
        'AddressForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 351)
        Me.Controls.Add(Me.GetCustomerIDButton)
        Me.Controls.Add(Me.GetAddressIDButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.ZipCode)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.AddressTwo)
        Me.Controls.Add(Me.AddressOne)
        Me.Controls.Add(Me.CustomerID)
        Me.Controls.Add(Me.AddressID)
        Me.Controls.Add(Me.PhoneNumber_TB)
        Me.Controls.Add(Me.ZipCode_TB)
        Me.Controls.Add(Me.State_TB)
        Me.Controls.Add(Me.City_TB)
        Me.Controls.Add(Me.AddressTwo_TB)
        Me.Controls.Add(Me.AddressOne_TB)
        Me.Controls.Add(Me.CustomerID_TB)
        Me.Controls.Add(Me.AddressID_TB)
        Me.Name = "AddressForm"
        Me.Text = "AddressForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddressID_TB As TextBox
    Friend WithEvents CustomerID_TB As TextBox
    Friend WithEvents AddressOne_TB As TextBox
    Friend WithEvents AddressTwo_TB As TextBox
    Friend WithEvents City_TB As TextBox
    Friend WithEvents State_TB As TextBox
    Friend WithEvents ZipCode_TB As TextBox
    Friend WithEvents PhoneNumber_TB As TextBox
    Friend WithEvents AddressID As Label
    Friend WithEvents CustomerID As Label
    Friend WithEvents AddressOne As Label
    Friend WithEvents AddressTwo As Label
    Friend WithEvents City As Label
    Friend WithEvents State As Label
    Friend WithEvents ZipCode As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents SubmitButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GetAddressIDButton As Button
    Friend WithEvents GetCustomerIDButton As Button
End Class
