using UnityEngine;

public class Finish : MonoBehaviour
{



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
}
