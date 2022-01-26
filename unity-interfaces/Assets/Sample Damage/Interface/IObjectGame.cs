using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObjectGame 
{
    public ObjectType typeObject {get; set;}
    public DamageSystem damageSystem { get; set;}
    public ShootOptions shootOptions{get; set;}   
    public int objectNumberReference {get; set;}
}
