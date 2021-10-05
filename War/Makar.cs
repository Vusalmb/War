using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Makar
    {
        public int Ammo;
        public int CurrentAmmo;


        public Makar()
        {
            Ammo = 64;
        }

        public void ShutMakar()
        {
            for (int i = 8; i > 0; i--)
            {
                Reload();
            }
            return;
        }
        public void Reload()
        {
            CurrentAmmo = 8;
            if (CurrentAmmo < 8 && Ammo > 0)
            {
                if (Ammo >= 8)
                {
                    if (Ammo == 8)
                    {
                        Ammo = 0;
                    }
                    else
                    {
                        Ammo = Ammo - (8 - CurrentAmmo);
                    }
                    CurrentAmmo = 8;
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
