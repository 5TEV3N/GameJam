using UnityEngine;
using System.Collections;

public class RedTileController : MonoBehaviour
{
    TileManager tileManager;

    public bool isGreen;
    public bool isRed;

    public Material greenMat;
    public Material redMat;

    private Renderer tileRend;

    void Awake()
    {
        tileRend = GetComponent<MeshRenderer>();
        tileManager = GameObject.FindGameObjectWithTag("T_TileManager").GetComponent<TileManager>();
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "T_Red")
        {
            tileRend.material = greenMat;
            gameObject.tag = "T_Green";
            tileManager.redTilesList.Remove(gameObject);
            tileManager.greenTilesList.Add(gameObject);
        }
    }
}
