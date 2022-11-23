using UnityEngine;

public class DogNavyMovement : MonoBehaviour
{
    private float _speed = 5;
    private float _killZoneY = -6;

    void Start()
    {
        _speed *= -Mathf.Sign(transform.position.x);
        transform.localScale = new Vector3(transform.localScale.x * Mathf.Sign(-_speed), transform.localScale.y);
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3(_speed * Time.deltaTime, 0, 0);

        if (transform.position.y < _killZoneY)
        {
            Destroy(gameObject);
        }
    }
}
