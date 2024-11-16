using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    Rigidbody2D rb2d;
    [SerializeField]Vector2 force;

    public override void Move()
    {
        rb2d.AddForce(force);
       
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
        }
        
    }

    public void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        force = new Vector2(GetShootDirection() * 100,400);
        Damage = 20;
        Move();
    }
    void Update()
    {

    }

}
