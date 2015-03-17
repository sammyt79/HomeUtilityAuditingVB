' Home Utility Auditing Program
' Samuel Tollefson
' POS/408
' March 9, 2015
' Tim Hagan

Public Class MainForm

    Dim dblCost As Double ' Variable to hold txtCost input.
    Dim dblPower As Double ' Variable to hold txtPower input.
    Dim dblHours As Double ' Variable to hold txtHours input.
    Dim dblTotalHr As Double ' Variable to hold txtTotalHr output.
    Dim dblTotalYr As Double ' Variable to hold txtTotalYr output.
    Dim allGood As Boolean = True ' Used to test if the program is ready for calculations.

    ' Determine what happens when the user presses the "Clear" button (btnClear).
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' Reset combo box.
        cboAppliance.SelectedIndex = -1

        ' Clear input text boxes.
        txtCost.Clear()
        txtPower.Clear()
        txtHours.Clear()

        ' Clear output text boxes.
        ClearOutputs()

    End Sub

    ' Determine what happens when the user presses the "Calculate" button (btnCalculate).
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        allGood = True ' Ensure variable is set to true before inputs are read.

        ' Test combobox for valid user selection.
        If cboAppliance.SelectedIndex = -1 Then

            ' Display error message.
            MsgBox("Please select an appliance", , " input error")
            allGood = False ' Not ready for calculations.
        End If

        ' Validate that the cost entered has the correct format and is within a reasonable range.
        Try
            dblCost = CDbl(txtCost.Text)
            If dblCost < 0.05 Or dblCost > 0.5 Then

                ' Display error message.
                MsgBox("Cost / kW-hour must be between " + FormatCurrency("0.05") + "and " + FormatCurrency("0.5"), , " input error")
                txtCost.Clear() ' Clear cost input textbox.
                allGood = False ' Not ready for calculations.
            End If
        Catch ex As Exception

            ' Display error message.
            MsgBox("Please enter a valid amount for amount for ""Cost""", , " input error")
            txtCost.Clear() ' Clear cost input textbox.
            allGood = False ' Not ready for calculations.
        End Try

        ' Validate that the power entered has the correct format and is within a reasonable range.
        Try
            dblPower = CDbl(txtPower.Text)
            If dblPower < 1 Or dblPower > 100 Then

                ' Display error message.
                MsgBox("The value for Power Needed must be between 1.0 and 100", , " input error")
                txtPower.Clear() ' Clear power input textbox.
                allGood = False ' Not ready for calculations.
            End If
        Catch ex As Exception

            ' Display error message.
            MsgBox("Please enter a valid amount for ""Power Needed""", , " input error")
            txtPower.Clear() ' Clear power input textbox.
            allGood = False ' Not ready for calculations.
        End Try

        ' Validate that the hours entered has the correct format and is within a reasonable range.
        Try
            dblHours = CDbl(txtHours.Text)
            If dblHours < 0 Or dblHours > 24 Then

                ' Display error message.
                MsgBox("Hours Used must be within a 24 hour period", , " input error")
                txtHours.Clear() ' Clear hours input Textbox.
                allGood = False ' Not ready for calculations.
            End If
        Catch ex As Exception

            ' Display error message.
            MsgBox("Please enter a valid amount for ""Hours Used""", , " input error")
            txtHours.Clear() ' Clear hours input Textbox.
            allGood = False ' Not ready for calculations.
        End Try

        ' Check to see if inputs have been validated.
        If allGood = True Then

            ' Display output message.
            lblTotal.Text = cboAppliance.SelectedItem() + "'s total cost ="

            ' Calculate totals.
            dblTotalHr = dblCost * dblPower
            dblTotalYr = dblTotalHr * dblHours * 365

            ' Display totals.
            txtTotalHr.Text = FormatCurrency(dblTotalHr)
            txtTotalYr.Text = FormatCurrency(dblTotalYr)
        End If

    End Sub

    ' Determine what happens when the user presses the "Exit" button (btnExit).
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Close the program.
    End Sub

    ' Clear outputs when user changess selection.
    Private Sub cboAppliance_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAppliance.SelectedIndexChanged
        ClearOutputs()
    End Sub

    ' Clear outputs when user changess input.
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        ClearOutputs()
    End Sub

    ' Clear outputs when user changess input.
    Private Sub txtPower_TextChanged(sender As Object, e As EventArgs) Handles txtPower.TextChanged
        ClearOutputs()
    End Sub

    ' Clear outputs when user changess input.
    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        ClearOutputs()
    End Sub

    ' This procedure clears the output text boxes.
    Sub ClearOutputs()
        txtTotalHr.Clear()
        txtTotalYr.Clear()
    End Sub
End Class