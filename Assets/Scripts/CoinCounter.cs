using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    public float coinCounter;

    private void Update()
    {
        coinText.text = $"Coin: {coinCounter}";
    }
}
