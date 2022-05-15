using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace KarenLogic {

	public class Upgrade {

		public bool managerPresent = false;
		public void Check(int XP) {
			if (XP > 15 && managerPresent == false) {
				createManager();
			}
		}



		public void createManager() {
			managerPresent = true;
            //return new PictureBox() {
            //    Image = Image.FromFile(@"..\AttackOfTheKarens\data\Manager64.png"),
            //    Top = 640,
            //    Left = 8 * 64,
            //    Width = 64,
            //    Height = 64
            //};
        }
    }
}



//// upgrade privates
//private PictureBox picMan;
//private int xMan;
//private int yMan;

//private void createManager() {
//    int top = xMan * CELL_SIZE;
//    int left = yMan * CELL_SIZE;
//    picMan = CreatePic(Properties.Resources.Manager64, top, left);
//    panMall.Controls.Add(picMan);
//    picMan.BringToFront();
//}