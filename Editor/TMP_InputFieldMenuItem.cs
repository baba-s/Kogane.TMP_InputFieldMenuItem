using TMPro;
using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    internal static class TMP_InputFieldMenuItem
    {
        [MenuItem( "CONTEXT/TMP_InputField/Reset All Color To White" )]
        private static void ResetAllColorToWhite( MenuCommand menuCommand )
        {
            var tmpInputField = ( TMP_InputField )menuCommand.context;

            Undo.RecordObject( tmpInputField, "Reset All Color To White" );

            var color  = Color.white;
            var colors = tmpInputField.colors;

            colors.normalColor      = color;
            colors.highlightedColor = color;
            colors.pressedColor     = color;
            colors.selectedColor    = color;
            colors.disabledColor    = color;

            tmpInputField.colors = colors;
        }
    }
}