
//Bir MonoBehaviour sınıfı oluşturun ve adını GameOverlay olarak belirleyin. 
//İki adet Texture2D tipinde özel (private) değişken tanımlayın: _healthIcon ve _coinIcon. 
// OnGUI() metodunu kullanarak _healthIcon ikonunu ekranın sol üst köşesinden 20 piksel sağa ve 20 piksel aşağıya yerleştirin. İkonun boyutu 48x48 piksel olmalıdır.
// "Health: 100" metnini _healthIcon ikonunun hemen sağında (10 piksel boşluk bırakarak) yerleştirin.
// _coinIcon ikonunu ekranın sağ üst köşesinden 20 piksel sola ve 20 piksel aşağıya yerleştirin. İkonun boyutu 40x40 piksel olmalıdır.
// "Coins: 50" metnini _coinIcon ikonunun hemen solunda (10 piksel boşluk bırakarak) yerleştirin.


using UnityEngine;
using System.Collections;

public class GameOverlay : MonoBehaviour
{
    [SerializeField] private Texture2D _healthIcon;
    [SerializeField] private Texture2D _coinIcon;

    void OnGUI()
    {
        GUI.DrawTexture(new Rect(20, 20, 48, 48), _healthIcon);
        GUI.Label(new Rect(20 + 48 + 10, 20, 100, 20), "Health: 100"); // 48 ikonun genişliği, 10 boşluk

        GUI.DrawTexture(new Rect(Screen.width - 40 - 20, 20, 40, 40), _coinIcon); // 40 ikonun genişliği, 20 ekranın sağından boşluk
        GUI.Label(new Rect(Screen.width - 40 - 20 - 10 - 100, 20, 100, 20), "Coins: 50"); // 40 ikonun genişliği, 20 ekranın sağından boşluk, 10 boşluk, 100 labelin genişliği
    }
}
