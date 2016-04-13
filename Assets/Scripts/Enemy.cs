using UnityEngine;

public class Enemy : MonoBehaviour {
    public int health;

    void Start()
    {
        FloatingTextController.Initialize();
    }

    public virtual void TakeDamage(int amount)
    {
        FloatingTextController.CreateFloatingText(amount.ToString(), transform);
        Debug.LogFormat("{0} was dealt {1} damage", gameObject.name, amount);
        if ((health -= amount) <= 0)
            Die();
    }


    public virtual void Die()
    {
        Debug.Log(gameObject.name + " has died.");
    }

}
