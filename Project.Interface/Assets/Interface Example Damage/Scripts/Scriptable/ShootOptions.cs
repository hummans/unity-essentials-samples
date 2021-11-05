using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Shoot Options", menuName = "Scriptable/New Shoot Options")]
public class ShootOptions : ScriptableObject
{
    public GameObject bulletPrefab;
    public float bulletForce;
    public int damage;
    public int rate;
    public ObjectType[] attackTarget;
    public float rangeAttack;
}
