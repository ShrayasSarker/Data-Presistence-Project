using UnityEngine;
using TMPro;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public TMP_InputField NameInput;
    public string PlayerName;
    public TMP_Text BestScoreText;

    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        // Load best score
        var data = LoadHighScore();
        if (data == null)
        {
            BestScoreText.text = "No Best Score Yet!!";
        }
        else
        {
            BestScoreText.text = "Best Score: " + data.BestScore + " by " + data.BestPlayer;
        }
    }


    public void SaveName()
    {
        PlayerName = NameInput.text;
        Debug.Log("Player Name: " + PlayerName);
    }

    public void OnClickStart()
    {
        SaveName();
        SceneManager.LoadScene(1);
    }

    public void OnClickExit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }

[System.Serializable]

    public class SaveData
    {
        public string BestPlayer;
        public int BestScore;
    }

    public void SaveHighScore(string playerName, int score)
    {
        SaveData data = new SaveData();
        data.BestPlayer = playerName;
        data.BestScore = score;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public SaveData LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            return JsonUtility.FromJson<SaveData>(json);
        }
        return null;
    }

    public void OnClickReset()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            File.Delete(path);
            BestScoreText.text = "No Best Score Yet!!";
            Debug.Log("High score reset!");
        }
    }

}    