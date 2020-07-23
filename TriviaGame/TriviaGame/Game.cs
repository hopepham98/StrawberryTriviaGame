using static System.Console; 

namespace TriviaGame
{
    public class Game
    {
        public string Name = "Strawberry Trivia Game";
        public string Setting = "A classroom at Columbia";
        public int Goal = 10;

        public void Start()
        {
            Title = "The Strawberry Trivia Game by Hope Pham";
            WriteLine("Welcome to the Strawberry Trivia Game by Hope Pham. In this game you will learn fun facts about strawberry. To get ready for the game there is a question you must answer first. What is your name?");
       
            Player.Name = ReadLine();
            WriteLine("Hello " + Player.Name + "! Let's play The Strawberry Trivia Game! Press enter to start!");
            ReadLine();
            
            Question strawberrySeeds = new Question();
            strawberrySeeds.QuestionText = "There are 200 seeds in a strawberry. Treu or false?";
            strawberrySeeds.CorrectAnswer = "true";
            Clear();

            Question strawberryGroupMember = new Question();
            strawberryGroupMember.QuestionText = "What is the flower family name that strawberry belongs to (that starts with the letter r)?";
            strawberryGroupMember.CorrectAnswer = "rose";
            Clear();
          
            string input;
            WriteLine(strawberrySeeds.QuestionText);
            input = ReadLine(); 
            WriteLine("Your answer: " + input + ", the correct answer: " + strawberrySeeds.CorrectAnswer);
            ReadLine(); 
            Clear();

            WriteLine(strawberryGroupMember.QuestionText);
            input = ReadLine();
            WriteLine("Your answer: " + input + ", the correct answer: " + strawberryGroupMember.CorrectAnswer);
            ReadLine();
            Clear(); 

            WriteLine("Thanks for playing! Press the enter to exit this game.");
            ReadLine();



        }
    }
}