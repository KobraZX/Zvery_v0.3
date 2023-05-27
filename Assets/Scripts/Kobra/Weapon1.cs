using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Weapon1 : MonoBehaviour
{

    public int damage = 25;
    public int MinusStam = 25;
    public float SpeedAttack = 2f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerAttack.damage *= 0;
            PlayerAttack.damage += damage;

            PlayerAttack.stam *= 0;
            PlayerAttack.stam += MinusStam;

            PlayerAttack.SpeedAttack *= 0;
            PlayerAttack.SpeedAttack += SpeedAttack;

            Destroy(gameObject);
        }

    }
}
