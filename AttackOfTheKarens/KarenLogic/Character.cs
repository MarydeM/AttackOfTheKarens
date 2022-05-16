using System.Windows.Forms;

namespace KarenLogic {
	/// <summary>
	/// A class for creating the owner and managers
	/// </summary>
	public class Character {
		//public int Damage { get; set; }
		public string Name { get; set; }
		public PictureBox pic;
        public int xLocation { get; set; }
		public int yLocation { get; set; }
        public int xPreLocation { get; set; }
        public int yPreLocation { get; set; }

        /// <summary>
        /// constructor
        /// </summary>
        public Character(PictureBox pic) {
            this.pic = pic;
            this.pic.Visible = true;
            this.pic.BringToFront();
            //this.Damage = damage;
        }
    }
}
