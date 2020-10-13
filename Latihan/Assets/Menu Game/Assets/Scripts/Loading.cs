using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    
    [SerializeField] private float delayLoading = 3f;
    [SerializeField] private string namaScene;

    private float timeElapsed;
    private void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayLoading)
        {
            SceneManager.LoadScene(namaScene);
        }
    }
}