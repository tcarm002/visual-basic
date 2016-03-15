<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkFlaResident = New System.Windows.Forms.CheckBox()
        Me.radUnderGrad = New System.Windows.Forms.RadioButton()
        Me.radGrad = New System.Windows.Forms.RadioButton()
        Me.txtPantherId = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboCourses = New System.Windows.Forms.ComboBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lstBasket = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.Location = New System.Drawing.Point(671, 325)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(95, 30)
        Me.btnRemove.TabIndex = 0
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(671, 469)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkFlaResident)
        Me.GroupBox1.Controls.Add(Me.radUnderGrad)
        Me.GroupBox1.Controls.Add(Me.radGrad)
        Me.GroupBox1.Controls.Add(Me.txtPantherId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(430, 130)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Info"
        '
        'chkFlaResident
        '
        Me.chkFlaResident.AutoSize = True
        Me.chkFlaResident.Location = New System.Drawing.Point(205, 40)
        Me.chkFlaResident.Name = "chkFlaResident"
        Me.chkFlaResident.Size = New System.Drawing.Size(178, 29)
        Me.chkFlaResident.TabIndex = 3
        Me.chkFlaResident.Text = "Florida Resident"
        Me.chkFlaResident.UseVisualStyleBackColor = True
        '
        'radUnderGrad
        '
        Me.radUnderGrad.AutoSize = True
        Me.radUnderGrad.Location = New System.Drawing.Point(205, 81)
        Me.radUnderGrad.Name = "radUnderGrad"
        Me.radUnderGrad.Size = New System.Drawing.Size(129, 29)
        Me.radUnderGrad.TabIndex = 2
        Me.radUnderGrad.TabStop = True
        Me.radUnderGrad.Text = "Undergrad"
        Me.radUnderGrad.UseVisualStyleBackColor = True
        '
        'radGrad
        '
        Me.radGrad.AutoSize = True
        Me.radGrad.Location = New System.Drawing.Point(48, 81)
        Me.radGrad.Name = "radGrad"
        Me.radGrad.Size = New System.Drawing.Size(80, 29)
        Me.radGrad.TabIndex = 1
        Me.radGrad.TabStop = True
        Me.radGrad.Text = "Grad"
        Me.radGrad.UseVisualStyleBackColor = True
        '
        'txtPantherId
        '
        Me.txtPantherId.Location = New System.Drawing.Point(31, 38)
        Me.txtPantherId.Name = "txtPantherId"
        Me.txtPantherId.Size = New System.Drawing.Size(118, 30)
        Me.txtPantherId.TabIndex = 0
        Me.txtPantherId.Text = "1234567"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.cboCourses)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 234)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 119)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Course Info"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(48, 72)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 31)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'cboCourses
        '
        Me.cboCourses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCourses.FormattingEnabled = True
        Me.cboCourses.Location = New System.Drawing.Point(18, 33)
        Me.cboCourses.Name = "cboCourses"
        Me.cboCourses.Size = New System.Drawing.Size(121, 33)
        Me.cboCourses.TabIndex = 0
        '
        'lblResults
        '
        Me.lblResults.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(12, 397)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(587, 123)
        Me.lblResults.TabIndex = 6
        '
        'lstBasket
        '
        Me.lstBasket.FormattingEnabled = True
        Me.lstBasket.ItemHeight = 25
        Me.lstBasket.Location = New System.Drawing.Point(631, 114)
        Me.lstBasket.Name = "lstBasket"
        Me.lstBasket.Size = New System.Drawing.Size(165, 204)
        Me.lstBasket.TabIndex = 7
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(203, 339)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(157, 27)
        Me.lblTotal.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(838, 529)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.lstBasket)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campus Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPantherId As System.Windows.Forms.TextBox
    Friend WithEvents radUnderGrad As System.Windows.Forms.RadioButton
    Friend WithEvents radGrad As System.Windows.Forms.RadioButton
    Friend WithEvents chkFlaResident As System.Windows.Forms.CheckBox
    Friend WithEvents cboCourses As System.Windows.Forms.ComboBox
    Friend WithEvents lblResults As System.Windows.Forms.Label
    Friend WithEvents lstBasket As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
	Friend WithEvents lblTotal As System.Windows.Forms.Label

End Class
