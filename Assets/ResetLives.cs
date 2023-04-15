using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLives : MonoBehaviour
{
    [SerializeField] string triggeringTag;
    //[SerializeField] LivesCountField livesField;
    private LivesCountField livesField;

    void Awake()
    {
        livesField = GameObject.FindGameObjectWithTag("LivesCount").GetComponent<LivesCountField>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && livesField != null)
        {
            livesField.ResetLives();
            Destroy(gameObject);
        }
    }

    public void SetLLivesField(LivesCountField newLivesField)
    {
        this.livesField = newLivesField;
    }
}
