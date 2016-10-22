using UnityEngine;
using System.Collections;

public class WhiteTileCheckRed : MonoBehaviour
{
    WhiteTileManager whiteTileManager;

    void Awake()
    {
        whiteTileManager = GameObject.FindGameObjectWithTag("T_WhiteTileManager").GetComponent<WhiteTileManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "T_Red")
        {
            //whiteTileManager.objectsNearWhiteTile++;
            print("Cannot remove yet");
        }
    }
}
