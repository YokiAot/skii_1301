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

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0f, 89f, -87.41f);
        player.HP = 100;
        ShowNotiText("Don't worry, I can't do it too..");
        Time.timeScale = 1f;
        ShowHideRestartBotton(false);
    }

    public void ShowHideRestartBotton(bool flag)
    {
        restartBotton.SetActive(flag);
    }

    public void Exit()
    {
        ShowHideRestartBotton(false);
        Application.Quit();
    }
}
