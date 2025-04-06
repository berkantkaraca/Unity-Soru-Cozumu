//Bir MonoBehaviour sınıfı oluşturun ve adını ScoreDisplay olarak belirleyin. 
// OnGUI() metodunu kullanarak aşağıdaki metinleri ekrana çizdirin: 
// "Score: 1500" metnini ekranın sol üst köşesinden 30 piksel sağa ve 20 piksel aşağıya yerleştirin. 
// "Level: 3" metnini ekranın sağ üst köşesinden 30 piksel sola ve 20 piksel aşağıya yerleştirin. 
// "Time: 45" metnini ekranın tam ortasına yerleştirin. Metnin genişliği 60 piksel, yüksekliği 20 piksel olacak şekilde ayarlayın.
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(30, 20, 100, 20), "Score: 1500");
        GUI.Label(new Rect(Screen.width - 130, 20, 100, 20), "Level: 3");
        GUI.Label(new Rect((Screen.width - 60) / 2, (Screen.height - 20) / 2, 60, 20), "Time: 45");
    }
}
