using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceWeapon : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(2);
    }
}
