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

            player.HP -= 15;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color(166, 114, 114);
    }
}
