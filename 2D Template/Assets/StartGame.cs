using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    private void Update()
    {
        GameObject.FindGameObjectWithTag("Bird").GetComponent<FlapWings>().enabled = true;
        GameObject.FindGameObjectWithTag("Tree").GetComponent<TreeSpawner>().enabled = true;
        GameObject.FindGameObjectWithTag("Bird").GetComponent<Rigidbody2D>().gravityScale = 0;
        //GameObject.FindGameObjectWithTag("Bird").GetComponent<Rigidbody2D>().gravi;
    }
}
