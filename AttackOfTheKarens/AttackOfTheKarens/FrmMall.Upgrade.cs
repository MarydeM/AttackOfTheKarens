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

        //privates
        private bool managerPresent = false;
        private Character manager;


        public void check(float XP)
        {
            if (XP > 15.0 && managerPresent == false)
            {
                createManager();
            }

            if (XP > 0 && XP % 5f == 0)
            {
                if (tmrMoveOwner.Interval > 1)
                {
                    tmrMoveOwner.Interval -= 1;
                }
            }
        }

        public void createManager() {
                PictureBox pic = null;
                int top = 5 * CELL_SIZE;
                int left = 5 * CELL_SIZE;
                pic = CreatePic(Properties.Resources.Manager64, top, left);

                manager = new Character(pic);
                manager.xLocation = left / CELL_SIZE;
                manager.yLocation = top / CELL_SIZE;
                panMall.Controls.Add(manager.pic);
                managerPresent = true;
        }

    }
}