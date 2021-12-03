using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CharacterJump : MonoBehaviour
{
    public Rigidbody2D rigid;
    public float jumpHeight;
    private float newHeight = 0.1f;

    int count = 0;
    public Text countText;
    public Text resetText;

    // Start is called before the first frame update
    void Start()
    {
        countText.text = "Jump Combo = " + count.ToString();
        resetText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, new Vector3(0, -1.05f, 0), new Color(255, 69, 0));

        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector3(0, -0.1f, 0), 1.1f);

        if (hit && InputManager.Instance.IsJump)
        {
            resetText.gameObject.SetActive(false);
            jumpHeight = newHeight;
            rigid.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
            newHeight = newHeight + 0.1f;
            count++;
            countText.text = "Jump Combo = " + count.ToString();
        }
        else if (hit.collider == null && InputManager.Instance.IsJump)
        {
            newHeight = 0.1f;
            count = 0;
            resetText.gameObject.SetActive(true);
            countText.text = "Jump Combo = " + count.ToString();
        }
                        
    }
    
}
