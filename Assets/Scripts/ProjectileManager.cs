using System.Collections.Generic;

using UnityEngine;

public class ProjectileManager
{
    GameObject prefab;
    List<GameObject> projectiles = new List<GameObject>();

    public ProjectileManager(GameObject prefab)
    {
        this.prefab = prefab;
    }

    public GameObject GetInactiveProjectile()
    {
        foreach (GameObject p in projectiles)
        {
            if (!p.activeSelf)
            {
                return p;
            }
        }

        GameObject newProjectile = Object.Instantiate(prefab);
        projectiles.Add(newProjectile);
        newProjectile.SetActive(true);

        return newProjectile;
    }
}
