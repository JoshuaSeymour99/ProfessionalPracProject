﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateEnemiesLevel4 : MonoBehaviour
{
    //this script starts the first round of the level and spawns the enemy objects randomly on the sides of the ship and on the bow.
    // public Round2 round2;
    // public Round3 round3;
    // public Round4 round4;
    //Links the scripts for round 2,3,4


    //all the round scripts run the same functions as this script.
    //IEnumerator only runs the enemyspawn functions once per Start so i had to run the spawn functions in the 3 other round Scripts
    public GameObject enemy;
    public int xPos;
    public int zPos;
    private int enemyCount;
    public int enemySpawn;

    // Start is called before the first frame update
    void Start()
    {
        startWave();
    }

    public void startWave() 
    {   
        //Debug.Log("BLEEP");
        StartCoroutine(EnemySpawnShip());
    }

    IEnumerator EnemySpawnShip() 
    {
        while(enemyCount < enemySpawn) 
        {
            xPos = Random.Range(27,-1); //sets a random x position range for when we need to instantiate the enemy
            zPos = Random.Range(-47,-66); //sets a random y position range for when we need to instantiate the enemy
            Instantiate(enemy, new Vector3(xPos,3,zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f); //spawn delay
            enemyCount += 1;
        }

    }


}
