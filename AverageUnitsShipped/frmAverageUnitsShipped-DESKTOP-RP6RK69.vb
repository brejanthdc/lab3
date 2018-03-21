Option Strict On

Public Class frmAverageUnitsShipped
    Private employeeCounter As Integer = 0
    Private dayCounter As Integer = 0
    Private Const maximumDays = 6
    Private Const totalEmployees = 2
    Private unitsSoldArray(totalEmployees, maximumDays) As Integer
    Private userInput As String = String.Empty
    Private userInputValidated As Integer
    Private outputEmployee1 As String = String.Empty
    Private outputEmployee2 As String = String.Empty
    Private outputEmployee3 As String = String.Empty
    Private averageUnitsEmployee1 As Double
    Private averageUnitsEmployee2 As Double
    Private averageUnitsEmployee3 As Double


    Private Function Validate(ByVal UserInput As String, ByRef userInputValidated As Integer) As Boolean ' This function will get the user input, and return a true/false value and the number the user entered
        Dim userInputDouble As Integer = 0  'This variable is used to store the user inputs after it is validiated
        Dim returnValue As Boolean = True 'Returns a true or false value which tells the code if the number has passed the validation

        If (Integer.TryParse(UserInput, userInputDouble)) Then 'Trys to parse the user input as a double 

            If userInputDouble >= 0 AndAlso userInputDouble <= 1000 Then ' if the number is a double it then checks if its within the range
                userInputValidated = userInputDouble ' The user input has been validated so it stores the number back into the userInputValidated to send back to the main code
                returnValue = True 'Returns a true value which the code will use to progress
            Else
                returnValue = False ' Returns a false value which the program will use for an error message

            End If
        Else
            returnValue = False ' Returns a false value which the program will use for an error message

        End If
        Return returnValue ' Returns the return value

    End Function

    Private Sub lblUnits_Click(sender As Object, e As EventArgs) Handles lblUnits.Click

    End Sub

    Private Sub btnResetButton_Click(sender As Object, e As EventArgs) Handles btnResetButton.Click

    End Sub



    Private Sub btnEnterButton_Click(sender As Object, e As EventArgs) Handles btnEnterButton.Click
        userInput = txtUserEntry.Text ' converts whatever is in the textbox into the user input variable


        If dayCounter = maximumDays And employeeCounter = 2 Then ' If the user inputs 7 numbers then

            btnEnterButton.Enabled = False 'The enter button on the appilcation gets disabled
            txtUserEntry.ReadOnly = True ' The text box that the user inputs into aslo gets disabled

        End If

        If Validate(userInput, userInputValidated) = True Then
            ' Private employeeCounter As Integer = 0
            ' Private dayCounter As Integer = 0
            'Private Const maximumDays = 6
            'rivate Const totalEmployees = 2
            'unitsSoldArray(totalEmployees, maximumDays)

            unitsSoldArray(employeeCounter, dayCounter) = userInputValidated 'Stores the validated user input into the array slot based of what day it is

            If employeeCounter = 0 Then
                outputEmployee1 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line
            ElseIf employeeCounter = 1 Then
                outputEmployee2 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line
            ElseIf employeeCounter = 2 Then
                outputEmployee3 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line

            End If


            dayCounter = dayCounter + 1 'Increasesd the counter by 1 to proceed to the next day
            txtUserEntry.Clear() 'Clears the text box so the user can enter a number without erasing thier previous entry
            txtUserEntry.Focus() 'Sets the focus back to the text box so the user doesn't have to reclick on the text box
        Else
            MessageBox.Show("Please ensure the number you input is between 0 and 1000", "Error")  'Error message if the user input is not valid

        End If

        If employeeCounter = 0 And dayCounter > 6 Then
            For avgCounter As Integer = 0 To maximumDays   'Creates a for loop that counts for each day of the week
                averageUnitsEmployee1 = averageUnitsEmployee1 + unitsSoldArray(employeeCounter, avgCounter) 'Adds all the numbers the user inputed into the array
            Next
            averageUnitsEmployee1 = averageUnitsEmployee1 / (maximumDays + 1) ' takes the total and divides with amount of days that the users enters in data

            lblAverageEmployee1Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee1, 2) 'Outputs the average with two decimal places to the output/error label

        End If

        If employeeCounter = 1 And dayCounter > 6 Then
            For avgCounter As Integer = 0 To maximumDays 'Creates a for loop that counts for each day of the week
                averageUnitsEmployee2 = averageUnitsEmployee2 + unitsSoldArray(employeeCounter, avgCounter) 'Adds all the numbers the user inputed into the array
            Next
            averageUnitsEmployee2 = averageUnitsEmployee2 / (maximumDays + 1) ' takes the total Sand divides with amount of days that the users enters in data

            lblAverageEmployee2Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee1, 2) 'Outputs the average with two decimal places to the output/error label

        End If

        If employeeCounter = 2 And dayCounter > 6 Then
            For avgCounter As Integer = 0 To maximumDays  'Creates a for loop that counts for each day of the week
                averageUnitsEmployee3 = averageUnitsEmployee3 + unitsSoldArray(employeeCounter, avgCounter) 'Adds all the numbers the user inputed into the array
            Next
            averageUnitsEmployee3 = averageUnitsEmployee3 / (maximumDays + 1) ' takes the total and divides with amount of days that the users enters in data

            lblAverageEmployee3Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee1, 2) 'Outputs the average with two decimal places to the output/error label

        End If
        If dayCounter > 6 Then
            dayCounter = 0
            employeeCounter += 1

        End If
        lblUnitsShippedEmployee1.Text = outputEmployee1 'Outputs the list of numbers the user has entered
        lblUnitsShippedEmployee2.Text = outputEmployee2 'Outputs the list of numbers the user has entered
        lblUnitsShippedEmployee3.Text = outputEmployee3 'Outputs the list of numbers the user has entered





    End Sub

    Private Sub lblUnitsShippedEmployee1_Click(sender As Object, e As EventArgs) Handles lblUnitsShippedEmployee1.Click

    End Sub
End Class
