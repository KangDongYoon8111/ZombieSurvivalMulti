using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class HealthPack : MonoBehaviourPun, IItem
{
    public int health = 50; // 체력을 회복할 수치

    public void Use(GameObject target)
    {
        LivingEntity life = target.GetComponent<LivingEntity>();

        if (life != null)
        {
            life.RestoreHealth(health);
        }

        // 모든 클라이언트에서 자신 파괴
        PhotonNetwork.Destroy(gameObject);
    }

}
