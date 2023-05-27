using UnityEngine;
using UnityEngine.UI;


public class Shop : MonoBehaviour
{
    [Header("Сюда Shop из Canvas.")]
    public  GameObject ShopPrefab;

    [Header("Кнопки переключения")]
    public GameObject Wealcome;
    public GameObject Weaponlist;
    public GameObject Rashodlist;
    public GameObject Iconlist;

    [Header("Бэкраунд в описании")]
    public GameObject Backround3;

    [Header("Описание расход.")]
    public GameObject Rashod_Text_Health;
    public GameObject Rashod_Text_Mana;
    public GameObject Rashod_Text_Stam;

    [Header("Описание характер.")]
    public GameObject Harakter_Text_Health;
    public GameObject Harakter_Text_Mana;
    public GameObject Harakter_Text_Stam;

    [Header("Описание оруж.")]
    public GameObject Sword_Shop_Text;
    public GameObject Bow_Shop_Text;
    public GameObject Book_Shop_Text;

    [Header("Цена на зелья")]
    public Text Skolko_Heal; //Текст показывающий стоимость.
    public static int Health_Coin = 20; //начальная стоимость.
    public int Health_Upgrade = 50;//стоимость начального апгрейда.

    public Text Skolko_Stam;//Текст показывающий стоимость.
    public static int Stam_Coin = 40;//начальная стоимость.
    public int Stam_Upgrade = 50;//стоимость начального апгрейда.

    public Text Skolko_Mana;//Текст показывающий стоимость.
    public static int Mana_Coin = 25;//начальная стоимость.
    public int Mana_Upgrade = 50;//стоимость начального апгрейда.

    [Header("Цена на улучшение характеристик")]
    public Text Skolko_Hp_Max;//Текст показывающий стоимость.
    public static int Harakter_Hp_Coin = 50;//начальная стоимость.
    public int Harakter_Hp_Upgrade = 50;//стоимость начального апгрейда.
    public static float hp_prise = 1.5f;

    public Text Skolko_Stam_Max;//Текст показывающий стоимость.
    public static int Harakter_Stam_Coin = 50;//начальная стоимость.
    public int Harakter_Stam_Upgrade = 50;//стоимость начального апгрейда.
    public static float stam_prise = 1.5f;

    public Text Skolko_Mana_Max;//Текст показывающий стоимость.
    public static int Harakter_Mana_Coin = 50;//начальная стоимость.
    public int Harakter_Mana_Upgrade = 50;//стоимость начального апгрейда.
    public static float mana_prise = 1.5f;

    [Header("Цена на улучшение оружия")]
    public Text Skolko_Sword_Upgrade;//Текст показывающий стоимость.
    public static int Sword_Coin = 100;//начальная стоимость.
    public int Sword_Upgrade = 50;//стоимость начального апгрейда.
    public static float Minus_Sword = 25;

    public Text Skolko_Bow_Upgrade;//Текст показывающий стоимость.
    public static int Bow_Coin = 100;//начальная стоимость.
    public int Bow_Upgrade = 50;//стоимость начального апгрейда.
    public static float Minus_Bow = 10;

    public Text Skolko_Book_Upgrade;//Текст показывающий стоимость.
    public static int Book_Coin = 100;//начальная стоимость.
    public static int Book_Upgrade = 50;//стоимость начального апгрейда.
    public static float Minus_Book = 50;

    void Start()
    {
        Wealcome.SetActive(true); //Надписаь Wealcome в начале.
        Backround3.SetActive(false); //Отключение вкладки под описание.

        Weaponlist.SetActive(false);//Отключение вкладки.
        Rashodlist.SetActive(false);//Отключение вкладки.
        Iconlist.SetActive(false);//Отключение вкладки.

        Rashod_Text_Health.SetActive(false);//отключение текста с описанием.
        Rashod_Text_Mana.SetActive(false);//отключение текста с описанием.
        Rashod_Text_Stam.SetActive(false);//отключение текста с описанием.

        Harakter_Text_Health.SetActive(false);//отключение текста с описанием.
        Harakter_Text_Mana.SetActive(false);//отключение текста с описанием.
        Harakter_Text_Stam.SetActive(false);//отключение текста с описанием.

        Sword_Shop_Text.SetActive(false);//отключение текста с описанием.
        Bow_Shop_Text.SetActive(false);//отключение текста с описанием.
        Book_Shop_Text.SetActive(false);//отключение текста с описанием.

    }


    void Update()
    {
        Skolko();
    }

    public void Skolko()//отображение значения в тексте. (не трогать)
    {
        Skolko_Heal.text = Health_Coin.ToString();
        Skolko_Stam.text = Stam_Coin.ToString();
        Skolko_Mana.text = Mana_Coin.ToString();

        Skolko_Hp_Max.text = Harakter_Hp_Coin.ToString();
        Skolko_Stam_Max.text = Harakter_Stam_Coin.ToString();
        Skolko_Mana_Max.text = Harakter_Mana_Coin.ToString();

        Skolko_Sword_Upgrade.text = Sword_Coin.ToString();
        Skolko_Bow_Upgrade.text = Bow_Coin.ToString();
        Skolko_Book_Upgrade.text = Book_Coin.ToString();
    }

