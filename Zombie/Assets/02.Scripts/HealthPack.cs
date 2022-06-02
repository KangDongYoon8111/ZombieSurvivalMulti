using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPack : MonoBehaviour, IItem
{
    public int health = 50; // 체력을 회복할 수치

    public void Use(GameObject target)
    {
        LivingEntity life = target.GetComponent<LivingEntity>();

        if (life != null)
        {
            life.RestoreHealth(health);
        }

        Destroy(gameObject);
    }

}
