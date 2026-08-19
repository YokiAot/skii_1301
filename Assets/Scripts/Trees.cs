using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();
    }
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.HP -= 15;

        UIMenager.Instance.ShowNotiText($"Hurt -15\nHp: {player.HP}");

        if (player.HP <= 0)
        {
            player.HP = 0;

            UIMenager.Instance.ShowNotiText($"You are dead!\nYour hp is: {player.HP}");
            Time.timeScale = 0f;
            UIMenager.Instance.ShowHideRestartBotton(true);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(118, 62, 46, 255);
    }
}