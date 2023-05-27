using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject[] Zona;
    public GameObject loc1Area;
    public GameObject loc2Area;
    public GameObject tpPoint1;
    public GameObject tpPoint2;
    public GameObject player;
    public float timeStart1 = 60f; //время в первой локации
    public float timeStart2 = 120f;//время во второй локации
    public static float timeStart; //для расчетов, будет приравнено ко времени локации
    public Text timerText; //текст, который будет выводится на экран
    public static int rounds;
    public Text roundsText;
    public static bool pos = true; //чтобы знать какая локация, по умолчанию 1
    [Header("Выключатель")]
    public bool timerRun = true; //выключатель таймера
    private bool roundPlus = true;
    // Start is called before the first frame update
    void Start()
    {
        rounds = 0;
        timeStart = timeStart1;
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        roundsText.text = "Раунд: " + rounds.ToString();
        Limer();
    }

    public void Limer()
    {
        if (timerRun)
        {
            if (pos) { Timer1(); }
            else if (!pos) { Timer2(); }
        }
        else if (!timerRun) { timerText.fontSize = 30; timerText.text = "Таймер выключен"; }
    }

    public void Timer1()
    {
        Zona[0].SetActive(true);
        Zona[1].SetActive(true);
       
        timerText.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 10f) //смена цвета
            timerText.color = Color.red;
        if (timeStart <= 0f) //сброс таймера и приравнивание его ко времени 2 локации
        {
            player.GetComponent<CharacterController>().enabled = false;
            timerText.color = Color.white;
            player.transform.position = tpPoint2.transform.position;
            timeStart = timeStart2;
            if (roundPlus)
            {
                Round();
                roundPlus = false;
            }
            pos = false;
            roundPlus = true;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }

    public void Timer2()
    {
        Zona[0].SetActive(false);
        Zona[1].SetActive(false);
        Zona[2].SetActive(false);
        timerText.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 10f) //смена цвета
            timerText.color = Color.red;
        if (timeStart <= 0f) //сброс таймера и приравнивание его ко времени 2 локации
        {
            player.GetComponent<CharacterController>().enabled = false;
            timerText.color = Color.white;
            player.transform.position = tpPoint1.transform.position;
            timeStart = timeStart1;
            pos = true;
            player.GetComponent<CharacterController>().enabled = true;
        }
    }
    void Round()
    {
        rounds++;
    }
}