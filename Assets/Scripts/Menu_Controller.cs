using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class Menu_Controller : MonoBehaviour
    {
        /// <summary>
        /// Start is called before the first frame update.
        /// </summary>
        void Start()
        {
        
        }

        /// <summary>
        /// Update is called once per frame.
        /// </summary>
        void Update()
        {
        
        }

        public void StartGame()
        {
            SceneManager.LoadScene(1);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}
