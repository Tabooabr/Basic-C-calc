using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculadora_Csharp__basica
{

    /// <summary>
    /// A basic Calculator for a project :)
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor for the calc.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Clearing Methods
        /// <summary>
        /// Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments </param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            //clears the text from the user input
            this.UserInputTxt.Text = string.Empty;
            
            //Focuses the input of the user
            FocusInputText();
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            DeleteTextValue();
            
            //Focuses the input of the user
            FocusInputText();
        }
        #endregion

        #region Operator Method


        /// <summary>
        /// mathematical operators
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Divide_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void ButtonMultiplication_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }
        #endregion

        /// <summary>
        /// Calculate the Equation and output the answer to the user.
        /// </summary>
        private void CalculateEquation()
        {
            

            this.CalculationResultTxt.Text = ParseOperation();
            //Focus the user input text
            FocusInputText();
        }

        /// <summary>
        /// Parses the users equation and calculates the result
        /// </summary>
        /// <returns></returns>
        private string ParseOperation()
        {
            try
            {
                //Get the users equation input
                var input = this.UserInputTxt.Text;
                //remove all spaces
                input = input.Replace(" ", "");

                //Create a new top level operation
                var operation = new Operation();
                var leftSide = true;
                //with this for loop you take the string and start moving towards the right side (Through each character)
                for (int i = 0; i < input.Length; i++)
                {
                    //TODO: Handle order priority 
                    // 4 + 5 * 3 
                    // 1st: 5*3 
                    // then 15 + 4

                    //Check if the current character is a number
                                 
                    if ("0123456789.".Any(c => input[i] == c))
                    {
                        if (leftSide)
                            operation.Leftside = AddNumberPart(operation.Leftside, input[i]);
                        else
                            operation.Rightside = AddNumberPart(operation.Leftside, input[i]);
                    }
                    // If it is an operator (+ - * / ) set the operator type
                    else if ("+-*/".Any(c => input[i] == c))
                    {
                        //if we are on the right side already, we now need to calculate our current operation
                        //and set the result to the left side of the next operation
                        if (!leftSide)
                        {
                            //get the operator type
                            var operatorType = GetOperationType(input[i]);
                            //Check if we have a right side number
                            if (operation.Rightside.Length == 0)
                            {
                                //check the operator if it is not a minus (as a -4 is valid) 
                                if (operatorType != OperationType.Minus)
                                    throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without a left side number");

                                //If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.Rightside += input[i];

                            }
                            else
                            {

                                // Calculate previous equation and set to the left side
                                operation.Leftside = CalculateOperation(operation);
                                
                                //set new operator
                                operation.operationType = operatorType;


                                //Clear the previous right number
                                operation.Rightside = string.Empty;
                            }

                        }
                        else
                        {
                            //get the operator type
                            var operatorType = GetOperationType(input[i]);
                            //check if we have a left side number
                            if (operation.Leftside.Length == 0)
                            {
                                //check the operator if it is not a minus (as a -4 is valid) 
                                if (operatorType != OperationType.Minus)
                                throw new InvalidOperationException($"Operator (+ * / or more than one -) specified without a left side number");

                                //If we got here, the operator type is a minus, and there is no left number currently, so add the minus to the number
                                operation.Leftside += input[i];                              
                                
                            }
                            else
                            {
                                //if we got here, we have a left number, so we want to move to the right side

                                //set the operation type
                                operation.operationType = operatorType;

                                //move to the right side
                                leftSide = false;
                            }
                        }
                    }

                }

                // if we are done parsing, and there are no exceptions
                //Calculate the current operation
                CalculateOperation(operation);
                return string.Empty;
            }
            catch (Exception ex)
            {
                return $"Invalid Equation. {ex.Message}";
            }
           
        }
        /// <summary>
        /// Calculates an <see cref="Operation"/> and returns the result
        /// </summary>
        /// <param name="operation">This operation is the operation to calculate</param>
        private string CalculateOperation(Operation operation)
        {
            //store the values of the string representations
            decimal left = 0;
            decimal right = 0;

            // Check if we have a valid left side number
            if (string.IsNullOrEmpty(operation.Leftside) || !decimal.TryParse(operation.Leftside, out left))
                throw new InvalidOperationException($"Left Side of the operation is not a number. {operation.Leftside}");    

            // Check if we have a valid right side number
            if (string.IsNullOrEmpty(operation.Rightside) || !decimal.TryParse(operation.Rightside, out right))
                throw new InvalidOperationException($"Right Side of the operation is not a number. {operation.Rightside}");
            try
            {
                switch (operation.operationType)
                {
                     case OperationType.Add:
                        return (left + right).ToString();
                    case OperationType.Minus:
                        return (left - right).ToString();
                    case OperationType.Divide:
                        return (left / right).ToString();
                    case OperationType.Multiply:
                        return (left * right).ToString();
                    default:
                        throw new InvalidOperationException($"Unkown Operator type when calculating operation. {operation.operationType}");
                }
            }
            catch
            {
                throw new InvalidOperationException($"failed to calculate operation {operation.Leftside} {operation.operationType} {operation.Rightside}");
            }
            

        }

        /// <summary>
        /// Accepts a character and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character to parse</param>
        /// <returns></returns>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                    
                case '-':
                    return OperationType.Minus;

                case '*':
                    return OperationType.Multiply;

                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unkown operator type {character} ");

            }
        }

        /// <summary>
        /// Attepmts to add a new character to the current number checking for valid characters as it goes.
        /// </summary>
        /// <param name="currentNumber">Current number string</param>
        /// <param name="newCharacter"></param> The new character to append to the string
        /// <returns></returns>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            //check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
                throw new InvalidOperationException($"Number {currentNumber} already contains a . and another cannot be added");
            return currentNumber + newCharacter;
        }


        #region Number Method
        private void ButtonDot_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }
        
        private void Button0_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }
        #endregion
        
        
        #region Private Helprs
        /// <summary>
        /// Focuses The input of the user after pressing a button
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputTxt.Focus();
            
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {
            //Remember selection start
            var selectionStart = this.UserInputTxt.SelectionStart;

            //Gets the current selection ( this.UserInputTxt.SelectionStart ) And inserts a 0 where the cursor is at the text box   
            this.UserInputTxt.Text = this.UserInputTxt.Text.Insert(this.UserInputTxt.SelectionStart, value);

            // Restore the selection start
            this.UserInputTxt.SelectionStart = selectionStart + value.Length;

            //Set Selection length to 0
            this.UserInputTxt.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes the caracter of the right of the 
        /// </summary>
        /// <param name="value"></param>
        private void DeleteTextValue()
        {
            //if we dont have a value Delete the character to the right of the selection
            if (this.UserInputTxt.Text.Length < this.UserInputTxt.SelectionStart + 1)
                return;
            //Remember selection start
            var selectionStart = this.UserInputTxt.SelectionStart;
            
            //Delete the char
            this.UserInputTxt.Text = this.UserInputTxt.Text.Remove(this.UserInputTxt.SelectionStart, 1);

            // Restore the selection start
            this.UserInputTxt.SelectionStart = selectionStart;

            //Set Selection length to 0
            this.UserInputTxt.SelectionLength = 0;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
