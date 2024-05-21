﻿using Chapter07;

// Instantiate several objects of various classes that inherit from Product
Book book1 = new("Pride and Prejudice", "This timeless classic showcases Austen's wit and winsome characters", 12.49, 6, "Jane Austen", "Romantic Fiction", "Paperback");
Book book2 = new("The Fellowship of the Ring", "The first book of the epic The Lord of the Rings trilogy", 18.99, 3, "JRR Tolkien", "Fantasy Fiction", "Hardcover");
UsedBook usedBook1 = new("Fahrenheit 451", "A masterpiece of dystopian storytelling", 6.50, 1, "Ray Bradbury", "Dystopian Fiction", "Hardcover", "Good");
UsedBook usedBook2 = new("A Pocket Full of Rye", "Miss Marple does it again in this twisty murder mystery", 4.75, 1, "Agatha Christie", "Mystery Fiction", "Paperback", "Fair");
Drinkware mug = new("Ahsoka Mug", "Have coffee with Ahsoka every day!", 13.99, 3, "Mugs", "Star Wars", "Ceramic", 15);
Drinkware tumbler = new("The Little Mermaid Tumbler", "Keep cool with one of Ariel's newfangled contraptions", 16.49, 2, "Tumblers", "Disney", "Metal", 24);
Apparel hat = new("Captain America Hat", "Feel like a supersoldier in this classic hat proudly displaying Captain America's vibranium shield", 19.99, 5, "Hats", "Marvel", ["OS"], ["navy", "gray"]);
Apparel tShirt = new("Batman T-shirt", "Don the classic Batman logo with this minimalist design", 24.49, 4, "T-Shirts", "DC", ["XS", "S", "M", "L", "XL"], ["black"]);

// Note: Collection expressions are new in C# v12 - [1, 2, 3] is short for new int[]{ 1, 2, 3 }

// Print each item
Console.WriteLine(book1);
Console.WriteLine(book2);
Console.WriteLine(usedBook1);
Console.WriteLine(usedBook2);
Console.WriteLine(mug);
Console.WriteLine(tumbler);
Console.WriteLine(hat);
Console.WriteLine(tShirt);

// Increase quantity of hat by 5, then print again
hat.IncreaseQuantity(5);
Console.WriteLine(hat);

// Decrease quantity of mug by 1, then print again
mug.DecreaseQuantity(1);
Console.WriteLine(mug);

// Describe each item
Console.WriteLine(book1.Describe());
Console.WriteLine(book2.Describe());
Console.WriteLine(usedBook1.Describe());
Console.WriteLine(usedBook2.Describe());
Console.WriteLine(mug.Describe());
Console.WriteLine(tumbler.Describe());
Console.WriteLine(hat.Describe());
Console.WriteLine(tShirt.Describe());