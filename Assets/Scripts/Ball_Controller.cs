using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    /// <summary>
    /// Controls the movement of the ball.
    /// </summary>
    public class Ball_Controller : MonoBehaviour
    {
        public Rigidbody BallBody;

        private Camera _mainCamera;
        private const float _minAngleOfDirection = 3.0f;
        private const float _maxAngleOfDirection = 9.0f;

        /// <summary>
        /// Start is called before the first frame update.
        /// </summary>
        void Start()
        {
            BallBody = GetComponent<Rigidbody>();
            _mainCamera = Camera.main;
            
            StartCoroutine(Pause());
        }

        IEnumerator Pause()
        {
            yield return new WaitForSeconds(2.5f);
            LaunchBall();
        }

        void LaunchBall()
        {
            transform.position = Vector3.zero;
            var leftOrRight = Random.Range(0, 2);
            var upOrDown = Random.Range(0, 2);


            float newXAngle = Random.Range(_minAngleOfDirection, _maxAngleOfDirection);
            float newYAngle = Random.Range(_minAngleOfDirection, _maxAngleOfDirection);

            float xForce = (leftOrRight == 1) ? -newXAngle : newXAngle;
            float yForce = (upOrDown == 1) ? -newYAngle : newYAngle;


            var launchDirection = new Vector3(xForce, yForce, 0f);
            
            BallBody.velocity = launchDirection;
        }

        /// <summary>
        /// Update is called once per frame.
        /// </summary>
        void Update()
        {
            if (transform.position.x < -25f)
            {
                transform.position = Vector3.zero;
                BallBody.velocity = Vector3.zero;

                Scoreboard_Controller.Instance.GivePlayerTwoAPoint();
                StartCoroutine(Pause());
            }

            if (transform.position.x > 25f)
            {
                transform.position = Vector3.zero;
                BallBody.velocity = Vector3.zero;

                Scoreboard_Controller.Instance.GivePlayerOneAPoint();
                StartCoroutine(Pause());
            }
            
            _mainCamera.backgroundColor = BallBody.velocity.x < 0f ? Color.red : Color.green;
        }
    }
}
