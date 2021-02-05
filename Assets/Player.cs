using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text bankDisplay;
    public int Bank
    { get; set; }

    public Text betDisplay;
    public int Bet
    { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        Bank = 100;
    }

    // Update is called once per frame
    void Update()
    {
        bankDisplay.text = $"Bank: {Bank}";
        betDisplay.text = $"Bet: {Bet}";
    }

    public void Raise(int value)
    {
        if (Bank - value >= 0)
        {
            Bank -= value;
            Bet += value;
        }
    }
}
