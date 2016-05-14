# Calc

This the half-completed tutorial project to learn C# and a concept of Objects and events for beginner.

Here are the steps to implement the Calc application from scrach.

1. Create a new Project 
  Create a new Windows Forms Application in C# ,with a decent project name. Not like WindowsFormsApplication !
2. Create calc screen with Control objects from Toolbox
  Add Textbox to display and  buttons neccesary , like 1, 2, 3, +, -, C and etc.
3. Add Event Handler for showing input
   For example,  When pressing button 3  ,textbox shows "3" and press "+" then text box shows  "3+"
4. For simplify the calculation logic , import NCalc library by NuGet.
  Tools -> NuGet Package Manager -> Package Manager Console 
  PM> get-help
  PM> Find-Package NCalc
  PM> Install-Package NCalc-Edge
5. Use NCalc to calculate the expression
           Expression ex = new Expression(display.Text);
            try
            {
                display.Text = ex.Evaluate().ToString();

            }
            catch (Exception)
            {
                //ignore
            } }
