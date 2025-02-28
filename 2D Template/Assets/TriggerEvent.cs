using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public float speedIncrease;

    public void SpeedIncrease()
    {
        FindFirstObjectByType<TreeSpawner>().treeSpeed += speedIncrease;
        FindFirstObjectByType<TreeSpawner>().maxTimeDecrease -= speedIncrease;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bird") == true)
        {
            onTriggerEnter.Invoke();
        }
    }
}
