using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public enum _suit
    {
        Chest,
        Cutlass,
        Parrot,
        Ship,
    }

    private int pointValue
    {
        get { return pointValue; }
        set { pointValue = value; }
    }
    private string displayName
    {
        get { return displayName;}
        set { displayName = value}
    }
    // need to figure out how to make a sprite property, and what to do with the sprite sheet
    // private sprite cardFace
    // private sprite cardBack
    private _suit suit
    {
        get { return suit; }
        set { suit = value; }
    }

    public Card(int pointValue, string displayName, _suit suit)
    {
        this.pointValue = pointValue;
        this.displayName = displayName;
        this.suit = suit;
        // set card front and back sprites
    }

    public Card(int pointValue, _suit suit)
    {
        this.pointValue = pointValue;
        this.displayName = pointValue.ToString();
        this.suit = suit;
        // set card front and back sprites
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

