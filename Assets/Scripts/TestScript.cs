using UnityEngine;

public class TestScript : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Test script on");
    }
    private void OnDisable()
    {
        Debug.Log("Test script off");
    }
}
