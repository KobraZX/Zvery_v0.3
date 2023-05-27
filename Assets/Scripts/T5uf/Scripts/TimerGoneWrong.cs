using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimerGoneWrong : MonoBehaviour
{

    public float timeStart1 = 60f; //����� � ������ �������
    public float timeStart2 = 120f; //����� �� ������ �������
    public static float timeStart; //��� ��������, ����� ���������� �� ������� �������
    public Text timerText; //�����, ������� ����� ��������� �� �����
    public static bool pos = true; //����� ����� ����� �������, �� ��������� 1
    [Header("�����������")]
    public bool timerRun = true; //����������� �������


    void Start()
    {
        timeStart = timeStart1; //������������� �� ������� 1 �������
        timerText.text = timeStart.ToString(); //������� ���� � float �� string
    }

    void Update()
    {
        if (timerRun) //�������� ������� ������ ��� ���
            TimeMachine();
        else if (!timerRun)
        {
            timerText.fontSize = 30;
            timerText.text = "������ ��������";
        }
    }

    public void TimeMachine() //��� ������
    {

        timeStart -= Time.deltaTime; //����� ����� ����������� ���������� ���� �������
        timerText.text = Mathf.Round(timeStart).ToString(); //���������� � ������� �� string
        if (timeStart <= 10f) //����� �����
            timerText.color = Color.red;
        if (timeStart <= 0f && pos) //����� ������� � ������������� ��� �� ������� 2 �������
        {
            timerText.color = Color.white;
            pos = false;
            timeStart = timeStart2;
        }
        else if (timeStart <= 0f && !pos) //����� ������� � ������������� ��� � 1 �������
        {
            timerText.color = Color.white;
            pos = true;
            timeStart = timeStart1;
        }
    }
}