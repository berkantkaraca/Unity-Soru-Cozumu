// Bir MonoBehaviour sınıfı oluşturun ve adını CubeRotator olarak belirleyin. 
// Bu script, bir küp nesnesinin "Player" tag'ine sahip bir oyuncunun konum bilgilerini alarak ona doğru dönmesini sağlayacaktır.

using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] float _dh=5.0f;
    Transform _player;

    void Start()
    {
        GameObject playerGameObject = GameObject.FindGameObjectWithTag("Player");
        _player = playerGameObject.transform;
    }

    void Update()
    {
        Vector3 direction = _player.position - transform.position; 
        direction.Normalize();

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * _dh);
    }
}
