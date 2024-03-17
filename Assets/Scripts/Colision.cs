using UnityEngine;
using UnityEngine.SceneManagement;

public class Colision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    public string levelName;

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.gameObject.CompareTag("finish"))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (collision.gameObject.CompareTag("finish"))
        {
            SceneManager.LoadScene("Level2");
        }
    }

    void finish()
    {
        SceneManager.LoadScene(levelName);
        Debug.Log("next level: " + levelName);
    }

    void restart()
    {
        SceneManager.LoadScene("Menu");
        Debug.Log("restart level: " + levelName);
    }
}
