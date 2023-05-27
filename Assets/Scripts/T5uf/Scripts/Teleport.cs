using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tpPoint1; //точка телепорта 2 локации
    public GameObject tpPoint; //точка телепорта 1 локации
    public GameObject player; //персонаж
    void Start()
    {
        
    }

    void Update()
    {
        //проверка закончился ли таймер и какая локация
        if (Timer.timeStart <= 0.6f && Timer.pos) //если 1 локация то тп во 2 локацию
            player.transform.position = tpPoint1.transform.position;
        else if (Timer.timeStart <= 0.6f && !Timer.pos) //елси 2 локация то в 1 локацию
            player.transform .position = tpPoint.transform.position;
    }
}
