using UnityEngine;


class Balls : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPos;
    private void Start()
    {
        Launch();
    }

    private void Update()
    {
        
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : -1;
        float y = Random.Range(0, 2) == 0 ? -1 : -1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPos;
        Launch();
    }
}
