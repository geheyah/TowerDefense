using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int health = 3;
    public Image heart1;
    public Image heart2;
    public Image heart3;
    public GameObject enemy;

    // Update is called once per frame
    void Update()
    {
        if (health == 2)
        {
            Destroy(heart3);
        }
        if (health == 1)
        {
            Destroy(heart2);
        }

        if (health == 0)
        {
            SceneManager.LoadScene("Fail");
        }
        
    }
}
