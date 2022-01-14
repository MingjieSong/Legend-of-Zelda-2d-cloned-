using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Sprint2
{
	public static class BGM
	{

		private static Song mainBgm;
		private static Song room;
		private static ContentManager contentManager;
		private static SoundEffect collision;

		public static void LoadBGM(ContentManager content)
		{
			contentManager = content;
			mainBgm = contentManager.Load<Song>("bgm");
			room = contentManager.Load<Song>("room");
			collision = contentManager.Load<SoundEffect>("collision");
		}

		public static void PlayMainSong()
		{
			MediaPlayer.Play(mainBgm);
		}
		public static void PlayRoom()
		{
			MediaPlayer.Stop();
			MediaPlayer.Play(room);
		}
		public static void PlayCollision()
		{
			collision.Play();
		}


	}

}