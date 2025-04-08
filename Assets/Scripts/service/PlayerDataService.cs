using System;
using System.IO;
using UnityEngine;

public class PlayerDataService : MonoBehaviour
{
    public static PlayerDataService Instance;
    
    public string PlayerName { get; private set; }
    public string PlayerSelectedCarName { get; private set; }
    public int PlayerScore { get; private set; }
    
    public Action<int> OnScoreChanged;
    
    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    public void SetPlayerName(string playerName)
    {
        PlayerName = playerName;
    }
    
    public void AddPlayerScore(int score)
    {
        PlayerScore += score;
        OnScoreChanged?.Invoke(PlayerScore);
    }
    
    public void UpdatePlayerCarName(string carName)
    {
        PlayerSelectedCarName = carName;
    }
    
    public void LoadPlayer()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.PlayerName;
            PlayerSelectedCarName = data.SelectedCarName;
        }
        else
        {
            PlayerName = string.Empty;
            PlayerSelectedCarName = string.Empty;
        }
    }

    public void SavePlayerData()
    {
        SaveData data = new SaveData();
        data.PlayerName = PlayerName;
        data.SelectedCarName = PlayerSelectedCarName;

        string json = JsonUtility.ToJson(data);
  
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
}
