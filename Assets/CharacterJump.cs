using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;
    private float newHeight = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, new Vector3(0, -1.05f, 0), new Color(0, 1, 0));

        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector3(0, -0.1f, 0), 1.07f);

        if (hit && Input.GetKeyDown(KeyCode.UpArrow))
        {
            jumpHeight = newHeight;
            rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            newHeight = newHeight + 1;
            Debug.Log("Jump!");            
        }
        else if (hit.collider == null && Input.GetKeyDown(KeyCode.UpArrow))
        {
            newHeight = 1;
        }
        else if (hit && Input.GetKeyDown(KeyCode.None))
        {
            newHeight = 1;
        }
        
    }
}
