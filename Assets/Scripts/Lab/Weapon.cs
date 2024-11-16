using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShortcutManagement;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField]private int damage;
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }

    protected IShootable shooter;
    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owmner)
    {
        Damage = _damage;
        shooter = _owmner;
    }
    public int GetShootDirection()
    {
        float shootDir = shooter.BulletSpawnPoint.transform.position.x - shooter.BulletSpawnPoint.parent.transform.position.x;
        if (shootDir < 0)
            return -1;
        else
            return 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject, 5f);
    }
}
