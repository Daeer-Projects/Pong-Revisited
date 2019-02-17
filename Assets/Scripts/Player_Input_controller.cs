using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Script that handles the input from two players.
    /// Player 1 => Controls left bat with W/S keys.
    /// Player 2 => Controls right bat with arrow keys.
    /// </summary>
    public class Player_Input_controller : MonoBehaviour
    {
        public GameObject LeftBat;
        public GameObject RightBat;

        /// <summary>
        /// Start is called before the first frame update.
        /// </summary>
        private void Start()
        {
        }

        /// <summary>
        /// Update is called once per frame.
        /// </summary>
        private void Update()
        {
            MoveLeftBat();
            MoveRightBat();
        }

        private void MoveLeftBat()
        {
            LeftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

            // Player 1 key actions.
            if (Input.GetKey(KeyCode.W))
            {
                LeftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                LeftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
            }
        }

        private void MoveRightBat()
        {
            RightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

            // Player 1 key actions.
            if (Input.GetKey(KeyCode.UpArrow))
            {
                RightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 8f, 0f);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                RightBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, -8f, 0f);
            }
        }
    }
}