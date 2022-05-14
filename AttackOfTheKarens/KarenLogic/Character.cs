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
		public Character(PictureBox pic) {
			this.pic = pic;
			this.pic.Visible = true;
			this.pic.BringToFront();
		}

	}
}
