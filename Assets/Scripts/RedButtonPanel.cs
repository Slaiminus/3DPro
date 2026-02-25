using UnityEngine;

public class RedButtonPanel : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private void OnEnable()
    {
        panel.SetActive(true);
    }
    private void OnDisable()
    {
        panel.SetActive(false);
    }
}
