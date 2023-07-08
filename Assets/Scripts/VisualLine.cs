using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class VisualLine : MonoBehaviour
{
    public Transform charPos;
    private LineRenderer lineRenderer;
    private Vector3 endPos = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void FixedUpdate()
    {
        int layermask = 1 << 6;

        RaycastHit2D lineInfo;
        if(lineInfo = Physics2D.Linecast(charPos.position, Camera.main.ScreenToWorldPoint(Input.mousePosition), layermask)) 
        {
            endPos = lineInfo.point;
        }
        else 
        {
            endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, charPos.position);
        lineRenderer.SetPosition(1, endPos);
    }
}
