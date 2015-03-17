<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.cboAppliance = New System.Windows.Forms.ComboBox()
        Me.lblAppliance = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblPower = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.txtPower = New System.Windows.Forms.TextBox()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtTotalHr = New System.Windows.Forms.TextBox()
        Me.txtTotalYr = New System.Windows.Forms.TextBox()
        Me.lblHour = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(183, 67)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(50, 20)
        Me.txtCost.TabIndex = 0
        '
        'cboAppliance
        '
        Me.cboAppliance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppliance.FormattingEnabled = True
        Me.cboAppliance.Items.AddRange(New Object() {"Stereo", "Dish Washer", "Lava Lamp", "Microwave", "Gamma Blaster", "TV"})
        Me.cboAppliance.Location = New System.Drawing.Point(183, 22)
        Me.cboAppliance.Name = "cboAppliance"
        Me.cboAppliance.Size = New System.Drawing.Size(121, 21)
        Me.cboAppliance.TabIndex = 1
        '
        'lblAppliance
        '
        Me.lblAppliance.AutoSize = True
        Me.lblAppliance.Location = New System.Drawing.Point(24, 25)
        Me.lblAppliance.Name = "lblAppliance"
        Me.lblAppliance.Size = New System.Drawing.Size(85, 13)
        Me.lblAppliance.TabIndex = 2
        Me.lblAppliance.Text = "Home Appliance"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(24, 70)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(80, 13)
        Me.lblCost.TabIndex = 3
        Me.lblCost.Text = "Cost / kW-hour"
        '
        'lblPower
        '
        Me.lblPower.AutoSize = True
        Me.lblPower.Location = New System.Drawing.Point(24, 115)
        Me.lblPower.Name = "lblPower"
        Me.lblPower.Size = New System.Drawing.Size(109, 13)
        Me.lblPower.TabIndex = 4
        Me.lblPower.Text = "Power Needed in kW"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(24, 160)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(93, 13)
        Me.lblHours.TabIndex = 5
        Me.lblHours.Text = "Hours Used / Day"
        '
        'txtPower
        '
        Me.txtPower.Location = New System.Drawing.Point(183, 112)
        Me.txtPower.Name = "txtPower"
        Me.txtPower.Size = New System.Drawing.Size(50, 20)
        Me.txtPower.TabIndex = 6
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(183, 157)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(50, 20)
        Me.txtHours.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(287, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 25)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(287, 109)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 25)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(287, 154)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 25)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtTotalHr
        '
        Me.txtTotalHr.Location = New System.Drawing.Point(200, 208)
        Me.txtTotalHr.Name = "txtTotalHr"
        Me.txtTotalHr.ReadOnly = True
        Me.txtTotalHr.Size = New System.Drawing.Size(45, 20)
        Me.txtTotalHr.TabIndex = 11
        '
        'txtTotalYr
        '
        Me.txtTotalYr.Location = New System.Drawing.Point(294, 208)
        Me.txtTotalYr.Name = "txtTotalYr"
        Me.txtTotalYr.ReadOnly = True
        Me.txtTotalYr.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalYr.TabIndex = 13
        '
        'lblHour
        '
        Me.lblHour.AutoSize = True
        Me.lblHour.Location = New System.Drawing.Point(248, 215)
        Me.lblHour.Name = "lblHour"
        Me.lblHour.Size = New System.Drawing.Size(38, 13)
        Me.lblHour.TabIndex = 14
        Me.lblHour.Text = "/ Hour"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(366, 215)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(37, 13)
        Me.lblYear.TabIndex = 15
        Me.lblYear.Text = "/ Year"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotal.Location = New System.Drawing.Point(24, 211)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTotal.Size = New System.Drawing.Size(170, 13)
        Me.lblTotal.TabIndex = 16
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MainForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(432, 260)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblHour)
        Me.Controls.Add(Me.txtTotalYr)
        Me.Controls.Add(Me.txtTotalHr)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.txtPower)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblPower)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblAppliance)
        Me.Controls.Add(Me.cboAppliance)
        Me.Controls.Add(Me.txtCost)
        Me.Name = "MainForm"
        Me.Text = "Home Utility Auditing Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents cboAppliance As System.Windows.Forms.ComboBox
    Friend WithEvents lblAppliance As System.Windows.Forms.Label
    Friend WithEvents lblCost As System.Windows.Forms.Label
    Friend WithEvents lblPower As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents txtPower As System.Windows.Forms.TextBox
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtTotalHr As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalYr As System.Windows.Forms.TextBox
    Friend WithEvents lblHour As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
