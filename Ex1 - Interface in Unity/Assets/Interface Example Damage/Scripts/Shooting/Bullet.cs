using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private int damage = 0;

    void Awake() 
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    public void SetAngle(float angle)
    {
        _rigidbody.rotation = angle;
    }
    public void Impulse(Transform point, float force)
    {
        _rigidbody.AddForce(point.up * force, ForceMode2D.Impulse);
    }
    public void SetDamageToBullet(int value)
    {
        damage = value;
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        IObjectGame objectGame = collision.gameObject.GetComponent<IObjectGame>();
        IDamage damageable = collision.gameObject.GetComponent<IDamage>();

        if(damageable != null)
        {
            // Do something
            damageable.Damage(damage);
            Destroy(gameObject, 0.1f);
        } 
    }
}
