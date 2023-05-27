using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_vremeno : MonoBehaviour
{
    public int sc = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            MoneySystem.ScoreMoney += sc;
            Destroy(gameObject);
        }

    }
}
