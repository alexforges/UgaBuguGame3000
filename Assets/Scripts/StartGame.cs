using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector3 currentMouseDown;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("level-1");
        }

        currentMouseDown = Input.mousePosition;
        Debug.Log("poss: " + currentMouseDown);
    }
}
