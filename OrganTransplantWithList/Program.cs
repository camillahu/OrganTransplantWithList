
using OrganTransplantWithList;

var PeopleList = new List<Person>()
{
    new ("Kåre", true, false),
    new ("Bjarne", true, false),
    new ("Marius", true, false),
    new ("Bernt", false, false),
};


Run();
 void Run()
 {
    Console.WriteLine($"{PeopleList[^1].Name} was in an accident.\n Both of his kidneys stopped functioning!");
     Thread.Sleep(1000);
     Console.WriteLine($"{PeopleList[^1].Name} now needs your help picking a donor!");
     Console.WriteLine("If you're ready, tap a key and we'll get started!");
     Console.ReadKey();

     Console.WriteLine();
    Thread.Sleep(1000);
     Console.WriteLine($"The first candidate out is {PeopleList[0].Name}! " +
                       $"\n He's a 6'5 vegan who loves kombucha and meditation! " +
                       $"\n He's a self-proclaimed health-enthusiast, and swears his kidneys are the best on the market. ");
     Console.WriteLine();
    Console.WriteLine("Tap whatever key you want to see our next candidate!");
    Console.ReadKey();

    Console.WriteLine();
    Console.WriteLine("*************************************************************************************************");
     Thread.Sleep(500);
     Console.WriteLine($"Next up is {PeopleList[1].Name}! " +
                       $"\n He's a professional mourner who you can pay to attend funerals!" +
                       $"\n His acting skills are out of this world, though we can't say the same about his kidney function.");
     Console.WriteLine();
    Console.WriteLine("Tap whatever key you want to see our next candidate!");
    Console.ReadKey();
    Console.WriteLine();
    Console.WriteLine("*****************************************************************************************************");
    Thread.Sleep(500);
    Console.WriteLine($"Next up is {PeopleList[2].Name}! " +
                       $"\n He loves Dr. Pepper and dinosaur-shaped biscuits." +
                       $"\n This one is a wild card, and his kidney functions remain a mystery.");
    Console.WriteLine();
    Console.WriteLine("Now the choice is yours! Choose candidate 1, 2 or 3 by typing their respective number. " +
                      $"\n Failure to so will result in {PeopleList[^1].Name}'s imminent death.");
    string userInput = Console.ReadLine();
    Person selectedDonor = CheckUserInput(userInput);
    selectedDonor.SetIsDonor(selectedDonor);
    Thread.Sleep(1000);
    Console.WriteLine($"Great choice! {selectedDonor} is now getting ready for the surgery.");
    Thread.Sleep(1000);
    selectedDonor.GiveKidney(PeopleList[^1]);

 }

 Person CheckUserInput(string input)
 {
     Person selectedPerson = null;

     if (input == "1")
     {
         selectedPerson= PeopleList[0];
     }
     else if (input == "2")
     {
         selectedPerson= PeopleList[1];
     }
     else if(input == "3")
     {
         selectedPerson = PeopleList[2];
     }
     else
     {
         Console.WriteLine($"You didn't input any of the correct numbers. Therefore you let {PeopleList[^1].Name} die. You monster! ");
         Environment.Exit(1);
     }

     return selectedPerson;
     
 };

