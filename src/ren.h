using System;

namespace AllLivings {
    class Ren {
        string name;
        int id;

	private struct status {
	  double health;
	  double qi;
	  double load;
	  double jing;
	}

	private struct abilties {
	  double strength;
	  double shen;
	}

	private struct damage {
	  int head;
	  int lArm;
	  int rArm;
	  int lLeg;
	  int rLeg;
	  int chest;
	  int belly;
	}

        void init () {
	  this.bestStatus();
	}
      //reset the character with the best possible status
      //TO-DO: implementation of the logic between abilities and maximum values
        void bestStatus () {
          this.health = MAX_HEALTH;	

      }
    }
}