    //Вкладки
    public void OnClickWeapon()
    {
        Wealcome.SetActive(false);
        Rashodlist.SetActive(false);
        Iconlist.SetActive(false);
        Backround3.SetActive(false);

        Rashod_Text_Mana.SetActive(false);
        Rashod_Text_Stam.SetActive(false);
        Rashod_Text_Health.SetActive(false);

        Harakter_Text_Mana.SetActive(false);
        Harakter_Text_Stam.SetActive(false);
        Harakter_Text_Health.SetActive(false);

        Sword_Shop_Text.SetActive(false);
        Bow_Shop_Text.SetActive(false);
        Book_Shop_Text.SetActive(false);

        Weaponlist.SetActive(true);
    }
    public void OnClickRashod()
    {
        Wealcome.SetActive(false);
        Weaponlist.SetActive(false);
        Iconlist.SetActive(false);
        Backround3.SetActive(false);

        Harakter_Text_Mana.SetActive(false);
        Harakter_Text_Stam.SetActive(false);
        Harakter_Text_Health.SetActive(false);

        Rashod_Text_Mana.SetActive(false);
        Rashod_Text_Stam.SetActive(false);
        Rashod_Text_Health.SetActive(false);

        Sword_Shop_Text.SetActive(false);
        Bow_Shop_Text.SetActive(false);
        Book_Shop_Text.SetActive(false);

        Rashodlist.SetActive(true);
    }
    public void OnClickHren() //это характеристики.
    {
        Wealcome.SetActive(false);
        Weaponlist.SetActive(false);
        Rashodlist.SetActive(false);
        Backround3.SetActive(false);

        Harakter_Text_Mana.SetActive(false);
        Harakter_Text_Stam.SetActive(false);
        Harakter_Text_Health.SetActive(false);

        Rashod_Text_Mana.SetActive(false);
        Rashod_Text_Stam.SetActive(false);
        Rashod_Text_Health.SetActive(false);

        Sword_Shop_Text.SetActive(false);
        Bow_Shop_Text.SetActive(false);
        Book_Shop_Text.SetActive(false);

        Iconlist.SetActive(true);
    }

    //Информация о зельях
    public void OnClickHealth()
    {
        Rashod_Text_Mana.SetActive(false);
        Rashod_Text_Stam.SetActive(false);

        Backround3.SetActive(true);
        Rashod_Text_Health.SetActive(true);
    }

    public void OnClickMana()
    {
        Rashod_Text_Health.SetActive(false);
        Rashod_Text_Stam.SetActive(false);

        Backround3.SetActive(true);
        Rashod_Text_Mana.SetActive(true);
    }

    public void OnClickStam()
    {
        Rashod_Text_Health.SetActive(false);
        Rashod_Text_Mana.SetActive(false);

        Backround3.SetActive(true);
        Rashod_Text_Stam.SetActive(true);
    }

    //Покупка зелья
    public void OnClickBuyHealth()
    {
        if (MoneySystem.ScoreMoney >= Health_Coin)
        {
            MoneySystem.ScoreMoney -= Health_Coin;
            RashodButton.scoreHealth += 1;
        }
    }
    public void OnClickBuyStam()
    {
        if (MoneySystem.ScoreMoney >= Stam_Coin)
        {
            MoneySystem.ScoreMoney -= Stam_Coin;
            RashodButton.scoreStam += 1;
        }
    }
    public void OnClickBuyMana()
    {
        if (MoneySystem.ScoreMoney >= Mana_Coin)
        {
            MoneySystem.ScoreMoney -= Mana_Coin;
            RashodButton.scoreMana += 1;
        }
    }

    //Улучшение зелья
    public void OnClickUpgradeHeal()
    {
        if (MoneySystem.ScoreMoney >= Health_Upgrade)
        {
            MoneySystem.ScoreMoney -= Health_Upgrade;
            RashodButton.RegenHp += RashodButton.RegenHp;
            Health_Upgrade += Health_Upgrade / 5;
            Health_Coin += Health_Upgrade / 10;
        }
    }
    public void OnClickUpgradeStam()
    {
        if (MoneySystem.ScoreMoney >= Stam_Upgrade)
        {
            MoneySystem.ScoreMoney -= Stam_Upgrade;
            RashodButton.RegenStam += RashodButton.RegenStam;
            Stam_Upgrade += Stam_Upgrade / 5;
            Stam_Coin += Stam_Upgrade / 10;
        }
    }
    public void OnClickUpgradeMana()
    {
        if (MoneySystem.ScoreMoney >= Mana_Upgrade)
        {
            MoneySystem.ScoreMoney -= Mana_Upgrade;
            RashodButton.RegenMana += RashodButton.RegenMana;
            Mana_Upgrade += Mana_Upgrade / 5;
            Mana_Coin += Mana_Upgrade / 10;
        }
    }

