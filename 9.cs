//Bir MonoBehaviour sınıfı oluşturun ve adını DistanceCalculator olarak belirleyin. 
// Sahnede bulunan kapsül ile küp. Script kapsüle verilecek. 
// Küp nesnesi cube tag’ına sahiptir. 
// Bu script küp nesnesine ait tag’ı bulacak ve kapsül ile arasındaki mesafeyi hesaplayıp konsola yazdıracaktır. 
// Debug.Log kullanın. Mesaj formatı şu şekilde olmalı: "Distance between cubes: [mesafe]".

using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{
    void Update()
    {
        GameObject cube = GameObject.FindGameObjectWithTag("cube");
        if (cube != null)
        {
            float distance = Vector3.Distance(transform.position, cube.transform.position);
            Debug.Log($"Distance between cubes: {distance}");
        }
    }
}


/*
    private GameObject cube;

    void Start()
    {
        cube = GameObject.FindGameObjectWithTag("cube");
    }

    void Update()
    {
        if (cube != null)
        {
            float distance = Vector3.Distance(transform.position, cube.transform.position);
            Debug.Log($"Distance between cubes: {distance}");
        }
    }
*/