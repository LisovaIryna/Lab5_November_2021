using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlls : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //движение вправо и влево
        float moveX = Input.GetAxis("Horizontal");
        rb.MovePosition(rb.position + Vector2.right * moveX * speed * Time.deltaTime * 7);

        //прыжок
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector2.up * 5500);
        }
    }
}