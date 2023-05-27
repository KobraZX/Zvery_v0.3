using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ESC : MonoBehaviour
{
    public bool GameIsPaused = false;

    public GameObject esc;

    void Start()
    {
        esc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Pause();
    }
    public void Pause()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {   
            esc.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    public void OnClickCont()
    {
        esc.SetActive(false);

        Time.timeScale = 1f;
    }

    public void OnClickQuitMenu()
    {
        SceneManager.LoadScene(0);
    }
}
