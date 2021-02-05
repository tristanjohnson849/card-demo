using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTable : MonoBehaviour
{
    public GameObject playerPrefab;
    public List<Vector2> seatPositions; 
    public List<GameObject> players;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void AddPlayer()
    {
        if (players.Count < seatPositions.Count) {
            Debug.Log($"Adding player at index {players.Count}");
            var tmpObj = Instantiate(playerPrefab);
            players.Add(tmpObj);
            var newSeat = seatPositions[players.Count - 1];
            tmpObj.transform.position = newSeat;
            tmpObj.transform.SetParent(this.transform, false);
        }
    }

    public void RemovePlayer()
    {
        if (players.Count > 0)
        {
            Debug.Log($"Removing player at index {players.Count - 1}");
            var toDestroy = players[players.Count - 1];
            players.RemoveAt(players.Count - 1);
            DestroyImmediate(toDestroy);
        }
    }
}
/**
 * -700, 0
 * -600, -200
 * -350, -300
 * 0, -300
 * 350, -300
 * 600, -200
 * 700, 0
 */
