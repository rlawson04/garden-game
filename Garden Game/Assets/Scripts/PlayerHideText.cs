using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHideText : MonoBehaviour
{
    [SerializeField]
    private PlayerController player;

    [SerializeField]
    private float visibleRadius;

    [SerializeField]
    private MeshRenderer mr;

    private GameObject telescope;

    // Start is called before the first frame update
    void Start()
    {
        telescope = transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, telescope.transform.position) < visibleRadius) // TODO: Rewrite this to not use Vector3.Distance
        {
            mr.gameObject.SetActive(true);
        }
        else
        {
            mr.gameObject.SetActive(false);
        }

        
    }
    public void OnDrawGizmos()
    {
        if (!Application.isPlaying) return;

        Gizmos.DrawWireSphere(telescope.transform.position, visibleRadius);
    }
}
