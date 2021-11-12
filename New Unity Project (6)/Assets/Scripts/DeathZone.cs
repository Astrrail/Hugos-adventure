using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathZone : MonoBehaviour
{
    public GameObject Player;
    public GameObject Respawn;
    public Vector3 SavePosition;

    private void Start()
    {
        SavePosition = Respawn.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("HEEEEELLLLLPPPP");
        SceneManager.LoadScene("Scene_A");

        Player.transform.position = SavePosition;

    }


}
