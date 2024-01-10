Public Class Form1

    'Global Totals

    Dim dblEmployeeYtdDiscount As Double
    Dim dblYTDPurchases As Double
    Dim dblDailySubTotal As Double
    Dim dblDailyTotal As Double

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close Program
        Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare Variables

        Dim intYearsEmployed As Integer
        Dim dblPurchase As Double

        Dim dblDiscountPercent As Double
        Dim dblEmployeeSubTotal As Double
        Dim dblDiscount As Double
        Dim dblEmployeeTotal As Double

        'Get and Validate Inputs

        If txtName.Text = String.Empty Then
            MessageBox.Show("First Name is Required")
            txtName.Focus()
            Exit Sub
        End If

        If IsNumeric(txtYearsEmployed.Text) Then
            intYearsEmployed = txtYearsEmployed.Text
            If (intYearsEmployed > 0) Then
            Else
                MessageBox.Show("Years employed must be numeric and greater than 0")
                txtYearsEmployed.Focus()
                Exit Sub
            End If
        End If

        If IsNumeric(txtYtdTotalPurchases.Text) Then
            If (dblYTDPurchases >= 0) Then
                dblYTDPurchases = txtYtdTotalPurchases.Text
            Else
                MessageBox.Show("YTD Total Purchases must be numeric and greater than or equal to 0")
                txtYtdTotalPurchases.Focus()
                Exit Sub
            End If
        End If

        If IsNumeric(txtPurchase.Text) Then
            dblPurchase = txtPurchase.Text
            If (dblPurchase >= 0) Then
            Else
                MessageBox.Show("Purchase must be numeric and greater than or equal to 0")
                txtPurchase.Focus()
                Exit Sub
            End If
        End If

        'Do Calculations

        If chkManager.Checked Then
            If intYearsEmployed > 0 And intYearsEmployed < 4 Then
                dblDiscountPercent = 0.2
            Else
                If intYearsEmployed >= 4 And intYearsEmployed < 7 Then
                    dblDiscountPercent = 0.24
                Else
                    If intYearsEmployed >= 7 And intYearsEmployed < 11 Then
                        dblDiscountPercent = 0.3
                    Else
                        If intYearsEmployed >= 11 And intYearsEmployed < 16 Then
                            dblDiscountPercent = 0.35
                        Else
                            If intYearsEmployed >= 15 Then
                                dblDiscountPercent = 0.4
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If chkManager.Checked = False Then
            If intYearsEmployed > 0 And intYearsEmployed < 4 Then
                dblDiscountPercent = 0.1
            Else
                If intYearsEmployed >= 4 And intYearsEmployed < 7 Then
                    dblDiscountPercent = 0.14
                Else
                    If intYearsEmployed >= 7 And intYearsEmployed < 11 Then
                        dblDiscountPercent = 0.2
                    Else
                        If intYearsEmployed >= 11 And intYearsEmployed < 16 Then
                            dblDiscountPercent = 0.25
                        Else
                            If intYearsEmployed >= 15 Then
                                dblDiscountPercent = 0.3
                            End If
                        End If
                    End If
                End If
            End If
        End If

        dblYTDPurchases += dblPurchase

        dblEmployeeYtdDiscount = dblYTDPurchases * dblDiscountPercent

        dblEmployeeSubTotal += dblPurchase

        If dblEmployeeYtdDiscount + (dblPurchase * dblDiscountPercent) < 200 Then
            dblDiscount = dblEmployeeYtdDiscount * dblDiscountPercent
        Else
            If dblEmployeeYtdDiscount + (dblPurchase * dblDiscountPercent) > 200 Then
                dblDiscount = dblEmployeeYtdDiscount * dblDiscountPercent - 200
            End If
        End If

        If dblEmployeeYtdDiscount > 200 Then
            dblDiscount = 0
        End If

        dblEmployeeTotal = dblPurchase - dblDiscount

        dblDailySubTotal += dblPurchase

        dblDailyTotal += dblPurchase - dblDiscount

        'Display Outputs

        lblDiscountPercent.Text = FormatPercent(dblDiscountPercent)
        lblYtdEDiscount.Text = FormatCurrency(dblEmployeeYtdDiscount)
        lblESubTotal.Text = FormatCurrency(dblEmployeeSubTotal)
        lblDiscount.Text = FormatCurrency(dblDiscount)
        lblTotal.Text = FormatCurrency(dblEmployeeTotal)

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click
        'Clear employee inputs

        txtName.Clear()
        txtYearsEmployed.Clear()
        txtYtdTotalPurchases.Clear()
        txtPurchase.Clear()
        chkManager.Checked = False
        lblDiscountPercent.ResetText()
        lblYtdEDiscount.ResetText()
        lblESubTotal.ResetText()
        lblDiscount.ResetText()
        lblTotal.ResetText()
        txtName.Focus()
        dblEmployeeYtdDiscount = 0
        dblDailySubTotal = 0
        dblDailyTotal = 0

    End Sub

    Private Sub btnDiscountSummary_Click(sender As Object, e As EventArgs) Handles btnDiscountSummary.Click
        MessageBox.Show(FormatCurrency(dblDailySubTotal), "Daily Sub Total")
        MessageBox.Show(FormatCurrency(dblDailyTotal), "Daily Total")

    End Sub
End Class
