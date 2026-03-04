using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour
{
    [SerializeField] private GameObject portalEnd;
    [SerializeField] private GameObject message;
    [SerializeField] private GameObject coinMessage;
    [SerializeField] private float textDuration = 1f;

    private bool canDeactivate = false;
    private void Update()
    {
        if (Input.anyKeyDown & canDeactivate)
        {
            message.SetActive(false);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canDeactivate = false;
            StartCoroutine(Waiting());
            other.transform.position = portalEnd.transform.position;
            other.transform.rotation = portalEnd.transform.rotation;
            message.SetActive(true);
            coinMessage.SetActive(true);
        }
    }
    IEnumerator Waiting()
    {
        yield return new WaitForSeconds(textDuration);
        canDeactivate = true;
    }
}
