using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject bullet; // �Ѿ� ������
    public Transform muzzle; // �Ѿ��� �߻�Ǵ� ��ġ
    public float impForce = 20f; // �Ѿ� �ӵ�
    private AudioSource shooting;
    private bool bomb = false;
    public ScoreManager scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        shooting = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (bomb)
        {

            GameObject bullet = Instantiate(this.bullet, muzzle.position, muzzle.rotation);


            bullet.GetComponent<Rigidbody>().AddForce(impForce * muzzle.forward, ForceMode.Impulse);
            shooting.Play();
            Destroy(bullet, 2);
            GameObject[] monsters = GameObject.FindGameObjectsWithTag("Monster");
            
            foreach (GameObject monster in monsters)
            {
                Destroy(monster);
            }
            Debug.Log("You killed all the monsters!!");


            bomb = false;
        }

    }

    public void Fire()
    {
        bomb = true;
    }
}
