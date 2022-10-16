using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;
    [SerializeField] private Transform levelPart_Start;
    [SerializeField] private List<Transform> platformsList;
    [SerializeField] private Transform player;

    private Vector3 lastEndPosition;

    private void Awake()
    {
        lastEndPosition = levelPart_Start.Find("EndPosition").position;

        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }

    private void Update()
    {
        if (Vector3.Distance(player.position, lastEndPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }

    }

    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = platformsList[Random.Range(0, platformsList.Count)];
        Vector3 offset = chosenLevelPart.position - chosenLevelPart.Find("StartPosition").position;
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition + offset);

        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
