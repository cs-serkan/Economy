using UnityEngine;

namespace CsSerkan.Economy
{
    public class HitTrigger : MonoBehaviour
    {
        // Bu metod Unity içindeki bir butona veya týklama olayýna baðlanýr
        public void ExecuteHit()
        {
            if (EconomyCore.Instance != null)
            {
                EconomyCore.Instance.ProcessHit();
            }
        }
    }
}