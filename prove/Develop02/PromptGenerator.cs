public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What was the funniest part of your day?",
            "How did you wake up this morning?",
            "What was your favorite meal today?"
        };

        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string random = _prompts[randIndex];
        
        return random;
    }
}