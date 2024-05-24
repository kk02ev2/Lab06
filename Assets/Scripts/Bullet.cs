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
        // �浹�� ������Ʈ�� �������� Ȯ��
        if (collision.gameObject.CompareTag("Monster"))
        {

            // ���� ������Ʈ �ı�
            Destroy(collision.gameObject);
            death.Play();


            scoreManager.DecreaseCount();
            

        }
    
    }
}
