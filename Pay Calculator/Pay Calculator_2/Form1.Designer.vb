<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtHourlyRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDeductions = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad401k = New System.Windows.Forms.RadioButton()
        Me.radPension = New System.Windows.Forms.RadioButton()
        Me.chkTravelBonus = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Calculating Monthly Pay"
        '
        'txtHourlyRate
        '
        Me.txtHourlyRate.Location = New System.Drawing.Point(144, 43)
        Me.txtHourlyRate.Name = "txtHourlyRate"
        Me.txtHourlyRate.Size = New System.Drawing.Size(100, 29)
        Me.txtHourlyRate.TabIndex = 1
        Me.txtHourlyRate.Text = "0.0"
        Me.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Hourly pay rate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hours worked:"
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(144, 86)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 29)
        Me.txtHours.TabIndex = 3
        Me.txtHours.Text = "0.0"
        Me.txtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(268, 222)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(99, 33)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gross pay:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblGrossPay
        '
        Me.lblGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossPay.Location = New System.Drawing.Point(134, 18)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(108, 23)
        Me.lblGrossPay.TabIndex = 7
        Me.lblGrossPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(373, 222)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 33)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(456, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 33)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 309)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(587, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(0, 17)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblNetPay)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.lblDeductions)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblGrossPay)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(292, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 151)
        Me.Panel1.TabIndex = 11
        '
        'lblNetPay
        '
        Me.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetPay.Location = New System.Drawing.Point(134, 92)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(108, 23)
        Me.lblNetPay.TabIndex = 11
        Me.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Net pay:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDeductions
        '
        Me.lblDeductions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDeductions.Location = New System.Drawing.Point(134, 55)
        Me.lblDeductions.Name = "lblDeductions"
        Me.lblDeductions.Size = New System.Drawing.Size(108, 23)
        Me.lblDeductions.TabIndex = 9
        Me.lblDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Deductions:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad401k)
        Me.GroupBox1.Controls.Add(Me.radPension)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(246, 67)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Retirement Plan"
        '
        'rad401k
        '
        Me.rad401k.AutoSize = True
        Me.rad401k.Location = New System.Drawing.Point(129, 31)
        Me.rad401k.Name = "rad401k"
        Me.rad401k.Size = New System.Drawing.Size(82, 28)
        Me.rad401k.TabIndex = 14
        Me.rad401k.TabStop = True
        Me.rad401k.Text = "401 K"
        Me.rad401k.UseVisualStyleBackColor = True
        '
        'radPension
        '
        Me.radPension.AutoSize = True
        Me.radPension.Location = New System.Drawing.Point(19, 31)
        Me.radPension.Name = "radPension"
        Me.radPension.Size = New System.Drawing.Size(104, 28)
        Me.radPension.TabIndex = 13
        Me.radPension.TabStop = True
        Me.radPension.Text = "Pension"
        Me.radPension.UseVisualStyleBackColor = True
        '
        'chkTravelBonus
        '
        Me.chkTravelBonus.AutoSize = True
        Me.chkTravelBonus.Location = New System.Drawing.Point(15, 227)
        Me.chkTravelBonus.Name = "chkTravelBonus"
        Me.chkTravelBonus.Size = New System.Drawing.Size(146, 28)
        Me.chkTravelBonus.TabIndex = 13
        Me.chkTravelBonus.Text = "Travel bonus"
        Me.chkTravelBonus.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 331)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkTravelBonus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtHourlyRate)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "Pay Calculation Program"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents txtHourlyRate As System.Windows.Forms.TextBox
	Friend WithEvents Label2 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
	Friend WithEvents txtHours As System.Windows.Forms.TextBox
	Friend WithEvents btnCalculate As System.Windows.Forms.Button
	Friend WithEvents Label4 As System.Windows.Forms.Label
	Friend WithEvents lblGrossPay As System.Windows.Forms.Label
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
	Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents lblNetPay As System.Windows.Forms.Label
	Friend WithEvents Label8 As System.Windows.Forms.Label
	Friend WithEvents lblDeductions As System.Windows.Forms.Label
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	Friend WithEvents rad401k As System.Windows.Forms.RadioButton
	Friend WithEvents radPension As System.Windows.Forms.RadioButton
	Friend WithEvents chkTravelBonus As System.Windows.Forms.CheckBox

End Class
