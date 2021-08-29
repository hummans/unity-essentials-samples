using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerDefense : MonoBehaviour, IObjectGame, IDamage
{

    public int objectNumberReference{get;set;}
    private int actualVida;

    [SerializeField] private ObjectType r_type;
    public ObjectType typeObject {get; set; }

    [SerializeField] private DamageSystem r_damage;
    public DamageSystem damageSystem{get; set;}
    
    [SerializeField] private ShootOptions r_options;
    public ShootOptions shootOptions{get; set;}

    void Awake()
    {
        typeObject = r_type;
        damageSystem = r_damage;
        shootOptions = r_options;

        actualVida = damageSystem.maxVida;
        objectNumberReference = Random.Range(0, 50000);
    }

    void Start() 
    {
        CircleCollider2D rangeCollider = GetComponent<CircleCollider2D>();
        rangeCollider.radius = shootOptions.rangeAttack;
    }

    public void Damage(int damage)
    {
        if(actualVida <= 0)
            return;
        //Debug.Log("Damage system");
        
        actualVida -= damage;
        GameEvents.current.OnVidaChange(typeObject, actualVida, damage, objectNumberReference);

        if(actualVida <= 0)
            Dead();
    }

    private void Dead()
    {
        Debug.Log(typeObject + " is Dead.");
        Destroy(gameObject, 1f);
    }
}
