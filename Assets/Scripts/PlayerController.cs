using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 2.5f;
    public GameObject background;
    float rangeLimit = 4.2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        background = GameObject.Find("Background");
        transform.position = new Vector3(-8, background.transform.position.y / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && !(transform.position.y >= rangeLimit))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S) && !(transform.position.y <= -rangeLimit))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
