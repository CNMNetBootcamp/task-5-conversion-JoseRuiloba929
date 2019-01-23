/*Create a program that converts cups to quarts/gallons and quarts to cups. 
 * The program shall ask the user what they want to convert, provide appropriate messages and output the result. 
 * The user will be given an option to quit or convert another measurement. */

// setup
int conversionType=0;
int inputValue=0;
single coversionValue = 0;
string textNote = string.Empty;

 //input
 "Please select the numeric value of the type of conversion you want to do";
" 1 converts cups to quarts/gallons ";
" 2 quarts to cups";
get conversionType;
//check for valid entry value

    "Please enter value"
//check for valid entry value
get inputValue;
 //process
 if conversionType==1 
    {
    textNote="Converting "+ inputValue + "cups  is " + inputValue/4f + "quarts and " +inputValue/16f +"gallons";
    }
else if conversionType==2
    {
    textNote="Converting "+ inputValue + " quarts is equal to" + inputValue*4f + "cups";
    }

//output
textNote