    //Информация о характеристиках
    public void OnClickHarakterHp()
    {
        Harakter_Text_Mana.SetActive(false);
        Harakter_Text_Stam.SetActive(false);

        Backround3.SetActive(true);
        Harakter_Text_Health.SetActive(true);
    }

    public void OnClickHarakterMana()
    {
        Harakter_Text_Health.SetActive(false);
        Harakter_Text_Stam.SetActive(false);

        Backround3.SetActive(true);
        Harakter_Text_Mana.SetActive(true);
    }

    public void OnClickHarakterStam()
    {
        Harakter_Text_Health.SetActive(false);
        Harakter_Text_Mana.SetActive(false);

        Backround3.SetActive(true);
        Harakter_Text_Stam.SetActive(true);
    }
    //Улучшение характеристик
    public void OnClickUpgradeHarakterHp()
    {
        if (MoneySystem.ScoreMoney >= Harakter_Hp_Upgrade)
        {
            MoneySystem.ScoreMoney -= Harakter_Hp_Upgrade;
            RashodButton.RegenHp += RashodButton.RegenHp;
            Harakter_Hp_Upgrade += Harakter_Hp_Upgrade / 5;
            Harakter_Hp_Coin *= 2;
            PlayerHP.MaxHealth += hp_prise;
            PlayerHP.currentHealth = PlayerHP.MaxHealth;
        }
    }
    public void OnClickUpgradeHarakterStam()
    {
        if (MoneySystem.ScoreMoney >= Harakter_Stam_Upgrade)
        {
            MoneySystem.ScoreMoney -= Harakter_Stam_Upgrade;
            RashodButton.RegenStam += RashodButton.RegenStam;
            Harakter_Stam_Upgrade += Harakter_Stam_Upgrade / 5;
            Harakter_Stam_Coin *= 2;
            PlayerStamina.MaxStamina += stam_prise;
            PlayerStamina.currentStamina = PlayerStamina.MaxStamina;
        }
    }
    public void OnClickUpgradeHarakterMana()
    {
        if (MoneySystem.ScoreMoney >= Harakter_Mana_Upgrade)
        {
            MoneySystem.ScoreMoney -= Harakter_Mana_Upgrade;
            RashodButton.RegenMana += RashodButton.RegenMana;
            Harakter_Mana_Upgrade += Harakter_Mana_Upgrade / 5;
            Harakter_Mana_Coin *= 2;
            PlayerMana.MaxMana += mana_prise;
            PlayerMana.currentMana = PlayerMana.MaxMana;
        }
    }

    //Информация о оружие
    public void OnClickSword()
    {
        Bow_Shop_Text.SetActive(false);
        Book_Shop_Text.SetActive(false);

        Backround3.SetActive(true);
        Sword_Shop_Text.SetActive(true);
    }

    public void OnClickBow()
    {
        Sword_Shop_Text.SetActive(false);
        Book_Shop_Text.SetActive(false);

        Backround3.SetActive(true);
        Bow_Shop_Text.SetActive(true);
    }

    public void OnClickBook()
    {
        Sword_Shop_Text.SetActive(false);
        Bow_Shop_Text.SetActive(false);

        Backround3.SetActive(true);
        Book_Shop_Text.SetActive(true);
    }
    //Улучшение Оружия
    public void OnClickUpgradeSword()
        
    {
        if (MoneySystem.ScoreMoney >= Sword_Upgrade)
        {
            MoneySystem.ScoreMoney -= Sword_Upgrade;
            RashodButton.RegenHp += RashodButton.RegenHp;
            Sword_Upgrade += Sword_Upgrade / 5;
            Sword_Coin *= 2;
            PlayerDamage.swordDamage += 25;
            Minus_Sword *= 1.2f;
            
        }
    }
    public void OnClickUpgradeBow()
    {
        if (MoneySystem.ScoreMoney >= Bow_Upgrade)
        {
            MoneySystem.ScoreMoney -= Bow_Upgrade;
            RashodButton.RegenStam += RashodButton.RegenStam;
            Bow_Upgrade += Bow_Upgrade / 5;
            Bow_Coin *= 2;
            PlayerDamage.arrowDamage += 10;
            Minus_Bow *= 1.2f;
        }
    }
    public void OnClickUpgradeBook()
    {
        if (MoneySystem.ScoreMoney >= Book_Upgrade)
        {
            MoneySystem.ScoreMoney -= Book_Upgrade;
            RashodButton.RegenMana += RashodButton.RegenMana;
            Book_Upgrade += Book_Upgrade / 5;
            Book_Coin *= 2;
            PlayerDamage.spellDamage += 40;
            Minus_Book *= 1.2f;
        }
    }    
}



