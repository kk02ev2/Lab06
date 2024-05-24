using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet; // �Ѿ� ������
    public Transform muzzle; // �Ѿ��� �߻�Ǵ� ��ġ
    public float impForce = 20f; // �Ѿ� �ӵ�
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
            // �Ѿ� ������ �ν��Ͻ�ȭ
            GameObject bullet = Instantiate(this.bullet, muzzle.position, muzzle.rotation);

            // �Ѿ˿� ���� ����
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
