// Copyright (c) 2015 Bartlomiej Wolk (bartlomiejwolk@gmail.com)
//  
// This file is part of the GamePause extension for Unity.
// Licensed under the MIT license. See LICENSE file in the project root folder.

using UnityEngine;
using UnityEngine.Events;

namespace PauseModule {

    public sealed class GamePause : MonoBehaviour {

        #region CONSTANTS

        public const string Version = "v0.1.0";
        public const string Extension = "GamePause";
        public const string Description = "";

        #endregion CONSTANTS

        #region DELEGATES
        #endregion DELEGATES

        #region EVENTS
        #endregion EVENTS

        #region FIELDS

#pragma warning disable 0414
        /// <summary>
        ///     Allows identify component in the scene file when reading it with
        ///     text editor.
        /// </summary>
        [SerializeField]
        [HideInInspector]
        private string componentName = "GamePause";
#pragma warning restore 0414

        #endregion FIELDS

        #region INSPECTOR FIELDS

        [SerializeField]
        private string comment = "Comment";

        [SerializeField]
        private KeyCode shortcut;

        [SerializeField]
        private UnityEvent onPauseCallbacks;

        [SerializeField]
        private UnityEvent onUnPauseCallbacks;

        #endregion INSPECTOR FIELDS

        #region PROPERTIES

        /// <summary>
        ///     Optional text to describe purpose of this instance of the component.
        /// </summary>
        public string Comment {
            get { return comment; }
            set { comment = value; }
        }

        /// <summary>
        /// Pause key.
        /// </summary>
        public KeyCode Shortcut {
            get { return shortcut; }
            set { shortcut = value; }
        }

        /// <summary>
        /// Callbacks invoked on pause.
        /// </summary>
        public UnityEvent OnPauseCallbacks {
            get { return onPauseCallbacks; }
            set { onPauseCallbacks = value; }
        }

        public UnityEvent OnUnPauseCallbacks {
            get { return onUnPauseCallbacks; }
            set { onUnPauseCallbacks = value; }
        }

        #endregion PROPERTIES

        #region UNITY MESSAGES

        private void Awake() { }

        private void FixedUpdate() { }

        private void LateUpdate() { }

        private void OnEnable() { }

        private void Reset() { }

        private void Start() { }

        private void Update() {
            HandlePauseKey();
        }
        private void OnValidate() { }

        private void OnDisable() { }

        private void OnDestroy() { }

        #endregion UNITY MESSAGES

        #region EVENT INVOCATORS
        #endregion INVOCATORS

        #region EVENT HANDLERS
        #endregion EVENT HANDLERS

        #region METHODS

        private void HandlePauseKey() {
            if (!Input.GetKeyDown(Shortcut)) {
                return;
            }

            // Toggle time scale.
            if (Time.timeScale == 1) {
                Time.timeScale = 0;

                OnPauseCallbacks.Invoke();
            }
            else {
                Time.timeScale = 1;

                OnUnPauseCallbacks.Invoke();
            }
        }

        public void Pause() {
            Time.timeScale = 0;
        }

        public void UnPause() {
            Time.timeScale = 1;
        }

        #endregion METHODS

    }

}