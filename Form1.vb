Public Class Form1
    'This code is an attempt to adress an error in which the radio buttons are checked when the form loads
    'rdbStandard.Checked = False
    'rdbDelux.Checked = False
    'rdbSuperior.Checked = False
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'Here an if statement is used to ensure the validation function is triggered befrore acual calculations occur
        If validation() = True Then
            'First we clear the listbox to make room for new data
            lsbDisplay.Text = ""
            'The following variables will be used to assist in calculations
            Dim intGuests As Integer
            Dim intNights As Integer
            Dim dblBreakfastCost As Integer
            Dim dblRoomExtras As Double
            Dim dblSelectedRoomCost As Double
            Dim dblTotalRoomCost As Double
            Dim dblTotalCost As Double
            'Here we assign values to the dblBreakfastCost variable
            If rdbStandard.Checked = True Then
                dblBreakfastCost = 20
            ElseIf rdbDelux.Checked = True Then
                dblBreakfastCost = 30
            ElseIf rdbSuperior.Checked = True Then
                dblBreakfastCost = 40
            End If
            'Next we calculate the room extras in 2 seperate if statements
            If cbxSuperiorPillows.Checked = True Then
                dblRoomExtras += 50
            End If
            If cbxFoodBasket.Checked = True Then
                dblRoomExtras += 30
            End If
            'Next we assign the values of intGuests and intNights
            intGuests = tbxGuests.Text
            intNights = tbxNights.Text
            'Here we multiply dblBreakfastCost by intGuests and intNights for our final answer
            dblBreakfastCost = dblBreakfastCost * intGuests * intNights
            'Next we assign the value of dblSelectedRoom based on the combobox selection
            If cmbxRoomType.SelectedItem = "Single" Then
                dblSelectedRoomCost = 100
            ElseIf cmbxRoomType.SelectedItem = "Double" Then
                dblSelectedRoomCost = 150
            ElseIf cmbxRoomType.SelectedItem = "Family" Then
                dblSelectedRoomCost = 250
            ElseIf cmbxRoomType.SelectedItem = "Penthouse Suite" Then
                dblSelectedRoomCost = 500
            End If
            'Now we calculate for the total cost of rooms
            dblTotalRoomCost = dblSelectedRoomCost * intNights
            'And finally we calculate for the total cost of overall
            dblTotalCost = dblBreakfastCost + dblRoomExtras + dblTotalRoomCost
            'Now all thats left is to put the all into the listbox
            lsbDisplay.Items.Add("Room booking made by " & tbxFirstName.Text & tbxSurName.Text)
            lsbDisplay.Items.Add("===============================================")
            lsbDisplay.Items.Add(" ")
            lsbDisplay.Items.Add("The number of guests is: " & intGuests)
            lsbDisplay.Items.Add("The number of nights requested is: " & intNights)
            lsbDisplay.Items.Add("The room extras cost is: $" & dblRoomExtras)
            lsbDisplay.Items.Add("The breakfast cost is: $" & dblBreakfastCost)
            lsbDisplay.Items.Add("The room cost is: $" & dblTotalRoomCost)
            lsbDisplay.Items.Add(" ")
            lsbDisplay.Items.Add("The TOTAL cost is: $" & dblTotalCost)
            lsbDisplay.Items.Add("===============================================")
        End If
    End Sub
    Private Function validation()
        'Here we validate the radiobuttons by verifying if none of them have been checked
        'Unfortunatuly it is made redundant by an unknown error that has been making the form open with one of the radiobuttons checked
        If rdbStandard.Checked = False And rdbDelux.Checked = False And rdbSuperior.Checked = False Then
            'If no input has been given then we send an error message
            MessageBox.Show("A bread type must be selected", "Input Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return false ends the program
            Return False
        End If
        'Here we check if any of the textboxes are empty
        If tbxFirstName.Text = "" Or tbxSurName.Text = "" Or tbxGuests.Text = "" Or tbxNights.Text = "" Then
            MessageBox.Show("One or more textboxes have been left empty", "Input Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        'Here we ensure that the guests and nights textbox values are numeric
        If IsNumeric(tbxGuests.Text) = False Or IsNumeric(tbxNights.Text) = False Then
            MessageBox.Show("Please confirm that all data entered into the Number of guests and Number of nights text boxes is numeric", "Input Error",
       MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        'If the comboboxes selected index is -1 then no option has been selected
        If cmbxRoomType.SelectedIndex = -1 Then
            MessageBox.Show("Please select measurement units from the drop-down list", "Input Error",
       MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        'At this point of none of the if statements have been triggerd then all of the data should be valid
        Return True
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This sub needs to clear the textboxes, radio buttons, combo box, check boxes an listbox

        'Here we replace each of the textboxes values with an empty string 
        tbxFirstName.Text = ""
        tbxSurName.Text = ""
        tbxGuests.Text = ""
        tbxNights.Text = ""
        'Next we manualy uncheck all of the radio butttons
        rdbStandard.Checked = False
        rdbDelux.Checked = False
        rdbSuperior.Checked = False
        'After that we reset the combobox to it's default selection
        cmbxRoomType.SelectedIndex = -1
        'Then we need to uncheck each of the checkboxes
        cbxSuperiorPillows.Checked = False
        cbxFoodBasket.Checked = False
        'And finally we replace the listbox with an empty string
        lsbDisplay.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'First we display a pop-up confirming whether the user wants to close the program
        'For this we will need a new integer variable
        Dim intResponse As Integer
        'The following code creates a message box that has a question mark icon and a yes/no option
        intResponse = MessageBox.Show("Are you sure you would like to close the program?", "",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'The answer given to the message box defines the value of the intResponse variable which triggers the if statement

        If intResponse = vbYes Then
            'Note: The form refers to itself as "Me" instead of "Form1"
            Me.Close()
        End If
    End Sub
End Class
