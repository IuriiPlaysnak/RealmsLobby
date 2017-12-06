﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlaysnakRealms {

	[RequireComponent (typeof(RealmsPlayPauseHandButtonUI))]
	[RequireComponent (typeof(RealmsHandButton))]
	public class RealmsPlayPauseHandButton : MonoBehaviour {

		[SerializeField]
		private RealmYouTubeVideoPlayer _player;

		private RealmsPlayPauseHandButtonUI _ui;
		private RealmsHandButton _buttonHandler;

		void Awake() {

			_ui = gameObject.GetComponent<RealmsPlayPauseHandButtonUI> ();
			_buttonHandler = gameObject.GetComponent<RealmsHandButton> ();
			_buttonHandler.OnClick += OnButtonClick;
			_buttonHandler.OnOver += OnButtonOver;
			_buttonHandler.OnOut += OnButtonOut;

			_player.OnPlay += OnVideoPlay;
		}

		void OnButtonOut ()
		{
			_ui.OnOut ();
		}

		void OnButtonOver ()
		{
			_ui.OnOver ();
		}

		void OnButtonClick ()
		{
			_ui.OnClick ();
			_player.OnPlayPause ();
		}

		void OnVideoPlay ()
		{
			_ui.SetState (RealmsPlayPauseHandButtonUI.State.PLAY);
		}
	}
}