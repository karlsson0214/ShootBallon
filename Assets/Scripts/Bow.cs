using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject arrowPrefab;
    private GameObject arrow;
    private Rigidbody2D rbArrow;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        rb.freezeRotation = true;
        arrow = Instantiate(arrowPrefab, new Vector3(0.14f + rb.position.x, rb.position.y, 0), Quaternion.identity);
        rbArrow = arrow.GetComponent<Rigidbody2D>();
        rbArrow.SetRotation(-90);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // up
            rb.SetRotation(rb.rotation + 30 * Time.deltaTime);
            rbArrow.SetRotation(rbArrow.rotation + 30 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // down
            rb.SetRotation(rb.rotation - 30 * Time.deltaTime);
            rbArrow.SetRotation((rbArrow.rotation - 30) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            // shoot
        }
        
    }
}
