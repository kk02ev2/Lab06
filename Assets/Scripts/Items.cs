using UnityEngine;

public class Items : MonoBehaviour
{
    public AudioSource Correct;


    private void OnCollisionEnter(Collision collision)
    {

        
        if (collision.gameObject.CompareTag(this.tag))
        {
            
            Correct.Play(); 
            Destroy(this.gameObject,0.3f); 
            IncreaseScore(); 

        }

    }

    public void IncreaseScore()
    {
        Score.Instance.Addscore();
    }
}
