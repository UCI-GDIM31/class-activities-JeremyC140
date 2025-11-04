using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playerTransform;

    private void Start() { 
        _playerTransform = transform;
        _speed = 3.0f;
    }
    private void Update() {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            _playerTransform.position, 
            _speed * Time.deltaTime);
    }
    public void EnableChase(Transform player) { 
        enabled = true;
        _playerTransform = player;
    }

    public void DisableChase() { 
        enabled = false;
    }


}
