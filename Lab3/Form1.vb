Public Class Form1

    Private billData As BillingData
    Private timeClk As TimeClock


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

		billData = New BillingData
		timeClk = New TimeClock

		For Each client In billData.Clients
			cboClients.Items.Add(client)
        Next

        btnStop.Enabled = False
        lblProgress.Visible = False
		cboClients.SelectedIndex = 0

    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

		lblStop.Text = ""
		lblBill.Text = ""
		btnStart.Enabled = False
		btnStop.Enabled = True
		btnExit.Enabled = False
		lblProgress.Visible = True
		cboClients.Enabled = False

		timeClk.StartTime = Now

		timeClk.ClientName = cboClients.SelectedItem.ToString

		lblStart.Text = Format(timeClk.StartTime, "Long Time")
       
    End Sub

    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click

		cboClients.Enabled = True
		timeClk.StopTime = Now
		btnStart.Enabled = True
		btnExit.Enabled = True
		btnStop.Enabled = False
		lblProgress.Visible = False
		timeClk.ClientName = cboClients.SelectedItem
		Dim totElapsedTime As String = timeClk.TotalElapsed.Hours.ToString + ":" + timeClk.TotalElapsed.Minutes.ToString

		lblStop.Text = Format(timeClk.StopTime, "Long Time")

		lblBill.Text = totElapsedTime

		billData.WriteBilling(Today + ", " + timeClk.ClientName +
		  ", " + Format(timeClk.StartTime, "Long Time") +
		  ", " + Format(timeClk.StopTime, "Long Time") +
		  ", " + totElapsedTime)

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		billData.CloseBilling()
		Me.Close()
    End Sub

 
End Class

