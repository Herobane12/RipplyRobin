using UnityEngine;

public class HitCode : MonoBehaviour
{
    public GameObject Button;
    public GameObject GameOverTitle;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(GameObject.FindGameObjectWithTag("Bird"));
    }

    private void OnDestroy()
    {
        Button.SetActive(true);
        GameOverTitle.SetActive(true);
    }
}

