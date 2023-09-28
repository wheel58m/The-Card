// Driver -------------------------------------------------/
Console.Clear();

// Create Deck of Cards ---------------/
int numColors = Enum.GetValues(typeof(Color)).Length;
int numRanks = Enum.GetValues(typeof(Rank)).Length;
int numCards = numColors * numRanks; // Get total number of cards

Card[] deck = new Card[numCards]; // Create deck of cards
for (int i = 0; i < numColors; i++) {
    for (int j = 0; j < numRanks; j++) {
        deck[i * numRanks + j] = new Card((Color)(i + 1), (Rank)(j + 1));
    }
}

// Select A Card ----------------------/
int cardNum;
while (true) {
    Console.Write($"Enter a card number (1-{numCards}): ");

    if (int.TryParse(Console.ReadLine(), out cardNum)) {
        if (cardNum >= 1 && cardNum <= numCards) {
            break;
        } else {
            Console.WriteLine($"Invalid input. Enter a number between 1 and {numCards}.");
        }
    } else {
        Console.WriteLine("Invalid input. Enter a number.");
    }
}

// Display Card -----------------------/
Console.WriteLine($"You selected the {deck[cardNum - 1].Rank} of {deck[cardNum - 1].Color}.");

// Card ---------------------------------------------------/
public class Card {
    public Color Color { get; set; }
    public Rank Rank { get; set; }

    public Card(Color color, Rank rank) {
        Color = color;
        Rank = rank;
    }
}

// Enumerations -------------------------------------------/
public enum Color { Red = 1, Green, Blue, Yellow }
// Enumeration of Ranks (1-10 & Symbols)
public enum Rank { One = 1, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Dollar, Modulo, Caret, Ampersand }