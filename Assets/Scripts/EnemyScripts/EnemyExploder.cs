using UnityEditor.Search;
using UnityEngine;

public class EnemyExploder : MonoBehaviour
{

    [SerializeField] private GameObject Radius;

    [SerializeField] private Shrapnel Projecile;

    public bool explode;

    private Vector3[] directions = new Vector3[]
    {
        Vector3.up,
        (Vector3.up + Vector3.right).normalized,
        Vector3.right,
        (Vector3.down + Vector3.right).normalized,
        Vector3.down,
        (Vector3.down + Vector3.left).normalized,
        Vector3.left,
        (Vector3.up + Vector3.left).normalized
    };

    // Update is called once per frame
    void Update()
    {
        if (explode) {
            Boom();
        }
        
    }

    void Boom()
    {

        for (int i = 0; i < 8; i ++) {

            Shrapnel proj = Instantiate(Projecile, transform.position, Quaternion.identity);
            proj.movement = directions[i];
        }
       
       Destroy(gameObject);
    }
}
