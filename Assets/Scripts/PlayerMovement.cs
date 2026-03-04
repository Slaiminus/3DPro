using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private InputControler movementInputs;
    private Rigidbody _rb;
    private bool isGrounded = false;
    private string groundTag = "Ground";
    private int objectCount = 0;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    public void Jump()
    {
        if (isGrounded)
        {
            _rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }


    public void Walk(bool isForward, bool isBackward)
    {
        int isForwards = isForward ? 1 : 0;
        int isBackwards = isBackward ? 1 : 0;
        int direction = 1 * isForwards - 1 * isBackwards;
        transform.Translate(Vector3.forward * speed * direction * Time.deltaTime);
    }
    public void Rotate(bool isLeft, bool isRight)
    {
        int isLefts = isLeft ? 1 : 0;
        int isRights = isRight ? 1 : 0;
        int direction = 1 * isRights - 1 * isLefts;
        gameObject.transform.Rotate(0, direction * rotationSpeed, 0);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag(groundTag))
        {
            objectCount += 1;
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag(groundTag))
        {
            objectCount -= 1;
            if (objectCount <= 0)
            {
                isGrounded = false;
                objectCount = 0;
            }
        }
    }
}
