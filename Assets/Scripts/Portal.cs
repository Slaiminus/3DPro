using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject portalEnd;
    [SerializeField] private GameObject message;
    [SerializeField] private GameObject coinMessage;

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            message.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = portalEnd.transform.position;
            message.SetActive(true);
            coinMessage.SetActive(true);
        }
    }
}
