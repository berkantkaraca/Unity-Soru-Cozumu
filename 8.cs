//Bir player nesnesine verilece sağlık scripti için public bir TakeDamage metodu oluşturun. 
// Metot, bir int parametresi (damageAmount) alsın. _currentHealth değerini damageAmount kadar azaltın.
//Eğer _currentHealth sıfır veya sıfırdan küçükse, player nesnesini yok edin.
//Eğer _currentHealth 1 ile 30 arasındaysa, konsola "Ağır yaralı” 
//Eğer _currentHealth 31 ile 60 arasındaysa “Hafif yaralı”
//Eğer _currentHealth 61’den büyükse, konsola "Sağlık durumu iyi" Mesajlarını konsola yazdırın (Debug.Log kullanın).


using UnityEngine;
using System.Collections;
public class Health1 : MonoBehaviour
{
    [SerializeField] int _maximumHealth = 100;
    [SerializeField] int _currentHealth = 0;
    void Start()
    {
        _currentHealth = _maximumHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        _currentHealth -= damageAmount;

        if (_currentHealth <= 0)
        {
            Debug.Log("Player destroyed");
            Destroy(gameObject);
        }
        else if (_currentHealth >= 1 && _currentHealth <= 30)
        {
            Debug.Log("Ağır yaralı");
        }
        else if (_currentHealth >= 31 && _currentHealth <= 60)
        {
            Debug.Log("Hafif yaralı");
        }
        else if (_currentHealth > 60)
        {
            Debug.Log("Sağlık durumu iyi");
        }
    }
}