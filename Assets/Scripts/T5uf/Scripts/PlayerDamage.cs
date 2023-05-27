using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public static float swordDamage = 25f;
    public static float arrowDamage = 10f;
    public static float spellDamage = 40f;
    public float prov;

    void Update()
    {
        prov = spellDamage;
    }
}
