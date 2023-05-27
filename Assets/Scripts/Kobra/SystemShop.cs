using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemShop : MonoBehaviour
{
    public GameObject B;
    public GameObject Shop;

    public bool actB;
    public bool actShop;

    void Start()
    {
        actB = false;
        
    }

    
    void Update()
    {
        ActAndDeActB();
        ActShop();
        actShop = actB;
    }

    private void OnTriggerStay (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            actB = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            actB = false;
            Shop.SetActive(false);
        }
    }

    public void ActAndDeActB()
    {
        if (actB == true)
        {
            B.SetActive(true);
        }
        else if (actB == false)
        {
            B.SetActive(false);
        }
    }
    public void ActShop()
    {
        if (Input.GetKeyDown(KeyCode.B) && actB == true)
        {
            Shop.SetActive(true);
            /*
            GameObject ob1 = GameObject.Find("Camera");
            CameraController sc1 = ob1.GetComponent<CameraController>();
            sc1.enabled = false;
            */
        }
        else if (actB == false)
        {
            Shop.SetActive(false);
        }
    }
}
