using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ListExtensions;

public class GameTable : MonoBehaviour
{
    public GameObject playerPrefab;
    public List<Vector2> seatPositions; 
    public List<GameObject> players;

    public void AddPlayer()
    {
        if (players.Count < seatPositions.Count) 
        {
            var tmpObj = Instantiate(playerPrefab);
            players.Add(tmpObj);
            var newSeat = seatPositions[players.LastIndex()];
            tmpObj.transform.position = newSeat;
            tmpObj.transform.SetParent(this.transform, false);
        }
    }

    public void RemovePlayer()
    {
        var toDestroy = players.Pop();
        if (toDestroy != null)
        {
            DestroyImmediate(toDestroy);
        }
    }
}