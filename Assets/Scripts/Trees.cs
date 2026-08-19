using System;
using UnityEngine;

public class Trees : MonoBehaviour
{

    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        rd.material.color = Color.red;
        Player player = collision.gameObject.GetComponent<Player>();

         if (player == null )
        {
            return;

            player.Hp -= 80;

           /* UIMenager.Instance.ShowNotiText($"Hurt -15\nHP : {player.HP}");

            if (player.HP <= 0 )
            {
                player.HP = 0;
                UIMenager.Instance.ShowNotiText($"You Die!\nYour HP is {player.HP}");
                Time.timeScale = 0f;
                UIMenager.Instance.ShowHideRestartBotton(true);
            }*/
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color(0.6f, 0.4f, 0.2f); // Brown color
    }
}
