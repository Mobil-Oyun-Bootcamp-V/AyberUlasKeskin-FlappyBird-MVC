using System.Collections;
using System.Collections.Generic;
using MVC;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;


    public class GameManager : MonoBehaviour
    {
       
        public PlayerView _view;
        private PlayerController _controller;
        public int score;

        public Text ScoreText;
    

        // Start is called before the first frame update
        private void Start()
        {
            
            _controller = new PlayerController(_view);
            Time.timeScale = 1;
           
            score = 0;
            ScoreText.text = score.ToString();
            

        }
        // Update is called once per frame
        void Update()
        {

        }
        public void UpdateScore()
        {
            score++;
            ScoreText.text = score.ToString();
        }

        public void RestartGame()
        {
            SceneManager.LoadScene(0);
        }
    }


