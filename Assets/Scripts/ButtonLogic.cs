using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] private MonoBehaviour action;
    [SerializeField] private LayerMask mask;
    private int objectCount = 0;

    
    private void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("NoButton"))
        {
            objectCount += 1;
            action.enabled = true;
        }
    }
    private void OnCollisionExit(Collision other)
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