using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TileManager : MonoBehaviour
{
    // http://answers.unity3d.com/questions/141847/removing-objects-from-a-list-in-c.html
    [Header ("Lists")]
    public List<GameObject> redTilesList = new List <GameObject>();
    public List<GameObject> greenTilesList = new List <GameObject>();

    [Header("")]
    public int countRedTilesLength;
    public int countGreenTilesLength;

    public bool redGoal;
    public bool greenGoal;

    void Update()
    {
        countRedTilesLength = redTilesList.Count;
        countGreenTilesLength = greenTilesList.Count;

        CorrecTileContainer();
    }

    public void CorrecTileContainer()
    {
        if (greenGoal == true)
        {
            if (countRedTilesLength == 0)
            {
                print("green win");
            }
        }

        if (redGoal == true)
        {
            if (countGreenTilesLength == 0)
            {
                print("red win");
            }
        }
    }
}
