public class PromptGenerator 
//Supplies the user with random prompts whenever needed.
{
   public List<string> _prompts;
   //creates a blueprint of a list of strings with a variable name of prompts.

   public PromptGenerator()
   //This is the conductor that runs when an object gets created.
   {
      _prompts = new List<string>
      //This fills the prompts with real prompts.
      {
         "Who was the most interesting person I interacted with today?",
         "What was the best part of my day?",
         "How did I see the hand of the Lord in my life today?",
         "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?"

      };
   }
   public string GetRandomPrompt()
   {
      Random rand = new Random();
      //creates a random object.
      int index = rand.Next(_prompts.Count);
      //picks a random index from _prompts.
      return _prompts[index];
   }
}