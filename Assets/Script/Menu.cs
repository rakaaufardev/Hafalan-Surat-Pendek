using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ReadButton()
    {
        SceneManager.LoadScene("MenuPilihSuratBaca");
    }

    public void ReadAnNas()
    {
        SceneManager.LoadScene("BacaAnNas");
    }

    public void ReadAlFalaq()
    {
        SceneManager.LoadScene("BacaAlFalaq");
    }

    public void ReadAlIkhlas()
    {
        SceneManager.LoadScene("BacaAlIkhlas");
    }

    public void ReadAlLahab()
    {
        SceneManager.LoadScene("BacaAlLahab");
    }

    public void ReadAnNasr()
    {
        SceneManager.LoadScene("BacaAnNasr");
    }

    public void ReadAlKafirun()
    {
        SceneManager.LoadScene("BacaAlKafirun");
    }

    public void ReadAlKausar()
    {
        SceneManager.LoadScene("BacaAlKausar");
    }

    public void SoalAnNas()
    {
        SceneManager.LoadScene("QuizAnNas");
    }

    public void BackReadAnNas()
    {
        SceneManager.LoadScene("MenuPilihSuratBaca");
    }

    public void BackHomeButton()
    {
        SceneManager.LoadScene("Menu");
    }

    public void AboutButton()
    {
        SceneManager.LoadScene("About");
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
