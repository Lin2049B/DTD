
using UnityEngine;

public class follow : MonoBehaviour
{
    // Start is called before the first frame update
        public Transform player;

        public Vector3 ofset;

    // Update is called once per frame
    void Update()
    {
          transform.position = player.position + ofset;
    }
}
