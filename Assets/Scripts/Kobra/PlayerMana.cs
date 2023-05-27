using UnityEngine;
using UnityEngine.UI;

public class PlayerMana : MonoBehaviour
{
    [Header("����")]
    public static float MaxMana = 100f;
    public float proverka_MaxMana;
    public static float currentMana;
    public float proverka_currentMana;
    [Header("����������� ����")]
    public float PlusMana = 5; // ������� �����.���� � ���

    public Image manaBar;
   
    void Start()
    {
        currentMana = MaxMana;
        manaBar.fillAmount = MaxMana / MaxMana;

        proverka_MaxMana= MaxMana;
        proverka_currentMana = currentMana;
    }

    private void Update()
    {
        
        manaBar.fillAmount = currentMana / MaxMana;

        proverka_MaxMana = MaxMana;
        proverka_currentMana = currentMana;

        ProverkaMaxMana();
        ProverkaMinMana();
        StamPlus();

    }

    private void StamPlus() // ����� �������
    {
        manaBar.fillAmount = currentMana / MaxMana;
        if (currentMana < MaxMana)
        {
            currentMana += PlusMana * Time.deltaTime; // ����� ������� � ���       
        }
    }

    private void ProverkaMaxMana() // ���� �� ��������� ����.�������� ����
    {
        if (currentMana > MaxMana)
        {
            currentMana = MaxMana;
        }
    }

    private void ProverkaMinMana() // ���� ���� �� ������� � �����
    {
        if (currentMana < 0)
        {
            currentMana = 0;
        }
    }
}
