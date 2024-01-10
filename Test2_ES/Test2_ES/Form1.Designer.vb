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
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtYearsEmployed = New System.Windows.Forms.TextBox()
        Me.txtYtdTotalPurchases = New System.Windows.Forms.TextBox()
        Me.txtPurchase = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkManager = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblESubTotal = New System.Windows.Forms.Label()
        Me.lblDiscountPercent = New System.Windows.Forms.Label()
        Me.lblYtdEDiscount = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDiscountSummary = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(149, 29)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 0
        '
        'txtYearsEmployed
        '
        Me.txtYearsEmployed.Location = New System.Drawing.Point(149, 67)
        Me.txtYearsEmployed.Name = "txtYearsEmployed"
        Me.txtYearsEmployed.Size = New System.Drawing.Size(100, 20)
        Me.txtYearsEmployed.TabIndex = 1
        '
        'txtYtdTotalPurchases
        '
        Me.txtYtdTotalPurchases.Location = New System.Drawing.Point(149, 105)
        Me.txtYtdTotalPurchases.Name = "txtYtdTotalPurchases"
        Me.txtYtdTotalPurchases.Size = New System.Drawing.Size(100, 20)
        Me.txtYtdTotalPurchases.TabIndex = 2
        '
        'txtPurchase
        '
        Me.txtPurchase.Location = New System.Drawing.Point(149, 143)
        Me.txtPurchase.Name = "txtPurchase"
        Me.txtPurchase.Size = New System.Drawing.Size(100, 20)
        Me.txtPurchase.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Years Employed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "YTD Total Purchases"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Todays Purchase"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkManager)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtYearsEmployed)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtYtdTotalPurchases)
        Me.GroupBox1.Controls.Add(Me.txtPurchase)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 218)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'chkManager
        '
        Me.chkManager.AutoSize = True
        Me.chkManager.Location = New System.Drawing.Point(101, 180)
        Me.chkManager.Name = "chkManager"
        Me.chkManager.Size = New System.Drawing.Size(68, 17)
        Me.chkManager.TabIndex = 11
        Me.chkManager.Text = "Manager"
        Me.chkManager.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDiscountPercent)
        Me.GroupBox2.Controls.Add(Me.lblYtdEDiscount)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 110)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Discount"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(148, 96)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 18
        '
        'lblDiscount
        '
        Me.lblDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscount.Location = New System.Drawing.Point(148, 59)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscount.TabIndex = 17
        '
        'lblESubTotal
        '
        Me.lblESubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblESubTotal.Location = New System.Drawing.Point(148, 22)
        Me.lblESubTotal.Name = "lblESubTotal"
        Me.lblESubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblESubTotal.TabIndex = 16
        '
        'lblDiscountPercent
        '
        Me.lblDiscountPercent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscountPercent.Location = New System.Drawing.Point(149, 25)
        Me.lblDiscountPercent.Name = "lblDiscountPercent"
        Me.lblDiscountPercent.Size = New System.Drawing.Size(100, 23)
        Me.lblDiscountPercent.TabIndex = 15
        '
        'lblYtdEDiscount
        '
        Me.lblYtdEDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYtdEDiscount.Location = New System.Drawing.Point(149, 62)
        Me.lblYtdEDiscount.Name = "lblYtdEDiscount"
        Me.lblYtdEDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblYtdEDiscount.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "YTD Discount"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Discount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sub Total"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Discount Percentage"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 501)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(131, 23)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(151, 501)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(131, 23)
        Me.btnNextEmployee.TabIndex = 14
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(151, 530)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDiscountSummary
        '
        Me.btnDiscountSummary.Location = New System.Drawing.Point(12, 530)
        Me.btnDiscountSummary.Name = "btnDiscountSummary"
        Me.btnDiscountSummary.Size = New System.Drawing.Size(131, 23)
        Me.btnDiscountSummary.TabIndex = 15
        Me.btnDiscountSummary.Text = "Discount Summary"
        Me.btnDiscountSummary.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblDiscount)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblESubTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 355)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 140)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Purchase Total"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 571)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDiscountSummary)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Employee Discount"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtYearsEmployed As TextBox
    Friend WithEvents txtYtdTotalPurchases As TextBox
    Friend WithEvents txtPurchase As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkManager As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblESubTotal As Label
    Friend WithEvents lblDiscountPercent As Label
    Friend WithEvents lblYtdEDiscount As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNextEmployee As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnDiscountSummary As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
