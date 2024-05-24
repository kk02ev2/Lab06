using UnityEngine;

public class Items : MonoBehaviour
{

    private int score = 0;
    public AudioSource Correct;


    private void OnCollisionEnter(Collision collision)
    {

        // �浹�� ������Ʈ�� Ÿ������ Ȯ��
        if (collision.gameObject.CompareTag(this.tag))
        {
            // �����۰� Ÿ���� �±װ� ��ġ�ϸ�
            Destroy(this.gameObject); // �������� �ı�
            IncreaseScore(); // ���� ����
            Correct.Play();
            
        }

    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
