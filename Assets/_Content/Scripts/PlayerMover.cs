using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    const float MS_TO_KMH = 1 / 3.6f;
    private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += Vector3.forward * Time.deltaTime * MS_TO_KMH * speed;
    }
}
