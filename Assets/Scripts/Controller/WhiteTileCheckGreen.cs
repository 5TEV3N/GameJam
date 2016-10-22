using UnityEngine;
using System.Collections;

public class WhiteTileCheckGreen : MonoBehaviour
{
    WhiteTileManager whiteTileManager;
    public float xPos;
    public float zPos;

    void Awake()
    {
        whiteTileManager = GameObject.FindGameObjectWithTag("T_WhiteTileManager").GetComponent<WhiteTileManager>();
        xPos = gameObject.transform.position.x;
        zPos = gameObject.transform.position.z;
    }

    void Update()
    {
        if (whiteTileManager.greenNearWhiteTile >= 4)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(xPos, 2, zPos), 0.1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "T_Green")
        {
            whiteTileManager.greenNearWhiteTile++;
            print("Green Tile near me");
        }
    }
}
