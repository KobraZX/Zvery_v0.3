using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject tpPoint1; //����� ��������� 2 �������
    public GameObject tpPoint; //����� ��������� 1 �������
    public GameObject player; //��������
    void Start()
    {
        
    }

    void Update()
    {
        //�������� ���������� �� ������ � ����� �������
        if (Timer.timeStart <= 0.6f && Timer.pos) //���� 1 ������� �� �� �� 2 �������
            player.transform.position = tpPoint1.transform.position;
        else if (Timer.timeStart <= 0.6f && !Timer.pos) //���� 2 ������� �� � 1 �������
            player.transform .position = tpPoint.transform.position;
    }
}
