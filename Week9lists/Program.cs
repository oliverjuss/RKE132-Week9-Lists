string folterPatch = @"E:\Dropbox\Codeing\Week9lists";
string fileNmae = "shoppingList.txt";
string filePatch = Path.Combine(folterPatch, fileNmae);

List<string> myShoppingList = new List<string>();

if (File.Exists(filePatch))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePatch, myShoppingList);
}
else
{
    File.CreateText(filePatch).Close();
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePatch, myShoppingList);
    Console.WriteLine($"Crated a new file in {filePatch} name is: {fileNmae}");
}



static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/Exit (exit):");
        string userChoice = Console.ReadLine();

        if (userChoice == "add")
        {
            Console.WriteLine($"Enter a item: ");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye");
            break;
        }
    }
    return userList;
}

static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLentgth = someList.Count;
    Console.WriteLine($"You have added {listLentgth} to your shopping list");

    int i = 1;

    foreach (string item in someList)
    {
        Console.WriteLine($"{i} {item}");
        i++;
    }

}

