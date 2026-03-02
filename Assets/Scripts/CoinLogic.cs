using TMPro;
using UnityEngine;

public class CoinLogic : MonoBehaviour
{
    [SerializeField] private float CoinValue = 1f;
    [SerializeField] private CoinCounter CoinCounter;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CoinCounter.coinCounter += CoinValue;
            Destroy(gameObject);
        }
    }
}
