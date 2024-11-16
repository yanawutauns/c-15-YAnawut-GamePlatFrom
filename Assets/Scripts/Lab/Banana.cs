using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Banana : Weapon
{
    [SerializeField]private float Speed;
    public override void Move()
    {
        float newX = transform.position.x + Speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
        Debug.Log("Banana moves with constant speed using Transform");
    }

    private void FixedUpdate()
    {
        Move();
    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
        }

    }

    private void Start()
    {
        Damage = 30;
        Speed = 4.0f * GetShootDirection();
        Move();
    }
   
}
