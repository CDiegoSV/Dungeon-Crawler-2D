using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Enums

public enum EnumType
{
    TYPE_0, TYPE_1, TYPE_2, TYPE_3, TYPE_4, TYPE_5
}

#endregion

#region Structs

[System.Serializable]
public struct StructExample
{
    #region Variables

    public int variableInt;
    public int variableIntMana;
    public EnumType enumType;
    public string name;

    #endregion

    #region Methods

    public void MyMethod()
    {

    }

    #endregion

    public int GetInt
    {
        get
        {
            return variableInt;
        }
    }
}


#endregion

public class StructTest : MonoBehaviour
{
    public List<StructExample> structExample;



    void Start()
    {
        
    }

}
