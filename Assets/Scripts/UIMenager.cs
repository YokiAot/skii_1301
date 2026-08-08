using UnityEngine;
using TMPro;

public class UIMenager : MonoBehaviour
{
    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartBotton;

    [SerializeField]
    private Player player;

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

    public void RestartGame()
    {
        
    }
}
