using UnityEngine;

public class ClawBehavior : MonoBehaviour
{
    public float speed;

    Rigidbody2D body;
    public Vector3 mousePosG;
    public Vector2 newPosition;
    Camera cam;

    public GameObject[] balls;

    void Start() {
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }
    void FixedUpdate() {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        newPosition =  Vector2.MoveTowards(body.position, mousePosG, speed * Time.fixedDeltaTime);

        body.MovePosition(newPosition);
    }

    void Update(){
        if(Input.GetMouseButtonDown(0)){
            SpawnBall();
        }
    }

    void SpawnBall() {
        Instantiate(balls[Random.Range(0,balls.Length)], this.gameObject.transform.position, Quaternion.identity);
    }
}
