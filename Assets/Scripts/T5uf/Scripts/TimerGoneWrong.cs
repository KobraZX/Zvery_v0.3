using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TimerGoneWrong : MonoBehaviour
{

    public float timeStart1 = 60f; //время в первой локации
    public float timeStart2 = 120f; //время во второй локации
    public static float timeStart; //для расчетов, будет приравнено ко времени локации
    public Text timerText; //текст, который будет выводится на экран
    public static bool pos = true; //чтобы знать какая локация, по умолчанию 1
    [Header("Выключатель")]
    public bool timerRun = true; //выключатель таймера


    void Start()
    {
        timeStart = timeStart1; //приравнивание ко времени 1 локации
        timerText.text = timeStart.ToString(); //перевод типа с float на string
    }

    void Update()
    {
        if (timerRun) //проверка включен таймер или нет
            TimeMachine();
        else if (!timerRun)
        {
            timerText.fontSize = 30;
            timerText.text = "Таймер выключен";
        }
    }

    public void TimeMachine() //сам таймер
    {

        timeStart -= Time.deltaTime; //чтобы время уменьшалось отнимается одна секунда
        timerText.text = Mathf.Round(timeStart).ToString(); //округление и перевод на string
        if (timeStart <= 10f) //смена цвета
            timerText.color = Color.red;
        if (timeStart <= 0f && pos) //сброс таймера и приравнивание его ко времени 2 локации
        {
            timerText.color = Color.white;
            pos = false;
            timeStart = timeStart2;
        }
        else if (timeStart <= 0f && !pos) //сброс таймера и приравнивание его к 1 локации
        {
            timerText.color = Color.white;
            pos = true;
            timeStart = timeStart1;
        }
    }
}