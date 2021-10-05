using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Ak47
    {
        public int Ammo;
        public int CurrentAmmo;
        public float Speed;

        public Ak47(int a, int b)
        {
            Ammo = a;
            Speed = b;
        }

        public void ShutAk47()
        {
            if (Speed == 50)
            {
                for (int i = 10; i > 0; i--)
                {
                    Reload();
                }
            }
            else if (Speed==20)
            {
                for (int i = 10; i > 0; i--)
                {
                    Reload();
                }
            }
            
            return;
        }
        public void Reload()
        {
            CurrentAmmo = 30;
            if (CurrentAmmo < 30 && Ammo > 0)
            {
                if (Ammo >= 30)
                {
                    if (Ammo == 30)
                    {
                        Ammo = 0;
                    }
                    else
                    {
                        Ammo = Ammo - (30 - CurrentAmmo);
                    }
                    CurrentAmmo = 30;
                }
                else
                {
                    CurrentAmmo = Ammo;
                    Ammo = 0;
                }
            }
            return;
        }
    }   
}
