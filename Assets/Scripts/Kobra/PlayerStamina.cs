using UnityEngine;
using UnityEngine.UI;

public class PlayerStamina : MonoBehaviour
{
    [Header("����.������� ���������")]
    public static float MaxStamina = 100;  // ������������ �������� ������������
    public float proverka_MaxStamina;
    public static float currentStamina; // ������� �������� ������������
    public float currentStamina2; // ������� �������� ������������(���� ������ ��� ��������)
    [Header("����������� �������")]
    public float PlusStamina = 5; // ������� �����.������� � ���

    [Header("����.������� ��� ������")]
    public float MinusStamJump = 10; // ������� ������ ������� �� ������
    public static float MinusStamJump2; // ���� ���������� � �������� MinusStamJump �� ������ ��������

    [Header("����.������� ��� �����")]
    public float MinusStamShift = 1; // ������� ������ ������� � ���
    public static float MinusStamShift2; // ���� ���������� � �������� MinusStamShift �� ������ ��������

    public Image staminaBar;


    void Start()
    {
        currentStamina = MaxStamina;
        MinusStamJump2 = MinusStamJump;
        MinusStamShift2 = MinusStamShift;
        staminaBar.fillAmount = MaxStamina / MaxStamina;
    }

    private void Update()
    {
        proverka_MaxStamina = MaxStamina;
        currentStamina2 = currentStamina;
        staminaBar.fillAmount = currentStamina / MaxStamina;
        StamPlus();
        ProverkaMaxStam();
        ProverkaMinStam();
    }

    private void StamPlus() // ����� �������
    {
        staminaBar.fillAmount = currentStamina / MaxStamina;
        if (currentStamina < MaxStamina)
        {
            currentStamina += PlusStamina * Time.deltaTime; // ����� ������� � ���       
        }
    }

    private void ProverkaMaxStam() // ���� �� ��������� ����.�������� �������
    {
        if (currentStamina > MaxStamina)
        {
            currentStamina = MaxStamina;
        }
    }

    private void ProverkaMinStam() // ���� ������� �� ������� � �����
    {
        if (currentStamina < 0)
        {           
            currentStamina = 0;
        }
    }
}