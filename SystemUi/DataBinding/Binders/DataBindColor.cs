// ----------------------------------------------------------------------------
// The MIT License
// LeopotamGroupLibrary https://github.com/Leopotam/LeopotamGroupLibraryUnity
// Copyright (c) 2012-2017 Leopotam <leopotam@gmail.com>
// ----------------------------------------------------------------------------

using UnityEngine;
using UnityEngine.UI;

// ReSharper disable RedundantCast.0

namespace LeopotamGroup.SystemUi.DataBinding.Binders {
    /// <summary>
    /// Data binding of color for any Graphic component.
    /// </summary>
    [RequireComponent (typeof (Graphic))]
    public sealed class DataBindColor : AbstractBinderBase {
        Graphic _target;

        public override void OnBindedDataChanged (object data) {
            if ((object) _target == null) {
                _target = GetComponent<Graphic> ();
            }
            var color = data is Color ? (Color) data : Color.black;
            _target.color = color;
        }
    }
}