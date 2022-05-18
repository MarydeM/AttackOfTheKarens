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

        int Level = 1;
        private int Damage = 2;
        private int MaxXP = 15;
        private int CurrentXP = 0;

        /// <summary>
        /// Increments Current XP
        /// </summary>
        /// <param name="amount">Amount to increase XP</param>
        public void GainXP(int amount)
        {
            CurrentXP += amount;
            if (CurrentXP >= MaxXP)
            {
                Upgrade();
            }
        }

        /// <summary>
        /// Grabs Character Damage
        /// </summary>
        /// <returns>Character.Damage</returns>
        public int GetDamage() { return Damage; }

        /// <summary>
        /// Grabs Character Level
        /// </summary>
        /// <returns>Character.Level</returns>
        public int GetLevel() { return Level; }
        
        /// <summary>
        /// Grabs Current XP
        /// </summary>
        /// <returns>Character.CurrentXP</returns>
        public int GetCurrentXP() { return CurrentXP; }

        /// <summary>
        /// Grabs Max XP
        /// </summary>
        /// <returns>Character.MaxXP</returns>
        public int GetMaxXP() { return MaxXP; }
        
        /// <summary>
        /// Upgrades the character by incrementing Level, Damage, and Max XP
        /// </summary>
        public void Upgrade()
        {
            this.Level += 1;
            this.Damage *= 2;
            this.CurrentXP = 0;
            this.MaxXP *= 3;
        }
        /// <summary>
        /// constructor
        /// </summary>
        public Character(PictureBox pic) {
            this.pic = pic;
            this.pic.Visible = true;
            this.pic.BringToFront();
            
        }
    }
}
