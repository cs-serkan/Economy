using UnityEngine;
using System;

namespace CsSerkan.Economy
{
    public class EconomyCore : MonoBehaviour, IEconomyService
    {
        // Singleton: Diðer kodlarýn bu sisteme kolayca ulaþmasýný saðlar
        public static EconomyCore Instance { get; private set; }

        [Header("Ayarlar")]
        [SerializeField] private double _currentGold = 0;
        public double CurrentGold => _currentGold; // Dýþarýdan sadece okunabilir

        public double clickValue = 1.0; // Vuruþ baþýna kazanç

        // Event: Altýn deðiþtiðinde UI veya diðer sistemler bunu duyar
        public static event Action<double> OnBalanceChanged;

        private void Awake()
        {
            if (Instance == null) Instance = this;
            else Destroy(gameObject);
        }

        // Vuruþ yapýldýðýnda çaðrýlacak metod
        public void ProcessHit()
        {
            AddGold(clickValue);
        }

        public void AddGold(double amount)
        {
            if (amount <= 0) return;
            _currentGold += amount;

            // Deðiþikliði herkese haber ver
            OnBalanceChanged?.Invoke(_currentGold);
            Debug.Log("Yeni Bakiye: " + _currentGold);
        }

        public bool SpendGold(double amount)
        {
            if (amount > _currentGold) return false;
            _currentGold -= amount;
            OnBalanceChanged?.Invoke(_currentGold);
            return true;
        }
    }
}