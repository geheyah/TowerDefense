using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform spawn;

    public float interval = 300;
    private float counter = 0;
    public Health health;

    // Update is called once per frame
    void FixedUpdate()
    {
        counter += 1;

        if(counter >= interval){
            counter = 0;
            GameObject enemyObject = Instantiate(enemy, spawn.position,transform.rotation);
            health.enemy = enemyObject;
        }
    }
}
