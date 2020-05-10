// Program Name:    Major Assignment 2
//
// Author:          Marlon R.
//
// Date:            4-April-2020
//
// Description:     Grade Calculator tool to help instructors calculate the 
//                  final mark of a course as both a percentage and letter grade.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_2
{
    
    public partial class mainForm : Form
    {
        // method to determine a letter grade based on a numeric grade
        static string assignLetterGrade(double percentage)
        {
            if (percentage >= 95)
            {
                return ("A+");
            }

            else if (percentage >= 90)
            {
                return ("A");
            }

            else if (percentage >= 85)
            {
                return ("A-");
            }

            else if (percentage >= 80)
            {
                return ("B+");
            }

            else if (percentage >= 75)
            {
                return ("B");
            }

            else if (percentage >= 70)
            {
                return ("B-");
            }

            else if (percentage >= 67)
            {
                return ("C+");
            }

            else if (percentage >= 64)
            {
                return ("C");
            }

            else if (percentage >= 60)
            {
                return ("C-");
            }

            else if (percentage >= 55)
            {
                return ("D+");
            }

            else if (percentage >= 50)
            {
                return ("D");
            }

            else
            {
                return ("F");
            }
        }


        int quizzMark;                  // to save value of a quizz mark
        int midtermMark;                // to save midterm mark
        int finalExamMark;              // to save final exam mark
        int lowestMark;                 // to save lowest mark
        int highestMark;                // to save highest mark
        int quizzMarksCounter = 0;      // to count number of marks entered
        int quizzMarksTotal;            // to save sum of quizz marks
        double quizzMarksAverage;       // to save average of marks
        double finalNumberGrade;        // to save final grade in numerical format
        string finalLetterGrade;        // to save final grade in letter form
        int originalQuizzMarksCounter;  // to save value of marks counter before dropping marks
        int originalQuizzMarksTotal;    // to save value of marks total before dropping marks


        public mainForm()
        {
            InitializeComponent();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            // exit application

            Application.Exit();

        }

        private void resetAllMarksButton_Click(object sender, EventArgs e)
        {
            // reset all marks and variables involved in calculations

            quizzMark = 0;
            lowestMark = 0;
            highestMark = 0;
            quizzMarksTotal = 0;
            originalQuizzMarksTotal = 0;
            quizzMarksCounter = 0;
            originalQuizzMarksCounter = 0;
            quizzMarksAverage = 0;
            finalNumberGrade = 0;
            finalLetterGrade = "";
            midtermMark = 0;
            finalExamMark = 0;

            finalExamMarkTextBox.Text = "";
            midtermMarkTextBox.Text = "";
            quizzMarkTextbox.Text = "";
            quizzesTexbox.Text = "";
            finalNumberGradeTexBox.Text = "";
            finalLetterGradeTexBox.Text = "";

            dropCheckBox.Checked = false;

            // focus on mark textbox

            quizzMarkTextbox.Select();
        }

        
        private void transferMarkButton_Click(object sender, EventArgs e)
        {
            // marks validation

            if (!int.TryParse(quizzMarkTextbox.Text, out quizzMark))
            {
                MessageBox.Show("Marks must be whole numbers between 0 - 100.\nPlease enter a correct mark.");
                quizzMarkTextbox.Text = "";
                quizzMarkTextbox.Select();
                return;
            }

            if (quizzMark < 0 || quizzMark > 100)
            {
                MessageBox.Show("Marks must be whole numbers between 0 - 100.\nPlease enter a correct mark.");
                quizzMarkTextbox.Text = "";
                quizzMarkTextbox.Select();
                return;
            }

            // clear grade textboxes when a new mark is added

            if ( ! (finalNumberGradeTexBox.Text == "") )
            {
                finalNumberGradeTexBox.Text = "";
                finalLetterGradeTexBox.Text = "";
            }

            // add a quizz mark to multiline texbox and variables
            // String.Trim(char) method used in the following line to remove '-'
            // if user enters "-0"

            quizzesTexbox.AppendText(quizzMarkTextbox.Text.Trim('-') + Environment.NewLine);

            quizzMarksTotal += quizzMark;
            originalQuizzMarksTotal = quizzMarksTotal;

            quizzMarksCounter++;
            originalQuizzMarksCounter = quizzMarksCounter;

            quizzMarkTextbox.Text = "";
            quizzMarkTextbox.Select();

            // get lowest and highest mark

            if (quizzMarksCounter <= 1)
            {
                lowestMark = quizzMark;
                highestMark = quizzMark;
            }
            else
            {
                if (quizzMark < lowestMark)
                {
                    lowestMark = quizzMark;
                }
                if (quizzMark > highestMark)
                {
                    highestMark = quizzMark;
                }
            }
        }

        private void calculateGradeButton_Click(object sender, EventArgs e)
        {
            // check the following condition before performing a calculation.
            // output appropriate messages if condition is not met
            //  - at least one mark inputted
            //  - midterm mark inputted and valid
            //  - final mark inputted and valid

            if (quizzMarksCounter < 1 )
            {
                MessageBox.Show("At least one mark must be inputted.");
                quizzMarkTextbox.Select();
                return;
            }

            if ( ! int.TryParse(midtermMarkTextBox.Text, out midtermMark) )
            {
                MessageBox.Show("Midterm mark must be a hole number\nbetween 0 and 100.");
                midtermMarkTextBox.Select();
                return;
            }

            if ( (midtermMark < 0) | (midtermMark > 100) )
            {
                MessageBox.Show("Midterm mark must be a hole number\nbetween 0 and 100.");
                midtermMarkTextBox.Select();
                return;
            }

            // trim '-' if user enters "-0"

            midtermMarkTextBox.Text = midtermMarkTextBox.Text.Trim('-');

            if ( ! int.TryParse(finalExamMarkTextBox.Text, out finalExamMark) )
            {
                MessageBox.Show("Final exam mark must be a hole number\nbetween 0 and 100.");
                finalExamMarkTextBox.Select();
                return;
            }

            if ( (finalExamMark < 0) | (finalExamMark > 100) )
            {
                MessageBox.Show("Final exam mark must be a hole number\nbetween 0 and 100.");
                finalExamMarkTextBox.Select();
                return;
            }

            // trim '-' if user enters "-0"

            finalExamMarkTextBox.Text = finalExamMarkTextBox.Text.Trim('-');
            

            // calculate quizz marks average

            quizzMarksAverage = quizzMarksTotal / quizzMarksCounter;

            // calculate final numeric grade

            finalNumberGrade = Math.Floor(0.2 * quizzMarksAverage + 0.3 * midtermMark + 0.5 * finalExamMark);
            finalNumberGradeTexBox.Text = $"{finalNumberGrade}";

            // determine final letter grade using method assignLetterGrade()

            finalLetterGrade = assignLetterGrade(finalNumberGrade);
            finalLetterGradeTexBox.Text = finalLetterGrade;

        }

        private void midtermMarkTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear grade textboxes when text is changed in midtermMarkTextBox

            finalNumberGradeTexBox.Text = "";
            finalLetterGradeTexBox.Text = "";
        }

        private void finalExamMarkTextBox_TextChanged(object sender, EventArgs e)
        {
            // clear grade textboxes when text is changed in finalExamMarkTextBox

            finalNumberGradeTexBox.Text = "";
            finalLetterGradeTexBox.Text = "";
        }

        private void resetQuizzMarksButton_Click(object sender, EventArgs e)
        {
            // reset all marks and variables involved in calculations
            // except for midterm and final exam mark texboxes

            quizzMark = 0;                 
            lowestMark = 0;                 
            highestMark = 0;
            quizzMarksTotal =0;
            originalQuizzMarksTotal = 0;
            quizzMarksCounter = 0;
            originalQuizzMarksCounter = 0;
            quizzMarksAverage = 0;
            finalNumberGrade = 0;
            finalLetterGrade = "";

            quizzMarkTextbox.Text = "";
            quizzesTexbox.Text = "";
            finalNumberGradeTexBox.Text = "";
            finalLetterGradeTexBox.Text = "";

            dropCheckBox.Checked = false;

            quizzMarkTextbox.Select();
        }

        private void dropCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // clear grade textboxes when the drop option is selected

            if ( ! (finalNumberGradeTexBox.Text == "") )
            {
                finalNumberGradeTexBox.Text = "";
                finalLetterGradeTexBox.Text = "";
            }

            // if checkbox is checked and number of quizzes > 5, 
            // substract lowest and higest marks from total and reduce counter by 2
            // otherwise, use original marks total and counter 

            if (dropCheckBox.Checked == true)
            {
                if (quizzMarksCounter < 5)
                {
                    MessageBox.Show("At least 5 marks required\nto use this option.");
                    dropCheckBox.Checked = false;
                    return;
                }

                // drop marks and reduce counter

                quizzMarksTotal -= (highestMark + lowestMark);
                quizzMarksCounter -= 2;
            }
            else
            {
                // use original marks total and counter

                quizzMarksTotal = originalQuizzMarksTotal;
                quizzMarksCounter = originalQuizzMarksCounter;
            }
            
        }

        private void quizzMarkTextbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}