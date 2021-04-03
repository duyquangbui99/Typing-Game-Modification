using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool IsPaused = false;

    public GameObject PauseMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (IsPaused)
            {
                Continue();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void Continue()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        IsPaused = false;
    }

    void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        IsPaused = true;
    }


    public void saveGame()
    {
        PlayerPrefs.SetInt("score", SaveData.score);
        PlayerPrefs.SetString("name", SaveData.playerName);

        Debug.Log("Saved Game");
    }

    public void loadGame()
    {
        SaveData.score = PlayerPrefs.GetInt("score");
        SaveData.playerName = PlayerPrefs.GetString("name");
        Continue();

        Debug.Log("Loaded Game");
    }

    public void NewGame()
    {
        SaveData.score = 0;
        SceneManager.LoadScene("Main");
        Continue();
    }

    public void MusicToggle()
    {
        if (MusicScript.BgInstance.Audio.isPlaying)
        {
            MusicScript.BgInstance.Audio.Pause();
        }
        else
        {
            MusicScript.BgInstance.Audio.Play();
        }
    }

    public void SaveAsJson()
    {
        JsonData data = new JsonData();

        data.Name = SaveData.playerName;
        data.Score = SaveData.score.ToString();

        string json = JsonUtility.ToJson(data);

        Debug.Log("Save as JSON:" + json);

    }

    public void toScoreBoard()
    {
        SceneManager.LoadScene("ScoreBoard");
    }
}
