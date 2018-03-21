<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageUnitsShipped
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
        Me.components = New System.ComponentModel.Container()
        Me.tbUserEntry = New System.Windows.Forms.TextBox()
        Me.lblDayCount = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblEmployee1 = New System.Windows.Forms.Label()
        Me.lblEmployee2 = New System.Windows.Forms.Label()
        Me.lblEmployee3 = New System.Windows.Forms.Label()
        Me.AverageUnitsShippedByEmployeeTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblUnitsShippedEmployee1 = New System.Windows.Forms.Label()
        Me.lblUnitsShippedEmployee2 = New System.Windows.Forms.Label()
        Me.lblUnitsShippedEmployee3 = New System.Windows.Forms.Label()
        Me.lblAverageEmployee1Output = New System.Windows.Forms.Label()
        Me.lblAverageEmployee2Output = New System.Windows.Forms.Label()
        Me.lblAverageEmployee3Output = New System.Windows.Forms.Label()
        Me.lblTotalAverage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResetButton = New System.Windows.Forms.Button()
        Me.btnEnterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbUserEntry
        '
        Me.tbUserEntry.Location = New System.Drawing.Point(70, 44)
        Me.tbUserEntry.Name = "tbUserEntry"
        Me.tbUserEntry.Size = New System.Drawing.Size(53, 20)
        Me.tbUserEntry.TabIndex = 0
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.tbUserEntry, "User input text box, this is where the user enters their input")
        '
        'lblDayCount
        '
        Me.lblDayCount.Location = New System.Drawing.Point(12, 10)
        Me.lblDayCount.Name = "lblDayCount"
        Me.lblDayCount.Size = New System.Drawing.Size(51, 13)
        Me.lblDayCount.TabIndex = 4
        Me.lblDayCount.Text = "Day 1"
        Me.lblDayCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblDayCount, "Tells what day the user is currently on")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(11, 43)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(52, 21)
        Me.lblUnits.TabIndex = 5
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblUnits, "Units label")
        '
        'lblEmployee1
        '
        Me.lblEmployee1.Location = New System.Drawing.Point(26, 86)
        Me.lblEmployee1.Name = "lblEmployee1"
        Me.lblEmployee1.Size = New System.Drawing.Size(90, 21)
        Me.lblEmployee1.TabIndex = 6
        Me.lblEmployee1.Text = "Employee 1"
        Me.lblEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployee1, "Employee 1 label, will be bolded if user is currently using it")
        '
        'lblEmployee2
        '
        Me.lblEmployee2.Location = New System.Drawing.Point(179, 86)
        Me.lblEmployee2.Name = "lblEmployee2"
        Me.lblEmployee2.Size = New System.Drawing.Size(90, 21)
        Me.lblEmployee2.TabIndex = 7
        Me.lblEmployee2.Text = "Employee 2"
        Me.lblEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployee2, "Employee 2 label, will be bolded if user is currently using it")
        '
        'lblEmployee3
        '
        Me.lblEmployee3.Location = New System.Drawing.Point(326, 86)
        Me.lblEmployee3.Name = "lblEmployee3"
        Me.lblEmployee3.Size = New System.Drawing.Size(90, 21)
        Me.lblEmployee3.TabIndex = 8
        Me.lblEmployee3.Text = "Employee 3"
        Me.lblEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblEmployee3, "Employee 3 label, will be bolded if user is currently using it")
        '
        'lblUnitsShippedEmployee1
        '
        Me.lblUnitsShippedEmployee1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUnitsShippedEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnitsShippedEmployee1.Location = New System.Drawing.Point(15, 117)
        Me.lblUnitsShippedEmployee1.Name = "lblUnitsShippedEmployee1"
        Me.lblUnitsShippedEmployee1.Size = New System.Drawing.Size(130, 140)
        Me.lblUnitsShippedEmployee1.TabIndex = 9
        Me.lblUnitsShippedEmployee1.Text = "                   "
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblUnitsShippedEmployee1, "Employee 1's Output label, this shows what the user has entered ")
        '
        'lblUnitsShippedEmployee2
        '
        Me.lblUnitsShippedEmployee2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUnitsShippedEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnitsShippedEmployee2.Location = New System.Drawing.Point(162, 117)
        Me.lblUnitsShippedEmployee2.Name = "lblUnitsShippedEmployee2"
        Me.lblUnitsShippedEmployee2.Size = New System.Drawing.Size(129, 140)
        Me.lblUnitsShippedEmployee2.TabIndex = 10
        Me.lblUnitsShippedEmployee2.Text = "                   "
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblUnitsShippedEmployee2, "Employee 2's Output label, this shows what the user has entered ")
        '
        'lblUnitsShippedEmployee3
        '
        Me.lblUnitsShippedEmployee3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUnitsShippedEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUnitsShippedEmployee3.Location = New System.Drawing.Point(311, 117)
        Me.lblUnitsShippedEmployee3.Name = "lblUnitsShippedEmployee3"
        Me.lblUnitsShippedEmployee3.Size = New System.Drawing.Size(129, 140)
        Me.lblUnitsShippedEmployee3.TabIndex = 11
        Me.lblUnitsShippedEmployee3.Text = "                   "
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblUnitsShippedEmployee3, "Employee 3's Output label, this shows what the user has entered ")
        '
        'lblAverageEmployee1Output
        '
        Me.lblAverageEmployee1Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee1Output.Location = New System.Drawing.Point(15, 264)
        Me.lblAverageEmployee1Output.Name = "lblAverageEmployee1Output"
        Me.lblAverageEmployee1Output.Size = New System.Drawing.Size(130, 26)
        Me.lblAverageEmployee1Output.TabIndex = 12
        Me.lblAverageEmployee1Output.Text = " "
        Me.lblAverageEmployee1Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageEmployee1Output, "Employee 1's daily average")
        '
        'lblAverageEmployee2Output
        '
        Me.lblAverageEmployee2Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee2Output.Location = New System.Drawing.Point(162, 264)
        Me.lblAverageEmployee2Output.Name = "lblAverageEmployee2Output"
        Me.lblAverageEmployee2Output.Size = New System.Drawing.Size(129, 26)
        Me.lblAverageEmployee2Output.TabIndex = 13
        Me.lblAverageEmployee2Output.Text = " "
        Me.lblAverageEmployee2Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageEmployee2Output, "Employee 2's daily average")
        '
        'lblAverageEmployee3Output
        '
        Me.lblAverageEmployee3Output.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageEmployee3Output.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAverageEmployee3Output.Location = New System.Drawing.Point(311, 264)
        Me.lblAverageEmployee3Output.Name = "lblAverageEmployee3Output"
        Me.lblAverageEmployee3Output.Size = New System.Drawing.Size(129, 26)
        Me.lblAverageEmployee3Output.TabIndex = 14
        Me.lblAverageEmployee3Output.Text = " "
        Me.lblAverageEmployee3Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblAverageEmployee3Output, "Employee 3's daily average")
        '
        'lblTotalAverage
        '
        Me.lblTotalAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalAverage.Location = New System.Drawing.Point(12, 300)
        Me.lblTotalAverage.Name = "lblTotalAverage"
        Me.lblTotalAverage.Size = New System.Drawing.Size(428, 26)
        Me.lblTotalAverage.TabIndex = 15
        Me.lblTotalAverage.Text = " "
        Me.lblTotalAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.lblTotalAverage, "all the employees combined daily average")
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(311, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(129, 27)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnExit, "Exits the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnResetButton
        '
        Me.btnResetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResetButton.Location = New System.Drawing.Point(162, 336)
        Me.btnResetButton.Name = "btnResetButton"
        Me.btnResetButton.Size = New System.Drawing.Size(129, 27)
        Me.btnResetButton.TabIndex = 2
        Me.btnResetButton.Text = "&Reset"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnResetButton, "Resets the application")
        Me.btnResetButton.UseVisualStyleBackColor = True
        '
        'btnEnterButton
        '
        Me.btnEnterButton.Location = New System.Drawing.Point(15, 336)
        Me.btnEnterButton.Name = "btnEnterButton"
        Me.btnEnterButton.Size = New System.Drawing.Size(130, 27)
        Me.btnEnterButton.TabIndex = 1
        Me.btnEnterButton.Text = "&Enter"
        Me.AverageUnitsShippedByEmployeeTips.SetToolTip(Me.btnEnterButton, "Enter button that will add the numbers to the list")
        Me.btnEnterButton.UseVisualStyleBackColor = True
        '
        'frmAverageUnitsShipped
        '
        Me.AcceptButton = Me.btnEnterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnResetButton
        Me.ClientSize = New System.Drawing.Size(462, 384)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResetButton)
        Me.Controls.Add(Me.btnEnterButton)
        Me.Controls.Add(Me.lblTotalAverage)
        Me.Controls.Add(Me.lblAverageEmployee3Output)
        Me.Controls.Add(Me.lblAverageEmployee2Output)
        Me.Controls.Add(Me.lblAverageEmployee1Output)
        Me.Controls.Add(Me.lblUnitsShippedEmployee3)
        Me.Controls.Add(Me.lblUnitsShippedEmployee2)
        Me.Controls.Add(Me.lblUnitsShippedEmployee1)
        Me.Controls.Add(Me.lblEmployee3)
        Me.Controls.Add(Me.lblEmployee2)
        Me.Controls.Add(Me.lblEmployee1)
        Me.Controls.Add(Me.tbUserEntry)
        Me.Controls.Add(Me.lblDayCount)
        Me.Controls.Add(Me.lblUnits)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAverageUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employees"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbUserEntry As TextBox
    Friend WithEvents lblDayCount As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblEmployee1 As Label
    Friend WithEvents lblEmployee2 As Label
    Friend WithEvents lblEmployee3 As Label
    Friend WithEvents AverageUnitsShippedByEmployeeTips As ToolTip
    Friend WithEvents lblUnitsShippedEmployee1 As Label
    Friend WithEvents lblUnitsShippedEmployee2 As Label
    Friend WithEvents lblUnitsShippedEmployee3 As Label
    Friend WithEvents lblAverageEmployee1Output As Label
    Friend WithEvents lblAverageEmployee2Output As Label
    Friend WithEvents lblAverageEmployee3Output As Label
    Friend WithEvents lblTotalAverage As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnResetButton As Button
    Friend WithEvents btnEnterButton As Button
End Class
