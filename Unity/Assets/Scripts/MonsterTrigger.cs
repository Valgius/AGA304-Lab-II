using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{

    public GameObject monster;
    public GameObject monsterSpawnPoint;
    public UIManager ui;

    protected Transform spawn;
    //

    private void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("working");
        SpawnMonster();
        ui.BeginCountDown();
       
    }

    public void SpawnMonster()
    {
        monster.transform.position = monsterSpawnPoint.transform.position;
    }
}
