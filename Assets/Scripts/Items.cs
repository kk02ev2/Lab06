using UnityEngine;

public class Items : MonoBehaviour
{

    private int score = 0;
    public AudioSource Correct;


    private void OnCollisionEnter(Collision collision)
    {

        // 충돌한 오브젝트가 타겟인지 확인
        if (collision.gameObject.CompareTag(this.tag))
        {
            // 아이템과 타겟의 태그가 일치하면
            Destroy(this.gameObject); // 아이템을 파괴
            IncreaseScore(); // 점수 증가
            Correct.Play();
            
        }

    }

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score);
    }
}
