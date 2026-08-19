using UnityEngine;

public class Finish : MonoBehaviour
{

    [SerializeField]
    private GameObject gameOverScreen;

    public static Finish Instance;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.gameObject.GetComponent<Player>();

        if (p == null)
            return;

        UIMenager.Instance.ShowNotiText($"You Win!\nPoint : {p.Point}");
    }

    public void ShowHideGameOverScreen(bool flag)
    {
        gameOverScreen.SetActive(flag);
        return;
    }
}
