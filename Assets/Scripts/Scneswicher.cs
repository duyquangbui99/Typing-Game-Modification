using UnityEngine;
using UnityEngine.SceneManagement;

public class Scneswicher : MonoBehaviour
{
    public void loadGameScene()
    {
        SceneManager.LoadScene("Main");
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void loadExit()
    {
        SceneManager.LoadScene("Exit");
    }
}
