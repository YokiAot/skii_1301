using UnityEngine;
using UnityEngine.InputSystem;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
        {
            return;

            player.Point += 10;
            UIMenager.Instance.ShowNotiText($"+10 points\nPoints : {player.Point}");
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
