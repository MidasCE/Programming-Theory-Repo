using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace view.controller
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private GameObject uiMenu;
        [SerializeField] private TMP_Text scoreText;
        [SerializeField] private Button startGameButton;
        [SerializeField] private CarSelector carSelector;
        [SerializeField] private PlayerController playerController;

        public bool IsStarted { get; set; }

        public void Start()
        {
            IsStarted = false;
            startGameButton.onClick.AddListener(StartGame);

            PlayerDataService.Instance.OnScoreChanged = UpdateScore;
        }

        private void StartGame()
        {
            IsStarted = true;
            uiMenu.gameObject.SetActive(false);
            carSelector.gameObject.SetActive(false);
            playerController.SetCar(carSelector.GetSelectedCar());
        }

        private void UpdateScore(int score)
        {
            scoreText.text = "Score: " + score;
        }
    }
}