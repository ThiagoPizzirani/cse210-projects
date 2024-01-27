public class Scripture
{

    private Reference _reference;
    private List<Word> _words;


    public Scripture(string text, Reference reference)
    {
        
          List<Word> _words = new List<Word>();
        string[] splitter = text.Split(" ");

        for (int i = 0; i < splitter.Length; i++)
            {
               //Console.Write(splitter[i]);
               //Console.Write(" ");
                Word word = new Word(splitter[i]);
                _words.Add(word);
            }

    }

    public string HideRandomWords(string text)
    {
        string hiddenWords = text.Replace("Christ","____");
        return hiddenWords;
    }

    public void GetDisplayText()

    {

        foreach(Word item in _words) 
        {
            Console.Write($"{item}");
        }
        
    }

   // public bool IsCompletelyHidden()
   // {
        
   // }



}