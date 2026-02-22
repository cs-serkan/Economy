using UnityEngine;
using TMPro;
using CsSerkan.Economy;

namespace CsSerkan.Economy.UI
{
    public class EconomyDisplay : MonoBehaviour
    {
        // Butonun içindeki yazý objesini buraya sürükleyeceðiz
        public TextMeshProUGUI buttonText;

        private void OnEnable()
        {
            EconomyCore.OnBalanceChanged += UpdateButtonText;
        }

        private void OnDisable()
        {
            EconomyCore.OnBalanceChanged -= UpdateButtonText;
        }

        private void Start()
        {
            if (EconomyCore.Instance != null)
            {
                UpdateButtonText(EconomyCore.Instance.CurrentGold);
            }
        }

        private void UpdateButtonText(double currentGold)
        {
            if (buttonText != null)
            {
                // Sadece sayýyý ve altýn sembolünü butonun üzerine yazar
                buttonText.text = "ALTIN: " + currentGold.ToString("N0");
            }
        }
    }
}