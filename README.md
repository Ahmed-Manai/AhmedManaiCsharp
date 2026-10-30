# AhmedManaiCsharp

A personal collection of **718 standalone C# snippets** gathered while learning the language, grouped by topic.
Most files are small console programs (`static void Main`); the `Others` folder also contains WPF/XAML and WinForms UI snippets and a few standalone classes, mostly data structures.

> These are loose `.cs` files, not projects: there is no `.csproj` or `.sln` in the repository. Some snippets are incomplete or
> start with a plain-text title line, so not every file compiles as-is.

## Contents

| Folder | Files | Topic |
|---|---:|---|
| [Arrays](#arrays) | 46 | Array basics, searching, copying, jagged and multi-dimensional arrays, simple matrix work. |
| [Basic](#basic) | 46 | Introductory console programs: input/output, arithmetic, simple number problems. |
| [Conversions](#conversions) | 16 | Number-base, unit and temperature conversions, infix to postfix. |
| [DataStructures](#datastructures) | 5 | Linked lists, stack, binary search tree. |
| [Delegates](#delegates) | 12 | Declaring, combining and multicasting delegates. |
| [Events](#events) | 16 | Event handling, timers and date/time helpers (some use WinForms). |
| [Exception](#exception) | 6 | Exception handling examples. |
| [Files](#files) | 35 | File, directory and stream I/O. |
| [Functions](#functions) | 28 | Methods, parameters, properties, recursion and other language features. |
| [Games_&_Threads](#games__threads) | 16 | Threading basics plus small console games (Hangman, number guessing, Tower of Hanoi). |
| [Inheritance_&_Interface](#inheritance__interface) | 13 | Inheritance, interfaces and polymorphism. |
| [Linq](#linq) | 33 | LINQ queries. |
| [Mathematics](#mathematics) | 54 | Math and number-theory exercises. |
| [Matrix](#matrix) | 14 | Matrix operations. |
| [Others](#others) | 309 | WPF/XAML and WinForms UI snippets plus standalone classes (mostly data structures). |
| [Sorting](#sorting) | 18 | Sorting algorithms (two variants of several algorithms). |
| [Strings](#strings) | 51 | String manipulation. |

## How to run a snippet

Each console snippet is self-contained. To try one with the .NET SDK:

```bash
dotnet new console -o Sandbox
# replace Sandbox/Program.cs with the contents of the snippet you want to run
dotnet run --project Sandbox
```

WinForms snippets need a Windows project (`dotnet new winforms`) and WPF/XAML snippets need a WPF project (`dotnet new wpf`);
you can also paste them into a matching project in Visual Studio. Remove any leading title line that is not valid C#.

## Index

Descriptions are taken from the file names.

### Arrays

| # | Description |
|---:|---|
| 1 | [Convert a 2D Array into 1D Array](csharp/Arrays/C%23%20Program%20to%20Convert%20a%202D%20Array%20into%201D%20Array.cs) |
| 2 | [Copy a Section of One Array to Another](csharp/Arrays/C%23%20Program%20to%20Copy%20a%20Section%20of%20One%20Array%20to%20Another.cs) |
| 3 | [Demonstrate Jagged Arrays](csharp/Arrays/C%23%20Program%20to%20Demonstrate%20Jagged%20Arrays.cs) |
| 4 | [Find Minimum and Maximum of Numbers](csharp/Arrays/C%23%20Program%20to%20Find%20Minimum%20and%20Maximum%20of%20Numbers.cs) |
| 5 | [Find the Average Values of all the Array Elements](csharp/Arrays/C%23%20Program%20to%20Find%20the%20Average%20Values%20of%20all%20the%20Array%20Elements.cs) |
| 6 | [Find the Length of the Jagged Array using Predefined Functions](csharp/Arrays/C%23%20Program%20to%20Find%20the%20Length%20of%20the%20Jagged%20Array%20using%20Predefined%20Functions.cs) |
| 7 | [Find the Rank of a given Array](csharp/Arrays/C%23%20Program%20to%20Find%20the%20Rank%20of%20a%20given%20Array.cs) |
| 8 | [Get 2 Arrays as Input and Produce a 3rd Array by Appending one to other](csharp/Arrays/C%23%20Program%20to%20Get%202%20Arrays%20as%20Input%20and%20Produce%20a%203rd%20Array%20by%20Appending%20one%20to%20other.cs) |
| 9 | [Get Lower Bound and Upper Bound of an Array](csharp/Arrays/C%23%20Program%20to%20Get%20Lower%20Bound%20and%20Upper%20Bound%20of%20an%20Array.cs) |
| 10 | [Get the Length of the Array](csharp/Arrays/C%23%20Program%20to%20get%20the%20Length%20of%20the%20Array.cs) |
| 11 | [Implement Use of Indexers](csharp/Arrays/C%23%20Program%20to%20Implement%20Use%20of%20Indexers.cs) |
| 12 | [Negate the Positive Elements of Array](csharp/Arrays/C%23%20Program%20to%20Negate%20the%20Positive%20Elements%20of%20Array.cs) |
| 13 | [Reverse an Array](csharp/Arrays/C%23%20Program%20to%20Reverse%20an%20Array.cs) |
| 14 | [Search an Element in an Array](csharp/Arrays/C%23%20Program%20to%20Search%20an%20Element%20in%20an%20Array.cs) |
| 15 | [Search an element with Array Indices](csharp/Arrays/C%23%20Program%20to%20Search%20an%20element%20with%20Array%20Indices.cs) |
| 16 | [Sort a List of Names in Alphabetical Order](csharp/Arrays/C%23%20Program%20to%20Sort%20a%20List%20of%20Names%20in%20Alphabetical%20Order.cs) |
| 17 | [A 2D array of size 3x3 and print the matrix](csharp/Arrays/C%23%20Sharp%20for%20a%202D%20array%20of%20size%203x3%20and%20print%20the%20matrix.cs) |
| 18 | [Addition of two Matrices of same size](csharp/Arrays/C%23%20Sharp%20for%20addition%20of%20two%20Matrices%20of%20same%20size.cs) |
| 19 | [Multiplication of two square Matrices](csharp/Arrays/C%23%20Sharp%20for%20multiplication%20of%20two%20square%20Matrices.cs) |
| 20 | [Subtraction of two Matrices](csharp/Arrays/C%23%20Sharp%20for%20subtraction%20of%20two%20Matrices.cs) |
| 21 | [Accept a matrix and determine whether it is a sparse matrix](csharp/Arrays/C%23%20Sharp%20to%20accept%20a%20matrix%20and%20determine%20whether%20it%20is%20a%20sparse%20matrix.cs) |
| 22 | [Accept two matrices and check whether they are equal](csharp/Arrays/C%23%20Sharp%20to%20accept%20two%20matrices%20and%20check%20whether%20they%20are%20equal.cs) |
| 23 | [Calculate determinant of a 3 x 3 matrix](csharp/Arrays/C%23%20Sharp%20to%20calculate%20determinant%20of%20a%203%20x%203%20matrix.cs) |
| 24 | [Check whether a Given Matrix is an Identity Matrix](csharp/Arrays/C%23%20Sharp%20to%20Check%20whether%20a%20Given%20Matrix%20is%20an%20Identity%20Matrix.cs) |
| 25 | [Copy the elements one array into another array](csharp/Arrays/C%23%20Sharp%20to%20copy%20the%20elements%20one%20array%20into%20another%20array.cs) |
| 26 | [Count a total number of duplicate elements in an array](csharp/Arrays/C%23%20Sharp%20to%20count%20a%20total%20number%20of%20duplicate%20elements%20in%20an%20array.cs) |
| 27 | [Count the frequency of each element of an array](csharp/Arrays/C%23%20Sharp%20to%20count%20the%20frequency%20of%20each%20element%20of%20an%20array.cs) |
| 28 | [Delete an element at desired position from an array](csharp/Arrays/C%23%20Sharp%20to%20delete%20an%20element%20at%20desired%20position%20from%20an%20array.cs) |
| 29 | [Find maximum and minimum element in an array](csharp/Arrays/C%23%20Sharp%20to%20find%20maximum%20and%20minimum%20element%20in%20an%20array.cs) |
| 30 | [Find second largest element in the array](csharp/Arrays/C%23%20Sharp%20to%20find%20second%20largest%20element%20in%20the%20array.cs) |
| 31 | [Find second smallest element in the array](csharp/Arrays/C%23%20Sharp%20to%20find%20second%20smallest%20element%20in%20the%20array.cs) |
| 32 | [Find sum of right diagonals of a matrix](csharp/Arrays/C%23%20Sharp%20to%20find%20sum%20of%20right%20diagonals%20of%20a%20matrix.cs) |
| 33 | [Find the sum of all elements of array](csharp/Arrays/C%23%20Sharp%20to%20find%20the%20sum%20of%20all%20elements%20of%20array.cs) |
| 34 | [Find the sum of rows an columns of a Matrix](csharp/Arrays/C%23%20Sharp%20to%20find%20the%20sum%20of%20rows%20an%20columns%20of%20a%20Matrix.cs) |
| 35 | [Find transpose of a given matrix](csharp/Arrays/C%23%20Sharp%20to%20find%20transpose%20of%20a%20given%20matrix.cs) |
| 36 | [Insert New value in the array (sorted list )](csharp/Arrays/C%23%20Sharp%20to%20insert%20New%20value%20in%20the%20array%20%28sorted%20list%20%29.cs) |
| 37 | [Insert New value in the array (unsorted list )](csharp/Arrays/C%23%20Sharp%20to%20insert%20New%20value%20in%20the%20array%20%28unsorted%20list%20%29.cs) |
| 38 | [Merge two arrays of same size sorted in ascending order](csharp/Arrays/C%23%20Sharp%20to%20merge%20two%20arrays%20of%20same%20size%20sorted%20in%20ascending%20order.cs) |
| 39 | [Print all unique elements in an array](csharp/Arrays/C%23%20Sharp%20to%20print%20all%20unique%20elements%20in%20an%20array.cs) |
| 40 | [Print or display the lower triangular of a given matrix](csharp/Arrays/C%23%20Sharp%20to%20print%20or%20display%20the%20lower%20triangular%20of%20a%20given%20matrix.cs) |
| 41 | [Print or display upper triangular matrix](csharp/Arrays/C%23%20Sharp%20to%20print%20or%20display%20upper%20triangular%20matrix.cs) |
| 42 | [Read n number of values in an array and display it in reverse order](csharp/Arrays/C%23%20Sharp%20to%20read%20n%20number%20of%20values%20in%20an%20array%20and%20display%20it%20in%20reverse%20order.cs) |
| 43 | [Separate odd and even integers in separate arrays](csharp/Arrays/C%23%20Sharp%20to%20separate%20odd%20and%20even%20integers%20in%20separate%20arrays.cs) |
| 44 | [Sort elements of array in ascending order](csharp/Arrays/C%23%20Sharp%20to%20sort%20elements%20of%20array%20in%20ascending%20order.cs) |
| 45 | [Sort elements of the array in descending order](csharp/Arrays/C%23%20Sharp%20to%20sort%20elements%20of%20the%20array%20in%20descending%20order.cs) |
| 46 | [Store elements in an array and print it](csharp/Arrays/C%23%20Sharp%20to%20store%20elements%20in%20an%20array%20and%20print%20it.cs) |

### Basic

| # | Description |
|---:|---|
| 1 | [Takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit](csharp/Basic/C%23%20program%20that%20takes%20a%20number%20as%20input%20and%20then%20displays%20a%20rectangle%20of%203%20columns%20wide%20and%205%20rows%20tall%20using%20that%20digit.cs) |
| 2 | [Accept a Number from the user and Display it if it is Positive](csharp/Basic/C%23%20Program%20to%20Accept%20a%20Number%20from%20the%20user%20and%20Display%20it%20if%20it%20is%20Positive.cs) |
| 3 | [Accept the Height of a Person & Categorize as Tall, Dwarf or Average](csharp/Basic/C%23%20Program%20to%20Accept%20the%20Height%20of%20a%20Person%20%26%20Categorize%20as%20Tall%2C%20Dwarf%20or%20Average.cs) |
| 4 | [Calculate Acceleration](csharp/Basic/C%23%20Program%20to%20Calculate%20Acceleration.cs) |
| 5 | [Check whether the Entered Number is Even or Odd](csharp/Basic/C%23%20Program%20to%20Check%20whether%20the%20Entered%20Number%20is%20Even%20or%20Odd.cs) |
| 6 | [Check Whether the Entered Year is a Leap Year or Not](csharp/Basic/C%23%20Program%20to%20Check%20Whether%20the%20Entered%20Year%20is%20a%20Leap%20Year%20or%20Not.cs) |
| 7 | [Check whether the given Integer has an Alternate Pattern](csharp/Basic/C%23%20Program%20to%20Check%20whether%20the%20given%20Integer%20has%20an%20Alternate%20Pattern.cs) |
| 8 | [Compare Two Dates](csharp/Basic/C%23%20Program%20to%20Compare%20Two%20Dates.cs) |
| 9 | [Compute Average for the Set of Values](csharp/Basic/C%23%20Program%20to%20Compute%20Average%20for%20the%20Set%20of%20Values.cs) |
| 10 | [Count the Number of 1’s in the Entered Number](csharp/Basic/C%23%20Program%20to%20Count%20the%20Number%20of%201%E2%80%99s%20in%20the%20Entered%20Number.cs) |
| 11 | [Create Sealed Class](csharp/Basic/C%23%20Program%20to%20Create%20Sealed%20Class.cs) |
| 12 | [Display All the Prime Numbers Between 1 to 100](csharp/Basic/C%23%20Program%20to%20Display%20All%20the%20Prime%20Numbers%20Between%201%20to%20100.cs) |
| 13 | [Display Numbers in the form of Triangle](csharp/Basic/C%23%20Program%20to%20Display%20Numbers%20in%20the%20form%20of%20Triangle.cs) |
| 14 | [Display Squarefeet of a House](csharp/Basic/C%23%20Program%20to%20Display%20Squarefeet%20of%20a%20House.cs) |
| 15 | [Display the ATM Transaction](csharp/Basic/C%23%20Program%20to%20Display%20the%20ATM%20Transaction.cs) |
| 16 | [Display the Date in Various Formats](csharp/Basic/C%23%20Program%20to%20Display%20the%20Date%20in%20Various%20Formats.cs) |
| 17 | [Find a Number using Pythagoras Theorem](csharp/Basic/C%23%20Program%20to%20Find%20a%20Number%20using%20Pythagoras%20Theorem.cs) |
| 18 | [Find Greatest among 2 numbers](csharp/Basic/C%23%20Program%20to%20Find%20Greatest%20among%202%20numbers.cs) |
| 19 | [Find Magnitude of Integer](csharp/Basic/C%23%20Program%20to%20Find%20Magnitude%20of%20Integer.cs) |
| 20 | [Generate Random Numbers](csharp/Basic/C%23%20Program%20to%20Generate%20Random%20Numbers.cs) |
| 21 | [Get a Number and Display the Number with its Reverse](csharp/Basic/C%23%20Program%20to%20Get%20a%20Number%20and%20Display%20the%20Number%20with%20its%20Reverse.cs) |
| 22 | [Get a Number and Display the Sum of the Digits](csharp/Basic/C%23%20Program%20to%20Get%20a%20Number%20and%20Display%20the%20Sum%20of%20the%20Digits.cs) |
| 23 | [Illustrate LeftShift Operations](csharp/Basic/C%23%20Program%20to%20Illustrate%20LeftShift%20Operations.cs) |
| 24 | [Illustrate the Use of Access Specifiers](csharp/Basic/C%23%20Program%20to%20Illustrate%20the%20Use%20of%20Access%20Specifiers.cs) |
| 25 | [Implement for-each in Inteface](csharp/Basic/C%23%20Program%20to%20Implement%20for-each%20in%20Inteface.cs) |
| 26 | [Implement PhoneBook](csharp/Basic/C%23%20Program%20to%20Implement%20PhoneBook.cs) |
| 27 | [Perform Division of Exponents of Same Base](csharp/Basic/C%23%20Program%20to%20Perform%20Division%20of%20Exponents%20of%20Same%20Base.cs) |
| 28 | [Perform Unboxing Operation](csharp/Basic/C%23%20Program%20to%20Perform%20Unboxing%20Operation.cs) |
| 29 | [Print a BinaryTriangle](csharp/Basic/C%23%20Program%20to%20Print%20a%20BinaryTriangle.cs) |
| 30 | [Print a Diamond Using Nested Loop](csharp/Basic/C%23%20Program%20to%20Print%20a%20Diamond%20Using%20Nested%20Loop.cs) |
| 31 | [Read a Grade & Display the Equivalent Description](csharp/Basic/C%23%20Program%20to%20Read%20a%20Grade%20%26%20Display%20the%20Equivalent%20Description.cs) |
| 32 | [Swap 2 Numbers](csharp/Basic/C%23%20Program%20to%20Swap%202%20Numbers.cs) |
| 33 | [Swap the Contents of two Numbers using Bitwise XOR Operation](csharp/Basic/C%23%20Program%20to%20Swap%20the%20Contents%20of%20two%20Numbers%20using%20Bitwise%20XOR%20Operation.cs) |
| 34 | [That takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation](csharp/Basic/C%23%20program%20to%20that%20takes%20a%20number%20as%20input%20and%20display%20it%20four%20times%20in%20a%20row%20%28separated%20by%20blank%20spaces%29%2C%20and%20then%20four%20times%20in%20the%20next%20row%2C%20with%20no%20separation.cs) |
| 35 | [Takes a number as input and print its multiplication table](csharp/Basic/C%23%20Sharp%20program%20that%20takes%20a%20number%20as%20input%20and%20print%20its%20multiplication%20table.cs) |
| 36 | [Takes an age (for example 20) as input and prints something as](csharp/Basic/C%23%20Sharp%20program%20that%20takes%20an%20age%20%28for%20example%2020%29%20as%20input%20and%20prints%20something%20as.cs) |
| 37 | [Takes four numbers as input to calculate and print the average](csharp/Basic/C%23%20Sharp%20program%20that%20takes%20four%20numbers%20as%20input%20to%20calculate%20and%20print%20the%20average.cs) |
| 38 | [Convert from celsius degrees to Kelvin and Fahrenheit](csharp/Basic/C%23%20Sharp%20program%20to%20convert%20from%20celsius%20degrees%20to%20Kelvin%20and%20Fahrenheit.cs) |
| 39 | [Print Hello and your name in a separate line](csharp/Basic/C%23%20Sharp%20program%20to%20print%20Hello%20and%20your%20name%20in%20a%20separate%20line.cs) |
| 40 | [Print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will be entered by the user](csharp/Basic/C%23%20Sharp%20program%20to%20print%20on%20screen%20the%20output%20of%20adding%2C%20subtracting%2C%20multiplying%20and%20dividing%20of%20two%20numbers%20which%20will%20be%20entered%20by%20the%20user.cs) |
| 41 | [Print the output of multiplication of three numbers which will be entered by the user](csharp/Basic/C%23%20Sharp%20program%20to%20print%20the%20output%20of%20multiplication%20of%20three%20numbers%20which%20will%20be%20entered%20by%20the%20user.cs) |
| 42 | [Print the result of dividing two numbers](csharp/Basic/C%23%20Sharp%20program%20to%20print%20the%20result%20of%20dividing%20two%20numbers.cs) |
| 43 | [Print the result of the specified operations](csharp/Basic/C%23%20Sharp%20program%20to%20print%20the%20result%20of%20the%20specified%20operations.cs) |
| 44 | [Print the sum of two numbers](csharp/Basic/C%23%20Sharp%20program%20to%20print%20the%20sum%20of%20two%20numbers.cs) |
| 45 | [Swap two numbers](csharp/Basic/C%23%20Sharp%20program%20to%20swap%20two%20numbers.cs) |
| 46 | [That takes three numbers(x,y,z) as input and print the output of (x+y)úz and xúy + yúz](csharp/Basic/C%23%20Sharp%20program%20to%20that%20takes%20three%20numbers%28x%2Cy%2Cz%29%20as%20input%20and%20print%20the%20output%20of%20%28x%2By%29%C3%BAz%20and%20x%C3%BAy%20%2B%20y%C3%BAz.cs) |

### Conversions

| # | Description |
|---:|---|
| 1 | [Convert a Given Number of Days in terms of Years, Weeks & Days](csharp/Conversions/C%23%20Program%20to%20Convert%20a%20Given%20Number%20of%20Days%20in%20terms%20of%20Years%2C%20Weeks%20%26%20Days.cs) |
| 2 | [Convert Big Endian to Little Endian](csharp/Conversions/C%23%20Program%20to%20Convert%20Big%20Endian%20to%20Little%20Endian.cs) |
| 3 | [Convert Decimal to Binary](csharp/Conversions/C%23%20Program%20to%20Convert%20Decimal%20to%20Binary.cs) |
| 4 | [Convert Decimal to Octal](csharp/Conversions/C%23%20Program%20to%20Convert%20Decimal%20to%20Octal.cs) |
| 5 | [Convert Digits to Words](csharp/Conversions/C%23%20Program%20to%20Convert%20Digits%20to%20Words.cs) |
| 6 | [Convert Fahrenheit to Celsius](csharp/Conversions/C%23%20Program%20to%20Convert%20Fahrenheit%20to%20Celsius.cs) |
| 7 | [Convert Infix to Postfix](csharp/Conversions/C%23%20Program%20to%20Convert%20Infix%20to%20Postfix.cs) |
| 8 | [Covert HexaDecimal Number to Decimal](csharp/Conversions/C%23%20Program%20to%20Covert%20HexaDecimal%20Number%20to%20Decimal.cs) |
| 9 | [Create a Gray Code](csharp/Conversions/C%23%20Program%20to%20Create%20a%20Gray%20Code.cs) |
| 10 | [Demonstrate DefaultIfEmpty case](csharp/Conversions/C%23%20Program%20to%20Demonstrate%20DefaultIfEmpty%20case.cs) |
| 11 | [Obtain the Character from the User and Convert the Case of the Character](csharp/Conversions/C%23%20Program%20to%20Obtain%20the%20Character%20from%20the%20User%20and%20Convert%20the%20Case%20of%20the%20Character.cs) |
| 12 | [Perfom Currency Conversions](csharp/Conversions/C%23%20Program%20to%20Perfom%20Currency%20Conversions.cs) |
| 13 | [Perform Binary to Decimal Conversion](csharp/Conversions/C%23%20Program%20to%20Perform%20Binary%20to%20Decimal%20Conversion.cs) |
| 14 | [Perform Celsius to Fahrenheit Conversion](csharp/Conversions/C%23%20Program%20to%20Perform%20Celsius%20to%20Fahrenheit%20Conversion.cs) |
| 15 | [Perform Conversions of Meter to Kilometer and viceversa](csharp/Conversions/C%23%20Program%20to%20Perform%20Conversions%20of%20Meter%20to%20Kilometer%20and%20viceversa.cs) |
| 16 | [Perform Decimal to HexaDecimal Conversion](csharp/Conversions/C%23%20Program%20to%20Perform%20Decimal%20to%20HexaDecimal%20Conversion.cs) |

### DataStructures

| # | Description |
|---:|---|
| 1 | [Create a Singly Linked Circular List](csharp/DataStructures/C%23%20Program%20to%20Create%20a%20Singly%20Linked%20Circular%20List.cs) |
| 2 | [Create an Instance of StackTrace and to Get all Frames](csharp/DataStructures/C%23%20Program%20to%20Create%20an%20Instance%20of%20StackTrace%20and%20to%20Get%20all%20Frames.cs) |
| 3 | [Implement Binary Search Tree using Linked List](csharp/DataStructures/C%23%20Program%20to%20Implement%20Binary%20Search%20Tree%20using%20Linked%20List.cs) |
| 4 | [Implement Stack with Push and Pop operations](csharp/DataStructures/C%23%20Program%20to%20Implement%20Stack%20with%20Push%20and%20Pop%20operations.cs) |
| 5 | [Implement Traversal in Singly Linked List](csharp/DataStructures/C%23%20Program%20to%20Implement%20Traversal%20in%20Singly%20Linked%20List.cs) |

### Delegates

| # | Description |
|---:|---|
| 1 | [Call Math Operations using Delegates](csharp/Delegates/C%23%20Program%20to%20Call%20Math%20Operations%20using%20Delegates..cs) |
| 2 | [Combine Two Delegates](csharp/Delegates/C%23%20Program%20to%20Combine%20Two%20Delegates..cs) |
| 3 | [Convert Feet to Inches using Delegates](csharp/Delegates/C%23%20Program%20to%20Convert%20Feet%20to%20Inches%20using%20Delegates..cs) |
| 4 | [Create Generic Delegate](csharp/Delegates/C%23%20Program%20to%20Create%20Generic%20Delegate..cs) |
| 5 | [Declare and Instantiate Delegates](csharp/Delegates/C%23%20Program%20to%20Declare%20and%20Instantiate%20Delegates..cs) |
| 6 | [Display Results using Delegates](csharp/Delegates/C%23%20Program%20to%20Display%20Results%20using%20Delegates..cs) |
| 7 | [Illustrate Array of Delegates](csharp/Delegates/C%23%20Program%20to%20Illustrate%20Array%20of%20Delegates..cs) |
| 8 | [Implement Arithmetic Operations using Delegates](csharp/Delegates/C%23%20Program%20to%20Implement%20Arithmetic%20Operations%20using%20Delegates..cs) |
| 9 | [Implement Delegates](csharp/Delegates/C%23%20Program%20to%20Implement%20Delegates..cs) |
| 10 | [Implement Multicast Delegates](csharp/Delegates/C%23%20Program%20to%20Implement%20Multicast%20Delegates..cs) |
| 11 | [Implement Principles of Delegates](csharp/Delegates/C%23%20Program%20to%20Implement%20Principles%20of%20Delegates..cs) |
| 12 | [Use Delegate to Call 2 Methods within which First method Prints to Console and Second Method Prints to File](csharp/Delegates/C%23%20Program%20to%20Use%20Delegate%20to%20Call%202%20Methods%20within%20which%20First%20method%20Prints%20to%20Console%20and%20Second%20Method%20Prints%20to%20File..cs) |

### Events

| # | Description |
|---:|---|
| 1 | [Add Two TimeSpan](csharp/Events/C%23%20Program%20to%20Add%20Two%20TimeSpan.cs) |
| 2 | [Create a Progress Bar Control](csharp/Events/C%23%20Program%20to%20Create%20a%20Progress%20Bar%20Control.cs) |
| 3 | [Create Input Box and Display the Text](csharp/Events/C%23%20Program%20to%20Create%20Input%20Box%20and%20Display%20the%20Text.cs) |
| 4 | [Create Radio Button and Demonstrate its Use](csharp/Events/C%23%20Program%20to%20Create%20Radio%20Button%20and%20Demonstrate%20its%20Use.cs) |
| 5 | [Create Stop Watch](csharp/Events/C%23%20Program%20to%20Create%20Stop%20Watch.cs) |
| 6 | [Demonstrate Trigger Concept](csharp/Events/C%23%20Program%20to%20Demonstrate%20Trigger%20Concept.cs) |
| 7 | [Demonstrate Use of Clone](csharp/Events/C%23%20Program%20to%20Demonstrate%20Use%20of%20Clone.cs) |
| 8 | [Detect Whether ENTER key is Pressed or Not](csharp/Events/C%23%20Program%20to%20Detect%20Whether%20ENTER%20key%20is%20Pressed%20or%20Not.cs) |
| 9 | [Get the DayLight Saving Information](csharp/Events/C%23%20Program%20to%20Get%20the%20DayLight%20Saving%20Information.cs) |
| 10 | [Get the Local Time](csharp/Events/C%23%20Program%20to%20get%20the%20Local%20Time.cs) |
| 11 | [Get the Universal Time](csharp/Events/C%23%20Program%20to%20get%20the%20Universal%20Time.cs) |
| 12 | [Illustrate Actions](csharp/Events/C%23%20Program%20to%20Illustrate%20Actions.cs) |
| 13 | [Illustrate Elapsed Event](csharp/Events/C%23%20Program%20to%20Illustrate%20Elapsed%20Event.cs) |
| 14 | [Illustrate Predicate](csharp/Events/C%23%20Program%20to%20Illustrate%20Predicate.cs) |
| 15 | [Perform Addition with MOUSEUP Event](csharp/Events/C%23%20Program%20to%20Perform%20Addition%20with%20MOUSEUP%20Event.cs) |
| 16 | [Perform Subtraction with Key Up Event](csharp/Events/C%23%20Program%20to%20Perform%20Subtraction%20with%20Key%20Up%20Event.cs) |

### Exception

| # | Description |
|---:|---|
| 1 | [Demonstrate DivideByZero Exception](csharp/Exception/C%23%20Program%20to%20Demonstrate%20DivideByZero%20Exception.cs) |
| 2 | [Demonstrate Exception Handling for Stack Overflow](csharp/Exception/C%23%20Program%20to%20Demonstrate%20Exception%20Handling%20for%20Stack%20Overflow.cs) |
| 3 | [Demonstrate IndexOutOfRange Exception](csharp/Exception/C%23%20Program%20to%20Demonstrate%20IndexOutOfRange%20Exception.cs) |
| 4 | [Demonstrate Multiple Exceptions](csharp/Exception/C%23%20Program%20to%20Demonstrate%20Multiple%20Exceptions.cs) |
| 5 | [Illustrate Exception Handling for Invalid TypeCasting in UnBoxing](csharp/Exception/C%23%20Program%20to%20Illustrate%20Exception%20Handling%20for%20Invalid%20TypeCasting%20in%20UnBoxing.cs) |
| 6 | [Illustrate NullRefernce Exception](csharp/Exception/C%23%20Program%20to%20Illustrate%20NullRefernce%20Exception.cs) |

### Files

| # | Description |
|---:|---|
| 1 | [Calculate the Size of Folder](csharp/Files/C%23%20Program%20to%20Calculate%20the%20Size%20of%20Folder.cs) |
| 2 | [Check the Existence of a File](csharp/Files/C%23%20Program%20to%20Check%20the%20Existence%20of%20a%20File.cs) |
| 3 | [Copy the Contents from one File to another File](csharp/Files/C%23%20Program%20to%20Copy%20the%20Contents%20from%20one%20File%20to%20another%20File.cs) |
| 4 | [Create a Directory](csharp/Files/C%23%20Program%20to%20Create%20a%20Directory.cs) |
| 5 | [Create a File](csharp/Files/C%23%20Program%20to%20Create%20a%20File.cs) |
| 6 | [Demonstrate StringReader](csharp/Files/C%23%20Program%20to%20Demonstrate%20StringReader.cs) |
| 7 | [Get Content from a File and Read the Content 1 Byte at a Time](csharp/Files/C%23%20Program%20to%20Get%20Content%20from%20a%20File%20and%20Read%20the%20Content%201%20Byte%20at%20a%20Time.cs) |
| 8 | [Get File Time using File Class](csharp/Files/C%23%20Program%20to%20Get%20File%20Time%20using%20File%20Class.cs) |
| 9 | [Illustrate Memory Stream Class](csharp/Files/C%23%20Program%20to%20Illustrate%20Memory%20Stream%20Class.cs) |
| 10 | [Illustrate Methods of FileInfo Class](csharp/Files/C%23%20Program%20to%20Illustrate%20Methods%20of%20FileInfo%20Class.cs) |
| 11 | [Illustrate StringBuilder](csharp/Files/C%23%20Program%20to%20Illustrate%20StringBuilder.cs) |
| 12 | [Illustrate StringWriter](csharp/Files/C%23%20Program%20to%20Illustrate%20StringWriter.cs) |
| 13 | [Implement BinaryReader](csharp/Files/C%23%20Program%20to%20Implement%20BinaryReader.cs) |
| 14 | [List Disk Drives](csharp/Files/C%23%20Program%20to%20List%20Disk%20Drives.cs) |
| 15 | [List the Files in a Directory](csharp/Files/C%23%20Program%20to%20List%20the%20Files%20in%20a%20Directory.cs) |
| 16 | [Perform File Comparison](csharp/Files/C%23%20Program%20to%20Perform%20File%20Comparison.cs) |
| 17 | [Perform Text Operations in a File](csharp/Files/C%23%20Program%20to%20Perform%20Text%20Operations%20in%20a%20File.cs) |
| 18 | [Read Data from Stream and Cast Data to Chars](csharp/Files/C%23%20Program%20to%20Read%20Data%20from%20Stream%20and%20Cast%20Data%20to%20Chars.cs) |
| 19 | [Read Lines from a File until the End of File is Reached](csharp/Files/C%23%20Program%20to%20Read%20Lines%20from%20a%20File%20until%20the%20End%20of%20File%20is%20Reached.cs) |
| 20 | [Read the Contents of the File](csharp/Files/C%23%20Program%20to%20Read%20the%20Contents%20of%20the%20File.cs) |
| 21 | [Search Directories and List Files](csharp/Files/C%23%20Program%20to%20Search%20Directories%20and%20List%20Files.cs) |
| 22 | [Trap Events from File](csharp/Files/C%23%20Program%20to%20Trap%20Events%20from%20File.cs) |
| 23 | [Use StreamReader to Read Entire Line](csharp/Files/C%23%20Program%20to%20Use%20StreamReader%20to%20Read%20Entire%20Line.cs) |
| 24 | [View the Date and time of Access of a File](csharp/Files/C%23%20Program%20to%20View%20the%20Date%20and%20time%20of%20Access%20of%20a%20File.cs) |
| 25 | [View the Information of the File](csharp/Files/C%23%20Program%20to%20View%20the%20Information%20of%20the%20File.cs) |
| 26 | [Append some text to an existing file](csharp/Files/C%23%20Sharp%20to%20append%20some%20text%20to%20an%20existing%20file.cs) |
| 27 | [Count the number of lines in a file](csharp/Files/C%23%20Sharp%20to%20count%20the%20number%20of%20lines%20in%20a%20file.cs) |
| 28 | [Create a file and move the file into the same directory to another name](csharp/Files/C%23%20Sharp%20to%20create%20a%20file%20and%20move%20the%20file%20into%20the%20same%20directory%20to%20another%20name.cs) |
| 29 | [Create a file and write an array of strings to the file](csharp/Files/C%23%20Sharp%20to%20create%20a%20file%20and%20write%20an%20array%20of%20strings%20to%20the%20file.cs) |
| 30 | [Create and copy the file to another name and display the content](csharp/Files/C%23%20Sharp%20to%20create%20and%20copy%20the%20file%20to%20another%20name%20and%20display%20the%20content.cs) |
| 31 | [Create and read last n number of lines of a file](csharp/Files/C%23%20Sharp%20to%20create%20and%20read%20last%20n%20number%20of%20lines%20of%20a%20file.cs) |
| 32 | [Create and read the last line of a file](csharp/Files/C%23%20Sharp%20to%20create%20and%20read%20the%20last%20line%20of%20a%20file.cs) |
| 33 | [Create and write some line of text into a file which does not contain a given string in a line](csharp/Files/C%23%20Sharp%20to%20create%20and%20write%20some%20line%20of%20text%20into%20a%20file%20which%20does%20not%20contain%20a%20given%20string%20in%20a%20line.cs) |
| 34 | [Read a specific line from a file](csharp/Files/C%23%20Sharp%20to%20read%20a%20specific%20line%20from%20a%20file.cs) |
| 35 | [Read the first line from a file](csharp/Files/C%23%20Sharp%20to%20read%20the%20first%20line%20from%20a%20file.cs) |

### Functions

| # | Description |
|---:|---|
| 1 | [Illustrate Method Hiding](csharp/Functions/C%23%20Program%20Illustrate%20Method%20Hiding.cs) |
| 2 | [Create Anonymous Method](csharp/Functions/C%23%20Program%20to%20Create%20Anonymous%20Method.cs) |
| 3 | [Create Obsolete Class](csharp/Functions/C%23%20Program%20to%20Create%20Obsolete%20Class.cs) |
| 4 | [Demonstrate Abstract Properties](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Abstract%20Properties.cs) |
| 5 | [Demonstrate Boxing Operations](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Boxing%20Operations.cs) |
| 6 | [Demonstrate Culture Names](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Culture%20Names.cs) |
| 7 | [Demonstrate Environment Type](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Environment%20Type.cs) |
| 8 | [Demonstrate iscollection](csharp/Functions/C%23%20Program%20to%20Demonstrate%20iscollection.cs) |
| 9 | [Demonstrate New Modifier](csharp/Functions/C%23%20Program%20to%20Demonstrate%20New%20Modifier.cs) |
| 10 | [Demonstrate Pass by Reference Parameter](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Pass%20by%20Reference%20Parameter.cs) |
| 11 | [Demonstrate Pass by Value Parameter](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Pass%20by%20Value%20Parameter.cs) |
| 12 | [Demonstrate Properties of the Class](csharp/Functions/C%23%20Program%20to%20Demonstrate%20Properties%20of%20the%20Class.cs) |
| 13 | [Demonstrate the icollection Count](csharp/Functions/C%23%20Program%20to%20Demonstrate%20the%20icollection%20Count.cs) |
| 14 | [Demonstrate the Operations of C# Path Class](csharp/Functions/C%23%20Program%20to%20Demonstrate%20the%20Operations%20of%20C%23%20Path%20Class.cs) |
| 15 | [Demonstrate the Working #define Preprocessor](csharp/Functions/C%23%20Program%20to%20Demonstrate%20the%20Working%20%23define%20Preprocessor.cs) |
| 16 | [Find Product of 2 Numbers using Recursion](csharp/Functions/C%23%20Program%20to%20find%20Product%20of%202%20Numbers%20using%20Recursion.cs) |
| 17 | [Find Sum of Digits of a Number using Recursion](csharp/Functions/C%23%20Program%20to%20Find%20Sum%20of%20Digits%20of%20a%20Number%20using%20Recursion.cs) |
| 18 | [Illustrate Regular Expression Pattern](csharp/Functions/C%23%20Program%20to%20Illustrate%20Regular%20Expression%20Pattern.cs) |
| 19 | [Illustrate the Concept of Goto](csharp/Functions/C%23%20Program%20to%20Illustrate%20the%20Concept%20of%20Goto.cs) |
| 20 | [Illustrate the use of Conditional Logical Operator](csharp/Functions/C%23%20Program%20to%20Illustrate%20the%20use%20of%20Conditional%20Logical%20Operator.cs) |
| 21 | [Ilustrate Nullable Data Types](csharp/Functions/C%23%20Program%20to%20Ilustrate%20Nullable%20Data%20Types.cs) |
| 22 | [Implement Namespaces](csharp/Functions/C%23%20Program%20to%20Implement%20Namespaces.cs) |
| 23 | [Implement Static Method](csharp/Functions/C%23%20Program%20to%20Implement%20Static%20Method.cs) |
| 24 | [Print Binary Equivalent of an Integer using Recursion](csharp/Functions/C%23%20Program%20to%20Print%20Binary%20Equivalent%20of%20an%20Integer%20using%20Recursion.cs) |
| 25 | [Print Hello World Without using WriteLine](csharp/Functions/C%23%20Program%20to%20Print%20Hello%20World%20Without%20using%20WriteLine.cs) |
| 26 | [Produce a filtered sequence of elements that contain only one property of each Student](csharp/Functions/C%23%20Program%20to%20Produce%20a%20filtered%20sequence%20of%20elements%20that%20contain%20only%20one%20property%20of%20each%20Student.cs) |
| 27 | [Reverse a String with Predefined Function](csharp/Functions/C%23%20Program%20to%20Reverse%20a%20String%20with%20Predefined%20Function.cs) |
| 28 | [Sort a String using Predefined Function](csharp/Functions/C%23%20Program%20to%20Sort%20a%20String%20using%20Predefined%20Function.cs) |

### Games_&_Threads

| # | Description |
|---:|---|
| 1 | [Assign Name to Thread by using Name Property](csharp/Games_%26_Threads/C%23%20Program%20to%20Assign%20Name%20to%20Thread%20by%20using%20Name%20Property.cs) |
| 2 | [Create a HangMan Game](csharp/Games_%26_Threads/C%23%20Program%20to%20Create%20a%20HangMan%20Game.cs) |
| 3 | [Create a Simple Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Create%20a%20Simple%20Thread.cs) |
| 4 | [Create Thread Pools](csharp/Games_%26_Threads/C%23%20Program%20to%20Create%20Thread%20Pools.cs) |
| 5 | [Demonstrate Lock in Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Demonstrate%20Lock%20in%20Thread.cs) |
| 6 | [Demonstrate Tower Of Hanoi](csharp/Games_%26_Threads/C%23%20Program%20to%20Demonstrate%20Tower%20Of%20Hanoi.cs) |
| 7 | [Display the Name of the Current Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Display%20the%20Name%20of%20the%20Current%20Thread.cs) |
| 8 | [Display the Priority of the Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Display%20the%20Priority%20of%20the%20Thread.cs) |
| 9 | [Find the Current Context id of the Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Find%20the%20Current%20Context%20id%20of%20the%20Thread.cs) |
| 10 | [Illustrate the Concept of Passing Parameter for Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Illustrate%20the%20Concept%20of%20Passing%20Parameter%20for%20Thread.cs) |
| 11 | [Implement Sleep method of Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Implement%20Sleep%20method%20of%20Thread.cs) |
| 12 | [Kill a Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Kill%20a%20Thread.cs) |
| 13 | [Obtain Status of the Current Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Obtain%20Status%20of%20the%20Current%20Thread.cs) |
| 14 | [Pause a Thread](csharp/Games_%26_Threads/C%23%20Program%20to%20Pause%20a%20Thread.cs) |
| 15 | [Perform a Number Guessing Game](csharp/Games_%26_Threads/C%23%20Program%20to%20Perform%20a%20Number%20Guessing%20Game.cs) |
| 16 | [Prefix Game](csharp/Games_%26_Threads/C%23%20Program%20to%20Prefix%20Game.cs) |

### Inheritance_&_Interface

| # | Description |
|---:|---|
| 1 | [Demonstrate iDictionary Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20iDictionary%20Interface.cs) |
| 2 | [Demonstrate IDumpable Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20IDumpable%20Interface.cs) |
| 3 | [Demonstrate iList Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20iList%20Interface.cs) |
| 4 | [Demonstrate Multilevel Inheritance](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20Multilevel%20Inheritance.cs) |
| 5 | [Demonstrate Properties of the Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20Properties%20of%20the%20Interface.cs) |
| 6 | [Demonstrate Transactions using Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Demonstrate%20Transactions%20using%20Interface.cs) |
| 7 | [Display Cost of a Rectangle Plot Using Inheritance](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Display%20Cost%20of%20a%20Rectangle%20Plot%20Using%20Inheritance.cs) |
| 8 | [IIlustrate Handling an Event Declared in an Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20IIlustrate%20Handling%20an%20Event%20Declared%20in%20an%20Interface.cs) |
| 9 | [Illustrate Hierarchical Inheritance](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Illustrate%20Hierarchical%20Inheritance.cs) |
| 10 | [Illustrate Multilevel Inheritance with Virtual Methods](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Illustrate%20Multilevel%20Inheritance%20with%20Virtual%20Methods.cs) |
| 11 | [Illustrate Single Inheritance](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Illustrate%20Single%20Inheritance.cs) |
| 12 | [Implement IComparable Interface](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Implement%20IComparable%20Interface.cs) |
| 13 | [Implement IEnumerable Interface using LINQ](csharp/Inheritance_%26_Interface/C%23%20Program%20to%20Implement%20IEnumerable%20Interface%20using%20LINQ.cs) |

### Linq

| # | Description |
|---:|---|
| 1 | [Calculate Size of File using LINQ](csharp/Linq/C%23%20Program%20to%20Calculate%20Size%20of%20File%20using%20LINQ.cs) |
| 2 | [Count File Extensions and Group it using LINQ](csharp/Linq/C%23%20Program%20to%20Count%20File%20Extensions%20and%20Group%20it%20using%20LINQ.cs) |
| 3 | [Display the Greatest numbers in an Array using WHERE Clause LINQ](csharp/Linq/C%23%20Program%20to%20Display%20the%20Greatest%20numbers%20in%20an%20Array%20using%20WHERE%20Clause%20LINQ.cs) |
| 4 | [Display the Smallest numbers in an Array using FROM Clause LINQ](csharp/Linq/C%23%20Program%20to%20Display%20the%20Smallest%20numbers%20in%20an%20Array%20using%20FROM%20Clause%20LINQ.cs) |
| 5 | [Display the Student Details using Select Clause LINQ](csharp/Linq/C%23%20Program%20to%20Display%20the%20Student%20Details%20using%20Select%20Clause%20LINQ.cs) |
| 6 | [Divide Sequence into Groups using LINQ](csharp/Linq/C%23%20Program%20to%20Divide%20Sequence%20into%20Groups%20using%20LINQ.cs) |
| 7 | [Generate Odd Numbers in Parallel using LINQ](csharp/Linq/C%23%20Program%20to%20Generate%20Odd%20Numbers%20in%20Parallel%20using%20LINQ.cs) |
| 8 | [Implement IEnumerable Interface using LINQ](csharp/Linq/C%23%20Program%20to%20Implement%20IEnumerable%20Interface%20using%20LINQ.cs) |
| 9 | [Implement Let Condition using LINQ](csharp/Linq/C%23%20Program%20to%20Implement%20Let%20Condition%20using%20LINQ.cs) |
| 10 | [Accept the members of a list through the keyboard and display the members more than a specific value](csharp/Linq/C%23%20Sharp%20to%20Accept%20the%20members%20of%20a%20list%20through%20the%20keyboard%20and%20display%20the%20members%20more%20than%20a%20specific%20value.cs) |
| 11 | [Calculate Size of File using LINQ](csharp/Linq/C%23%20Sharp%20to%20Calculate%20Size%20of%20File%20using%20LINQ.cs) |
| 12 | [Convert a string array to a string](csharp/Linq/C%23%20Sharp%20to%20convert%20a%20string%20array%20to%20a%20string.cs) |
| 13 | [Create a list of numbers and display the numbers greater than 80 as output](csharp/Linq/C%23%20Sharp%20to%20create%20a%20list%20of%20numbers%20and%20display%20the%20numbers%20greater%20than%2080%20as%20output.cs) |
| 14 | [Display numbers, multiplication of number with frequency and the frequency of number of giving array](csharp/Linq/C%23%20Sharp%20to%20display%20numbers%2C%20multiplication%20of%20number%20with%20frequency%20and%20the%20frequency%20of%20number%20of%20giving%20array.cs) |
| 15 | [Display the characters and frequency of character from giving string](csharp/Linq/C%23%20Sharp%20to%20display%20the%20characters%20and%20frequency%20of%20character%20from%20giving%20string.cs) |
| 16 | [Display the name of the days of a week](csharp/Linq/C%23%20Sharp%20to%20display%20the%20name%20of%20the%20days%20of%20a%20week.cs) |
| 17 | [Display the number and frequency of number from given array](csharp/Linq/C%23%20Sharp%20to%20display%20the%20number%20and%20frequency%20of%20number%20from%20given%20array.cs) |
| 18 | [Display the top nth records](csharp/Linq/C%23%20Sharp%20to%20display%20the%20top%20nth%20records.cs) |
| 19 | [Find the +ve numbers from a list of numbers using two where conditions in LINQ Query](csharp/Linq/C%23%20Sharp%20to%20find%20the%20%2Bve%20numbers%20from%20a%20list%20of%20numbers%20using%20two%20where%20conditions%20in%20LINQ%20Query.cs) |
| 20 | [Find the n-th Maximum grade point achieved by the students from the list of students](csharp/Linq/C%23%20Sharp%20to%20find%20the%20n-th%20Maximum%20grade%20point%20achieved%20by%20the%20students%20from%20the%20list%20of%20students.cs) |
| 21 | [Find the number of an array and the square of each number which is more than 20](csharp/Linq/C%23%20Sharp%20to%20find%20the%20number%20of%20an%20array%20and%20the%20square%20of%20each%20number%20which%20is%20more%20than%2020.cs) |
| 22 | [Find the string which starts and ends with a specific character](csharp/Linq/C%23%20Sharp%20to%20find%20the%20string%20which%20starts%20and%20ends%20with%20a%20specific%20character.cs) |
| 23 | [Find the strings for a specific minimum length](csharp/Linq/C%23%20Sharp%20to%20find%20the%20strings%20for%20a%20specific%20minimum%20length.cs) |
| 24 | [Find the uppercase words in a string](csharp/Linq/C%23%20Sharp%20to%20find%20the%20uppercase%20words%20in%20a%20string.cs) |
| 25 | [Generate a Cartesian Product of three sets](csharp/Linq/C%23%20Sharp%20to%20generate%20a%20Cartesian%20Product%20of%20three%20sets.cs) |
| 26 | [Generate a Cartesian Product of two sets](csharp/Linq/C%23%20Sharp%20to%20generate%20a%20Cartesian%20Product%20of%20two%20sets.cs) |
| 27 | [Generate an Inner Join between two data sets](csharp/Linq/C%23%20Sharp%20to%20generate%20an%20Inner%20Join%20between%20two%20data%20sets.cs) |
| 28 | [Remove a range of items from a list by passing the start index and number of elements to remove](csharp/Linq/C%23%20Sharp%20to%20remove%20a%20range%20of%20items%20from%20a%20list%20by%20passing%20the%20start%20index%20and%20number%20of%20elements%20to%20remove.cs) |
| 29 | [Remove Items from List by creating an object internally by filtering](csharp/Linq/C%23%20Sharp%20to%20Remove%20Items%20from%20List%20by%20creating%20an%20object%20internally%20by%20filtering.cs) |
| 30 | [Remove Items from List by passing filters](csharp/Linq/C%23%20Sharp%20to%20Remove%20Items%20from%20List%20by%20passing%20filters.cs) |
| 31 | [Remove Items from List by passing the item index](csharp/Linq/C%23%20Sharp%20to%20Remove%20Items%20from%20List%20by%20passing%20the%20item%20index.cs) |
| 32 | [Remove Items from List using remove function by passing object](csharp/Linq/C%23%20Sharp%20to%20Remove%20Items%20from%20List%20using%20remove%20function%20by%20passing%20object.cs) |
| 33 | [Shows how the three parts of a query operation execute](csharp/Linq/C%23%20Sharp%20to%20shows%20how%20the%20three%20parts%20of%20a%20query%20operation%20execute.cs) |

### Mathematics

| # | Description |
|---:|---|
| 1 | [Add 2 Complex Numbers](csharp/Mathematics/C%23%20Program%20to%20Add%202%20Complex%20Numbers.cs) |
| 2 | [Add Two Dates](csharp/Mathematics/C%23%20Program%20to%20Add%20Two%20Dates.cs) |
| 3 | [Calculate Area and Volume of a Cone](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Area%20and%20Volume%20of%20a%20Cone.cs) |
| 4 | [Calculate Compound Interest](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Compound%20Interest.cs) |
| 5 | [Calculate Fractional Power](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Fractional%20Power.cs) |
| 6 | [Calculate nPr](csharp/Mathematics/C%23%20Program%20to%20Calculate%20nPr.cs) |
| 7 | [Calculate Perimeter of Circle and Rectangle](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Perimeter%20of%20Circle%20and%20Rectangle.cs) |
| 8 | [Calculate Period Duration](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Period%20Duration.cs) |
| 9 | [Calculate Power of Three](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Power%20of%20Three.cs) |
| 10 | [Calculate Simple Interest](csharp/Mathematics/C%23%20Program%20to%20Calculate%20Simple%20Interest.cs) |
| 11 | [Calculate the Distance Travelled by Reading Speed and Time](csharp/Mathematics/C%23%20Program%20to%20Calculate%20the%20Distance%20Travelled%20by%20Reading%20Speed%20and%20Time.cs) |
| 12 | [Calculate the Power Exponent Value](csharp/Mathematics/C%23%20Program%20to%20Calculate%20the%20Power%20Exponent%20Value.cs) |
| 13 | [Calculate the series sin(x)](csharp/Mathematics/C%23%20Program%20to%20calculate%20the%20series%20sin%28x%29.cs) |
| 14 | [Calculate the Value of nCr](csharp/Mathematics/C%23%20Program%20to%20Calculate%20the%20Value%20of%20nCr.cs) |
| 15 | [Check the Edge Values in Power Function](csharp/Mathematics/C%23%20Program%20to%20Check%20the%20Edge%20Values%20in%20Power%20Function.cs) |
| 16 | [Check Whether the Entered Number is a Amicable Number or Not](csharp/Mathematics/C%23%20Program%20to%20Check%20Whether%20the%20Entered%20Number%20is%20a%20Amicable%20Number%20or%20Not.cs) |
| 17 | [Check Whether the Entered Number is a Perfect Number or Not](csharp/Mathematics/C%23%20Program%20to%20Check%20Whether%20the%20Entered%20Number%20is%20a%20Perfect%20Number%20or%20Not.cs) |
| 18 | [Check Whether the Entered Number is an Armstrong Number or Not](csharp/Mathematics/C%23%20Program%20to%20Check%20Whether%20the%20Entered%20Number%20is%20an%20Armstrong%20Number%20or%20Not.cs) |
| 19 | [Check Whether the Given Number is a Prime number if so then Display its Largest Facor](csharp/Mathematics/C%23%20Program%20to%20Check%20Whether%20the%20Given%20Number%20is%20a%20Prime%20number%20if%20so%20then%20Display%20its%20Largest%20Facor.cs) |
| 20 | [Display Absolute value of a Number](csharp/Mathematics/C%23%20Program%20to%20Display%20Absolute%20value%20of%20a%20Number.cs) |
| 21 | [Display Floyd’s Triangle with an Numeric Mode](csharp/Mathematics/C%23%20Program%20to%20Display%20Floyd%E2%80%99s%20Triangle%20with%20an%20Numeric%20Mode.cs) |
| 22 | [Display the Factors of the Entered Number](csharp/Mathematics/C%23%20Program%20to%20Display%20the%20Factors%20of%20the%20Entered%20Number.cs) |
| 23 | [Find and Display the H.C](csharp/Mathematics/C%23%20Program%20to%20Find%20and%20Display%20the%20H.C.cs) |
| 24 | [Find and display the Multiplication Table](csharp/Mathematics/C%23%20Program%20to%20Find%20and%20display%20the%20Multiplication%20Table.cs) |
| 25 | [Find LCM](csharp/Mathematics/C%23%20Program%20to%20Find%20LCM.cs) |
| 26 | [Find Multiplication of two Binary Numbers](csharp/Mathematics/C%23%20Program%20to%20Find%20Multiplication%20of%20two%20Binary%20Numbers.cs) |
| 27 | [Find Power of 2 using Bitwise Operator](csharp/Mathematics/C%23%20Program%20to%20Find%20Power%20of%202%20using%20Bitwise%20Operator.cs) |
| 28 | [Find Roots of a Quadratic Equation](csharp/Mathematics/C%23%20Program%20to%20Find%20Roots%20of%20a%20Quadratic%20Equation.cs) |
| 29 | [Find Square Root of a Given Number](csharp/Mathematics/C%23%20Program%20to%20Find%20Square%20Root%20of%20a%20Given%20Number.cs) |
| 30 | [Find the Cube Root of a Given Number](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Cube%20Root%20of%20a%20Given%20Number.cs) |
| 31 | [Find the Maximum Range of Values for Decimal,Float and Double Datatype](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Maximum%20Range%20of%20Values%20for%20Decimal%2CFloat%20and%20Double%20Datatype.cs) |
| 32 | [Find the Mean of given Set of Numbers](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Mean%20of%20given%20Set%20of%20Numbers.cs) |
| 33 | [Find the Minimum Range of Values for Decimal, Float and Double Datatype](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Minimum%20Range%20of%20Values%20for%20Decimal%2C%20Float%20and%20Double%20Datatype.cs) |
| 34 | [Find the Standard Deviation of a Set of Given Numbers](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Standard%20Deviation%20of%20a%20Set%20of%20Given%20Numbers.cs) |
| 35 | [Find the Sum of first 50 Natural Numbers using For Loop](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Sum%20of%20first%2050%20Natural%20Numbers%20using%20For%20Loop.cs) |
| 36 | [Find the Sum of two Binary Numbers](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Sum%20of%20two%20Binary%20Numbers.cs) |
| 37 | [Find the Value of Cos(x)](csharp/Mathematics/C%23%20Program%20to%20Find%20the%20Value%20of%20Cos%28x%29.cs) |
| 38 | [Find Volume and Surface Area of a Sphere](csharp/Mathematics/C%23%20Program%20to%20find%20Volume%20and%20Surface%20Area%20of%20a%20Sphere.cs) |
| 39 | [Find whether the Number is Divisible by 2](csharp/Mathematics/C%23%20Program%20to%20Find%20whether%20the%20Number%20is%20Divisible%20by%202.cs) |
| 40 | [Generate Fibonacci Series](csharp/Mathematics/C%23%20Program%20to%20Generate%20Fibonacci%20Series.cs) |
| 41 | [Generate Register Number automatically for 100 Students using Static Constructor](csharp/Mathematics/C%23%20Program%20to%20Generate%20Register%20Number%20automatically%20for%20100%20Students%20using%20Static%20Constructor.cs) |
| 42 | [Generate the Factorial of Given Number](csharp/Mathematics/C%23%20Program%20to%20Generate%20the%20Factorial%20of%20Given%20Number.cs) |
| 43 | [Generate the Sum of N Numbers](csharp/Mathematics/C%23%20Program%20to%20Generate%20the%20Sum%20of%20N%20Numbers.cs) |
| 44 | [Illustrate Bitwise Operations](csharp/Mathematics/C%23%20Program%20to%20Illustrate%20Bitwise%20Operations.cs) |
| 45 | [Illustrate Pascal Triangle](csharp/Mathematics/C%23%20Program%20to%20Illustrate%20Pascal%20Triangle.cs) |
| 46 | [Illustrate Trignometry Angles in Degrees](csharp/Mathematics/C%23%20Program%20to%20Illustrate%20Trignometry%20Angles%20in%20Degrees.cs) |
| 47 | [Illustrate Trignometry Angles in Radians](csharp/Mathematics/C%23%20Program%20to%20Illustrate%20Trignometry%20Angles%20in%20Radians.cs) |
| 48 | [Multiply given Number by 4 using Bitwise Operators](csharp/Mathematics/C%23%20Program%20to%20Multiply%20given%20Number%20by%204%20using%20Bitwise%20Operators.cs) |
| 49 | [Perform all Basic Arithmetic Operations](csharp/Mathematics/C%23%20Program%20to%20Perform%20all%20Basic%20Arithmetic%20Operations.cs) |
| 50 | [Perform GCD](csharp/Mathematics/C%23%20Program%20to%20Perform%20GCD.cs) |
| 51 | [Perform Multiplication of Exponents of Same Base](csharp/Mathematics/C%23%20Program%20to%20Perform%20Multiplication%20of%20Exponents%20of%20Same%20Base.cs) |
| 52 | [Print all the Multiples of 17 which are Less than 100](csharp/Mathematics/C%23%20Program%20to%20Print%20all%20the%20Multiples%20of%2017%20which%20are%20Less%20than%20100.cs) |
| 53 | [Print the Sum of all the Multiples of 3 and 5](csharp/Mathematics/C%23%20Program%20to%20Print%20the%20Sum%20of%20all%20the%20Multiples%20of%203%20and%205.cs) |
| 54 | [Reverse a Number & Check if it is a Palindrome](csharp/Mathematics/C%23%20Program%20to%20Reverse%20a%20Number%20%26%20Check%20if%20it%20is%20a%20Palindrome.cs) |

### Matrix

| # | Description |
|---:|---|
| 1 | [Check If a Given Matrix is an Identity Matrix](csharp/Matrix/C%23%20Program%20to%20Check%20If%20a%20Given%20Matrix%20is%20an%20Identity%20Matrix.cs) |
| 2 | [Display Lower Triangular Matrix](csharp/Matrix/C%23%20Program%20to%20Display%20Lower%20Triangular%20Matrix.cs) |
| 3 | [Display Upper Triangular Matrix](csharp/Matrix/C%23%20Program%20to%20Display%20Upper%20Triangular%20Matrix.cs) |
| 4 | [Find Largest Element in a Matrix](csharp/Matrix/C%23%20Program%20to%20Find%20Largest%20Element%20in%20a%20Matrix.cs) |
| 5 | [Find Smallest Element in a Matrix](csharp/Matrix/C%23%20Program%20to%20Find%20Smallest%20Element%20in%20a%20Matrix.cs) |
| 6 | [Find Sum of the Elements of each Column of the Given Matrix](csharp/Matrix/C%23%20Program%20to%20Find%20Sum%20of%20the%20Elements%20of%20each%20Column%20of%20the%20Given%20Matrix.cs) |
| 7 | [Find Sum of the Elements of each Row of the Given Matrix](csharp/Matrix/C%23%20Program%20to%20Find%20Sum%20of%20the%20Elements%20of%20each%20Row%20of%20the%20Given%20Matrix.cs) |
| 8 | [Find the Sum of the Values on Diagonal of the Matrix](csharp/Matrix/C%23%20Program%20to%20Find%20the%20Sum%20of%20the%20Values%20on%20Diagonal%20of%20the%20Matrix.cs) |
| 9 | [Generate the Transpose of a Given Matrix](csharp/Matrix/C%23%20Program%20to%20Generate%20the%20Transpose%20of%20a%20Given%20Matrix.cs) |
| 10 | [Interchange any 2 Columns of Matrix](csharp/Matrix/C%23%20Program%20to%20Interchange%20any%202%20Columns%20of%20Matrix.cs) |
| 11 | [Interchange any 2 Rows of a Matrix](csharp/Matrix/C%23%20Program%20to%20Interchange%20any%202%20Rows%20of%20a%20Matrix.cs) |
| 12 | [Perform Matrix Addition](csharp/Matrix/C%23%20Program%20to%20Perform%20Matrix%20Addition.cs) |
| 13 | [Perform Matrix Multiplication](csharp/Matrix/C%23%20Program%20to%20Perform%20Matrix%20Multiplication.cs) |
| 14 | [Perform Matrix Subtraction](csharp/Matrix/C%23%20Program%20to%20Perform%20Matrix%20Subtraction.cs) |

### Others

| File | Kind |
|---|---|
| [A hierarchy of timelines](csharp/Others/A%20hierarchy%20of%20timelines.cs) | WPF / XAML |
| [A rectangle with curved corners](csharp/Others/A%20rectangle%20with%20curved%20corners.cs) | WPF / XAML |
| [About Dialog](csharp/Others/About%20Dialog.cs) | WPF / XAML |
| [Add a control to a Panel](csharp/Others/Add%20a%20control%20to%20a%20Panel.cs) | WPF / XAML |
| [Add buttons to a Canvas with code](csharp/Others/Add%20buttons%20to%20a%20Canvas%20with%20code.cs) | WPF / XAML |
| [Add child control](csharp/Others/Add%20child%20control.cs) | WPF / XAML |
| [Add control to a form window](csharp/Others/Add%20control%20to%20a%20form%20window.cs) | WinForms |
| [Add control to a window](csharp/Others/Add%20control%20to%20a%20window.cs) | WinForms |
| [Add image to Button](csharp/Others/Add%20image%20to%20Button.cs) | WinForms |
| [Add Image to Statusbar](csharp/Others/Add%20Image%20to%20Statusbar.cs) | WPF / XAML |
| [Add items to combo box](csharp/Others/Add%20items%20to%20combo%20box.cs) | WinForms |
| [Add Polyline to UniformGrid](csharp/Others/Add%20Polyline%20to%20UniformGrid.cs) | WPF / XAML |
| [Add Separator to StackPanel](csharp/Others/Add%20Separator%20to%20StackPanel.cs) | WPF / XAML |
| [Add Thickness for Padding](csharp/Others/Add%20Thickness%20for%20Padding.cs) | WPF / XAML |
| [Adding Hyperlink to TextBlock](csharp/Others/Adding%20Hyperlink%20to%20TextBlock.cs) | WPF / XAML |
| [All Mouse Cursors](csharp/Others/All%20Mouse%20Cursors.cs) | WinForms |
| [An ellipse that has been scaled by 20%](csharp/Others/An%20ellipse%20that%20has%20been%20scaled%20by%2020%25.cs) | WPF / XAML |
| [Anchor Two Buttons](csharp/Others/Anchor%20Two%20Buttons.cs) | WinForms |
| [Animate EndPoint](csharp/Others/Animate%20EndPoint.cs) | WPF / XAML |
| [Animate the background color](csharp/Others/Animate%20the%20background%20color.cs) | WPF / XAML |
| [Animation In Style](csharp/Others/Animation%20In%20Style.cs) | WPF / XAML |
| [Application Exit event](csharp/Others/Application%20Exit%20event.cs) | WPF / XAML |
| [Application Startup event](csharp/Others/Application%20Startup%20event.cs) | WPF / XAML |
| [Application.GetResourceStream](csharp/Others/Application.GetResourceStream.cs) | WPF / XAML |
| [Apply Syntax Highlighting in a Text Control](csharp/Others/Apply%20Syntax%20Highlighting%20in%20a%20Text%20Control.cs) | WPF / XAML |
| [AssemblyInfo](csharp/Others/AssemblyInfo.cs) | Class / other |
| [Automatic Width and Height](csharp/Others/Automatic%20Width%20and%20Height.cs) | WPF / XAML |
| [AutoScroll Window](csharp/Others/AutoScroll%20Window.cs) | WinForms |
| [Basic DialogBox](csharp/Others/Basic%20DialogBox.cs) | WPF / XAML |
| [Bind a TabControl to a data source](csharp/Others/Bind%20a%20TabControl%20to%20a%20data%20source.cs) | WPF / XAML |
| [Bind current time to Button](csharp/Others/Bind%20current%20time%20to%20Button.cs) | WPF / XAML |
| [Bind to XML Data embed the data directly](csharp/Others/Bind%20to%20XML%20Data%20embed%20the%20data%20directly.cs) | WPF / XAML |
| [Binding Label to TextBox](csharp/Others/Binding%20Label%20to%20TextBox.cs) | WPF / XAML |
| [Binding With Data Context](csharp/Others/Binding%20With%20Data%20Context.cs) | WPF / XAML |
| [BloomFilter](csharp/Others/BloomFilter.cs) | Class / other |
| [Bold text in Flow document](csharp/Others/Bold%20text%20in%20Flow%20document.cs) | WPF / XAML |
| [BorderLess Window](csharp/Others/BorderLess%20Window.cs) | WinForms |
| [Bouncing Ball](csharp/Others/Bouncing%20Ball.cs) | WPF / XAML |
| [BPlusTree](csharp/Others/BPlusTree.cs) | Class / other |
| [Built-In Command Bindings](csharp/Others/Built-In%20Command%20Bindings.cs) | WPF / XAML |
| [Button Click event handler](csharp/Others/Button%20Click%20event%20handler.cs) | WPF / XAML |
| [Button Image, Size, Parent](csharp/Others/Button%20Image%2C%20Size%2C%20Parent.cs) | WinForms |
| [Capture Mouse Ellipse](csharp/Others/Capture%20Mouse%20Ellipse.cs) | WPF / XAML |
| [Cast event sender to a control](csharp/Others/Cast%20event%20sender%20to%20a%20control.cs) | WPF / XAML |
| [Center form window](csharp/Others/Center%20form%20window.cs) | WinForms |
| [Change Button text](csharp/Others/Change%20Button%20text.cs) | WinForms |
| [Change StackPanel Orientation](csharp/Others/Change%20StackPanel%20Orientation.cs) | WPF / XAML |
| [Check Spelling Error](csharp/Others/Check%20Spelling%20Error.cs) | WPF / XAML |
| [CheckBox with Label](csharp/Others/CheckBox%20with%20Label.cs) | WinForms |
| [Checked RadioButton](csharp/Others/Checked%20RadioButton.cs) | WPF / XAML |
| [CircularBuffer](csharp/Others/CircularBuffer.cs) | Class / other |
| [CircularQueue](csharp/Others/CircularQueue.cs) | Class / other |
| [Clear FlowDocumentReader](csharp/Others/Clear%20FlowDocumentReader.cs) | WinForms |
| [Click on me to change the color](csharp/Others/Click%20on%20me%20to%20change%20the%20color.cs) | WinForms |
| [Code Animation Accelerate Decelerate](csharp/Others/Code%20Animation%20Accelerate%20Decelerate.cs) | WPF / XAML |
| [Color Fill dialog](csharp/Others/Color%20Fill%20dialog.cs) | WinForms |
| [Command Enabling](csharp/Others/Command%20Enabling.cs) | WPF / XAML |
| [ConcurrentAdjacencyList](csharp/Others/ConcurrentAdjacencyList.cs) | Class / other |
| [ConcurrentHashSet](csharp/Others/ConcurrentHashSet.cs) | Class / other |
| [Control Enabled](csharp/Others/Control%20Enabled.cs) | WinForms |
| [ControlDark to ControlLight](csharp/Others/ControlDark%20to%20ControlLight.cs) | WPF / XAML |
| [Controlling The Storyboard](csharp/Others/Controlling%20The%20Storyboard.cs) | WPF / XAML |
| [Converting text to geometry](csharp/Others/Converting%20text%20to%20geometry.cs) | WPF / XAML |
| [Copying from the Clipboard](csharp/Others/Copying%20from%20the%20Clipboard.cs) | WinForms |
| [Copying to the Clipboard](csharp/Others/Copying%20to%20the%20Clipboard.cs) | WinForms |
| [Create a button when the page loads](csharp/Others/Create%20a%20button%20when%20the%20page%20loads.cs) | WPF / XAML |
| [Create a line with point value](csharp/Others/Create%20a%20line%20with%20point%20value.cs) | WPF / XAML |
| [Create a ProgressBar](csharp/Others/Create%20a%20ProgressBar.cs) | WPF / XAML |
| [Create a shadow effect for displayed text](csharp/Others/Create%20a%20shadow%20effect%20for%20displayed%20text.cs) | WPF / XAML |
| [Create an animated Popup control](csharp/Others/Create%20an%20animated%20Popup%20control.cs) | WPF / XAML |
| [Create Button from Xaml string](csharp/Others/Create%20Button%20from%20Xaml%20string.cs) | WPF / XAML |
| [Create buttons using DrawingImage and GeometryDrawing](csharp/Others/Create%20buttons%20using%20DrawingImage%20and%20GeometryDrawing.cs) | WPF / XAML |
| [Create Full Color Bitmap](csharp/Others/Create%20Full%20Color%20Bitmap.cs) | WPF / XAML |
| [Create Indexed Bitmap](csharp/Others/Create%20Indexed%20Bitmap.cs) | WPF / XAML |
| [Create rectangles in WPF](csharp/Others/Create%20rectangles%20in%20WPF.cs) | WPF / XAML |
| [Create RoutedCommand from InputGestureCollection](csharp/Others/Create%20RoutedCommand%20from%20InputGestureCollection.cs) | WPF / XAML |
| [Cross Thread Exception Raising](csharp/Others/Cross%20Thread%20Exception%20Raising.cs) | WPF / XAML |
| [DateTemplate for String](csharp/Others/DateTemplate%20for%20String.cs) | WPF / XAML |
| [Define Double value as resource](csharp/Others/Define%20Double%20value%20as%20resource.cs) | WPF / XAML |
| [Deque](csharp/Others/Deque.cs) | Class / other |
| [Desktop to AppWorkspace](csharp/Others/Desktop%20to%20AppWorkspace.cs) | WPF / XAML |
| [Desktop to Control](csharp/Others/Desktop%20to%20Control.cs) | WPF / XAML |
| [Diagonal linear gradient - multiple colors](csharp/Others/Diagonal%20linear%20gradient%20-%20multiple%20colors.cs) | WPF / XAML |
| [Digital Clock](csharp/Others/Digital%20Clock.cs) | WPF / XAML |
| [Disabled Button with ToolTipService](csharp/Others/Disabled%20Button%20with%20ToolTipService.cs) | WPF / XAML |
| [Display a Border](csharp/Others/Display%20a%20Border.cs) | WPF / XAML |
| [Display a notification icon in the system tray](csharp/Others/Display%20a%20notification%20icon%20in%20the%20system%20tray.cs) | WinForms |
| [Display a Static Image](csharp/Others/Display%20a%20Static%20Image.cs) | WPF / XAML |
| [Dock StatusBar](csharp/Others/Dock%20StatusBar.cs) | WPF / XAML |
| [Dock Style Left](csharp/Others/Dock%20Style%20Left.cs) | WinForms |
| [Dock Two Buttons](csharp/Others/Dock%20Two%20Buttons.cs) | WinForms |
| [Docking left and right before top and bottom](csharp/Others/Docking%20left%20and%20right%20before%20top%20and%20bottom.cs) | WPF / XAML |
| [Document Styles](csharp/Others/Document%20Styles.cs) | WPF / XAML |
| [Double value as the Font size](csharp/Others/Double%20value%20as%20the%20Font%20size.cs) | WPF / XAML |
| [DoubleHashedDictionary](csharp/Others/DoubleHashedDictionary.cs) | Class / other |
| [Draw Graphics On Bitmap](csharp/Others/Draw%20Graphics%20On%20Bitmap.cs) | WPF / XAML |
| [Draw second figure with  NonZero FillRule](csharp/Others/Draw%20second%20figure%20with%20%20NonZero%20FillRule.cs) | WPF / XAML |
| [Draws a circle with a blue interior](csharp/Others/Draws%20a%20circle%20with%20a%20blue%20interior.cs) | WPF / XAML |
| [Duplicate VisualBrush](csharp/Others/Duplicate%20VisualBrush.cs) | WPF / XAML |
| [Dynamic Resource](csharp/Others/Dynamic%20Resource.cs) | WPF / XAML |
| [Ellipse Mouse Down event](csharp/Others/Ellipse%20Mouse%20Down%20event.cs) | WPF / XAML |
| [EllipseGeometry](csharp/Others/EllipseGeometry.cs) | WPF / XAML |
| [Elliptical Arc](csharp/Others/Elliptical%20Arc.cs) | WPF / XAML |
| [Embedded code for Application](csharp/Others/Embedded%20code%20for%20Application.cs) | WPF / XAML |
| [Expander control](csharp/Others/Expander%20control.cs) | WPF / XAML |
| [Expander Header](csharp/Others/Expander%20Header.cs) | WPF / XAML |
| [External Web Links](csharp/Others/External%20Web%20Links.cs) | WPF / XAML |
| [File menu](csharp/Others/File%20menu.cs) | WPF / XAML |
| [Find children](csharp/Others/Find%20children.cs) | WPF / XAML |
| [Find Control With Tag](csharp/Others/Find%20Control%20With%20Tag.cs) | WPF / XAML |
| [Find enclosure component](csharp/Others/Find%20enclosure%20component.cs) | WPF / XAML |
| [Flow Document Reader](csharp/Others/Flow%20Document%20Reader.cs) | WPF / XAML |
| [FlowDocument with Section](csharp/Others/FlowDocument%20with%20Section.cs) | WPF / XAML |
| [Font Properties Moved](csharp/Others/Font%20Properties%20Moved.cs) | WPF / XAML |
| [Font Viewer](csharp/Others/Font%20Viewer.cs) | WPF / XAML |
| [Format TextBox with MenuItem  normal, bold, itali](csharp/Others/Format%20TextBox%20with%20MenuItem%20%20normal%2C%20bold%2C%20itali.cs) | WPF / XAML |
| [Four-quadrant Cartesian coordinate system](csharp/Others/Four-quadrant%20Cartesian%20coordinate%20system.cs) | WPF / XAML |
| [Freezables and element](csharp/Others/Freezables%20and%20element.cs) | WPF / XAML |
| [Geometry Transform for Rectangle](csharp/Others/Geometry%20Transform%20for%20Rectangle.cs) | WPF / XAML |
| [Get all controls on a form window](csharp/Others/Get%20all%20controls%20on%20a%20form%20window.cs) | WinForms |
| [Get all system installed font](csharp/Others/Get%20all%20system%20installed%20font.cs) | WinForms |
| [Get RoutedEvent Name](csharp/Others/Get%20RoutedEvent%20Name.cs) | WPF / XAML |
| [Get selected checkbox list items](csharp/Others/Get%20selected%20checkbox%20list%20items.cs) | WinForms |
| [Get Selected item from ComboBox](csharp/Others/Get%20Selected%20item%20from%20ComboBox.cs) | WinForms |
| [Get the font in a FontDialog](csharp/Others/Get%20the%20font%20in%20a%20FontDialog.cs) | WinForms |
| [Glowing Effect with OuterGlowBitmapEffect](csharp/Others/Glowing%20Effect%20with%20OuterGlowBitmapEffect.cs) | WPF / XAML |
| [Glyphs with ttf font file](csharp/Others/Glyphs%20with%20ttf%20font%20file.cs) | WPF / XAML |
| [Gradient background button](csharp/Others/Gradient%20background%20button.cs) | WPF / XAML |
| [Grid MouseMove](csharp/Others/Grid%20MouseMove.cs) | WPF / XAML |
| [Grid With Splitter](csharp/Others/Grid%20With%20Splitter.cs) | WPF / XAML |
| [GroupBox Header with mixed content](csharp/Others/GroupBox%20Header%20with%20mixed%20content.cs) | WPF / XAML |
| [Hand Cursor](csharp/Others/Hand%20Cursor.cs) | WinForms |
| [Handle the ContentRendered event](csharp/Others/Handle%20the%20ContentRendered%20event.cs) | WPF / XAML |
| [Hard shadow on top of soft shadow](csharp/Others/Hard%20shadow%20on%20top%20of%20soft%20shadow.cs) | WPF / XAML |
| [Hard single shadow](csharp/Others/Hard%20single%20shadow.cs) | WPF / XAML |
| [Horizontal Line](csharp/Others/Horizontal%20Line.cs) | WPF / XAML |
| [Horizontal linear gradient](csharp/Others/Horizontal%20linear%20gradient.cs) | WPF / XAML |
| [Image tile](csharp/Others/Image%20tile.cs) | WPF / XAML |
| [INode](csharp/Others/INode.cs) | Class / other |
| [Insert Button to a Panel](csharp/Others/Insert%20Button%20to%20a%20Panel.cs) | WPF / XAML |
| [Insert Row](csharp/Others/Insert%20Row.cs) | WPF / XAML |
| [IntermediateNode](csharp/Others/IntermediateNode.cs) | Class / other |
| [Is Logical Ancestor Of](csharp/Others/Is%20Logical%20Ancestor%20Of.cs) | WPF / XAML |
| [Label with ControlTemplate](csharp/Others/Label%20with%20ControlTemplate.cs) | WPF / XAML |
| [Large ArcSegments](csharp/Others/Large%20ArcSegments.cs) | WPF / XAML |
| [LeafNode](csharp/Others/LeafNode.cs) | Class / other |
| [Left,Top,Right,Bottom for Padding](csharp/Others/Left%2CTop%2CRight%2CBottom%20for%20Padding.cs) | WPF / XAML |
| [Line with Path](csharp/Others/Line%20with%20Path.cs) | WPF / XAML |
| [LinearProbingDictionary](csharp/Others/LinearProbingDictionary.cs) | Class / other |
| [LineGeometry](csharp/Others/LineGeometry.cs) | WPF / XAML |
| [Link To Another Page](csharp/Others/Link%20To%20Another%20Page.cs) | WPF / XAML |
| [LinkedDictionary](csharp/Others/LinkedDictionary.cs) | Class / other |
| [ListBox and SelectionMode](csharp/Others/ListBox%20and%20SelectionMode.cs) | WPF / XAML |
| [ListBox with Image item](csharp/Others/ListBox%20with%20Image%20item.cs) | WPF / XAML |
| [ListBox With Items Panel](csharp/Others/ListBox%20With%20Items%20Panel.cs) | WPF / XAML |
| [Load image source from a hard code directory](csharp/Others/Load%20image%20source%20from%20a%20hard%20code%20directory.cs) | WPF / XAML |
| [Load Xaml Resource](csharp/Others/Load%20Xaml%20Resource.cs) | WPF / XAML |
| [Logical Resources](csharp/Others/Logical%20Resources.cs) | WPF / XAML |
| [Margin Left,Top,Right,Bottom](csharp/Others/Margin%20Left%2CTop%2CRight%2CBottom.cs) | WPF / XAML |
| [Markup Extensions for Button](csharp/Others/Markup%20Extensions%20for%20Button.cs) | WPF / XAML |
| [Matrix Animated Button](csharp/Others/Matrix%20Animated%20Button.cs) | WPF / XAML |
| [Matrix3D RotateAt](csharp/Others/Matrix3D%20RotateAt.cs) | WPF / XAML |
| [Matrix3D scale transformation](csharp/Others/Matrix3D%20scale%20transformation.cs) | WPF / XAML |
| [Matrix3D Translation](csharp/Others/Matrix3D%20Translation.cs) | WPF / XAML |
| [MenuItems with Commands](csharp/Others/MenuItems%20with%20Commands.cs) | WPF / XAML |
| [Message Only MessageBox](csharp/Others/Message%20Only%20MessageBox.cs) | WPF / XAML |
| [Mouse Enter and leave a Border](csharp/Others/Mouse%20Enter%20and%20leave%20a%20Border.cs) | WPF / XAML |
| [MoveToFrontList](csharp/Others/MoveToFrontList.cs) | Class / other |
| [Multiple geometries](csharp/Others/Multiple%20geometries.cs) | WPF / XAML |
| [Multiple Line Segments](csharp/Others/Multiple%20Line%20Segments.cs) | WPF / XAML |
| [Multiple Subpaths with PathFigure](csharp/Others/Multiple%20Subpaths%20with%20PathFigure.cs) | WPF / XAML |
| [Navigate Frame to a xaml document](csharp/Others/Navigate%20Frame%20to%20a%20xaml%20document.cs) | WPF / XAML |
| [Nested Span elements](csharp/Others/Nested%20Span%20elements.cs) | WPF / XAML |
| [No margin](csharp/Others/No%20margin.cs) | WPF / XAML |
| [No rotation](csharp/Others/No%20rotation.cs) | WPF / XAML |
| [Non-resizable form](csharp/Others/Non-resizable%20form.cs) | WinForms |
| [NullSkipNode](csharp/Others/NullSkipNode.cs) | Class / other |
| [On Key Down Handler](csharp/Others/On%20Key%20Down%20Handler.cs) | WPF / XAML |
| [On Mouse Wheel](csharp/Others/On%20Mouse%20Wheel.cs) | WinForms |
| [OpacityMask, LinearGradientBrush, RenderTransform](csharp/Others/OpacityMask%2C%20LinearGradientBrush%2C%20RenderTransform.cs) | WPF / XAML |
| [OpenFileDialog Test](csharp/Others/OpenFileDialog%20Test.cs) | WPF / XAML |
| [Page Loaded event](csharp/Others/Page%20Loaded%20event.cs) | WPF / XAML |
| [Painting a 3D surface with a bitmap](csharp/Others/Painting%20a%203D%20surface%20with%20a%20bitmap.cs) | WPF / XAML |
| [Paints a rectangle with a checkered pattern](csharp/Others/Paints%20a%20rectangle%20with%20a%20checkered%20pattern.cs) | WPF / XAML |
| [Paragraph FontWeight](csharp/Others/Paragraph%20FontWeight.cs) | WPF / XAML |
| [Password for PasswordBox](csharp/Others/Password%20for%20PasswordBox.cs) | WPF / XAML |
| [PasswordBox with Margin](csharp/Others/PasswordBox%20with%20Margin.cs) | WPF / XAML |
| [Path with ScaleTransformation](csharp/Others/Path%20with%20ScaleTransformation.cs) | WPF / XAML |
| [PenLineCap.Round](csharp/Others/PenLineCap.Round.cs) | WPF / XAML |
| [PenLineJoin.Bevel](csharp/Others/PenLineJoin.Bevel.cs) | WPF / XAML |
| [Play audio through event trigger](csharp/Others/Play%20audio%20through%20event%20trigger.cs) | WPF / XAML |
| [Play mp3 file](csharp/Others/Play%20mp3%20file.cs) | WPF / XAML |
| [Ployline types do not require connecting ends](csharp/Others/Ployline%20types%20do%20not%20require%20connecting%20ends.cs) | WPF / XAML |
| [Polygon Mouse down event](csharp/Others/Polygon%20Mouse%20down%20event.cs) | WPF / XAML |
| [Polygon Stretch=Fill](csharp/Others/Polygon%20Stretch%3DFill.cs) | WPF / XAML |
| [Polygon with Fill](csharp/Others/Polygon%20with%20Fill.cs) | WPF / XAML |
| [Polyline by Points](csharp/Others/Polyline%20by%20Points.cs) | WPF / XAML |
| [Print a WPF Visual](csharp/Others/Print%20a%20WPF%20Visual.cs) | WPF / XAML |
| [Print Custom Page](csharp/Others/Print%20Custom%20Page.cs) | WPF / XAML |
| [ProgressBar and Animation](csharp/Others/ProgressBar%20and%20Animation.cs) | WPF / XAML |
| [Property changed callback](csharp/Others/Property%20changed%20callback.cs) | WPF / XAML |
| [Property Inheritance](csharp/Others/Property%20Inheritance.cs) | WPF / XAML |
| [Proportional Tiles](csharp/Others/Proportional%20Tiles.cs) | WPF / XAML |
| [Put Canvas into ScrollViewer](csharp/Others/Put%20Canvas%20into%20ScrollViewer.cs) | WPF / XAML |
| [Query Left  or Right control key](csharp/Others/Query%20Left%20%20or%20Right%20control%20key.cs) | WPF / XAML |
| [Query Left or Right Shift key](csharp/Others/Query%20Left%20or%20Right%20Shift%20key.cs) | WPF / XAML |
| [RadialGradientBrush GradientOrigin](csharp/Others/RadialGradientBrush%20GradientOrigin.cs) | WPF / XAML |
| [Radio Button Groups](csharp/Others/Radio%20Button%20Groups.cs) | WPF / XAML |
| [RectangleGeometry](csharp/Others/RectangleGeometry.cs) | WPF / XAML |
| [Reference SystemParameters](csharp/Others/Reference%20SystemParameters.cs) | WPF / XAML |
| [Remove aniamtion with RemoveStoryboard](csharp/Others/Remove%20aniamtion%20with%20RemoveStoryboard.cs) | WPF / XAML |
| [Remove Animations with Storyboard](csharp/Others/Remove%20Animations%20with%20Storyboard.cs) | WPF / XAML |
| [Repetition count](csharp/Others/Repetition%20count.cs) | WPF / XAML |
| [Repetition duration](csharp/Others/Repetition%20duration.cs) | WPF / XAML |
| [Replease mouse with Mouse.Capture(null)](csharp/Others/Replease%20mouse%20with%20Mouse.Capture%28null%29.cs) | WPF / XAML |
| [Resource Lookup](csharp/Others/Resource%20Lookup.cs) | WPF / XAML |
| [Rotate then Translate](csharp/Others/Rotate%20then%20Translate.cs) | WPF / XAML |
| [Rotating Popup](csharp/Others/Rotating%20Popup.cs) | WPF / XAML |
| [Rounded Rectangle Corner radius of 100 (X) and 60 (Y)](csharp/Others/Rounded%20Rectangle%20Corner%20radius%20of%20100%20%28X%29%20and%2060%20%28Y%29.cs) | WPF / XAML |
| [RoutedEvents  Drag And Drop](csharp/Others/RoutedEvents%20%20Drag%20And%20Drop.cs) | WPF / XAML |
| [ScrollViewer and Big Ellipse](csharp/Others/ScrollViewer%20and%20Big%20Ellipse.cs) | WPF / XAML |
| [Set a Default Button](csharp/Others/Set%20a%20Default%20Button.cs) | WPF / XAML |
| [Set AccessText for Label](csharp/Others/Set%20AccessText%20for%20Label.cs) | WPF / XAML |
| [Set Binding ListView.ItemsSourceProperty to ListView](csharp/Others/Set%20Binding%20ListView.ItemsSourceProperty%20to%20ListView.cs) | WPF / XAML |
| [Set Border BorderBrush to ImageBrush](csharp/Others/Set%20Border%20BorderBrush%20to%20ImageBrush.cs) | WPF / XAML |
| [Set border corner radius](csharp/Others/Set%20border%20corner%20radius.cs) | WPF / XAML |
| [Set color for SolidColorBrush](csharp/Others/Set%20color%20for%20SolidColorBrush.cs) | WPF / XAML |
| [Set control border style](csharp/Others/Set%20control%20border%20style.cs) | WinForms |
| [Set Grid Row and Column for a Button](csharp/Others/Set%20Grid%20Row%20and%20Column%20for%20a%20Button.cs) | WPF / XAML |
| [Set interval and event handler for DispatcherTimer](csharp/Others/Set%20interval%20and%20event%20handler%20for%20DispatcherTimer.cs) | WPF / XAML |
| [Set Message, Header, and Button for MessageBox](csharp/Others/Set%20Message%2C%20Header%2C%20and%20Button%20for%20MessageBox.cs) | WPF / XAML |
| [Set Text value for TextBlock](csharp/Others/Set%20Text%20value%20for%20TextBlock.cs) | WPF / XAML |
| [Set TextBlock.FontSize for Grid](csharp/Others/Set%20TextBlock.FontSize%20for%20Grid.cs) | WPF / XAML |
| [Set the slider value with RepeatButton](csharp/Others/Set%20the%20slider%20value%20with%20RepeatButton.cs) | WPF / XAML |
| [Setting AccessText properties](csharp/Others/Setting%20AccessText%20properties.cs) | WPF / XAML |
| [Shadow effect by creating an outer glow](csharp/Others/Shadow%20effect%20by%20creating%20an%20outer%20glow.cs) | WPF / XAML |
| [Shaking Button](csharp/Others/Shaking%20Button.cs) | WPF / XAML |
| [Shape Union](csharp/Others/Shape%20Union.cs) | WPF / XAML |
| [Sharing a Style](csharp/Others/Sharing%20a%20Style.cs) | WPF / XAML |
| [Shorthand Path data](csharp/Others/Shorthand%20Path%20data.cs) | WPF / XAML |
| [Simple Border](csharp/Others/Simple%20Border.cs) | WPF / XAML |
| [Simple underline decoration](csharp/Others/Simple%20underline%20decoration.cs) | WPF / XAML |
| [Simple WrapPanel](csharp/Others/Simple%20WrapPanel.cs) | WPF / XAML |
| [Skew the text using a TranslateTransform](csharp/Others/Skew%20the%20text%20using%20a%20TranslateTransform.cs) | WPF / XAML |
| [SkipList](csharp/Others/SkipList.cs) | Class / other |
| [SkipNode](csharp/Others/SkipNode.cs) | Class / other |
| [Slider Attributes](csharp/Others/Slider%20Attributes.cs) | WPF / XAML |
| [Solid Color Brush In Code with SolidColorBrush](csharp/Others/Solid%20Color%20Brush%20In%20Code%20with%20SolidColorBrush.cs) | WPF / XAML |
| [SolidColorBrush described using 8-digit hexadecimal notation](csharp/Others/SolidColorBrush%20described%20using%208-digit%20hexadecimal%20notation.cs) | WPF / XAML |
| [SortedList](csharp/Others/SortedList.cs) | Class / other |
| [Span and FlowDocument](csharp/Others/Span%20and%20FlowDocument.cs) | WPF / XAML |
| [Split](csharp/Others/Split.cs) | Class / other |
| [StackPanel in a ScrollViewer](csharp/Others/StackPanel%20in%20a%20ScrollViewer.cs) | WPF / XAML |
| [Stretch = None](csharp/Others/Stretch%20%3D%20None.cs) | WPF / XAML |
| [Stretch = Uniform](csharp/Others/Stretch%20%3D%20Uniform.cs) | WPF / XAML |
| [Stretched GridSplitter](csharp/Others/Stretched%20GridSplitter.cs) | WPF / XAML |
| [Style With Data Trigger](csharp/Others/Style%20With%20Data%20Trigger.cs) | WPF / XAML |
| [Style With MultiTrigger](csharp/Others/Style%20With%20MultiTrigger.cs) | WPF / XAML |
| [Subclass CheckBox](csharp/Others/Subclass%20CheckBox.cs) | WinForms |
| [Suppress Keyboard and Mouse Events](csharp/Others/Suppress%20Keyboard%20and%20Mouse%20Events.cs) | WPF / XAML |
| [Tab page headers](csharp/Others/Tab%20page%20headers.cs) | WPF / XAML |
| [TabControl and Frame source](csharp/Others/TabControl%20and%20Frame%20source.cs) | WPF / XAML |
| [Text Wrapping Label](csharp/Others/Text%20Wrapping%20Label.cs) | WPF / XAML |
| [TextBox as Button Content](csharp/Others/TextBox%20as%20Button%20Content.cs) | WPF / XAML |
| [TextBox KeyUp](csharp/Others/TextBox%20KeyUp.cs) | WPF / XAML |
| [TextBox Style](csharp/Others/TextBox%20Style.cs) | WPF / XAML |
| [The same margin on all four sides](csharp/Others/The%20same%20margin%20on%20all%20four%20sides.cs) | WPF / XAML |
| [The same padding on all four sides](csharp/Others/The%20same%20padding%20on%20all%20four%20sides.cs) | WPF / XAML |
| [The UniformGrid](csharp/Others/The%20UniformGrid.cs) | WPF / XAML |
| [Throw Unhandled Exception](csharp/Others/Throw%20Unhandled%20Exception.cs) | WPF / XAML |
| [Tile VisualBrush](csharp/Others/Tile%20VisualBrush.cs) | WPF / XAML |
| [Toolbar TraysToolbar Trays](csharp/Others/Toolbar%20TraysToolbar%20Trays.cs) | WPF / XAML |
| [ToolBarTray and ToolBar](csharp/Others/ToolBarTray%20and%20ToolBar.cs) | WPF / XAML |
| [ToolTip for Border](csharp/Others/ToolTip%20for%20Border.cs) | WPF / XAML |
| [Translate](csharp/Others/Translate.cs) | WPF / XAML |
| [TranslateTransform X 50  or  Y 0](csharp/Others/TranslateTransform%20X%2050%20%20or%20%20Y%200.cs) | WPF / XAML |
| [TransposeList](csharp/Others/TransposeList.cs) | Class / other |
| [Underline decoration with dashes](csharp/Others/Underline%20decoration%20with%20dashes.cs) | WPF / XAML |
| [Use ArrayList as the ListView ItemSource](csharp/Others/Use%20ArrayList%20as%20the%20ListView%20ItemSource.cs) | WPF / XAML |
| [Use ControlTemplate and event handler](csharp/Others/Use%20ControlTemplate%20and%20event%20handler.cs) | WPF / XAML |
| [Use Font from Form to paint string on a form](csharp/Others/Use%20Font%20from%20Form%20to%20paint%20string%20on%20a%20form.cs) | WinForms |
| [Use Frame to Load another Xaml file](csharp/Others/Use%20Frame%20to%20Load%20another%20Xaml%20file.cs) | WPF / XAML |
| [Use JpegBitmapDecoder](csharp/Others/Use%20JpegBitmapDecoder.cs) | WPF / XAML |
| [Use LengthConverter](csharp/Others/Use%20LengthConverter.cs) | WPF / XAML |
| [Use ObservableCollection as Resource](csharp/Others/Use%20ObservableCollection%20as%20Resource.cs) | WPF / XAML |
| [Use outter resource or inner resource](csharp/Others/Use%20outter%20resource%20or%20inner%20resource.cs) | WPF / XAML |
| [Use Popup to display a hyperlink](csharp/Others/Use%20Popup%20to%20display%20a%20hyperlink.cs) | WPF / XAML |
| [Use Slider to control Drop Shadow](csharp/Others/Use%20Slider%20to%20control%20Drop%20Shadow.cs) | WPF / XAML |
| [Use Slider to control the ScaleTransform](csharp/Others/Use%20Slider%20to%20control%20the%20ScaleTransform.cs) | WPF / XAML |
| [Using a DispatcherTimer](csharp/Others/Using%20a%20DispatcherTimer.cs) | WPF / XAML |
| [Using a Style resource](csharp/Others/Using%20a%20Style%20resource.cs) | WPF / XAML |
| [Using LinearGradientBrush to draw a 3D button](csharp/Others/Using%20LinearGradientBrush%20to%20draw%20a%203D%20button.cs) | WPF / XAML |
| [Using MediaElement for Audio](csharp/Others/Using%20MediaElement%20for%20Audio.cs) | WPF / XAML |
| [Using the Jpeg Image](csharp/Others/Using%20the%20Jpeg%20Image.cs) | WPF / XAML |
| [Using XmlDataProvider](csharp/Others/Using%20XmlDataProvider.cs) | WPF / XAML |
| [Velocity animation](csharp/Others/Velocity%20animation.cs) | WPF / XAML |
| [Vertical Line](csharp/Others/Vertical%20Line.cs) | WPF / XAML |
| [Vertical linear gradient](csharp/Others/Vertical%20linear%20gradient.cs) | WPF / XAML |
| [Vertical or Horizontal Slider](csharp/Others/Vertical%20or%20Horizontal%20Slider.cs) | WPF / XAML |
| [Vertical WrapPanel Window](csharp/Others/Vertical%20WrapPanel%20Window.cs) | WPF / XAML |
| [VisualBrush and DrawingBrush](csharp/Others/VisualBrush%20and%20DrawingBrush.cs) | WPF / XAML |
| [WeightedAdjacencyList](csharp/Others/WeightedAdjacencyList.cs) | Class / other |
| [Width and Height animation](csharp/Others/Width%20and%20Height%20animation.cs) | WPF / XAML |
| [Window Closing and Closed event](csharp/Others/Window%20Closing%20and%20Closed%20event.cs) | WPF / XAML |
| [Window mouse up event](csharp/Others/Window%20mouse%20up%20event.cs) | WPF / XAML |
| [Window On Mouse up event](csharp/Others/Window%20On%20Mouse%20up%20event.cs) | WPF / XAML |
| [WPF Threading](csharp/Others/WPF%20Threading.cs) | WPF / XAML |
| [WrapPanel and Windows Controls](csharp/Others/WrapPanel%20and%20Windows%20Controls.cs) | WPF / XAML |
| [Write Jpeg file from BitmapSource](csharp/Others/Write%20Jpeg%20file%20from%20BitmapSource.cs) | WPF / XAML |

### Sorting

| # | Description |
|---:|---|
| 1 | [Demonstrate Heap Sort](csharp/Sorting/C%23%20Program%20to%20Demonstrate%20Heap%20Sort.cs) |
| 2 | [Implement Quick Sort](csharp/Sorting/C%23%20Program%20to%20Implement%20Quick%20Sort.cs) |
| 3 | [Perform a Selection Sort](csharp/Sorting/C%23%20Program%20to%20Perform%20a%20Selection%20Sort.cs) |
| 4 | [Perform Bubble Sort](csharp/Sorting/C%23%20Program%20to%20Perform%20Bubble%20Sort.cs) |
| 5 | [Perform Insertion Sort](csharp/Sorting/C%23%20Program%20to%20Perform%20Insertion%20Sort.cs) |
| 6 | [Perform Merge Sort](csharp/Sorting/C%23%20Program%20to%20Perform%20Merge%20Sort.cs) |
| 7 | [Perform Radix Sort](csharp/Sorting/C%23%20Program%20to%20Perform%20Radix%20Sort.cs) |
| 8 | [Sort a list of elements using Bogosort sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Bogosort%20sort.cs) |
| 9 | [Sort a list of elements using Bubble sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Bubble%20sort.cs) |
| 10 | [Sort a list of elements using Counting sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Counting%20sort.cs) |
| 11 | [Sort a list of elements using Heap sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Heap%20sort.cs) |
| 12 | [Sort a list of elements using Insertion sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Insertion%20sort.cs) |
| 13 | [Sort a list of elements using Merge sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Merge%20sort.cs) |
| 14 | [Sort a list of elements using Permutation sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Permutation%20sort.cs) |
| 15 | [Sort a list of elements using Quick sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Quick%20sort.cs) |
| 16 | [Sort a list of elements using Radix sort algorithm](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Radix%20sort%20algorithm.cs) |
| 17 | [Sort a list of elements using Shell sort](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20Shell%20sort.cs) |
| 18 | [Sort a list of elements using the selection sort algorithm](csharp/Sorting/C%23%20Sharp%20program%20to%20sort%20a%20list%20of%20elements%20using%20the%20selection%20sort%20algorithm.cs) |

### Strings

| # | Description |
|---:|---|
| 1 | [AdjacencyList](csharp/Strings/AdjacencyList.cs) |
| 2 | [Calculate the length of the string](csharp/Strings/C%23%20Program%20to%20calculate%20the%20length%20of%20the%20string.cs) |
| 3 | [Concatenate Two Strings](csharp/Strings/C%23%20Program%20to%20Concatenate%20Two%20Strings.cs) |
| 4 | [Convert Upper case to Lower Case](csharp/Strings/C%23%20Program%20to%20Convert%20Upper%20case%20to%20Lower%20Case.cs) |
| 5 | [Count Lines in a String](csharp/Strings/C%23%20Program%20to%20Count%20Lines%20in%20a%20String.cs) |
| 6 | [Count number of Vowels and consonants from a given String](csharp/Strings/C%23%20Program%20to%20Count%20number%20of%20Vowels%20and%20consonants%20from%20a%20given%20String.cs) |
| 7 | [Display Date in String](csharp/Strings/C%23%20Program%20to%20Display%20Date%20in%20String.cs) |
| 8 | [Display the Abbreviation of a Text](csharp/Strings/C%23%20Program%20to%20Display%20the%20Abbreviation%20of%20a%20Text.cs) |
| 9 | [Encrypt Decrypt using Rijndael Key](csharp/Strings/C%23%20Program%20to%20Encrypt%20Decrypt%20using%20Rijndael%20Key.cs) |
| 10 | [Generate the Marksheet of the Student](csharp/Strings/C%23%20Program%20to%20Generate%20the%20Marksheet%20of%20the%20Student.cs) |
| 11 | [Illustrate Binary Writer](csharp/Strings/C%23%20Program%20to%20Illustrate%20Binary%20Writer.cs) |
| 12 | [Implement String Splitter](csharp/Strings/C%23%20Program%20to%20Implement%20String%20Splitter.cs) |
| 13 | [List all Substrings in a given String](csharp/Strings/C%23%20Program%20to%20List%20all%20Substrings%20in%20a%20given%20String.cs) |
| 14 | [Perform Padding in the String](csharp/Strings/C%23%20Program%20to%20Perform%20Padding%20in%20the%20String.cs) |
| 15 | [Perform Searching using Predefined Functions](csharp/Strings/C%23%20Program%20to%20Perform%20Searching%20using%20Predefined%20Functions.cs) |
| 16 | [Randomly Generate Strings](csharp/Strings/C%23%20Program%20to%20Randomly%20Generate%20Strings.cs) |
| 17 | [Read a String and find the Sum of all Digits in the String](csharp/Strings/C%23%20Program%20to%20Read%20a%20String%20and%20find%20the%20Sum%20of%20all%20Digits%20in%20the%20String.cs) |
| 18 | [Replace a Character with the String](csharp/Strings/C%23%20Program%20to%20Replace%20a%20Character%20with%20the%20String.cs) |
| 19 | [Replace String in String](csharp/Strings/C%23%20Program%20to%20Replace%20String%20in%20String.cs) |
| 20 | [Reverse a String without using Reverse function](csharp/Strings/C%23%20Program%20to%20Reverse%20a%20String%20without%20using%20Reverse%20function.cs) |
| 21 | [Split a String Collections into Groups](csharp/Strings/C%23%20Program%20to%20Split%20a%20String%20Collections%20into%20Groups.cs) |
| 22 | [Trim the Given String](csharp/Strings/C%23%20Program%20to%20Trim%20the%20Given%20String.cs) |
| 23 | [Check whether a given substring is present in the given string](csharp/Strings/C%23%20Sharp%20program%20to%20check%20whether%20a%20given%20substring%20is%20present%20in%20the%20given%20string.cs) |
| 24 | [Compare (less than, greater than, equal to ) two substrings](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20%28less%20than%2C%20greater%20than%2C%20equal%20to%20%29%20two%20substrings.cs) |
| 25 | [Compare the last names of two people](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20the%20last%20names%20of%20two%20people.cs) |
| 26 | [Compare three versions of the letter I](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20three%20versions%20of%20the%20letter%20I.cs) |
| 27 | [Compare two strings in following three different ways produce three different results](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20two%20strings%20in%20following%20three%20different%20ways%20produce%20three%20different%20results.cs) |
| 28 | [Compare two substrings that only differ in case](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20two%20substrings%20that%20only%20differ%20in%20case.cs) |
| 29 | [Compare two substrings using different cultures and ignoring the case of the substrings](csharp/Strings/C%23%20Sharp%20program%20to%20compare%20two%20substrings%20using%20different%20cultures%20and%20ignoring%20the%20case%20of%20the%20substrings.cs) |
| 30 | [Compares four sets of words by using each member of the StringComparison enumeration](csharp/Strings/C%23%20Sharp%20program%20to%20compares%20four%20sets%20of%20words%20by%20using%20each%20member%20of%20the%20StringComparison%20enumeration.cs) |
| 31 | [Demonstrate how culture can affect a comparison](csharp/Strings/C%23%20Sharp%20program%20to%20demonstrate%20how%20culture%20can%20affect%20a%20comparison.cs) |
| 32 | [Demonstrate that CompareOrdinal and Compare use different sort orders](csharp/Strings/C%23%20Sharp%20program%20to%20demonstrate%20that%20CompareOrdinal%20and%20Compare%20use%20different%20sort%20orders.cs) |
| 33 | [Demonstrate that the Compare(String, String, Boolean) method is equivalent to using ToUpper or ToLower when comparing strings](csharp/Strings/C%23%20Sharp%20program%20to%20demonstrate%20that%20the%20Compare%28String%2C%20String%2C%20Boolean%29%20method%20is%20equivalent%20to%20using%20ToUpper%20or%20ToLower%20when%20comparing%20strings.cs) |
| 34 | [Check the username and password](csharp/Strings/C%23%20Sharp%20to%20check%20the%20username%20and%20password.cs) |
| 35 | [Check whether a character is an alphabet and not and if so, go to check for the case](csharp/Strings/C%23%20Sharp%20to%20check%20whether%20a%20character%20is%20an%20alphabet%20and%20not%20and%20if%20so%2C%20go%20to%20check%20for%20the%20case.cs) |
| 36 | [Compare two string without using string library functions](csharp/Strings/C%23%20Sharp%20to%20compare%20two%20string%20without%20using%20string%20library%20functions.cs) |
| 37 | [Copy one string to another string](csharp/Strings/C%23%20Sharp%20to%20copy%20one%20string%20to%20another%20string.cs) |
| 38 | [Count a total number of alphabets, digits and special characters in a string](csharp/Strings/C%23%20Sharp%20to%20count%20a%20total%20number%20of%20alphabets%2C%20digits%20and%20special%20characters%20in%20a%20string.cs) |
| 39 | [Count a total number of vowel or consonant in a string](csharp/Strings/C%23%20Sharp%20to%20count%20a%20total%20number%20of%20vowel%20or%20consonant%20in%20a%20string.cs) |
| 40 | [Count the total number of words in a string](csharp/Strings/C%23%20Sharp%20to%20count%20the%20total%20number%20of%20words%20in%20a%20string.cs) |
| 41 | [Find maximum occurring character in a string](csharp/Strings/C%23%20Sharp%20to%20find%20maximum%20occurring%20character%20in%20a%20string.cs) |
| 42 | [Find the length of a string without using library function](csharp/Strings/C%23%20Sharp%20to%20find%20the%20length%20of%20a%20string%20without%20using%20library%20function.cs) |
| 43 | [Find the number of times a substring appears in the given string](csharp/Strings/C%23%20Sharp%20to%20find%20the%20number%20of%20times%20a%20substring%20appears%20in%20the%20given%20string.cs) |
| 44 | [Insert a substring before the first occurrence of a string](csharp/Strings/C%23%20Sharp%20to%20insert%20a%20substring%20before%20the%20first%20occurrence%20of%20a%20string.cs) |
| 45 | [Print individual characters of the string in reverse order](csharp/Strings/C%23%20Sharp%20to%20print%20individual%20characters%20of%20the%20string%20in%20reverse%20order.cs) |
| 46 | [Read a sentence and replace lowercase characters by uppercase and vice-versa](csharp/Strings/C%23%20Sharp%20to%20read%20a%20sentence%20and%20replace%20lowercase%20characters%20by%20uppercase%20and%20vice-versa.cs) |
| 47 | [Read a string through the keyboard and sort it using bubble sort](csharp/Strings/C%23%20Sharp%20to%20read%20a%20string%20through%20the%20keyboard%20and%20sort%20it%20using%20bubble%20sort.cs) |
| 48 | [Search the position of a substring within a string](csharp/Strings/C%23%20Sharp%20to%20search%20the%20position%20of%20a%20substring%20within%20a%20string.cs) |
| 49 | [Separate the individual characters from a string](csharp/Strings/C%23%20Sharp%20to%20separate%20the%20individual%20characters%20from%20a%20string.cs) |
| 50 | [Sort a string array in ascending order](csharp/Strings/C%23%20Sharp%20to%20sort%20a%20string%20array%20in%20ascending%20order.cs) |
| 51 | [StringUtils](csharp/Strings/StringUtils.cs) |

## Contributing / suggestions

This is a learning archive. Corrections (for example snippets that do not compile) and suggestions are welcome through an issue or a pull request.
