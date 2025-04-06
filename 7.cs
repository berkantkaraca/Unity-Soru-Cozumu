//Bir MonoBehaviour sınıfı oluşturun ve adını EnemyHider olarak belirleyin. 
// Bu script, bir düşman nesnesinin "Player" tag'ine sahip bir oyuncuya olan mesafesine bağlı olarak aktif veya pasif olmasını sağlayacaktır. 
// Bu değişken, oyuncunun pozisyonunu takip edecek player_pos adında bir değişken tanımlayın. 
// Eğer düşman konumu Player konumundan 10f birimden uzaksa (gameObject.SetActive() metodu kullanarak düşman pasif hale gelsin.

using UnityEngine;

public class EnemyHider : MonoBehaviour
{
    [SerializeField] float _distanceThreshold = 10.0f;
    Transform _player;

    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        if (playerGameObject != null)
        {
            _player = playerGameObject.transform;
        }
    }

    void Update()
    {
        if (_player != null)
        {
            float distance = Vector3.Distance(transform.position, _player.position);
            gameObject.SetActive(distance <= _distanceThreshold);
        }
    }
}