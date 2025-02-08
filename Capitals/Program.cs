while (true)
{
    Console.WriteLine("Type a word: ");
    var word = Console.ReadLine();

    Console.WriteLine(word == null || word.Length == 0 ? false : (word.All(char.IsUpper)) || (word.All(char.IsLower)) ||
        (word[0].ToString().All(char.IsUpper) && (word.Length == 1 || word.Substring(1, word.Length - 1).All(char.IsLower))) ? true : false);
}