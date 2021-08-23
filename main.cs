using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Hello new player, enter an username to start a game :");
    string username = Console.ReadLine();

    Console.WriteLine("Welcome " + username + " ! Now we will make some calculations ! Enter a first number :");
    string firstNumber = Console.ReadLine();
    int firstIntNumber = Convert.ToInt32(firstNumber);

    Console.WriteLine("Now enter a second number :");
    string secondNumber = Console.ReadLine();
    int secondIntNumber = Convert.ToInt32(secondNumber);

    int result = firstIntNumber + secondIntNumber;
    Console.WriteLine("Well, the result of your calculation " + firstIntNumber + " + " + secondIntNumber + " = " + result + " !");
  }
}