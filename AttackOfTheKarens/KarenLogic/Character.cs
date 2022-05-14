using System.Windows.Forms;

namespace KarenLogic {
	/// <summary>
	/// A class for creating the owner and managers
	/// </summary>
	public class Character {
		public int Damage { get; set; }
		public string Name { get; set; }
		public PictureBox pic;
        public int xLocation;
		public int yLocation;
		public int xPrevLocation;
		public int yPrevLocation;
		/// <summary>
		/// constructor
		/// </summary>
		public Character(PictureBox pic, int damage) {
			this.pic = pic;
			this.pic.Visible = true;
			this.pic.BringToFront();
			this.Damage = damage;
		}
	}
}
