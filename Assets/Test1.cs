using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {

    public class Boss
    {
        private int hp = 100;
        private int power = 25;
        private int mp = 53;

        public void Attack()
        {
            Debug.Log(this.power + "のダメージを与えた");
        }

        public void Defence(int damage)
        {
            Debug.Log(damage + "のダメージを受けた");
            this.hp -= damage;
        }

        public void Magic()
        {
            if (mp >= 5)
            {
                this.mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
            }
            else
            {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }
    }

        void Start ()
    {
        Boss lastboss = new Boss();

        for (int i = 1; i <= 11; i++)
        {
            lastboss.Magic();
        }
    }
	
	void Update ()
    {
		
	}
}
