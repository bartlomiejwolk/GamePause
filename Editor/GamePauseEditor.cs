// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the Pause extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEditor;

namespace PauseModule {

    [CustomEditor(typeof(GamePause))]
    [CanEditMultipleObjects]
    public sealed class GamePauseEditor : Editor {

        #region FIELDS
        #endregion FIELDS

        #region UNITY MESSAGES
        #endregion UNITY MESSAGES

        #region METHODS

        [MenuItem("Component/Component Framework/GamePause")]
        private static void AddEntryToComponentMenu() {
            if (Selection.activeGameObject != null) {
                Selection.activeGameObject.AddComponent(typeof(GamePause));
            }
        }

        #endregion METHODS
    }

}