using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _force;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _upForce;

    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigidbody.AddForce(Vector2.right * _force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigidbody.AddForce(Vector2.left * _force);
        }
        if (Mathf.Abs(_rigidbody.velocity.x) > _maxSpeed)
        {
            _rigidbody.velocity = new Vector2(Mathf.Sign(_rigidbody.velocity.x) * _maxSpeed, _rigidbody.velocity.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bounce"))
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _upForce);
            GetComponent<Animator>().SetTrigger("bounce");
            UnityEngine.Debug.Log(_rigidbody.velocity);
        }
    }
}
