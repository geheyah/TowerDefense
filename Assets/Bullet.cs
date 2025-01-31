using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    public float velocity = 10f;
    public GameObject enemy;

    public float distance = 1f;
    public Gold goldgold;

    private void Start()
    {
        goldgold = GameObject.FindWithTag("Gold").GetComponent<Gold>();
    }
   
    private void Update()
    {
        transform.position += transform.TransformDirection(Vector3.up) * (velocity * Time.deltaTime);

        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            var enemyTransform = enemy.transform;

            if ((transform.position - enemyTransform.position).magnitude <= distance)
            {
                goldgold.gold += 5;
                Destroy(enemy);
            }
        }
    }
}

