using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Assets.Scripts
{
    /// <summary>
    /// Controls the scoreboard for the players.
    /// </summary>
    public class Scoreboard_Controller : MonoBehaviour
    {
        public static Scoreboard_Controller Instance;

        public Text PlayerOneScoreText;
        public Text PlayerTwoScoreText;

        private int _playerOneScore;
        private int _playerTwoScore;


        // Start is called before the first frame update
        private void Start()
        {
            Instance = this;
            _playerOneScore = 0;
            _playerTwoScore = 0;

            PlayerOneScoreText.text = _playerOneScore.ToString();
            PlayerTwoScoreText.text = _playerTwoScore.ToString();
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void GivePlayerOneAPoint()
        {
            _playerOneScore++;
            PlayerOneScoreText.text = _playerOneScore.ToString();

            if (_playerOneScore > 10)
            {
                SceneManager.LoadScene(2);
            }
        }

        public void GivePlayerTwoAPoint()
        {
            _playerTwoScore++;
            PlayerTwoScoreText.text = _playerTwoScore.ToString();

            if (_playerTwoScore > 10)
            {
                SceneManager.LoadScene(3);
            }
        }
    }
}