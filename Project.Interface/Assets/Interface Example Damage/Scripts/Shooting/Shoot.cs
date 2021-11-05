using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform[] firePoints;
    private ShootOptions shootOptions;

    private float _timeToShoot;
    void Start() 
    {
        shootOptions = gameObject.GetComponent<IObjectGame>().shootOptions;
        _timeToShoot = 0;
    }
    void Update()
    {
        _timeToShoot -= Time.deltaTime; 
        
        if(Input.GetButtonUp("Fire1"))
        {
            Shooting();
        }
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
