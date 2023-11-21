using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public List <Transform> Enemy_Spawner_List;
    public Transform SpawnLocation;
    public GameObject Zombie;
    public float respawn_time = 5;
    
    void Awake (){
        SpawnLocation = Enemy_Spawner_List[Random.Range(0,Enemy_Spawner_List.Count)];
    }

    // Update is called once per frame
    void Update()
    {
        respawn_time -= Time.deltaTime;
        if (respawn_time <= 0)
        {
            SpawnEnemies();
        }
    }

    public void SpawnEnemies()
    {
        int i = Random.Range(1,4);

        switch (i)
        {
            case 1 : 
                   GameObject zombie_respawn = Instantiate(Zombie,SpawnLocation.position, SpawnLocation.rotation);
                   Rigidbody2D zombie_sp = zombie_respawn.GetComponent<Rigidbody2D>();
                   break;
        }
        respawn_time = Random.Range(2, 5);
        SpawnLocation = Enemy_Spawner_List[Random.Range(0, Enemy_Spawner_List.Count)];                    
                    
    }
    
}
