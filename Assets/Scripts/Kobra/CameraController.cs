using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class CameraController : MonoBehaviour
{
    public GameObject Shop;
    public GameObject esc;

    public float mouseY;

    public static bool active;

    [Header("Чувст.мыши")]
    public float sensaMouse = 1f;

    public GameObject player;
    public float offsetX = 0;
    public float offsetZ = -5;
    public float playerVelocity = 5;
    private float movementX;
    private float movementZ;
    void Start()
    {
        active = true;
    }
    void Update()
    {

        CursorOnLock();
        MouseMovie();

    }

    public void CursorOnLock()
    {
        if (Shop.activeSelf || esc.activeSelf)
        {
            active = false;
            
        }
        else
        {
            active = true;
        }
    }

    public void MouseMovie()
    {
        movementX = ((player.transform.position.x + offsetX - this.transform.position.x));
        movementZ = ((player.transform.position.z + offsetZ - this.transform.position.z));
        this.transform.position += new Vector3((movementX * playerVelocity * Time.deltaTime), 0, (movementZ * playerVelocity * Time.deltaTime));
    }

}
