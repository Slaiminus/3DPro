using TMPro;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    [SerializeField] private GameObject finishPanel;
    [SerializeField] private int finishValue;
    public float coinCounter;

    private void Update()
    {
        coinText.text = $"Coin: {coinCounter}";
        if (coinCounter >= finishValue)
        {
            finishPanel.SetActive(true);
        }
    }
}
