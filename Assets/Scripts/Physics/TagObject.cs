using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TagType
{
    Ground,
    Sky,
    Bird,
    Mario,
}

// Tag la chứa các tag
public class TagObject : MonoBehaviour
{
    public List<TagType> tagObject;
    public SpriteRenderer sr;

    private void Update()
    {
        float diChuyenLenXuong = Input.GetAxis("Vertical");
        if (diChuyenLenXuong > 0)
        {
            sr.sortingOrder++;
        }
        else if (diChuyenLenXuong < 0)
        {
            sr.sortingOrder--;
        }
    }
}
