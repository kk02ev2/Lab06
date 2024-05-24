using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet; // ÃÑ¾Ë ÇÁ¸®ÆÕ
    public Transform muzzle; // ÃÑ¾ËÀÌ ¹ß»çµÇ´Â À§Ä¡
    public float impForce = 20f; // ÃÑ¾Ë ¼Óµµ
    private AudioSource shooting;
    private bool shoot = false;

    void Start()
    {
        shooting = GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        if (shoot)
        {
            // ÃÑ¾Ë ÇÁ¸®ÆÕ ÀÎ½ºÅÏ½ºÈ­
            GameObject bullet = Instantiate(this.bullet, muzzle.position, muzzle.rotation);

            // ÃÑ¾Ë¿¡ ÈûÀ» °¡ÇÔ
            bullet.GetComponent<Rigidbody>().AddForce(impForce * muzzle.forward, ForceMode.Impulse);
            shooting.Play();
            Destroy(bullet, 2);

            shoot = false;
        }

    }

    public void Fire()
    {
        shoot = true;
    }
}
