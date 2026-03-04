using UnityEngine;

public class BlueButtonWall : MonoBehaviour
{
    [SerializeField] private GameObject wall;
    private void OnEnable()
    {
        wall.SetActive(false);
    }
    private void OnDisable()
    {
        if (wall != null)
        {
            wall.SetActive(true);
        }
    }
}
