namespace KarenLogic {
  public class Store {
    private Karen karen;
    private bool containsOwner;

    public Store(Karen karen) {
      this.karen = karen;
    }

    public void ActivateTheKaren() {
      karen.Appear();
    }

    public void OwnerWalksIn() {
      containsOwner = true;
    }

    public void ResetOwner() {
      containsOwner = false;
    }

    public void Update(Character c) {
      if (karen.IsPresent && containsOwner) 
      {
                karen.Damage(c.GetDamage(), c);
      }
    }
  }
}
