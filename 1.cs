// Texture2D tipinde özel (private) bir değişken tanımlayın ve adını _icon yapın. 
// Bu değişkene, Unity Inspector üzerinden bir ikon texture atanabilsin. 
// OnGUI() metodunu kullanarak ekranın sol üst köşesine 50X50 piksel boşluk bırakarak bir ikon çizdirin. Çizilen ikonun boyutu 64x64 piksel olacak şekilde ayarlanmalıdır.
using UnityEngine;

public class PlayerGui : MonoBehaviour
{
    [SerializeField] private Texture2D _icon; // [SerializeField] ile Inspector'da görünür hale getiriyoruz
    void OnGUI()
    {
        GUI.DrawTexture(new Rect(50, 50, 64, 64), _icon);
    }
}
