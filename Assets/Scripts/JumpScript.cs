using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScript : MonoBehaviour
{
    public float speed;

    public float jumpForce;
    public float ChargeAmount = 0;

    public Rigidbody2D rb;

    public Image ChargeBar;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //bar begins at 0
        ChargeBar.fillAmount = 0;
    }

    void Update()
    {
        //horizontal movement
        float x = (Input.GetAxis("Horizontal") * speed);
        transform.position += new Vector3(x * Time.deltaTime, 0f, 0f);

        //hold space to charge
        if (Input.GetKey(KeyCode.Space))
        {
            ChargeAmount += Time.deltaTime;

            //bar fills with a proper ratio to maximum number
            ChargeBar.fillAmount = ChargeAmount / 2;

        }

        //Let go of space to jump
        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce * ChargeAmount));

            ChargeAmount = 0;

            //Bar returns to 0
            ChargeBar.fillAmount = 0;
        }

        //maximum charge value
        if (ChargeAmount >= 2)
        {
            ChargeAmount = 2;
        }
    }

}
