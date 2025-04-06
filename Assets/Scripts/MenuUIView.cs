using extensions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIView : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private TMP_InputField nameInputField;
    public void Start()
    {
        startButton.onClick.AddListener(OnClickStartButton);

        if (PlayerDataService.Instance != null)
        {
            PlayerDataService.Instance.LoadPlayer();
            
            if (PlayerDataService.Instance.PlayerName.IsNotNullOrEmpty())
            {
                nameInputField.text = PlayerDataService.Instance.PlayerName;
            }
        }
    }
    
    private void OnClickStartButton()
    {
        if (nameInputField.text.IsNotNullOrEmpty() == false)
        {
            infoText.text = "Fill the player name to start";
        }
        else
        {
            LoadMainScene();
        }
    }
    
    private void LoadMainScene()
    {
        PlayerDataService.Instance.SetPlayerName(nameInputField.text);
        PlayerDataService.Instance.SavePlayerData();
        SceneManager.LoadScene(1);
    }
}
