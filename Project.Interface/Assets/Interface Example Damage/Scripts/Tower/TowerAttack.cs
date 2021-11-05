using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAttack : MonoBehaviour
{
    public Transform[] firePoints;
    private ShootOptions shootOptions;
    [SerializeField] private Rigidbody2D _rigidbody;

    private float _timeToShoot = 0;

    void Start()
    {        
        shootOptions = gameObject.GetComponent<IObjectGame>().shootOptions;
        _timeToShoot = 0;
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        IObjectGame objectGame = other.GetComponent<IObjectGame>();

        if(objectGame == null)
            return;    
  
        if(IsTargetToAttack(objectGame.typeObject))
        {
            Vector2 vectorPos = other.transform.position - new Vector3(_rigidbody.position.x, _rigidbody.position.y);
            float angle = Mathf.Atan2(vectorPos.y, vectorPos.x) * Mathf.Rad2Deg -90f;
            _rigidbody.rotation = angle;

            Invoke("Shooting", 0.09f); // This invoke correct trigger error
        }
    }

    bool IsTargetToAttack(ObjectType type)
    {
        bool result = false;
        foreach(var target in shootOptions.attackTarget)
        {   
            if(target == type)
            {
                result = true;
                return result;
            }
        }
        return result;
    }
    
    void Update()
    {
        _timeToShoot -= Time.deltaTime;        
    }

    void Shooting()
    {
        if(_timeToShoot > 0)
            return;
        
        _timeToShoot = shootOptions.rate;

        Transform fpoint = firePoints[Random.Range(0, firePoints.Length)];
        GameObject bullet = Instantiate(shootOptions.bulletPrefab, fpoint.position, fpoint.rotation);
        
        Bullet b = bullet.GetComponent<Bullet>();
        b.SetDamageToBullet(shootOptions.damage);
        b.Impulse(fpoint, shootOptions.bulletForce);
    }
}
