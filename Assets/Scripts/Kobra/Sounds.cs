using UnityEngine;


public class Sounds : MonoBehaviour
{
    [Header("Звук кнопки")]
    public AudioSource sound_button;

    [Header("Звук магазина")]
    public GameObject Bshop;
    public AudioSource sound_open_shop;


    [Header("Звук покупки")]
    public AudioSource sound_buy;
    public AudioClip[] buyandzapret;

    void Update()
    {
        SoundOpenShop();
    }
    
    public void SoundClickButton()
    {
        sound_button.Play();                
    }
    
    public void SoundClickButtonBuy()
    {   
        if(MoneySystem.ScoreMoney >= Shop.Health_Coin||
           MoneySystem.ScoreMoney >= Shop.Stam_Coin||
           MoneySystem.ScoreMoney >= Shop.Mana_Coin ||
           MoneySystem.ScoreMoney >= Shop.Harakter_Hp_Coin ||
           MoneySystem.ScoreMoney >= Shop.Harakter_Stam_Coin ||
           MoneySystem.ScoreMoney >= Shop.Harakter_Mana_Coin ||
           MoneySystem.ScoreMoney >= Shop.Sword_Coin ||
           MoneySystem.ScoreMoney >= Shop.Bow_Coin ||
           MoneySystem.ScoreMoney >= Shop.Book_Coin)
        {
            sound_buy.clip = buyandzapret[0];
            sound_buy.Play();
        }
        else
        {
            sound_buy.clip = buyandzapret[1];
            sound_buy.Play();
        }
    }
    public void SoundOpenShop()
    {
        if (Bshop.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.B))
            {
                sound_open_shop.Play();
            }
                
        }
    }
}
