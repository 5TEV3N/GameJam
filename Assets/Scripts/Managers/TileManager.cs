using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TileManager : MonoBehaviour
{
    // http://answers.unity3d.com/questions/141847/removing-objects-from-a-list-in-c.html
    public List<GameObject> redTilesList = new List <GameObject>();
    public List<GameObject> greenTilesList = new List <GameObject>();

    public void CorrecTileContainer()
    {

    }
}
/*
public GameObject[] redTileArray;
public GameObject[] greenTileArray;
public int goalGreen;
public int goalRed;

void Awake()
{
    redTileArray = GameObject.FindGameObjectsWithTag("T_Red");
    greenTileArray = GameObject.FindGameObjectsWithTag("T_Green");
    goalGreen = greenTileArray.Length;
    goalRed = redTileArray.Length;
}
*/
