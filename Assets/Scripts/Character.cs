using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attributes, property
    int health;
    public int Health { get => health; set => health = (value < 0) ? 0 : value; }

    protected Animator anim;
    protected Rigidbody2D rb;

    //Initialized
    public void Initialize(int startHealth)
    {
        Health = startHealth;
        Debug.Log($"{this.name} initial Health: {this.Health}");

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    //methods
    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage}. Current Health: {Health}");
        IsDead();
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log($"{this.name} is dead and destroyed!");
            return true;
        }
        else return false;
    }
    
}
