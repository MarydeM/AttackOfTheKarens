using System.Windows.Forms;

namespace KarenLogic {
  /// <summary>
  /// TODO: write a comment here
  /// </summary>
  public class Karen {
    /// <summary>
    /// The pixel location of the row Karen is on
    /// </summary>
    public int Row { get; set; }
    public int Col { get; set; }
    public int Health { get; private set; }
    public bool IsPresent { get; private set; }

    /// <summary>
    /// This is the image of Karen
    /// </summary>
    public PictureBox pic;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="pic">The PictureBox container for Karen</param>
    public Karen(PictureBox pic) {
      this.pic = pic;
      this.pic.Visible = false;
      this.IsPresent = false;
      this.Health = 10;
    }

    public void Appear() {
      this.pic.Visible = true;
      this.IsPresent = true;
      this.pic.BringToFront();
    }

    public void Damage(int amount) {
      Health -= amount;
      if (Health < 0) {
        Game.AddToScore(6.00f);
        this.pic.Visible = false;
        this.IsPresent = false;
      }
    }
  }
}
