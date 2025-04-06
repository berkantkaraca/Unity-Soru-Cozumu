// Bir MonoBehaviour sınıfı oluşturun ve adını EnemyScanner olarak belirleyin. 
// Bu script, ekranın tam ortasında bulunan bir silindirin raycast kullanarak etrafı taramasını ve "Enemy" tag'ine sahip bir nesneyi bulduğunda durmasını sağlayacaktır. 
// Eğer raycast bir nesneye çarparsa, çarpılan nesnenin tag'ini kontrol edin. 
// Eğer tag "Enemy" ise: tarama dursun enemy pozisyonunu konsola yazdırın. 
// Eğer tag "Enemy" değilse, tarama devam etsin.

using UnityEngine;

public class EnemyScanner : MonoBehaviour
{
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Check the tag of the hit object
            if (hit.collider.CompareTag("Enemy"))
            {
                // Stop scanning and log the enemy's position
                Debug.Log("Enemy found at position: " + hit.collider.transform.position);
                enabled = false; // Disable this script to stop scanning
            }
        }
    }
}