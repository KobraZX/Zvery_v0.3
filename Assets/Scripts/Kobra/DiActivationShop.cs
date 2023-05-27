using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiActivationShop : MonoBehaviour
{
    public GameObject shop;

    void Update()
    {
        Di();
    }

    public void Di()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            shop.SetActive(false);
        }
    }
}
