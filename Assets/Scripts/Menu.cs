using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public float speed;

    public Animator transitionAnim;

    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }

    public void OnEnter()
    {
        transitionAnim.Play("End");
        Invoke("LoadScene", .6f);
    }

    void LoadScene()
    {
        SceneManager.LoadSceneAsync(1);
    }

}