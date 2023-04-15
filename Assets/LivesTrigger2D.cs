using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class LivesTrigger2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    private LivesCountField livesCountField;

    void Awake()
    {
        livesCountField = GameObject.FindGameObjectWithTag("LivesCount").GetComponent<LivesCountField>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            if (other.tag == "Enemy")
            {
                livesCountField.DropLive();
                if (livesCountField.GetLives() == 0)
                {
                    Destroy(this.gameObject);
                    Debug.Log("Game over!");
                    //Application.Quit();
                    SceneManager.LoadScene("EndScene");
                }
            }
            else
            {
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
