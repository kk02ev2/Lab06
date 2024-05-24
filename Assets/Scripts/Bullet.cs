using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet : MonoBehaviour
{
    private AudioSource death;
    public ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        death = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // 충돌한 오브젝트가 괴물인지 확인
        if (collision.gameObject.CompareTag("Monster"))
        {

            // 괴물 오브젝트 파괴
            Destroy(collision.gameObject);
            death.Play();


            scoreManager.DecreaseCount();
            

        }
    
    }
}
