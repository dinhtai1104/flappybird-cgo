using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float radius;
    public LayerMask layerEnemy;

    private void Update()
    {
        CheckEnemies();
        CheckChampionEnemyAttackTeam();
    }


    protected void CheckChampionEnemyAttackTeam()
    {
        bool isAttackChampion = CheckAttackChampion();
        if (isAttackChampion)
        {
            CheckChampion();
        }
        else
        {
            CheckEnemiesNormal();
        }
    }

    protected bool CheckAttackChampion()
    {
        return false;
    }
    protected void CheckEnemiesNormal()
    {

    }
    protected void CheckChampion()
    {

    }


    protected void CheckEnemies()
    {
        Collider2D[] enemies = Physics2D.OverlapCircleAll(transform.position, radius, layerEnemy);
        if (enemies != null)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                Debug.Log(enemies[i].transform.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
