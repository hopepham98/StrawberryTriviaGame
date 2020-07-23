# StrawberryTriviaGame :strawberry:
This is an application that was created during my Summer 2020 Intro to Programming class. This application allow player to answers questions about
strawberry and try to recived points.

# Assignment Challenge(s)
The challenge for this assignment was to figure out what questions to include in my application. However, the big issue was figuring how to add codes to allow players to receive points. To solve my first issue, I went on google to search for fun facts about strawberries. Then to address my most significant concern regarding code for the points, I decided to went on GitHub or other programming platforms to help me with my issue. I also had to figure out how I would incorporate the codes and cite the codes correctly.

```markdown
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
```
