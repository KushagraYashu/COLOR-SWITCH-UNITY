using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject countdownTxtGO;
    public GameObject countdownBGGO;
    public Text countdownTxt;
    public RawImage countdownBG;
    public GameObject dead;
    public GameObject end;
    bool enD = false;

    bool count = false;

    int j = 0;

    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }

    public void End()
    {
        end.SetActive(true);
        enD = true;
    }


    public void restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Dead()
    {
        if (!enD)
        {
            dead.SetActive(true);

        }
    }

    public void quit()
    {
        Application.Quit();
    }
    IEnumerator FadeImage()
    {
        for (float i = 1; i >= 0; i -= Time.unscaledDeltaTime * 3)
        {
            // set color with i as alpha
            countdownBG.color = new Color(1, 1, 1, i);
            yield return null;
        }

    }

    IEnumerator TextFn(bool resize)
    {
        if (resize)
        {
            for (float x = 3; x >= 1; x--)
            {
                countdownTxt.text = "" + (int)x;
                for (float i = 250; i > 145; i -= Time.unscaledDeltaTime * 100)
                {
                    countdownTxt.fontSize = (int)i;
                    yield return null;
                }
                if ((int)x == 1)
                {
                    count = true;
                }

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Time.timeScale = 0;
        if (count)
        {
            StartCoroutine(Resume());

        }
        if (j == 0)
        {
            StartCoroutine(TextFn(true));
            j++;
        }


    }

    IEnumerator Resume()
    {
        countdownTxt.text = "Play!";
        StartCoroutine(FadeImage());
        yield return new WaitForSecondsRealtime(1f);
        Time.timeScale = 1;
        countdownTxtGO.SetActive(false);
        countdownBGGO.SetActive(false);
    }
}
