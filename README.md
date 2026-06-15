# Kartlegging C# Dag 1

## Code examples
```cs
        string message = "Hello, World";
        Console.WriteLine(message);
        int wholeNumber = 25;
        double myDoubleNumber = 50.5;
        Console.WriteLine(wholeNumber + myDoubleNumber);
        char a = 'a';
        bool isTrue = true;
        Console.WriteLine(a);
        Console.WriteLine(isTrue);

        string[] shoppingList = ["Milk", "Soda", "Ice Cream", "Cookies", "Chicken", "Steak"];

        // for (int i = 0; i < shoppingList.Length; i++)
        // {
        //     Console.WriteLine(shoppingList[i]);
        // }

        // foreach (string items in shoppingList)
        // {
        //     Console.WriteLine(items);
        // }

        List<string> shoppingList2 = shoppingList.ToList();
        shoppingList2.AddRange(["BBQ Sauce", "Cod", "Herring", "Salad"]);
        foreach (string items in shoppingList2)
        {
            Console.WriteLine(items);
        }
```