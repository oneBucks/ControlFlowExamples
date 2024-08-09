// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// bool hasPermission = true;
// bool isAdmin = false;
// if (hasPermission && isAdmin) {
//     Console.WriteLine("Access granded.");
// }
// else{
//     Console.WriteLine("Access denied.");
// }

// int number = 10;
// if(number == 1){
//     Console.WriteLine("Number is one.");
// }
// else if (number == 2){
//     Console.WriteLine("Number is two.");
// }
// else if (number == 3){
//     Console.WriteLine("Number is three.");
// }
// else{
//     Console.WriteLine("Number is not one, two or three.");
// }

// int number = 10;
// switch(number)
// {
//     case 1: Console.WriteLine("Number is one.");
//     break;
//     case 2: Console.WriteLine("Number is two.");
//     break;
//     case 3: Console.WriteLine("Number is three.");
//     break;
//     default:
//     Console.WriteLine("Number is not one, two, or three.");
//     break;
// }

// int[] numbers = {1,2,3,4,5};

// for(int i = 0; i < 5; i++ ){
//     Console.WriteLine("Index is " + i + " number is " + numbers[i]);
// }

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                                             //Scale grade - delivarable//
//A: 90-100
//B: 80-89
//C: 70-79
//D: 60-69
//F: below 60

// using System.Collections;

// int score = 0;
// char grade;
// int range = score/10;
// switch(range){
//     case 9:
//         grade = 'A';
//     break;
//     case 8:
//         grade = 'B';
//     break;
//     case 7:
//         grade = 'C';
//     break;
//     case 6:
//         grade = 'D';
//     break;
//     case 5:
//         grade = 'F';
//     break;
//     default:
//         grade = 'G';
//     break;
// }
// Console.WriteLine("Grade: "+ grade);


//Scale grade - delivarable
//A: 90-100
//B: 80-89
//C: 70-79
//D: 60-69
//F: below 60
// int score = 75;
// char grade;
// switch(score){
//     case >= 90:
//         grade = 'A';
//     break;
//     case >= 80:
//         grade = 'B';
//     break;
//     case >= 70:
//         grade = 'C';
//     break;
//     case >= 60:
//         grade = 'D';
//     break;
//     default:
//         grade = 'F';
//     break;
// }
// Console.WriteLine("Grade: "+ grade);


//Ternary example
// int score = 85;
// char grade;

// grade = score >= 90 ? 'A' : score >= 80 ? 'B' : score >= 70 ? 'C' : score >= 60 ? 'D' : 'F';

// Console.WriteLine("Your grade is: " + grade);

//IfElse example
 int score = 55;

 if(score >= 90){
    Console.WriteLine("Your grade is A");
 }
 else if(score >= 80){
    Console.WriteLine("Your grade is B");
 }
 else if(score >= 70){
    Console.WriteLine("Your grade is C");
 }
 else if(score >= 60){
    Console.WriteLine("Your grade is D");
 }
 else{
    Console.WriteLine("Your suck!!!");
 }