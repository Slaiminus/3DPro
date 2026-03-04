using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private MonoBehaviour action;
    [SerializeField] private LayerMask mask;
    private int objectCount = 0;

    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("NoButton"))
        {
            objectCount += 1;
            action.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (!other.gameObject.CompareTag("NoButton"))
        {
            objectCount -= 1;
            if (objectCount <= 0)
            {
                action.enabled = false;
                objectCount = 0;
            }
        }
    }
}