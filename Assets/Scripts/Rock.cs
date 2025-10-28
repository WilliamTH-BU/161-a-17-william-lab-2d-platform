using UnityEngine;

public class Rock : Weapon
{
    private Rigidbody2D rb2d { get; set; }
    private Vector2 force {  get; set; }
    public override void Move()
    {
        rb2d.AddForce(force);
    }

    public override void OnHitWith(Character obj)
    {
        if (obj is Player)
        {
            obj.TakeDamage(this.damage);    
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        damage = 40;
        force = new Vector2(GetShootDirection() * 90, 400);
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
