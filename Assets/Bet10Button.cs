using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bet10Button : MonoBehaviour, IPointerClickHandler
{
    public Player player;

    public void OnPointerClick(PointerEventData eventData) => player.Raise(10);
}
