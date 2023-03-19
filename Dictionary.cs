using System.Collections.Generic;

class ErrorDictionary
{
    public static Dictionary<string, List<string>> GetDictionary()
    {
        var dictionary = new Dictionary<string, List<string>>();
        dictionary.Add("привет", new List<string> { "првиет" });
        dictionary.Add("Привет", new List<string> { "Првиет" });
        dictionary.Add("например", new List<string> { "напрмиер" });
        dictionary.Add("Олег", new List<string> { "олег" });
        dictionary.Add("твои", new List<string> { "тваи" });
        dictionary.Add("дела", new List<string> { "дила" });
        dictionary.Add("меня", new List<string> { "миня" });
        dictionary.Add("зовут", new List<string> { "завут" });
        dictionary.Add("Данил", new List<string> { "Донил", "Данел" });
        dictionary.Add("Я", new List<string> { "Йа" });
        dictionary.Add("хотел", new List<string> { "хател" });
        dictionary.Add("погулять", new List<string> { "пагулят", "прагуляца" });
        dictionary.Add("тобой", new List<string> { "табой" });
        return dictionary;
    }
}