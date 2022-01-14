using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace Sprint2
{
    public interface IInventory
    {
        bool barOnly { get; set; }
        bool showMap { get; set; }
         bool showCompass { get; set; }  

        int heartNum { get; set; }
        int heartContainerNum { get; set; }
        int diamondNum{ get; set; }
        int keyNum { get; set; }
        int bombNum { get; set; }
        int triPieceNum { get; set; }

        string itemA { get; set; }
        string itemB { get; set; }
#pragma warning disable CA2227 // Collection properties should be read only
        List<String> itemList { get; set; }
#pragma warning restore CA2227 // Collection properties should be read only
        int currentIndex { get; set; }
        string itemSelect { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);

    }
}
