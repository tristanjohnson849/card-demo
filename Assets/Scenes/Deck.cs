using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;
using System.Random;

public class Deck : MonoBehaviour
{
    private ArrayList<Card> cards;
    // need to figure out how to make a sprite property, and what to do with the sprite sheet
    // private sprite nonEmptyDeck;
    // private sprite emptyDeck;
    
    public Deck(int numStandardDecks = 1)
    {
        ArrayList<Card> myCards = new ArrayList<Card>();

        for (int i = 1; i <= 13; i++)
        {
            // foreach(_suit suit in enum.getValues(typeOf(_suit))) Q: Where should I be storing the enum value? Presumably its own C# file since I want to reference it outside of Card.cs?
            for (int j = 0; j <= 3; j++)
            {
                curCard = new Card(i, (_suit)j);
                myCards.Add(curCard);
            }
        }

        this.cards = myCards;
        this.Shuffle();
    }

    public Deck(ArrayList<Card> cards)
    {
        this.cards = cards;
        this.Shuffle()
    }

    public Shuffle()
    {
        // Fisher-Yates & Durstenfield algorithm
        // swap the ith 
        rnd = new Random();
        int j;
        var tempCard = new Card(); 
        
        for (int i = 0; i <= cards.Count - 2; i++)
        {
            j = rnd.Next(i, cards.Count);
            tempCard = cards[i];
            cards[i] = cards[j];
            cards[j] = tempCard;
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
