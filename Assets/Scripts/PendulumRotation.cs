using UnityEngine;
using UnityEngine.SceneManagement;

public class PendulumRotation : MonoBehaviour
{
    [SerializeField] private float angleX;
    [SerializeField] private float angleZ;
    [SerializeField] private float rotationSpeed;

    // [SerializeField] private float time;
    private int directionX = 1;
    private int directionZ = 1;

    private void FixedUpdate()
    {
        if (angleX != 0)
        {
            gameObject.transform.Rotate(directionX * rotationSpeed, 0, 0);
        }
        if (angleZ != 0)
        {
            gameObject.transform.Rotate(0, 0, directionZ * rotationSpeed);
        }
        if ((gameObject.transform.rotation.x * directionX * 360) > angleX)
        {
            directionX *= -1;
        }
        if ((gameObject.transform.rotation.z * directionZ * 360) > angleZ)
        {
            directionZ *= -1;
        }
    }
    /*private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }*/
}
