using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GroundSpawner : MonoBehaviour
{
    [SerializeField] private PlayerController _playerController = null;
    [SerializeField] private GameObject _bouncePrefab = null;
    [SerializeField] private int _diffHeight = 10;
    [SerializeField] private Vector2 _spawnRange = new Vector2(-5, 5);
    [SerializeField] private int _lastGroundSpawned = 30;
    [SerializeField] private int _minDiffHeight = 20;

    void Update()
    {
        if (_playerController.transform.position.y > _lastGroundSpawned)
        {
            int newY = _lastGroundSpawned + _diffHeight;
            Instantiate(_bouncePrefab, new Vector2(Random.Range(_spawnRange.x, _spawnRange.y), newY), Quaternion.identity, transform);
            _lastGroundSpawned = newY;
        }

        if (_playerController.transform.position.y < _lastGroundSpawned - _minDiffHeight)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
