using UnityEngine;

public class BlackButtonFall : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float TimeOfDisable = 1f;
    private Collider _c;

    private void Awake()
    {
        _c = player.GetComponent<Collider>();
    }
    private void Enable()
    {
        _c.enabled = true;
    }

    private void OnEnable()
    {
        _c.enabled = false;

        Invoke("Enable", TimeOfDisable);
    }
}
