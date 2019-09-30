using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinoGenerator : MonoBehaviour
{
    public GameObject[] minos;

    public void SpawnMino()
    {
        int minoIndex = Random.Range(0, 6);

        Instantiate(minos[minoIndex],
            transform.position,
            Quaternion.identity);
    }

    // Start is called before the first frame update
    private void Start()
    {
        SpawnMino();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
