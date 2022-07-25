using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#region AddComponentMenu
//Add componentMenuya elaveler etmek ucundur defaul adda vere bilersin
//[AddComponentMenu("Event/MyScripts")]
//[AddComponentMenu("Seymur/MyScripts")]
#endregion
#region RequireComponent
//Script Elave edildikde componentide elave et
//[RequireComponent(typeof(Rigidbody))]
#endregion 
public class HideFlags : MonoBehaviour
{
    #region ContextMenu
    //scriptde method cagirmaq ucun nezerde tutulub oyun baslasin ya baslamasin ferqi yoxdu scripte aiddir
    //[ContextMenu("MyMenu",false,1)]
    //[ContextMenu("MyMenu2",false,2)]
    #endregion
    #region Header
    // Fieldlari basliqlara gore siralamaq ucundur 
    //[Header("ana karakter")]
    //public string AnaKarakter;
    //[Header("dusman")]
    //public string Ad;

    #endregion
    #region ToolTip
    // Ne ise yaradigini gormek olur
    //[Tooltip("String yazmisam")]
    //public string a;
    #endregion
    #region Multiline
    //Setr olaraq yaza bilirsiz string deyerlerde
    //[Multiline(6)]
    #endregion
    #region Min
    //[Min(1)]
    ////asagi deyer yaza bilmirsen 
    #endregion
    #region Range
    // Araliq verirsen o araliq esasinda deyer vere bilirsen sadece 
    //[Range(1, 6)]
    //public int a;
    #endregion
    #region HideInInspector
    //bu inpsectordan public fieldi gizletmek ucundur 
    //[HideInInspector]
    //public string name;
    #endregion
}
