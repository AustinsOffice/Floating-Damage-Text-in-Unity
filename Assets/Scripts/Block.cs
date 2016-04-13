using UnityEngine;

public class Block : Enemy
{
    void OnMouseDown()
    {
        this.TakeDamage(Random.Range(0,100));
    }
}
