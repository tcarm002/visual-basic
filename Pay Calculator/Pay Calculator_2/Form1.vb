Public Class frmMain

	Private ReadOnly Rate_Pension As Double = 0.05
	Private ReadOnly Rate_401k As Double = 0.1
	Private ReadOnly Rate_TravelBonus As Double = 0.15

	Private Sub btnCalculate_Click() Handles btnCalculate.Click

		'MessageBox.Show("You clicked the button")

		Dim hours As Double
		Dim payRate As Double
		hours = CDbl(txtHours.Text)
		payRate = CDbl(txtHourlyRate.Text)
		Dim grossPay As Double = hours * payRate
		Dim deductions As Double = 0
		lblStatus.Text = String.Empty

		'Get the retirement deduction.
		If radPension.Checked Then
			deductions = (Rate_Pension * grossPay)
		ElseIf rad401k.Checked Then
			deductions = (Rate_401k * grossPay)
		Else
			lblStatus.Text = "Please select a Retirement plan"
			Return
		End If

		'Calculate and display the net pay.
		Dim netPay As Double = grossPay - deductions

		lblGrossPay.Text = grossPay.ToString("n")
		lblDeductions.Text = deductions.ToString("n")
		lblNetPay.Text = netPay.ToString("c")

		If chkTravelBonus.Checked Then

			Dim travelBonus As Double = Rate_TravelBonus * grossPay
			lblStatus.Text = "Travel bonus = " & travelBonus.ToString("c")
		End If

	End Sub

	Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click

		Me.Close()
	End Sub

	Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click

	End Sub

	Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

	End Sub

	Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click

		txtHourlyRate.Clear()
		txtHours.Clear()
		rad401k.Checked = False
		radPension.Checked = False
		chkTravelBonus.Checked = False

		lblGrossPay.Text = String.Empty
		lblNetPay.Text = String.Empty
		lblDeductions.Text = String.Empty
		lblStatus.Text = String.Empty

	End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
