using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Sprint2
{
	public static class Sound
	{

		private static Song mainBgm;
		private static Song room;
		private static ContentManager contentManager;
		private static SoundEffect linkDemage;
		private static SoundEffect itemCollision;
		private static Song lose;
		private static Song win;

		public static void LoadBGM(ContentManager content)
		{
			contentManager = content;
#pragma warning disable CA1062 // Validate arguments of public methods
			mainBgm = contentManager.Load<Song>("bgm");
#pragma warning restore CA1062 // Validate arguments of public methods
			room = contentManager.Load<Song>("room");
			linkDemage = contentManager.Load<SoundEffect>("collision");
			itemCollision = contentManager.Load<SoundEffect>("itemCollision");
			lose = contentManager.Load<Song>("lose");
			win = contentManager.Load<Song>("win");

			

		}

		public static void PlayMainSong()
		{
			MediaPlayer.Play(mainBgm);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChangedMainBGM;
		}
		public static void PlayLoseSong()
		{
			MediaPlayer.Play(lose);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateLose;
		}
		public static void PlayRoom()
		{
			MediaPlayer.Play(room);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateChangedRoom;
		}
		public static void PlayWin()
		{
			MediaPlayer.Play(win);
			MediaPlayer.MediaStateChanged += MediaPlayer_MediaStateWin;
		}
		public static void PlayLinkDemage()
		{
			linkDemage.Play();
		}

		public static void PlayItemCollision()
		{
			itemCollision.Play();
		}
		static void MediaPlayer_MediaStateChangedMainBGM(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(mainBgm);
		}
		static void MediaPlayer_MediaStateChangedRoom(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(room);
		}
		static void MediaPlayer_MediaStateLose(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(lose);
		}
		static void MediaPlayer_MediaStateWin(object sender, System.
										   EventArgs e)
		{
			MediaPlayer.Play(win);
		}

	}

}