Imports System.Collections.Generic

Public Class Form1

    'New: Arrays that hold courses and credit values
    Private courses As String() = {"COP 2210", "COP 2250", "COP 3804", "COP 4814"}
    Private credits As Integer() = {4, 3, 3, 2}
    Private totalTuition As Double = 0.0
    Private tuitionList As List(Of Double)

    Const UNDERGRAD_TUITION_RATE As Double = 150.0
    Const GRAD_TUITION_RATE As Double = 200.0
    Const FLA_RESIDENT_DISCOUNT_RATE = 0.5

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        For Each course As String In courses
            cboCourses.Items.Add(course)
        Next
        btnRemove.Enabled = False
        tuitionList = New List(Of Double)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click

        Dim index As Integer = cboCourses.SelectedIndex
        If index = -1 Then
            lblResults.Text = "Please select a course"
            Return
        End If

        Dim tuition As Double = 0.0

        If radGrad.Checked Then
            tuition = credits(index) * GRAD_TUITION_RATE
        ElseIf radUnderGrad.Checked Then
            tuition = credits(index) * UNDERGRAD_TUITION_RATE
        Else
            lblResults.Text = "Please select Grad or Undergrad"
            Return
        End If

        If chkFlaResident.Checked Then
            tuition = tuition * FLA_RESIDENT_DISCOUNT_RATE
        End If

        tuitionList.Add(tuition)
        totalTuition += tuition
        lblTotal.Text = "Total = " & totalTuition.ToString("c")

        lblResults.Text = "You have selected " & cboCourses.Items(index) &
           " and the tuition is " & tuition.ToString("c")

        lstBasket.Items.Add(cboCourses.Text & " (" & credits(index) & ")")
        btnRemove.Enabled = True
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRemove_Click() Handles btnRemove.Click

        Dim index As Integer = lstBasket.SelectedIndex
        If index = -1 Then Return

        totalTuition -= tuitionList(index)
        lblTotal.Text = "Total = " & totalTuition.ToString("c")

        lstBasket.Items.RemoveAt(index)
        tuitionList.RemoveAt(index)

        If lstBasket.Items.Count = 0 Then
            btnRemove.Enabled = False
        End If

    End Sub
End Class
