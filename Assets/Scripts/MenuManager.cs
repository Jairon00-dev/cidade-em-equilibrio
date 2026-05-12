using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void Sair()
    {
        Application.Quit();
    }
}