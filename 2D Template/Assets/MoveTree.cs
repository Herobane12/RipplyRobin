using UnityEngine;

public class MoveTree : MonoBehaviour
{
    [SerializeField] private float _speed = 0.8f;

    public void Start()
    {
        _speed += FindFirstObjectByType<TreeSpawner>().treeSpeed;
        _speed -= FindFirstObjectByType<TreeSpawner>().maxTimeDecrease;

    }
    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
