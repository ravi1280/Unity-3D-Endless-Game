using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentGenarator : MonoBehaviour
{
    public GameObject[] segment;
    [SerializeField] int zpos = 90;
    [SerializeField] bool creatingSegment = false;
    [SerializeField] int segmentNum;



    void Start()
    {

    }
    void Update()
    {
        if (creatingSegment == false)
        {
            creatingSegment = true;
            StartCoroutine(SegmentGen());
        }
    }

    IEnumerator SegmentGen()
    {
        segmentNum = Random.Range(0, 5);
        Instantiate(segment[segmentNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += 90;
        yield return new WaitForSeconds(5);
        creatingSegment = false;

    }
}
