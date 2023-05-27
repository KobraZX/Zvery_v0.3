using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SelectLoc : MonoBehaviour
{
    public GameObject player;
    public GameObject tpPoint;
    public GameObject tpPoint1;
    public KeyCode tpTo1Loc;
    public KeyCode tpTo2Loc;
    void Update()
    {
        if (Input.GetKeyDown(tpTo1Loc))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = tpPoint.transform.position;
            player.GetComponent<CharacterController>().enabled = true;
        }
        else if (Input.GetKeyDown(tpTo2Loc))
        {
            player.GetComponent<CharacterController>().enabled = false;
            player.transform.position = tpPoint1.transform.position;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
}
