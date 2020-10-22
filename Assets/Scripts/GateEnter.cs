using UnityEngine;
using UnityEngine.SceneManagement;

public class GateEnter : MonoBehaviour
{
    public int SceneNumber;
    string Scene;
    void Start()
    {
        if (SceneNumber == 0)
        {
            Scene = "0_Start";
        }
        else if (SceneNumber == 1)
        {
            Scene = "1_FlyingSpheres";
        }
        else if (SceneNumber == 2)
        {
            Scene = "2_JumpingPlatforms";
        }
        else if (SceneNumber == 3)
        {
            Scene = "3_Finish";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(Scene);
        }
    }
}
