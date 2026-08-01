using UnityEngine;
using TMPro;

public class UIMenager : MonoBehaviour
{

    private TMP_Text notiText;

    public static UIMenager Instance;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }
}
