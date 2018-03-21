'Lab 2: Semester Average 
'By: Brejanth Rajendran
'Date:3/07/2018
'Description: User will enter in sales for each day of the week for three employees and then the program will show their averages and the total average.

Option Strict On


Public Class frmAverageUnitsShipped
    Private Const maximumDays = 6 'Constant that tells program the maximum amount of days
    Private Const totalEmployees = 2 'Constant that tells program the maximum amount of employees
    Private Const minimumSales = 0 ' minimum sales that can be made
    Private Const maximumSales = 1000 ' Maximum sales that can be made


    Private employeeCounter As Integer = 0 'Counter that tells the program what employee it is on
    Private dayCounter As Integer = 0 'Counter that tells the program what day it is on
    Private unitsSoldArray(totalEmployees, maximumDays) As Integer 'Array that stores employees sales per day
    Private userInput As String = String.Empty 'Variable that stores user input
    Private userInputValidated As Integer 'Stores the number once it is validated
    Private outputEmployee1 As String = String.Empty 'Output string that is used to display what the user wrote for employee 1
    Private outputEmployee2 As String = String.Empty 'Output string that is used to display what the user wrote for employee 2
    Private outputEmployee3 As String = String.Empty 'Output string that is used to display what the user wrote for employee 3
    Private averageUnitsEmployee1 As Double 'Average total that is used to for employee 1
    Private averageUnitsEmployee2 As Double 'Average total that is used to for employee 2
    Private averageUnitsEmployee3 As Double 'Average total that is used to for employee 3
    Private finalAverage As Double 'Average total that is used to for all the employees 

    Dim BoldFont As New Font("Microsoft Sans Serif", 8.25, FontStyle.Bold) 'Used to change a font to bold
    Dim RegularFont As New Font("Microsoft Sans Serif", 8.25, FontStyle.Regular) 'Used to change a fond back to regular







    Private Overloads Function Validate(ByVal UserInput As String, ByRef userInputValidated As Integer) As Boolean ' This function will get the user input, and return a true/false value and the number the user entered
        Dim userInputInterger As Integer = 0  'This variable is used to store the user inputs after it is validiated
        Dim returnValue As Boolean = True 'Returns a true or false value which tells the code if the number has passed the validation

        If (Integer.TryParse(UserInput, userInputInterger)) Then 'Trys to parse the user input as a interger 

            If userInputInterger >= minimumSales AndAlso userInputInterger <= maximumSales Then ' if the number is a interger it then checks if its within the range
                userInputValidated = userInputInterger ' The user input has been validated so it stores the number back into the userInputValidated to send back to the main code
                returnValue = True 'Returns a true value which the code will use to progress
            Else
                returnValue = False ' Returns a false value which the program will use for an error message

            End If
        Else
            returnValue = False ' Returns a false value which the program will use for an error message

        End If
        Return returnValue ' Returns the return value

    End Function

    Private Function Average(ByVal EmployeeCounter As Integer, ByRef FinalAverage As Double) As Double

        For avgCounter As Integer = 0 To maximumDays  'Creates a for loop that counts for each day of the week
            FinalAverage = FinalAverage + unitsSoldArray(EmployeeCounter, avgCounter) 'Adds all the numbers the user inputed into the array
        Next

        FinalAverage = FinalAverage / (maximumDays + 1) ' takes the total and divides with amount of days that the users enters in data
        Return 0
    End Function

    Private Function TotalAverage(ByVal EmployeeCounter As Integer, ByRef FinalAverage As Double) As Double
        For employeeAverageCounter As Integer = 0 To totalEmployees 'Creates a nested for loop and this layer is for the number of employees
            For avgCounter As Integer = 0 To maximumDays  'Creates a for loop that counts for each day of the week
                FinalAverage = FinalAverage + unitsSoldArray(employeeAverageCounter, avgCounter) 'Adds all the numbers the user inputed into the array
            Next
        Next
        FinalAverage = FinalAverage / ((maximumDays + 1) * (totalEmployees + 1)) ' takes the total and divides with amount of days that the users enters in data
        Return 0
    End Function



    Private Sub lblUnits_Click(sender As Object, e As EventArgs) Handles lblUnits.Click

    End Sub

    Private Sub btnResetButton_Click(sender As Object, e As EventArgs) Handles btnResetButton.Click

        btnEnterButton.Enabled = True 'The enter button on the appilcation gets enables
        tbUserEntry.ReadOnly = False ' The text box that the user inputs into aslo gets enabled
        lblUnitsShippedEmployee1.ResetText() 'resets the text of of the lblUnitsShippedEmployee1
        lblUnitsShippedEmployee2.ResetText() 'resets the text of of the lblUnitsShippedEmployee2
        lblUnitsShippedEmployee3.ResetText() 'resets the text of of the lblUnitsShippedEmployee3
        lblAverageEmployee1Output.ResetText() 'resets the text of of the lblAverageEmployee1Output
        lblAverageEmployee2Output.ResetText() 'resets the text of of the lblAverageEmployee2Output
        lblAverageEmployee3Output.ResetText() 'resets the text of of the lblAverageEmployee3Output
        lblTotalAverage.ResetText() 'Resets the total average label
        tbUserEntry.Focus() ' sets the focus back to the text box
        employeeCounter = 0 ' sets the employee counter back 0
        dayCounter = 0 ' sets the day counter to 0
        averageUnitsEmployee1 = 0 ' sets the averages back to 0
        averageUnitsEmployee2 = 0
        averageUnitsEmployee3 = 0
        finalAverage = 0
        outputEmployee3 = String.Empty 'clears the output text
        outputEmployee2 = String.Empty
        outputEmployee1 = String.Empty
        Array.Clear(unitsSoldArray, totalEmployees, maximumDays) ' Clears the array


        lblEmployee1.Font = BoldFont 'this sets the label text to bold , and this is the label for employee 1
        lblEmployee2.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 2
        lblEmployee3.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 3



    End Sub



    Private Sub btnEnterButton_Click(sender As Object, e As EventArgs) Handles btnEnterButton.Click
        userInput = tbUserEntry.Text ' converts whatever is in the textbox into the user input variable


        If dayCounter = maximumDays And employeeCounter = 2 Then ' If the user inputs enters the last number in the array in this case it is 21st number it will
            'lock the button enter and text box

            btnEnterButton.Enabled = False 'The enter button on the appilcation gets disabled
            tbUserEntry.ReadOnly = True ' The text box that the user inputs into aslo gets disabled

        End If



        If Validate(userInput, userInputValidated) = True Then 'Runs the valdation function and if it passes it continues

            unitsSoldArray(employeeCounter, dayCounter) = userInputValidated 'Stores the validated user input into the array slot based of what day it is

            If employeeCounter = 0 Then 'When the array is set as employee 1

                lblEmployee1.Font = BoldFont 'this sets the label text to bold , and this is the label for employee 1
                lblEmployee2.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 2
                lblEmployee3.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 3

                outputEmployee1 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line
            ElseIf employeeCounter = 1 Then 'When the array is set as employee 2

                lblEmployee1.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 1
                lblEmployee2.Font = BoldFont 'this sets the label text to bold , and this is the label for employee 2
                lblEmployee3.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 3

                outputEmployee2 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line

            ElseIf employeeCounter = 2 Then 'When the array is set as employee 3

                lblEmployee1.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 1
                lblEmployee2.Font = RegularFont 'this sets the label text to normal , and this is the label for employee 2
                lblEmployee3.Font = BoldFont 'this sets the label text to bold , and this is the label for employee 3

                outputEmployee3 += unitsSoldArray(employeeCounter, dayCounter).ToString() & vbCrLf ' Stores the validated user input into the output string and also ends the line

            End If


            dayCounter = dayCounter + 1 'Increasesd the counter by 1 to proceed to the next day
            lblDayCount.Text = "Day " & dayCounter + 1 ' Changes the day label so the user knows what day they are typing in
            tbUserEntry.Clear() 'Clears the text box so the user can enter a number without erasing thier previous entry
            tbUserEntry.Focus() 'Sets the focus back to the text box so the user doesn't have to reclick on the text box
        Else
            MessageBox.Show("Please ensure the number you input is between 0 and 1000", "Error")  'Error message if the user input is not valid

        End If

        If employeeCounter = 0 And dayCounter > 6 Then ' this checks when the user types in the 7th day for the first employee
            Average(employeeCounter, averageUnitsEmployee1) 'Runs the average function which will take the employee counter and send the average to the averageUnitsEmployee1 variable

            lblAverageEmployee1Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee1, 2) 'Outputs the average with two decimal places to the average label

        End If

        If employeeCounter = 1 And dayCounter > 6 Then ' ' this checks when the user types in the 7th day for the second employee
            Average(employeeCounter, averageUnitsEmployee2) 'Runs the average function which will take the employee counter and send the average to the averageUnitsEmployee2 variable

            lblAverageEmployee2Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee2, 2) 'Outputs the average with two decimal places to the average label

        End If

        If employeeCounter = 2 And dayCounter > 6 Then ' this checks when the user types in the 7th day for the third employee  

            Average(employeeCounter, averageUnitsEmployee3) 'Runs the average function which will take the employee counter and send the average to the averageUnitsEmployee3 variable

            lblAverageEmployee3Output.Text = "Average per day: " & Math.Round(averageUnitsEmployee3, 2) 'Outputs the average with two decimal places to the average label

            TotalAverage(employeeCounter, finalAverage) 'Runs the total average function which will give the average for daily average and out that result to finalAverage

            lblTotalAverage.Text = "Average per Day: " & Math.Round(finalAverage, 2) 'Outputs the average with two decimal places to the average label

        End If

        If dayCounter > 6 Then ' This code stops the user from entering in a 8th day, by reseting counters back to 0 
            dayCounter = 0 ' The day counter is set to 0 so the day goes back to 1
            employeeCounter += 1 ' The employee number goes up by one
            lblDayCount.Text = "Day 1" 'The day counter text gets reset to default

        End If
        lblUnitsShippedEmployee1.Text = outputEmployee1 'Outputs the list of numbers the user has entered
        lblUnitsShippedEmployee2.Text = outputEmployee2 'Outputs the list of numbers the user has entered
        lblUnitsShippedEmployee3.Text = outputEmployee3 'Outputs the list of numbers the user has entered





    End Sub

    Private Sub lblUnitsShippedEmployee1_Click(sender As Object, e As EventArgs) Handles lblUnitsShippedEmployee1.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit() 'Exits the program
    End Sub
End Class
