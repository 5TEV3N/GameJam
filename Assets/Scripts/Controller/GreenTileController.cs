using UnityEngine;
using System.Collections;

public class GreenTileController : MonoBehaviour
{
    TileManager tileManager;

    public float xPos;
    public float zPos;

    public Material greenMat;
    public Material redMat;
    public Vector3 newPosition;

    public bool lerpStart = false;

    private Renderer tileRend;

    void Awake()
    {
        tileRend = GetComponent<MeshRenderer>();
        tileManager = GameObject.FindGameObjectWithTag("T_TileManager").GetComponent<TileManager>();
        xPos = gameObject.transform.position.x;
        zPos = gameObject.transform.position.z;
    }

    void Update()
    {
        if (lerpStart == true)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(xPos, 0, zPos), Time.deltaTime);
        }
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "T_Green")
        {
            tileRend.material = redMat;
            gameObject.tag = "T_Red";
            tileManager.redTilesList.Add(gameObject);
            tileManager.greenTilesList.Remove(gameObject);

            lerpStart = true;
        }
    }
}
