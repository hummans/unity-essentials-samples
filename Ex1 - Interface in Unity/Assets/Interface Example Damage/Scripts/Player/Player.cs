using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, IObjectGame, IDamage
{
    public int objectNumberReference{get;set;}
    private int actualVida;

    [Header("Object game")]
    [SerializeField] public ObjectType r_type;
    public ObjectType typeObject { get; set; }

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

    public void Damage(int damage)
    {
        if(actualVida <= 0)
            return;
        Debug.Log("Damage system player");
        
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
