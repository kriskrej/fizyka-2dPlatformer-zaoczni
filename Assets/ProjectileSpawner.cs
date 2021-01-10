using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour {
    [Range(0.1f, 1f)] public float spawnTimeInterval = 0.3f;
    [SerializeField] GameObject projectilePrefab;
    void Start() {
        InvokeRepeating("Spawn", spawnTimeInterval, spawnTimeInterval);
    }

    void Spawn() {
        Instantiate(projectilePrefab);
    }

}