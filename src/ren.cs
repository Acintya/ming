using System;

namespace AllLivings {
    public struct status
    {
        double health { get; set; }
        double qi { get; set; }
        double load { get; set; }
        double jing { get; set; }
    }

    struct maxStatus
    {
        double maxHealth;
        double maxQi;
        double maxLoad;
        double maxJing;
    }

    struct abilties
    {
        double strength;
        double shen;
    }

    struct damage
    {
        int head;
        int lArm;
        int rArm;
        int lLeg;
        int rLeg;
        int chest;
        int belly;
    }

    class Ren {
        String name;
        int id;

        public status renStatus;
        maxStatus renMaxStatus;
        internal object Status;

        public Ren()
        {
            //status m_status = new status();
        }

        public void init () {
	        setBestStatus();
	    }
        //reset the character with the best possible status
        //TO-DO: implementation of the logic between abilities and maximum values
        public void setBestStatus () {
            //Ren m_ren = new Ren();
            this.renStatus.health= 100;

            //m_status.he
            //Ren.status.qi = Ren.maxStatus.maxHealth;
            //Ren.status.load = this.MAX_LOAD;
            //Ren.status.jing = this.MAX_JING;
        }
	//TODO:Dialog
	
    }
}
