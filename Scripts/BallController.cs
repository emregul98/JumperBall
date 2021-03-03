using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Admin admin;
    public Animator animaton;
    public GameObject particul_effect;
    public GameObject paint;
    Vector3 paint_coordinat;

    public Rigidbody rgb;
    float jump_rate = 7.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag != "red_cube")
        {
            animaton.SetBool("hit", true);
            Invoke("animationReset", 0.5f);
            rgb.velocity = Vector3.up * jump_rate;

            paint_coordinat = collision.contacts[0].point;
            GameObject new_paint = Instantiate(paint, paint_coordinat, Quaternion.identity);
            new_paint.transform.parent = collision.gameObject.transform;

            GameObject new_particul_effect = Instantiate(particul_effect, paint_coordinat, Quaternion.identity);
            Destroy(new_particul_effect,1.0f);
        }
        if (collision.gameObject.tag == "red_cube")
        {
            admin.startagain();
        }
        if (collision.gameObject.tag == "win_point")
        {
            admin.nextstage();
        }
    }
    void animationReset()
    {
        animaton.SetBool("hit", false);
    }
}
