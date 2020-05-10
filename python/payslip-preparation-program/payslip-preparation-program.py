# Author:    Marlon R.
#   Date:    February 9, 2020

# The purpose of this program is to prepare a pay slip to be included
# in a cheque envelope for the employees of a small business.
# The application prompts the employee for their name, number of 
# total hours worked over the week, hourly rate of pay,
# whether they have deductions removed from their gross pay, and
# the percentage of their gross pay that is to be deducted (if applicable).
#
# 40 hours are considered regular; extra hours are regarded as overtime hours.

# Calculatations of gross pay, dollar amount of deductions and net pay are performed
# and results are presented along with employee information in an organized manner
# in console

# Variables 

#    employeeName:  contains the name of the user
#      totalHours:  the number of hours worked by an employee over a week (this amount 
#                   contains the overtime hours the employee worked during the week)
#      hourlyRate:  employee's hourly rate of pay in dollars
#       deduction:  contains either Y or N, where, Y means Yes and N means No
#    deductionPct:  deduction percentage (percentage of the gross pay that is deducted)
#      regularPay:  amount payed before deductions for regular hours worked (up to 40 hours)
#         otHours:  number of overtime hours worked by employee over a week
#     overTimePay:  amount payed before deductions for overtime hours worked
#        grossPay:  amount payed before deductions for all worked hours (regular + overtime)
# deductionAmount:  amount deducted from grossPay
#          netPay:  actual amount the employee receives 

# Function getValue is used to obtained correct values of totalHours, hourlyRate and deductionPct
# It has two str parameters: 
# prompt and typeValue; the latter is used to take decisions in the function based 
# on the strings 'float' or 'int' as parameter typeValue
# needValue is used as a sentinel value to end the while loop
# isANumber is a boolean variable. If 'true' it means that the entered value is a float or int value,
# otherwise it is 'false'


def getValue(prompt, typeValue) :

    value = input(prompt + ": ")
    needValue = True
    isANumber = False
    while (needValue) :
        try :           
            if typeValue == 'float' :
                result = float(value)
            else : 
                result = int(value)    
            isANumber = True
        except ValueError :
            isANumber = False
            value = input("{}. You entered '{}': ".format(prompt, value))
            
        if isANumber == True :
            if result > 0 and result != -0 and typeValue != 'int':
                needValue = False
            elif result >= 0 and result <= 100 and typeValue == 'int':
                needValue = False
            else : value = input("{}. You entered '{}': ".format(prompt, value))    
    return result


# Data validation and obtaining user information

# employeeName cannot be empty or include only spaces
# total hours can only be a float number
# hourlyRate can only be a float number
# deduction can only be Y or N
# deductionPct can only be an interger number


#  The following information is obtained from the user:
#       - name
#       - total number of hours worked over the week
#       - hourly rate of pay
#       - whether deductions are removed from gross pay
#       - percentage deducted from gross pay (only if deductions are to be removed)

employeeName = input("Please enter your full name: ").strip()
while (employeeName == '') :
    employeeName = input("Employee's name cannot be empty or include only spaces. Please enter your full name: ").strip()
    

totalHours = float(getValue("Please enter the number of hours you worked over the week (Positive number)", 'float'))
hourlyRate = float(getValue("What is your hourly rate of pay (Positive number)", 'float'))

deduction = input("Do you have any deductions removed from your gross pay? Please reply Y or N: ")

while (deduction != 'Y' and deduction != 'N') :
    deduction = input("Do you have any deductions removed from your gross pay? Please reply Y or N. You entered: '{}': ".format(deduction))

if deduction == "Y" :
    deductionPct = getValue("What percentage of your gross pay is deducted? Please enter a whole number between 0 and 100: ", 'int')
else : deductionPct = 0    


# Calculations  
# regular pay, overtime pay, gross pay, deduction amount from gross pay and
# net pay are calculated in this block
 
if totalHours > 40 :
    regularPay = 40 * hourlyRate
    otHours = totalHours - 40
else : 
    regularPay = totalHours * hourlyRate
    otHours = 0

overTimePay = otHours * 1.5 * hourlyRate 
grossPay = regularPay + overTimePay
deductionAmount = deductionPct / 100 * grossPay 
netPay = grossPay - deductionAmount


# Program output 
# Pay slip information is output to console showing each element in a separate line
# Currency values are shwon with a dollar sign, comma-separated into groups of three digits,
# and using two decimal units 

print( " \n * * * * * * * * * * \n Employee's name: {} \n Total hours worked: {} \n Overtime hours worked (from previous amount): {:.1f} \n Hourly pay rate: ${:,.2f} \n Gross pay: ${:,.2f} \n Deductions: ${:,.2f} \n Net pay: ${:,.2f} \n * * * * * * * * * *".format(employeeName, totalHours, otHours, hourlyRate, grossPay, deductionAmount, netPay))

