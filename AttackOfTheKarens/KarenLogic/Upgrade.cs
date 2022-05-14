namespace KarenLogic {

	public class Upgrade {

		public bool managerPresent;
		public void Check(int XP) {
			if (XP > 15 && managerPresent == false) {
				createManager();
			}
		}

		public void createManager() {

		}
	}
}
