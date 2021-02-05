using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RemovePlayerButton : MonoBehaviour, IPointerClickHandler
{
    public GameTable gameTable;

    public void OnPointerClick(PointerEventData eventData) => gameTable.RemovePlayer();
}
