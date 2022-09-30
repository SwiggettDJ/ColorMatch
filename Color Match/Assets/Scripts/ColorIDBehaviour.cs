using System;
using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorDataListObj;
    

    private void Awake()
    {
        idObj = colorDataListObj.currentColor;
    }
}
