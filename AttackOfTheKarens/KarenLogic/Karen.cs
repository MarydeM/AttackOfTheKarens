using System.Windows.Forms;
using System.Diagnostics;

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
    public bool IsPresent { get; private set; }
    
    int Level = 1;    
    int MaxHealth = 10;
    int CurrentHealth = 10;
    int XP = 3;
    float moneyDrop = 6.00f;
    float upgradeCounter = 50.00f;


    /// <summary>
    /// Grabs Karen Level
    /// </summary>
    /// <returns>Karen.Level</returns>
    public int GetLevel() { return Level; }

    /// <summary>
    /// Grabs Karen Max Health
    /// </summary>
    /// <returns>Karen.MaxHealth</returns>
    public int GetMaxHealth() { return this.MaxHealth; }

    /// <summary>
    /// Grabs Karen Current Health
    /// </summary>
    /// <returns>Karen.CurrenHealth</returns>
    public int GetCurrentHealth() { return this.CurrentHealth; }
    
    /// <summary>
    /// Decrements Health Counter
    /// </summary>
    /// <param name="amount"> Amount to remove from Upgrade Counter</param>
    public void DecrementCounter(float amount) { this.upgradeCounter -= amount; }
    
    /// <summary>
    /// Increment Max Health
    /// </summary>
    /// <param name="amount"> Amount to add to max health</param>
    private void IncrementMaxHealth(int amount) { this.MaxHealth += amount; }
    
    /// <summary>
    /// Increments Current Health
    /// </summary>
    /// <param name="amount">Amount to increment current health </param>
    private void IncrementCurrentHealth(int amount) { this.CurrentHealth += amount; }
    
    /// <summary>
    ///Increment Level 
    /// </summary>
    /// <param name="amount">Amount to increment level</param>
    private void IncrementLevel(int amount) { Level += amount; }

    /// <summary>
    /// Increase MaxHealth, XP, Money Dropped, and Upgrade Counter 
    /// </summary>
    public void Upgrade() 
    {
        this.IncrementMaxHealth(10);       
        this.IncrementCurrentHealth(10);
        this.IncrementLevel(1);
        this.XP = XP * Level;
        this.moneyDrop *= 0.65f;
        this.upgradeCounter = 50.0f * Level + 25;  
    }


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
      this.Level = 1;
      this.XP = 2;
      this.MaxHealth = 10;
    }

    public void Appear() {
      this.pic.Visible = true;
      this.IsPresent = true;
      this.pic.BringToFront();
      this.CurrentHealth = this.GetMaxHealth(); 
    }

    /// <summary>
    /// Damage Karen by Set amount, Gives XP if Karen's Health is <= 0 
    /// </summary>
    /// <param name="amount">Amount to Damage Karen</param>
    /// <param name="c">Character that gains XP</param>
    public void Damage(int amount, Character c) {
      CurrentHealth -= amount;
      
      //Debug Statement
      Debug.WriteLine($"Karen LV{this.Level}, HP:{ this.CurrentHealth}/{ this.MaxHealth}  Upgrade @ 0: {this.upgradeCounter}");

      if (CurrentHealth < 0) {
        Game.AddToScore(this.moneyDrop);
        c.GainXP(XP);
        
        //Debug Statement
        Debug.WriteLine($"CurrentLevel:{c.GetLevel()}, CurrentXP:{c.GetCurrentXP()}/{c.GetMaxXP()}");
        DecrementCounter(this.moneyDrop);

        //Reset counter and upgrade Karen
        if (this.upgradeCounter <= 0) 
        {
            this.Upgrade();
        }
        this.pic.Visible = false;
        this.IsPresent = false;
      }
    }
  }
}
