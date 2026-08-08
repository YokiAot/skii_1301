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
        player.transform.position = new Vector3(0f, 89f, -87.41f);
        player.HP = 100;
        ShowNotiText("Restart");
        Time.timeScale = 1f;
        ShowHideRestartBotton(false);
    }

    public void ShowHideRestartBotton(bool flag)
    {
        restartBotton.SetActive(flag);
    }
}
