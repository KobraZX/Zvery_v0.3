using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneySystem : MonoBehaviour
{
    public static int ScoreMoney = 0;
    public  int proverka_ScoreMoney;


    public Text Money;
    public RectTransform Trans;

    public Text[] MoneyShop;
    public RectTransform[] TransShop;

    // Update is called once per frame
    void Update()
    {
        
        ScoreText();
        ShopText1();
        ShopText2();
        ShopText3();
        ShopText4();
        ShopText5();
        ShopText6();
        ShopText7();
        ShopText8();
        ShopText9();

    }

    private void ScoreText()//—чЄт свеху
    {
        proverka_ScoreMoney = ScoreMoney;
        Money.text = ScoreMoney.ToString();

        if (ScoreMoney < 10)
        {
            Trans.anchoredPosition = new Vector2(50f, 0f);
        }
        if (ScoreMoney >= 10)
        {
            Trans.anchoredPosition = new Vector2(40f, 0f);
        }
        if (ScoreMoney >= 100)
        {
            Trans.anchoredPosition = new Vector2(20f, 0f);
        }
        if (ScoreMoney >= 1000)
        {
            Trans.anchoredPosition = new Vector2(-5f, 0f);
        }
        if (ScoreMoney >= 10000)
        {
            Trans.anchoredPosition = new Vector2(-25f, 0f);
        }
    } 
    private void ShopText1()//÷ена хилки
    {
        MoneyShop[0].text = Shop.Health_Coin.ToString();

        if (Shop.Health_Coin < 10)
        {
            TransShop[0].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Health_Coin >= 10)
        {
            TransShop[0].anchoredPosition = new Vector2(40f, 130f);
        }
        if (Shop.Health_Coin >= 100)
        {
            TransShop[0].anchoredPosition = new Vector2(30f, 130f);
        }
        if (Shop.Health_Coin >= 1000)
        {
            TransShop[0].anchoredPosition = new Vector2(20f, 130f);
        }
    }
    private void ShopText2()//÷ена стамины
    {
        MoneyShop[1].text = Shop.Stam_Coin.ToString();

        if (Shop.Stam_Coin < 10)
        {
            TransShop[1].anchoredPosition = new Vector2(60f, 130f);
        }
        if (Shop.Stam_Coin >= 10)
        {
            TransShop[1].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Stam_Coin >= 100)
        {
            TransShop[1].anchoredPosition = new Vector2(40f, 130f);
        }
        if (Shop.Stam_Coin >= 1000)
        {
            TransShop[1].anchoredPosition = new Vector2(30f, 130f);
        }
    }
    private void ShopText3()//÷ена маны
    {
        MoneyShop[2].text = Shop.Mana_Coin.ToString();

        if (Shop.Mana_Coin < 10)
        {
            TransShop[2].anchoredPosition = new Vector2(70f, 130f);
        }
        if (Shop.Mana_Coin >= 10)
        {
            TransShop[2].anchoredPosition = new Vector2(60f, 130f);
        }
        if (Shop.Mana_Coin >= 100)
        {
            TransShop[2].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Mana_Coin >= 1000)
        {
            TransShop[2].anchoredPosition = new Vector2(40f, 130f);
        }
    }
    private void ShopText4()//÷ена макс.хп
    {
        MoneyShop[3].text = Shop.Harakter_Hp_Coin.ToString();

        if (Shop.Harakter_Hp_Coin < 10)
        {
            TransShop[3].anchoredPosition = new Vector2(60f, 130f);
        }
        if (Shop.Harakter_Hp_Coin >= 10)
        {
            TransShop[3].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Harakter_Hp_Coin >= 100)
        {
            TransShop[3].anchoredPosition = new Vector2(40f, 130f);
        }
        if (Shop.Harakter_Hp_Coin >= 1000)
        {
            TransShop[3].anchoredPosition = new Vector2(30f, 130f);
        }
    }
    private void ShopText5()//÷ена макс.стам
    {
        MoneyShop[4].text = Shop.Harakter_Stam_Coin.ToString();

        if (Shop.Harakter_Stam_Coin < 10)
        {
            TransShop[4].anchoredPosition = new Vector2(60f, 130f);
        }
        if (Shop.Harakter_Stam_Coin >= 10)
        {
            TransShop[4].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Harakter_Stam_Coin >= 100)
        {
            TransShop[4].anchoredPosition = new Vector2(40f, 130f);
        }
        if (Shop.Harakter_Stam_Coin >= 1000)
        {
            TransShop[4].anchoredPosition = new Vector2(30f, 130f);
        }
    }
    private void ShopText6()//÷ена макс.маны
    {
        MoneyShop[5].text = Shop.Harakter_Mana_Coin.ToString();

        if (Shop.Harakter_Mana_Coin < 10)
        {
            TransShop[5].anchoredPosition = new Vector2(60f, 130f);
        }
        if (Shop.Harakter_Mana_Coin >= 10)
        {
            TransShop[5].anchoredPosition = new Vector2(50f, 130f);
        }
        if (Shop.Harakter_Mana_Coin >= 100)
        {
            TransShop[5].anchoredPosition = new Vector2(40f, 130f);
        }
        if (Shop.Harakter_Mana_Coin >= 1000)
        {
            TransShop[5].anchoredPosition = new Vector2(30f, 130f);
        }
    }
    private void ShopText7()//÷ена меч
    {
        MoneyShop[6].text = Shop.Sword_Coin.ToString();

        if (Shop.Sword_Coin < 10)
        {
            TransShop[6].anchoredPosition = new Vector2(60f, 150f);
        }
        if (Shop.Sword_Coin >= 10)
        {
            TransShop[6].anchoredPosition = new Vector2(50f, 150f);
        }
        if (Shop.Sword_Coin >= 100)
        {
            TransShop[6].anchoredPosition = new Vector2(40f, 150f);
        }
        if (Shop.Sword_Coin >= 1000)
        {
            TransShop[6].anchoredPosition = new Vector2(30f, 150f);
        }
    }
    private void ShopText8()//÷ена лук
    {
        MoneyShop[7].text = Shop.Bow_Coin.ToString();

        if (Shop.Bow_Coin < 10)
        {
            TransShop[7].anchoredPosition = new Vector2(60f, 150f);
        }
        if (Shop.Bow_Coin >= 10)
        {
            TransShop[7].anchoredPosition = new Vector2(50f, 150f);
        }
        if (Shop.Bow_Coin >= 100)
        {
            TransShop[7].anchoredPosition = new Vector2(40f, 150f);
        }
        if (Shop.Bow_Coin >= 1000)
        {
            TransShop[7].anchoredPosition = new Vector2(30f, 150f);
        }
    }
    private void ShopText9()//÷ена книга
    {
        MoneyShop[8].text = Shop.Book_Coin.ToString();

        if (Shop.Book_Coin < 10)
        {
            TransShop[8].anchoredPosition = new Vector2(60f, 150f);
        }
        if (Shop.Book_Coin >= 10)
        {
            TransShop[8].anchoredPosition = new Vector2(50f, 150f);
        }
        if (Shop.Book_Coin >= 100)
        {
            TransShop[8].anchoredPosition = new Vector2(40f, 150f);
        }
        if (Shop.Book_Coin >= 1000)
        {
            TransShop[8].anchoredPosition = new Vector2(30f, 150f);
        }
    }
}
