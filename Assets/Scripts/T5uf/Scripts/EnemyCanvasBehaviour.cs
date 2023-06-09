using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCanvasBehaviour : MonoBehaviour
{
    Transform mainCamera;
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").transform;
    }

    void Update()
    {
        transform.LookAt(mainCamera.position);
    }
}
