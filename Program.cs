Console.Clear();
//Zackary Santos
//Last Saved: 9/10/2026 3:32 PM
//Mini Challenge #5 - Mad Libs
//I asked the user to input 10 questions, and then I proceeded to take them and turn them into a story
//Peer Review name:Brandon Langehennig
//Review: great job, code looks great and runs fine.

//Loop
string replay = "";

while(replay != "No") {
//Question 1
Console.WriteLine("What is Your Name?: ");

string firstName = Console.ReadLine();

//Question 2
Console.WriteLine("Where do you live right now?: ");

string homeLocation = Console.ReadLine();

//Question 3
Console.WriteLine("What is your favorite color?: ");

string favoriteColor = Console.ReadLine();

//Question 4
Console.WriteLine("What is your favorite event?: ");

string favoriteEvent = Console.ReadLine();

//Question 5
Console.WriteLine("What is your favorite number?: ");

string favoriteNumber = Console.ReadLine();

int favoriteNumber2 = Convert.ToInt32(favoriteNumber);

//Question 6
Console.WriteLine("What is your Favorite Letter?: ");

string favoriteLetter = Console.ReadLine();

char favoriteLetter2 = Convert.ToChar(favoriteLetter);

//Question 7
Console.WriteLine("Who is your Best Friend?: ");

string bestFriend = Console.ReadLine();

//Queston 8
Console.WriteLine("Where is your favorite place to eat?: ");

string favoritePlace = Console.ReadLine();

//Question 9
Console.WriteLine("What is your favorite food?: ");

string favoriteFood = Console.ReadLine();

//Question 10
Console.WriteLine("What is your favorite Dessert?: ");

string favoriteDessert = Console.ReadLine();

//Story
Console.WriteLine("Great Answers! Now, this is the story using your answers:");
Console.WriteLine(firstName + ", who lived in " + homeLocation + ", one day found a free and brand new car, which was in their favorite color, which was " 
              + favoriteColor + ". The car even had their favorite number on it, which was " + favoriteNumber2 + 
              " and their favorite letter which was " + favoriteLetter2 + ". And so, they drove their new car to the nearest " + favoriteEvent + ". At this " + favoriteEvent + "," 
              + firstName + ", saw their best friend who was " + bestFriend + ". After letting them into the car they both went to " + favoritePlace + " to go eat dinner there. Inside of the Resturaunt, " + firstName + " ordered "
             + favoriteFood + " and then had dinner with their friend. After dinner, they both ordered dessert, which was " + favoriteDessert);

Console.WriteLine("Would you like to play again? 'Yes' or 'No': ");
replay = Console.ReadLine();
}

