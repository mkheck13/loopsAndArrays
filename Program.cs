// Loops and Arrays

Console.Clear();

// Switch Statements

/*

switch(expression){
    case a:
        //Code block
        break;
    case b:
        //Code block
         break;
    default:
        //Code block
        break;
}

*/

//TryParse

/*

int a;
string myString = "19";

bool results = int.TryParse(myString, out a);
Console.WriteLine(results);

*/

// While Loop

// Think of an if statement that runs over and over as long as the expression is true
// We can use this in validation by putting a TryParse inside the loop and use the bool to determine if the user gave a vailid number.

/*

while(true){
    //do the thing
}
// Remember, with an infinite loop , hit Ctrl + C to emergency eject from the project.

*/

// Do While Loops
// This is just like a while loop, except it will always run once BEFORE checking its condition. If the condition evalutes to 'true' then the loop will continue to run

int counter = 0;

do{
    counter++;
    Console.WriteLine("This loop has run " + counter + " number of times");  
}while(counter < 3);
// Note that the key feature of a do-while loop is that it will ALWAYS run at least one time.

do{
    Console.WriteLine("I did the thing");
}while(false);

// For Loops
// For loops set up three things:
/*

1) Where to start (as for as counting)
2) A condition for whether or not the loop fires
3) At what rate we count up or down, typically to fulfill the condtion that was set

*/
for(int i = 0; i < 5; i++){
    Console.WriteLine("Our variable i (meaning index) is now at " + i);
} 

// Notice that i only counts upwards at the END of each iteration. 
//1) We establish the variable i at the very beginning of the loop
//2) Then we check the condition, presumably running the loop at least once
//3) At the end of the loop iteration, we count up by our third part (i++)
//4) Finally we check the condition again to see if the loop continues. If the expression evaluates to 'true', it runs again, otherwise we move to the next line of code after our for loop. 

// for(int variable = starting point;   condition for firing the loop;   how many to count up by){
//      Code block to be run
//}

// Counting by more than one:
for(int i = 0; i < 21; i += 3){
    Console.WriteLine("Our i variable is now equal to " + i);
}

// Counting down with i--:
for(int i = 5; i >= 0; i--){
    Console.WriteLine("The value of i is now " + i);
}


// Strings as an array of Chars
string exampleString = "fruits are delicious";

for(int i = 0; i < 5; i++){
    Console.WriteLine(exampleString[i]);
    Console.WriteLine(exampleString[i].GetType());
}

//Arrays start counting at 0, also known as 'The index of 0'
// If you go outside the bounds of the array's index, it breaks your code! In otherwords, we don't want to run out of entries when iterating through a group of data

Console.WriteLine(exampleString.Length);
for(int i = 0; i < exampleString.Length; i++){
    Console.WriteLine(exampleString[i]);
}

// Arrays 
// What if I have a huge collection of strings? That would be a bunch of variables that will be cumbersome to manage. If only I could keep them all in one place...
// This is where arrays come in! We can have a collection of a single data type that can be of any length and addressed with indexes.
// When you hear the word "Array" you should think immediately of SQUARE BRACKETS []

// We target individual values with an index number, starting with 0:
//                      0        1        2       3       4
string[] carBrands = {"ford", "chevy", "dodge", "bmw", "kia"};
// We initialize an array by stating the variable type and adding square brackets (read literally as "data array"), then we give it a variable name, and set the variable equal to a collection to that data type wrapped in a curly braces (and of course ended with a semicolon;)

Console.WriteLine(carBrands[2]);
Console.WriteLine(carBrands.Length);

for(int i = 0; i < carBrands.Length; i++){
    Console.WriteLine(carBrands[i]);
}
// Remember that .Length and arrays in general count differently, .Length starts at 1 but arrays start at 0, which is why we can use arry.Length non-inclusively in our condition to tell our loops to go through our WHOLE collection.

for(int i = 0; i < carBrands.Length; i++){
    Console.WriteLine(carBrands[i]);
    // If we have several layers of collections, we can add an extra index box to address the index of a nested collection
    Console.WriteLine(carBrands[i][0]);
    // Drilling deeper into the array in an array
}

// We can change an entry in our arrays by addressing it by its index and using the assignment operator (=) to establish a new value.
Console.WriteLine("give me a car brand, and I'll save it into the first entry in the array");
string userRes = Console.ReadLine();
carBrands[0] = userRes;
Console.WriteLine("the entry in our array at the index of 0 is now "+ carBrands[0]);

// We can also make empty arrays with the intention to fill them later, but we have to tell it its length to start with.
// Note that c# arrays do NOT want to change sizes after being declared and/or initialized.

int[] someNumbers = new int[3];
// This is now a brand new integer array with exactly 3 empty slots/entries
// [(nothing), (nothing), (nothing)]
someNumbers[1] = 32;
// [(nothing), 32, (nothing)]
Console.WriteLine(someNumbers[0]);
Console.WriteLine(someNumbers[1]);
Console.WriteLine(someNumbers[2]);
