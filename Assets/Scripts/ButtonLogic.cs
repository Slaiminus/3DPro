using UnityEngine;

public class ButtonLogic : MonoBehaviour
{
    [SerializeField] MonoBehaviour action;

    private void OnCollisionEnter(Collision other)
    {
        action.enabled = true;
    }
    private void OnCollisionExit(Collision other)
    {
        action.enabled = false;
    }
}