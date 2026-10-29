using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] GameManager gm;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("colide");
        if(collider.gameObject.tag == "car")
        {
            gm.NewLevel();
        }
    }
}
