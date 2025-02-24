using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _Tree;

    private float _timer;

    private void Start()
    {
        SpawnTree();
    }

    private void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnTree();
            _timer = 0;
        }

        _timer += Time.deltaTime;
    }

    private void SpawnTree()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject Tree = Instantiate(_Tree, spawnPos, Quaternion.identity);

        Destroy(Tree, 10f);
    }
}
