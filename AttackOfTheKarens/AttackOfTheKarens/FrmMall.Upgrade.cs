using KarenLogic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace AttackOfTheKarens {

	partial class FrmMall {

        private Character manager;

        //privates
        private bool managerPresent = false;
        


		public void check(float XP) {
			if (XP > 15.0 && managerPresent == false) {
				createManager();
			}

            if (XP % 5f == 0){
                tmrMoveOwner.Interval-= 10;
            }
		}


        public void createManager() {
			managerPresent = true;
            PictureBox pic = null;
            int top = 10 * CELL_SIZE; 
            int left = 8 * CELL_SIZE;
            pic = CreatePic(Properties.Resources.owner, top, left);

            manager = new Character(pic);
            manager.xLocation = left / CELL_SIZE;
            manager.yLocation = top / CELL_SIZE;
            panMall.Controls.Add(manager.pic);
            //form.Manager = manager;




        }
    }
}