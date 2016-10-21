using UnityEngine;
using System.Collections;

public class GreenTileController : MonoBehaviour
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
        if (gameObject.tag == "T_Green")
        {
            tileRend.material = redMat;
            gameObject.tag = "T_Red";
            tileManager.redTilesList.Add(gameObject);
            tileManager.greenTilesList.Remove(gameObject);
        }
    }
}
