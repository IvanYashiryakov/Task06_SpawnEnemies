using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _dogNavyTemplate;

    private SpawnPoint[] _points;
    private Coroutine _corutine;

    private void Awake()
    {
        _points = gameObject.GetComponentsInChildren<SpawnPoint>();
        _corutine = StartCoroutine(StartSpawn());
    }

    private IEnumerator StartSpawn()
    {
        var secondsToWait = new WaitForSeconds(2);

        while (true)
        {
            int i = Random.Range(0, _points.Length);
            Instantiate(_dogNavyTemplate, _points[i].transform);

            yield return secondsToWait;
        }
    }
}
