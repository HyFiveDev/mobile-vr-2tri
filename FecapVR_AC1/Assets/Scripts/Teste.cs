using UnityEngine;

public class Teste : MonoBehaviour
{
    public void OnPointerDown()
    {
        transform.localScale = transform.localScale*1.5f;
    }

    public void OnPointerUp()
    {
        transform.localScale = transform.localScale * 0.5f;
    }
}
