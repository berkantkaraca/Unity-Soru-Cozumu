//Bir MonoBehaviour sınıfı oluşturun ve adını CubeMover olarak belirleyin. 
// Bu script, fare X eksenindeki hareketiyle bir küp nesnesinin konumunu değiştirecektir (fare sağa hareket ettiğinde küp sağa, sola hareket ettiğinde sola gidecek). 
// Farenin hareketine bağlı olarak konum değişim hızını belirleyen bir değişken oluşturun, varsayılan değeri 2f olsun. Fare hareketini zaman bağımsız hale getirin.

using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime, 0, 0);
    }
}