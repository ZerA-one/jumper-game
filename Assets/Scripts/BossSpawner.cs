using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject player;
    public GameObject boss;

    void Update()
    {
        if (boss.transform.position.x + 5 < player.transform.position.x)
            boss.SetActive(true);
    }
}
