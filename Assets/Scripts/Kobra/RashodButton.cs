using UnityEngine;
using UnityEngine.UI;

public class RashodButton : MonoBehaviour
{
    [Header("Настройка зелья здоровья")]
    public Text healthText;
    public GameObject HealthOff;

    public static int scoreHealth = 0;
    public static int RegenHp = 25;
    public int proverka_RegenHp;

    [Header("Настройка зелья стамины")]
    public Text stamText;
    public GameObject StamOff;

    public static int scoreStam = 0;
    public static int RegenStam = 50;

    [Header("Настройка зелья маны")]
    public Text manaText;
    public GameObject ManaOff;

    public static int scoreMana = 0;
    public static int RegenMana = 25;


    void Start()
    {
        HealthOff.SetActive(true);
        StamOff.SetActive(true);
        ManaOff.SetActive(true);
    }


    void Update()
    {
        Text();
        ActButton();
        ProverkaNa0();
        proverka_RegenHp = RegenHp;
    }

    private void Text()
    {
        healthText.text = scoreHealth.ToString();
        stamText.text = scoreStam.ToString();
        manaText.text = scoreMana.ToString();
    }

    private void ActButton()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (scoreHealth > 0)
            {
                scoreHealth -= 1;
                PlayerHP.currentHealth += RegenHp;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (scoreStam > 0)
            {
                scoreStam -= 1;
                PlayerStamina.currentStamina += RegenStam;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (scoreMana > 0)
            {
                scoreMana -= 1;
                PlayerMana.currentMana += RegenMana;
            }
        }
    }
    private void ProverkaNa0()
    {
        if (scoreHealth > 0)
        {
            HealthOff.SetActive(false);
        }
        if (scoreHealth == 0)
        {
            HealthOff.SetActive(true);
        }
        if (scoreStam > 0)
        {
            StamOff.SetActive(false);
        }
        if (scoreStam == 0)
        {
            StamOff.SetActive(true);
        }
        if (scoreMana > 0)
        {
            ManaOff.SetActive(false);
        }
        if (scoreMana == 0)
        {
            ManaOff.SetActive(true);
        }
    }
}
