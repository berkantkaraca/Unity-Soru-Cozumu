//Bir MonoBehaviour sınıfı oluşturun ve adını CubeScaler olarak belirleyin. 
// Bu script, fare y eksenindeki hareketiyle bir küp nesnesinin boyutunu değiştirecektir (fare yukarı hareket ettiğinde küp büyümeli, aşağı hareket ettiğinde küçülmeli). 

// Farenin hareketine bağlı olarak boyut değişim hızını belirleyen bir değişken oluşturun, varsayılan değeri 2f olsun. 
// Fare hareketini zaman bağımsız hale getirin. 
// Not: (X, Y, Z eksenlerinde aynı ölçek uygulanmalı).

using UnityEngine;

public class CubeScaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 2f;

    void Update()
    {
        float mouseY = Input.GetAxis("Mouse Y") * scaleSpeed * Time.deltaTime;
        
        Vector3 newScale = transform.localScale + Vector3.one * mouseY;
        newScale = Vector3.Max(newScale, Vector3.zero);
        
        transform.localScale = newScale;
    }
}
